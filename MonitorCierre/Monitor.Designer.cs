namespace MonitorCierre
{
    partial class MonitorCierre
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listCentrosCerrados = new System.Windows.Forms.ListBox();
            this.listCerradosMinutos = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listCentrosPorCerrar = new System.Windows.Forms.ListBox();
            this.listPorCerrarMinutos = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listClaveModulo = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCerrados = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblIntervalo = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // listCentrosCerrados
            // 
            this.listCentrosCerrados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listCentrosCerrados.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listCentrosCerrados.ForeColor = System.Drawing.Color.Green;
            this.listCentrosCerrados.FormattingEnabled = true;
            this.listCentrosCerrados.ItemHeight = 48;
            this.listCentrosCerrados.Location = new System.Drawing.Point(25, 116);
            this.listCentrosCerrados.Name = "listCentrosCerrados";
            this.listCentrosCerrados.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listCentrosCerrados.Size = new System.Drawing.Size(177, 964);
            this.listCentrosCerrados.Sorted = true;
            this.listCentrosCerrados.TabIndex = 1;
            // 
            // listCerradosMinutos
            // 
            this.listCerradosMinutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listCerradosMinutos.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listCerradosMinutos.FormattingEnabled = true;
            this.listCerradosMinutos.ItemHeight = 48;
            this.listCerradosMinutos.Location = new System.Drawing.Point(218, 116);
            this.listCerradosMinutos.Name = "listCerradosMinutos";
            this.listCerradosMinutos.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listCerradosMinutos.Size = new System.Drawing.Size(164, 964);
            this.listCerradosMinutos.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listCentrosCerrados);
            this.groupBox1.Controls.Add(this.listCerradosMinutos);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(990, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 1174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CIERRE TERMINADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(218, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Minutos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Centro";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.listCentrosPorCerrar);
            this.groupBox2.Controls.Add(this.listPorCerrarMinutos);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(441, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 1174);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CIERRE EN PROCESO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(218, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 38);
            this.label3.TabIndex = 4;
            this.label3.Text = "Minutos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(25, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 38);
            this.label4.TabIndex = 3;
            this.label4.Text = "Centro";
            // 
            // listCentrosPorCerrar
            // 
            this.listCentrosPorCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listCentrosPorCerrar.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listCentrosPorCerrar.ForeColor = System.Drawing.Color.Brown;
            this.listCentrosPorCerrar.FormattingEnabled = true;
            this.listCentrosPorCerrar.ItemHeight = 48;
            this.listCentrosPorCerrar.Location = new System.Drawing.Point(25, 116);
            this.listCentrosPorCerrar.Name = "listCentrosPorCerrar";
            this.listCentrosPorCerrar.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listCentrosPorCerrar.Size = new System.Drawing.Size(177, 964);
            this.listCentrosPorCerrar.Sorted = true;
            this.listCentrosPorCerrar.TabIndex = 1;
            // 
            // listPorCerrarMinutos
            // 
            this.listPorCerrarMinutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listPorCerrarMinutos.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listPorCerrarMinutos.FormattingEnabled = true;
            this.listPorCerrarMinutos.ItemHeight = 48;
            this.listPorCerrarMinutos.Location = new System.Drawing.Point(218, 116);
            this.listPorCerrarMinutos.Name = "listPorCerrarMinutos";
            this.listPorCerrarMinutos.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listPorCerrarMinutos.Size = new System.Drawing.Size(164, 964);
            this.listPorCerrarMinutos.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.listClaveModulo);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(68, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(237, 1174);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CLAVE MODULO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(25, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 38);
            this.label6.TabIndex = 3;
            this.label6.Text = "Centro";
            // 
            // listClaveModulo
            // 
            this.listClaveModulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listClaveModulo.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.listClaveModulo.ForeColor = System.Drawing.Color.Black;
            this.listClaveModulo.FormattingEnabled = true;
            this.listClaveModulo.ItemHeight = 48;
            this.listClaveModulo.Location = new System.Drawing.Point(25, 116);
            this.listClaveModulo.Name = "listClaveModulo";
            this.listClaveModulo.Size = new System.Drawing.Size(177, 964);
            this.listClaveModulo.Sorted = true;
            this.listClaveModulo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(1424, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 48);
            this.label5.TabIndex = 7;
            this.label5.Text = "TOTAL CERRADOS";
            // 
            // lblCerrados
            // 
            this.lblCerrados.AutoSize = true;
            this.lblCerrados.Font = new System.Drawing.Font("Segoe UI Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCerrados.Location = new System.Drawing.Point(1531, 250);
            this.lblCerrados.Name = "lblCerrados";
            this.lblCerrados.Size = new System.Drawing.Size(51, 60);
            this.lblCerrados.TabIndex = 8;
            this.lblCerrados.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.comboBox1.Location = new System.Drawing.Point(26, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 33);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(12, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 38);
            this.label7.TabIndex = 10;
            this.label7.Text = "Intervalo";
            // 
            // lblIntervalo
            // 
            this.lblIntervalo.AutoSize = true;
            this.lblIntervalo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIntervalo.Location = new System.Drawing.Point(154, 50);
            this.lblIntervalo.Name = "lblIntervalo";
            this.lblIntervalo.Size = new System.Drawing.Size(33, 38);
            this.lblIntervalo.TabIndex = 11;
            this.lblIntervalo.Text = "0";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MonitorCierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1842, 1399);
            this.Controls.Add(this.lblIntervalo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblCerrados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MonitorCierre";
            this.Text = "com";
            this.Load += new System.EventHandler(this.MonitorCierre_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox listCentrosCerrados;
        private ListBox listCerradosMinutos;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label3;
        private Label label4;
        private ListBox listCentrosPorCerrar;
        private ListBox listPorCerrarMinutos;
        private GroupBox groupBox3;
        private Label label6;
        private ListBox listClaveModulo;
        private Label label5;
        private Label lblCerrados;
        private System.Windows.Forms.Timer timer1;
        private ComboBox comboBox1;
        private Label label7;
        private Label lblIntervalo;
        private System.Windows.Forms.Timer timer2;
    }
}