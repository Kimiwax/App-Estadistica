namespace EjercicioProbabilidadYEstadistica
{
    partial class Calcular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.btn_agrupados = new System.Windows.Forms.Button();
            this.txt_agrupados = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Estadistica = new System.Windows.Forms.DataGridView();
            this.Variable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_Absoluta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Frecuencia_Acumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.varianza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_frecuencia = new System.Windows.Forms.TextBox();
            this.btn_frecuencia = new System.Windows.Forms.Button();
            this.btn_frecuenciaAcumulada = new System.Windows.Forms.Button();
            this.lbl_media = new System.Windows.Forms.Label();
            this.lbl_mediaVacio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_modaVacio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_medianaVacio = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_cvVacio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_desvioStanVacio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_CoefiVa = new System.Windows.Forms.Label();
            this.chart_grafico1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_nuevoCalculo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estadistica)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafico1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_agrupados
            // 
            this.btn_agrupados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(223)))), ((int)(((byte)(100)))));
            this.btn_agrupados.FlatAppearance.BorderSize = 2;
            this.btn_agrupados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agrupados.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agrupados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btn_agrupados.Location = new System.Drawing.Point(53, 93);
            this.btn_agrupados.Name = "btn_agrupados";
            this.btn_agrupados.Size = new System.Drawing.Size(117, 56);
            this.btn_agrupados.TabIndex = 0;
            this.btn_agrupados.Text = "AGREGAR";
            this.btn_agrupados.UseVisualStyleBackColor = true;
            this.btn_agrupados.Click += new System.EventHandler(this.btn_agrupados_Click);
            // 
            // txt_agrupados
            // 
            this.txt_agrupados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.txt_agrupados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_agrupados.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_agrupados.ForeColor = System.Drawing.Color.White;
            this.txt_agrupados.Location = new System.Drawing.Point(70, 56);
            this.txt_agrupados.MaxLength = 8;
            this.txt_agrupados.Name = "txt_agrupados";
            this.txt_agrupados.ShortcutsEnabled = false;
            this.txt_agrupados.Size = new System.Drawing.Size(81, 24);
            this.txt_agrupados.TabIndex = 2;
            this.txt_agrupados.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_agrupados.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_agrupados_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "INGRESE LAS VARIABLES";
            // 
            // dgv_Estadistica
            // 
            this.dgv_Estadistica.AllowUserToAddRows = false;
            this.dgv_Estadistica.AllowUserToDeleteRows = false;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_Estadistica.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_Estadistica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgv_Estadistica.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.dgv_Estadistica.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Estadistica.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Estadistica.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_Estadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Estadistica.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Variable,
            this.Frecuencia_Absoluta,
            this.Frecuencia_Acumulada,
            this.Column1,
            this.varianza});
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Estadistica.DefaultCellStyle = dataGridViewCellStyle23;
            this.dgv_Estadistica.EnableHeadersVisualStyles = false;
            this.dgv_Estadistica.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.dgv_Estadistica.Location = new System.Drawing.Point(12, 251);
            this.dgv_Estadistica.Name = "dgv_Estadistica";
            this.dgv_Estadistica.ReadOnly = true;
            this.dgv_Estadistica.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Estadistica.RowHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_Estadistica.RowHeadersVisible = false;
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgv_Estadistica.RowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgv_Estadistica.Size = new System.Drawing.Size(502, 252);
            this.dgv_Estadistica.TabIndex = 5;
            // 
            // Variable
            // 
            this.Variable.HeaderText = "Variable";
            this.Variable.Name = "Variable";
            this.Variable.ReadOnly = true;
            // 
            // Frecuencia_Absoluta
            // 
            this.Frecuencia_Absoluta.HeaderText = "Frecuencia Absoluta";
            this.Frecuencia_Absoluta.Name = "Frecuencia_Absoluta";
            this.Frecuencia_Absoluta.ReadOnly = true;
            // 
            // Frecuencia_Acumulada
            // 
            this.Frecuencia_Acumulada.HeaderText = "Frecuencia Acumulada";
            this.Frecuencia_Acumulada.Name = "Frecuencia_Acumulada";
            this.Frecuencia_Acumulada.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "X*F";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // varianza
            // 
            this.varianza.HeaderText = "varianza";
            this.varianza.Name = "varianza";
            this.varianza.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "AGREGUE LAS FRECUENCIAS";
            // 
            // txt_frecuencia
            // 
            this.txt_frecuencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(21)))), ((int)(((byte)(23)))));
            this.txt_frecuencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_frecuencia.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_frecuencia.ForeColor = System.Drawing.Color.White;
            this.txt_frecuencia.Location = new System.Drawing.Point(84, 56);
            this.txt_frecuencia.MaxLength = 8;
            this.txt_frecuencia.Name = "txt_frecuencia";
            this.txt_frecuencia.Size = new System.Drawing.Size(81, 24);
            this.txt_frecuencia.TabIndex = 7;
            this.txt_frecuencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            this.txt_frecuencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_frecuencia_KeyPress);
            // 
            // btn_frecuencia
            // 
            this.btn_frecuencia.Enabled = false;
            this.btn_frecuencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(223)))), ((int)(((byte)(100)))));
            this.btn_frecuencia.FlatAppearance.BorderSize = 2;
            this.btn_frecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_frecuencia.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_frecuencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btn_frecuencia.Location = new System.Drawing.Point(67, 93);
            this.btn_frecuencia.Name = "btn_frecuencia";
            this.btn_frecuencia.Size = new System.Drawing.Size(117, 56);
            this.btn_frecuencia.TabIndex = 8;
            this.btn_frecuencia.Text = "AGREGAR";
            this.btn_frecuencia.UseVisualStyleBackColor = true;
            this.btn_frecuencia.Click += new System.EventHandler(this.btn_frecuencia_Click);
            // 
            // btn_frecuenciaAcumulada
            // 
            this.btn_frecuenciaAcumulada.Enabled = false;
            this.btn_frecuenciaAcumulada.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(223)))), ((int)(((byte)(100)))));
            this.btn_frecuenciaAcumulada.FlatAppearance.BorderSize = 2;
            this.btn_frecuenciaAcumulada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_frecuenciaAcumulada.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_frecuenciaAcumulada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btn_frecuenciaAcumulada.Location = new System.Drawing.Point(184, 185);
            this.btn_frecuenciaAcumulada.Name = "btn_frecuenciaAcumulada";
            this.btn_frecuenciaAcumulada.Size = new System.Drawing.Size(147, 53);
            this.btn_frecuenciaAcumulada.TabIndex = 9;
            this.btn_frecuenciaAcumulada.Text = "CALCULAR";
            this.btn_frecuenciaAcumulada.UseVisualStyleBackColor = true;
            this.btn_frecuenciaAcumulada.Click += new System.EventHandler(this.btn_frecuenciaAcumulada_Click);
            // 
            // lbl_media
            // 
            this.lbl_media.AutoSize = true;
            this.lbl_media.BackColor = System.Drawing.Color.Transparent;
            this.lbl_media.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_media.ForeColor = System.Drawing.Color.White;
            this.lbl_media.Location = new System.Drawing.Point(3, 6);
            this.lbl_media.Name = "lbl_media";
            this.lbl_media.Size = new System.Drawing.Size(62, 20);
            this.lbl_media.TabIndex = 10;
            this.lbl_media.Text = "Media:";
            // 
            // lbl_mediaVacio
            // 
            this.lbl_mediaVacio.AutoSize = true;
            this.lbl_mediaVacio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_mediaVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mediaVacio.ForeColor = System.Drawing.Color.White;
            this.lbl_mediaVacio.Location = new System.Drawing.Point(71, 6);
            this.lbl_mediaVacio.Name = "lbl_mediaVacio";
            this.lbl_mediaVacio.Size = new System.Drawing.Size(62, 20);
            this.lbl_mediaVacio.TabIndex = 11;
            this.lbl_mediaVacio.Text = "Media:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Moda:";
            // 
            // lbl_modaVacio
            // 
            this.lbl_modaVacio.AutoSize = true;
            this.lbl_modaVacio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_modaVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modaVacio.ForeColor = System.Drawing.Color.White;
            this.lbl_modaVacio.Location = new System.Drawing.Point(71, 34);
            this.lbl_modaVacio.Name = "lbl_modaVacio";
            this.lbl_modaVacio.Size = new System.Drawing.Size(14, 20);
            this.lbl_modaVacio.TabIndex = 13;
            this.lbl_modaVacio.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mediana:";
            // 
            // lbl_medianaVacio
            // 
            this.lbl_medianaVacio.AutoSize = true;
            this.lbl_medianaVacio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_medianaVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_medianaVacio.ForeColor = System.Drawing.Color.White;
            this.lbl_medianaVacio.Location = new System.Drawing.Point(91, 64);
            this.lbl_medianaVacio.Name = "lbl_medianaVacio";
            this.lbl_medianaVacio.Size = new System.Drawing.Size(14, 20);
            this.lbl_medianaVacio.TabIndex = 15;
            this.lbl_medianaVacio.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Varianza:";
            // 
            // lbl_cvVacio
            // 
            this.lbl_cvVacio.AutoSize = true;
            this.lbl_cvVacio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cvVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cvVacio.ForeColor = System.Drawing.Color.White;
            this.lbl_cvVacio.Location = new System.Drawing.Point(94, 93);
            this.lbl_cvVacio.Name = "lbl_cvVacio";
            this.lbl_cvVacio.Size = new System.Drawing.Size(14, 20);
            this.lbl_cvVacio.TabIndex = 17;
            this.lbl_cvVacio.Text = ".";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Desvio Standard:";
            // 
            // lbl_desvioStanVacio
            // 
            this.lbl_desvioStanVacio.AutoSize = true;
            this.lbl_desvioStanVacio.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desvioStanVacio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_desvioStanVacio.ForeColor = System.Drawing.Color.White;
            this.lbl_desvioStanVacio.Location = new System.Drawing.Point(156, 121);
            this.lbl_desvioStanVacio.Name = "lbl_desvioStanVacio";
            this.lbl_desvioStanVacio.Size = new System.Drawing.Size(14, 20);
            this.lbl_desvioStanVacio.TabIndex = 19;
            this.lbl_desvioStanVacio.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "CV:";
            // 
            // lbl_CoefiVa
            // 
            this.lbl_CoefiVa.AutoSize = true;
            this.lbl_CoefiVa.BackColor = System.Drawing.Color.Transparent;
            this.lbl_CoefiVa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CoefiVa.ForeColor = System.Drawing.Color.White;
            this.lbl_CoefiVa.Location = new System.Drawing.Point(47, 149);
            this.lbl_CoefiVa.Name = "lbl_CoefiVa";
            this.lbl_CoefiVa.Size = new System.Drawing.Size(14, 20);
            this.lbl_CoefiVa.TabIndex = 21;
            this.lbl_CoefiVa.Text = ".";
            // 
            // chart_grafico1
            // 
            this.chart_grafico1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.chart_grafico1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.chart_grafico1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.chart_grafico1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.Name = "ChartArea1";
            this.chart_grafico1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_grafico1.Legends.Add(legend5);
            this.chart_grafico1.Location = new System.Drawing.Point(531, 224);
            this.chart_grafico1.Name = "chart_grafico1";
            this.chart_grafico1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart_grafico1.Size = new System.Drawing.Size(373, 300);
            this.chart_grafico1.TabIndex = 22;
            this.chart_grafico1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_agrupados);
            this.panel1.Controls.Add(this.btn_agrupados);
            this.panel1.Location = new System.Drawing.Point(22, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 161);
            this.panel1.TabIndex = 23;
            // 
            // btn_nuevoCalculo
            // 
            this.btn_nuevoCalculo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(90)))), ((int)(((byte)(214)))));
            this.btn_nuevoCalculo.FlatAppearance.BorderSize = 2;
            this.btn_nuevoCalculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevoCalculo.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nuevoCalculo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.btn_nuevoCalculo.Location = new System.Drawing.Point(369, 197);
            this.btn_nuevoCalculo.Name = "btn_nuevoCalculo";
            this.btn_nuevoCalculo.Size = new System.Drawing.Size(145, 41);
            this.btn_nuevoCalculo.TabIndex = 46;
            this.btn_nuevoCalculo.Text = "NUEVO CALCULO";
            this.btn_nuevoCalculo.UseVisualStyleBackColor = true;
            this.btn_nuevoCalculo.Click += new System.EventHandler(this.btn_nuevoCalculo_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.lbl_CoefiVa);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lbl_media);
            this.panel2.Controls.Add(this.lbl_mediaVacio);
            this.panel2.Controls.Add(this.lbl_desvioStanVacio);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lbl_modaVacio);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbl_cvVacio);
            this.panel2.Controls.Add(this.lbl_medianaVacio);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(531, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 174);
            this.panel2.TabIndex = 47;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel7.Location = new System.Drawing.Point(0, 142);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(373, 4);
            this.panel7.TabIndex = 20;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel6.Location = new System.Drawing.Point(0, 114);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(373, 4);
            this.panel6.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel5.Location = new System.Drawing.Point(0, 86);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(373, 4);
            this.panel5.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel4.Location = new System.Drawing.Point(0, 57);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 4);
            this.panel4.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.panel3.Location = new System.Drawing.Point(0, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 4);
            this.panel3.TabIndex = 12;
            // 
            // panel8
            // 
            this.panel8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panel8.Controls.Add(this.txt_frecuencia);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.btn_frecuencia);
            this.panel8.Location = new System.Drawing.Point(265, 15);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(256, 161);
            this.panel8.TabIndex = 48;
            // 
            // Calcular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(916, 536);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_nuevoCalculo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chart_grafico1);
            this.Controls.Add(this.btn_frecuenciaAcumulada);
            this.Controls.Add(this.dgv_Estadistica);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calcular";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Estadistica)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_grafico1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_agrupados;
        private System.Windows.Forms.TextBox txt_agrupados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Estadistica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Variable;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_Absoluta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Frecuencia_Acumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_frecuencia;
        private System.Windows.Forms.Button btn_frecuencia;
        private System.Windows.Forms.Button btn_frecuenciaAcumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn varianza;
        private System.Windows.Forms.Label lbl_media;
        private System.Windows.Forms.Label lbl_mediaVacio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_modaVacio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_medianaVacio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_cvVacio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_desvioStanVacio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_CoefiVa;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_grafico1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_nuevoCalculo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
    }
}