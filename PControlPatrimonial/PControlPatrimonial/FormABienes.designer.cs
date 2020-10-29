namespace ControlPatrimonial
{
    partial class FormABienes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormABienes));
            this.label3 = new System.Windows.Forms.Label();
            this.BoxDepreciacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BoxValorH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BoxObservacion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.BoxBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoxCodigo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.BoxDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.BoxColor = new System.Windows.Forms.TextBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminarUsuario = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.RadioBMueble = new System.Windows.Forms.RadioButton();
            this.RadioBComputo = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.LabelEstado = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.BoxEstado = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.BoxTVida = new System.Windows.Forms.TextBox();
            this.BoxFechaCompra = new System.Windows.Forms.TextBox();
            this.BoxValorNeto = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.BoxDimensiones = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.BoxDepreciacionAnual = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.BoxCaracteristicas = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.BoxModelo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.BoxMarca = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.BoxCodigoAmbiente = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.BoxDepreciacionMensual = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(339, 644);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depreciacion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // BoxDepreciacion
            // 
            this.BoxDepreciacion.Location = new System.Drawing.Point(489, 647);
            this.BoxDepreciacion.Name = "BoxDepreciacion";
            this.BoxDepreciacion.Size = new System.Drawing.Size(222, 22);
            this.BoxDepreciacion.TabIndex = 4;
            this.BoxDepreciacion.TextChanged += new System.EventHandler(this.BoxValorActual_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor Historico:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // BoxValorH
            // 
            this.BoxValorH.Location = new System.Drawing.Point(500, 617);
            this.BoxValorH.Name = "BoxValorH";
            this.BoxValorH.Size = new System.Drawing.Size(211, 22);
            this.BoxValorH.TabIndex = 6;
            this.BoxValorH.TextChanged += new System.EventHandler(this.BoxTasaInteres_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(339, 588);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Observacion:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // BoxObservacion
            // 
            this.BoxObservacion.Location = new System.Drawing.Point(489, 589);
            this.BoxObservacion.Name = "BoxObservacion";
            this.BoxObservacion.Size = new System.Drawing.Size(222, 22);
            this.BoxObservacion.TabIndex = 8;
            this.BoxObservacion.TextChanged += new System.EventHandler(this.BoxTiempo_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Filtrar por:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 28);
            this.label1.TabIndex = 13;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1100, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 66);
            this.button1.TabIndex = 16;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Grid1
            // 
            this.Grid1.AllowUserToAddRows = false;
            this.Grid1.AllowUserToDeleteRows = false;
            this.Grid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.Grid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Grid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Grid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Grid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Grid1.EnableHeadersVisualStyles = false;
            this.Grid1.Location = new System.Drawing.Point(12, 194);
            this.Grid1.Name = "Grid1";
            this.Grid1.ReadOnly = true;
            this.Grid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Grid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.Grid1.RowHeadersVisible = false;
            this.Grid1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Grid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Grid1.RowTemplate.Height = 24;
            this.Grid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid1.Size = new System.Drawing.Size(1262, 389);
            this.Grid1.TabIndex = 17;
            // 
            // BoxBuscar
            // 
            this.BoxBuscar.Location = new System.Drawing.Point(249, 160);
            this.BoxBuscar.Name = "BoxBuscar";
            this.BoxBuscar.Size = new System.Drawing.Size(462, 22);
            this.BoxBuscar.TabIndex = 33;
            this.BoxBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BoxBuscar_KeyUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(270, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(755, 105);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 38;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 589);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 40;
            this.label2.Text = "Codigo:";
            // 
            // BoxCodigo
            // 
            this.BoxCodigo.Location = new System.Drawing.Point(115, 588);
            this.BoxCodigo.Name = "BoxCodigo";
            this.BoxCodigo.Size = new System.Drawing.Size(216, 22);
            this.BoxCodigo.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 613);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 22);
            this.label8.TabIndex = 42;
            this.label8.Text = "Descripcion:";
            // 
            // BoxDescripcion
            // 
            this.BoxDescripcion.Location = new System.Drawing.Point(159, 617);
            this.BoxDescripcion.Name = "BoxDescripcion";
            this.BoxDescripcion.Size = new System.Drawing.Size(172, 22);
            this.BoxDescripcion.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 715);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 44;
            this.label9.Text = "Color:";
            // 
            // BoxColor
            // 
            this.BoxColor.Location = new System.Drawing.Point(100, 715);
            this.BoxColor.Name = "BoxColor";
            this.BoxColor.Size = new System.Drawing.Size(231, 22);
            this.BoxColor.TabIndex = 43;
            // 
            // BtnModificar
            // 
            this.BtnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnModificar.Location = new System.Drawing.Point(735, 122);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(174, 66);
            this.BtnModificar.TabIndex = 45;
            this.BtnModificar.Text = "Editar";
            this.BtnModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnModificar.UseVisualStyleBackColor = false;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminarUsuario
            // 
            this.BtnEliminarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.BtnEliminarUsuario.FlatAppearance.BorderSize = 0;
            this.BtnEliminarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.BtnEliminarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminarUsuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnEliminarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminarUsuario.Image")));
            this.BtnEliminarUsuario.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnEliminarUsuario.Location = new System.Drawing.Point(920, 122);
            this.BtnEliminarUsuario.Name = "BtnEliminarUsuario";
            this.BtnEliminarUsuario.Size = new System.Drawing.Size(174, 66);
            this.BtnEliminarUsuario.TabIndex = 46;
            this.BtnEliminarUsuario.Text = "Eliminar";
            this.BtnEliminarUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEliminarUsuario.UseVisualStyleBackColor = false;
            this.BtnEliminarUsuario.Click += new System.EventHandler(this.BtnEliminarUsuario_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Muebles",
            "Computo",
            "Ambos"});
            this.comboBox1.Location = new System.Drawing.Point(137, 127);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 24);
            this.comboBox1.TabIndex = 49;
            this.comboBox1.Text = "Ambos";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Codigo",
            "Descripcion",
            "Estado",
            "Observacion"});
            this.comboBox2.Location = new System.Drawing.Point(137, 160);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(106, 24);
            this.comboBox2.TabIndex = 51;
            this.comboBox2.Text = "Codigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 22);
            this.label7.TabIndex = 50;
            this.label7.Text = "Buscar por:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(104)))), ((int)(((byte)(13)))), ((int)(((byte)(15)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(1100, 722);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 66);
            this.button2.TabIndex = 52;
            this.button2.Text = "Guardar";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RadioBMueble
            // 
            this.RadioBMueble.AutoSize = true;
            this.RadioBMueble.Location = new System.Drawing.Point(1127, 665);
            this.RadioBMueble.Name = "RadioBMueble";
            this.RadioBMueble.Size = new System.Drawing.Size(127, 21);
            this.RadioBMueble.TabIndex = 53;
            this.RadioBMueble.TabStop = true;
            this.RadioBMueble.Text = "Agregar Mueble";
            this.RadioBMueble.UseVisualStyleBackColor = true;
            this.RadioBMueble.CheckedChanged += new System.EventHandler(this.RadioBMueble_CheckedChanged);
            // 
            // RadioBComputo
            // 
            this.RadioBComputo.AutoSize = true;
            this.RadioBComputo.Location = new System.Drawing.Point(1127, 692);
            this.RadioBComputo.Name = "RadioBComputo";
            this.RadioBComputo.Size = new System.Drawing.Size(137, 21);
            this.RadioBComputo.TabIndex = 54;
            this.RadioBComputo.TabStop = true;
            this.RadioBComputo.Text = "Agregar Computo";
            this.RadioBComputo.UseVisualStyleBackColor = true;
            this.RadioBComputo.CheckedChanged += new System.EventHandler(this.RadioBComputo_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1117, 603);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 23);
            this.label10.TabIndex = 55;
            this.label10.Text = "Estado:";
            // 
            // LabelEstado
            // 
            this.LabelEstado.AutoSize = true;
            this.LabelEstado.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelEstado.Location = new System.Drawing.Point(1116, 626);
            this.LabelEstado.Name = "LabelEstado";
            this.LabelEstado.Size = new System.Drawing.Size(148, 30);
            this.LabelEstado.TabIndex = 56;
            this.LabelEstado.Text = "Agregando";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 646);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 22);
            this.label12.TabIndex = 58;
            this.label12.Text = "Estado:";
            // 
            // BoxEstado
            // 
            this.BoxEstado.Location = new System.Drawing.Point(100, 646);
            this.BoxEstado.Name = "BoxEstado";
            this.BoxEstado.Size = new System.Drawing.Size(231, 22);
            this.BoxEstado.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(717, 589);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 22);
            this.label13.TabIndex = 61;
            this.label13.Text = "Tiempo Vida:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(717, 615);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(154, 22);
            this.label14.TabIndex = 60;
            this.label14.Text = "Fecha Compra:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(717, 645);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 22);
            this.label15.TabIndex = 59;
            this.label15.Text = "Valor Neto:";
            // 
            // BoxTVida
            // 
            this.BoxTVida.Location = new System.Drawing.Point(858, 588);
            this.BoxTVida.Name = "BoxTVida";
            this.BoxTVida.Size = new System.Drawing.Size(231, 22);
            this.BoxTVida.TabIndex = 64;
            // 
            // BoxFechaCompra
            // 
            this.BoxFechaCompra.Location = new System.Drawing.Point(890, 617);
            this.BoxFechaCompra.Name = "BoxFechaCompra";
            this.BoxFechaCompra.Size = new System.Drawing.Size(199, 22);
            this.BoxFechaCompra.TabIndex = 63;
            // 
            // BoxValorNeto
            // 
            this.BoxValorNeto.Location = new System.Drawing.Point(867, 646);
            this.BoxValorNeto.Name = "BoxValorNeto";
            this.BoxValorNeto.Size = new System.Drawing.Size(222, 22);
            this.BoxValorNeto.TabIndex = 62;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 743);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 22);
            this.label16.TabIndex = 66;
            this.label16.Text = "Dimensiones:";
            // 
            // BoxDimensiones
            // 
            this.BoxDimensiones.Location = new System.Drawing.Point(159, 743);
            this.BoxDimensiones.Name = "BoxDimensiones";
            this.BoxDimensiones.Size = new System.Drawing.Size(172, 22);
            this.BoxDimensiones.TabIndex = 65;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 771);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(199, 22);
            this.label17.TabIndex = 68;
            this.label17.Text = "Depreciacion Anual:";
            // 
            // BoxDepreciacionAnual
            // 
            this.BoxDepreciacionAnual.Location = new System.Drawing.Point(229, 771);
            this.BoxDepreciacionAnual.Name = "BoxDepreciacionAnual";
            this.BoxDepreciacionAnual.Size = new System.Drawing.Size(102, 22);
            this.BoxDepreciacionAnual.TabIndex = 67;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(339, 771);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 22);
            this.label18.TabIndex = 74;
            this.label18.Text = "Caracteristicas:";
            // 
            // BoxCaracteristicas
            // 
            this.BoxCaracteristicas.Location = new System.Drawing.Point(509, 770);
            this.BoxCaracteristicas.Name = "BoxCaracteristicas";
            this.BoxCaracteristicas.Size = new System.Drawing.Size(200, 22);
            this.BoxCaracteristicas.TabIndex = 73;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(339, 743);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(84, 22);
            this.label19.TabIndex = 72;
            this.label19.Text = "Modelo:";
            // 
            // BoxModelo
            // 
            this.BoxModelo.Location = new System.Drawing.Point(449, 742);
            this.BoxModelo.Name = "BoxModelo";
            this.BoxModelo.Size = new System.Drawing.Size(260, 22);
            this.BoxModelo.TabIndex = 71;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(339, 715);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(76, 22);
            this.label20.TabIndex = 70;
            this.label20.Text = "Marca:";
            // 
            // BoxMarca
            // 
            this.BoxMarca.Location = new System.Drawing.Point(430, 714);
            this.BoxMarca.Name = "BoxMarca";
            this.BoxMarca.Size = new System.Drawing.Size(279, 22);
            this.BoxMarca.TabIndex = 69;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(717, 769);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(209, 22);
            this.label21.TabIndex = 80;
            this.label21.Text = "Codigo de Ambiente:";
            // 
            // BoxCodigoAmbiente
            // 
            this.BoxCodigoAmbiente.Location = new System.Drawing.Point(941, 769);
            this.BoxCodigoAmbiente.Name = "BoxCodigoAmbiente";
            this.BoxCodigoAmbiente.Size = new System.Drawing.Size(148, 22);
            this.BoxCodigoAmbiente.TabIndex = 79;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold);
            this.label22.Location = new System.Drawing.Point(716, 745);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(363, 17);
            this.label22.TabIndex = 78;
            this.label22.Text = "Si va a agregar (Especifique el codigo de ambiente)";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(715, 713);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(220, 22);
            this.label23.TabIndex = 76;
            this.label23.Text = "Depreciacion Mensual:";
            // 
            // BoxDepreciacionMensual
            // 
            this.BoxDepreciacionMensual.Location = new System.Drawing.Point(961, 713);
            this.BoxDepreciacionMensual.Name = "BoxDepreciacionMensual";
            this.BoxDepreciacionMensual.Size = new System.Drawing.Size(128, 22);
            this.BoxDepreciacionMensual.TabIndex = 75;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(529, 680);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(223, 23);
            this.label24.TabIndex = 81;
            this.label24.Text = "Campo para Computo";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(81, 680);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(219, 23);
            this.label25.TabIndex = 82;
            this.label25.Text = "Campo para Muebles:";
            // 
            // FormABienes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1282, 800);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.BoxCodigoAmbiente);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.BoxDepreciacionMensual);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.BoxCaracteristicas);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.BoxModelo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.BoxMarca);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.BoxDepreciacionAnual);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.BoxDimensiones);
            this.Controls.Add(this.BoxTVida);
            this.Controls.Add(this.BoxFechaCompra);
            this.Controls.Add(this.BoxValorNeto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BoxEstado);
            this.Controls.Add(this.LabelEstado);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.RadioBComputo);
            this.Controls.Add(this.RadioBMueble);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BtnEliminarUsuario);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BoxColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BoxDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxCodigo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.BoxBuscar);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BoxObservacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BoxValorH);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BoxDepreciacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormABienes";
            this.Text = "Calcular Interes Simple";
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BoxDepreciacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox BoxValorH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox BoxObservacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.TextBox BoxBuscar;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BoxCodigo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox BoxDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox BoxColor;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminarUsuario;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton RadioBMueble;
        private System.Windows.Forms.RadioButton RadioBComputo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LabelEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox BoxEstado;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox BoxTVida;
        private System.Windows.Forms.TextBox BoxFechaCompra;
        private System.Windows.Forms.TextBox BoxValorNeto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox BoxDimensiones;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox BoxDepreciacionAnual;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox BoxCaracteristicas;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox BoxModelo;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox BoxMarca;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox BoxCodigoAmbiente;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox BoxDepreciacionMensual;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
    }
}