using System.ComponentModel;
using System.Data.SqlClient;


namespace MonitorCierre
{
    public partial class MonitorCierre : Form
    {
        string connectionString = @"Server=bco.citlali.mx\Produccion;Database=bco;User Id=bco;Password=bcocloud;";
        int segundos = 1;

        #region querys
        string porCerrar = "SELECT distinct(ct.clave_modulo) " +
                            "FROM centro_trabajo ct " +
                            "WHERE ct.clave_centro_trabajo NOT IN(SELECT clave_centro_trabajo " +
                            "FROM cierre_diario cd " +
                            "where CAST(cd.fecha_inicia_cierre as date) = CAST(SYSDATETIME() as date)) " +
                            "AND ct.situacion = 'A'; ";

        string enProceso = "SELECT DISTINCT ct.clave_modulo as clave_modulo, (DATEDIFF(MINUTE,GETDATE(),cd.fecha_inicia_cierre)) minutos " +
                            "FROM cierre_diario cd " +
                            "INNER JOIN centro_trabajo ct ON cd.clave_centro_trabajo = ct.clave_centro_trabajo " +
                            "WHERE CAST(cd.fecha_inicia_cierre as date) = CAST(SYSDATETIME() as date) " +
                            "AND fecha_fin_cierre IS NULL " +
                            "AND ct.id_centro_trabajo_tipo = 26 " +
                            "UNION " +
                            "SELECT DISTINCT ct.clave_modulo as [Servidores con cierre en proceso], (DATEDIFF(MINUTE, GETDATE(), cd.fecha_inicia_cierre)) [Minutos desde que inicio] " +
                            "FROM cierre_diario cd " +
                            "INNER JOIN centro_trabajo ct ON cd.clave_centro_trabajo = ct.clave_centro_trabajo " +
                            "WHERE CAST(cd.fecha_inicia_cierre as date) = CAST(SYSDATETIME() as date) " +
                            "AND fecha_fin_cierre IS NULL " +
                            "AND ct.clave_centro_trabajo = 'MES6' " +
                            "ORDER BY ct.clave_modulo;";

        string cerrado = "SELECT clave_modulo,  DATEDIFF(MINUTE,GETDATE(),fecha_cierre) minutos  " +
                            "FROM( " +
                            "SELECT ct.clave_modulo as clave_modulo, MAX(cd.fecha_fin_cierre) as fecha_cierre " +
                            "FROM cierre_diario cd " +
                            "INNER JOIN centro_trabajo ct ON cd.clave_centro_trabajo = ct.clave_centro_trabajo " +
                            " WHERE CAST(cd.fecha_inicia_cierre as date) = CAST(SYSDATETIME() as date) " +
                            "AND fecha_fin_cierre IS NOT NULL " +
                            "GROUP BY ct.clave_modulo " +
                            ") t;";

        #endregion        

        #region constructor
        public MonitorCierre()
        {
            InitializeComponent();
            //timer cada 1 segundo
            timer2.Start();
            timer2.Interval = 1000;
            //timer variable, empieza por defaul cada 5 segundos 
            timer1.Start();
            timer1.Interval = 5000;
        }
        #endregion

        #region load event
        private void MonitorCierre_Load(object sender, EventArgs e)
        {

        } 
        #endregion

        #region comboBox event
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            segundos = 1;
            Object selectedItem = comboBox1.SelectedItem;

            timer1.Stop();
            timer1.Interval = Convert.ToInt32(selectedItem.ToString()) * 1000;
            timer1.Start();

            timer2.Stop();
            timer2.Interval = 1000;
            timer2.Start();

        }

        #endregion

        #region timers events
        private void timer1_Tick(object sender, EventArgs e)
        {
            segundos = 1;
            CreateCommand(porCerrar, connectionString, TipoQery.PorCerrar);
            CreateCommand(cerrado, connectionString, TipoQery.Cerrados);
            CreateCommand(enProceso, connectionString, TipoQery.EnProceso);
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            lblIntervalo.Text = segundos.ToString();
            segundos++;
        } 
        #endregion

        #region methods
        private void CreateCommand(string queryString, string connectionString, TipoQery tipoQery)
        {
            List<CentroCierre> list = new List<CentroCierre>();


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();

                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        switch (tipoQery)
                        {
                            case TipoQery.PorCerrar:
                                var model = new CentroCierre { Centro = reader["clave_modulo"].ToString()!, Minutos = 0 };
                                list.Add(model);
                                break;
                            case TipoQery.Cerrados:
                                var model2 = new CentroCierre { Centro = reader["clave_modulo"].ToString()!, Minutos = Convert.ToInt32(reader["minutos"]) };
                                list.Add(model2);
                                break;
                            case TipoQery.EnProceso:
                                var model3 = new CentroCierre { Centro = reader["clave_modulo"].ToString()!, Minutos = Convert.ToInt32(reader["minutos"]) };
                                list.Add(model3);
                                break;
                            default:
                                break;
                        }

                    }
                    Actualizar(list, tipoQery);
                }
                finally
                {
                    reader.Close();
                }
            }
        }
        public void Actualizar(List<CentroCierre> list, TipoQery tipoQery)
        {
            switch (tipoQery)
            {
                case TipoQery.PorCerrar:
                    listClaveModulo.DataSource = list;
                    listClaveModulo.DisplayMember = "Centro";
                    break;
                case TipoQery.Cerrados:
                    listCentrosCerrados.DataSource = list;
                    listCentrosCerrados.DisplayMember = "Centro";
                    listCerradosMinutos.DataSource = list;
                    listCerradosMinutos.DisplayMember = "Minutos";
                    break;
                case TipoQery.EnProceso:
                    listCentrosPorCerrar.DataSource = list;
                    listCentrosPorCerrar.DisplayMember = "Centro";
                    listPorCerrarMinutos.DataSource = list;
                    listPorCerrarMinutos.DisplayMember = "Minutos";
                    break;
                default:
                    break;
            }

            if (tipoQery.ToString() == TipoQery.Cerrados.ToString())
            {
                lblCerrados.Text = list.Count().ToString();
            }
        } 
        #endregion
        
        #region objets, dto, enum 
        public class CentroCierre
        {
            public string Centro { get; set; } = null!;
            public int Minutos { get; set; }
        }

        public enum TipoQery
        {
            PorCerrar,
            Cerrados,
            EnProceso
        } 
        #endregion
    }
}