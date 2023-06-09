﻿namespace Proyecto_Net_2.GUI
{
    partial class Adm_Marcas
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
            this.components = new System.ComponentModel.Container();
            this.Lbl_Marcas = new System.Windows.Forms.Label();
            this.Gbox_Datos = new System.Windows.Forms.GroupBox();
            this.Txt_Direccion = new System.Windows.Forms.TextBox();
            this.Lbl_Direccion = new System.Windows.Forms.Label();
            this.Cbox_Comuna = new System.Windows.Forms.ComboBox();
            this.Lbl_Comuna = new System.Windows.Forms.Label();
            this.Cbox_Region = new System.Windows.Forms.ComboBox();
            this.Lbl_Region = new System.Windows.Forms.Label();
            this.Txt_Dig_Veri = new System.Windows.Forms.TextBox();
            this.Lbl_guion = new System.Windows.Forms.Label();
            this.Txt_Ident = new System.Windows.Forms.TextBox();
            this.Lbl_Ident = new System.Windows.Forms.Label();
            this.Txt_Rso_social = new System.Windows.Forms.TextBox();
            this.Lbl_Rso_social = new System.Windows.Forms.Label();
            this.Gbox_Inf_Vehiculos = new System.Windows.Forms.GroupBox();
            this.Lbl_Tip_Comb = new System.Windows.Forms.Label();
            this.Chk_Tip_Comb = new System.Windows.Forms.CheckedListBox();
            this.ChkBox_Estados_Vehi = new System.Windows.Forms.CheckedListBox();
            this.Lbl_Estados_Vehiculos = new System.Windows.Forms.Label();
            this.ChkBox_Tipos_Vehiculos = new System.Windows.Forms.CheckedListBox();
            this.Tipo_Vehiculos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cbox_Comuna_CNC = new System.Windows.Forms.ComboBox();
            this.Lbl_Comuna_CNC = new System.Windows.Forms.Label();
            this.Cbox_Region_CNC = new System.Windows.Forms.ComboBox();
            this.Lbl_Region_CNC = new System.Windows.Forms.Label();
            this.Txt_Direccion_CNC = new System.Windows.Forms.TextBox();
            this.Lbl_Direccion_CNC = new System.Windows.Forms.Label();
            this.Txt_Dig_verificador_CNC = new System.Windows.Forms.TextBox();
            this.Lbl_Guion_CNC = new System.Windows.Forms.Label();
            this.Txt_Ident_CNC = new System.Windows.Forms.TextBox();
            this.Lbl_Ident_CNC = new System.Windows.Forms.Label();
            this.Txt_Ape_CNC = new System.Windows.Forms.TextBox();
            this.Lbl_Ape_CNC = new System.Windows.Forms.Label();
            this.Txt_Nombre_CNC = new System.Windows.Forms.TextBox();
            this.Lbl_Nombre_CNT = new System.Windows.Forms.Label();
            this.Gbox_Botonera = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.carga_Region_Marca = new Proyecto_Net_2.Carga_Region_Marca();
            this.regionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.regionTableAdapter = new Proyecto_Net_2.Carga_Region_MarcaTableAdapters.regionTableAdapter();
            this.carga_Comunas_Marca = new Proyecto_Net_2.Carga_Comunas_Marca();
            this.comunasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comunasTableAdapter = new Proyecto_Net_2.Carga_Comunas_MarcaTableAdapters.ComunasTableAdapter();
            this.carga_Region_Cnc = new Proyecto_Net_2.Carga_Region_Cnc();
            this.regionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.regionTableAdapter1 = new Proyecto_Net_2.Carga_Region_CncTableAdapters.regionTableAdapter();
            this.carga_Comunas_Cnc = new Proyecto_Net_2.Carga_Comunas_Cnc();
            this.comunasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comunasTableAdapter1 = new Proyecto_Net_2.Carga_Comunas_CncTableAdapters.ComunasTableAdapter();
            this.Gbox_Datos.SuspendLayout();
            this.Gbox_Inf_Vehiculos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Gbox_Botonera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carga_Region_Marca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carga_Comunas_Marca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carga_Region_Cnc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carga_Comunas_Cnc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Marcas
            // 
            this.Lbl_Marcas.AutoSize = true;
            this.Lbl_Marcas.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Marcas.Location = new System.Drawing.Point(190, 9);
            this.Lbl_Marcas.Name = "Lbl_Marcas";
            this.Lbl_Marcas.Size = new System.Drawing.Size(287, 31);
            this.Lbl_Marcas.TabIndex = 0;
            this.Lbl_Marcas.Text = "Administración Marcas";
            // 
            // Gbox_Datos
            // 
            this.Gbox_Datos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gbox_Datos.Controls.Add(this.Txt_Direccion);
            this.Gbox_Datos.Controls.Add(this.Lbl_Direccion);
            this.Gbox_Datos.Controls.Add(this.Cbox_Comuna);
            this.Gbox_Datos.Controls.Add(this.Lbl_Comuna);
            this.Gbox_Datos.Controls.Add(this.Cbox_Region);
            this.Gbox_Datos.Controls.Add(this.Lbl_Region);
            this.Gbox_Datos.Controls.Add(this.Txt_Dig_Veri);
            this.Gbox_Datos.Controls.Add(this.Lbl_guion);
            this.Gbox_Datos.Controls.Add(this.Txt_Ident);
            this.Gbox_Datos.Controls.Add(this.Lbl_Ident);
            this.Gbox_Datos.Controls.Add(this.Txt_Rso_social);
            this.Gbox_Datos.Controls.Add(this.Lbl_Rso_social);
            this.Gbox_Datos.Location = new System.Drawing.Point(12, 53);
            this.Gbox_Datos.Name = "Gbox_Datos";
            this.Gbox_Datos.Size = new System.Drawing.Size(687, 128);
            this.Gbox_Datos.TabIndex = 1;
            this.Gbox_Datos.TabStop = false;
            this.Gbox_Datos.Text = "Datos Marcas";
            // 
            // Txt_Direccion
            // 
            this.Txt_Direccion.Location = new System.Drawing.Point(305, 86);
            this.Txt_Direccion.Name = "Txt_Direccion";
            this.Txt_Direccion.Size = new System.Drawing.Size(210, 20);
            this.Txt_Direccion.TabIndex = 10;
            // 
            // Lbl_Direccion
            // 
            this.Lbl_Direccion.AutoSize = true;
            this.Lbl_Direccion.Location = new System.Drawing.Point(302, 65);
            this.Lbl_Direccion.Name = "Lbl_Direccion";
            this.Lbl_Direccion.Size = new System.Drawing.Size(52, 13);
            this.Lbl_Direccion.TabIndex = 9;
            this.Lbl_Direccion.Text = "Dirección";
            // 
            // Cbox_Comuna
            // 
            this.Cbox_Comuna.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.comunasBindingSource, "id_Comuna", true));
            this.Cbox_Comuna.DataSource = this.comunasBindingSource;
            this.Cbox_Comuna.DisplayMember = "Nmbre_comuna";
            this.Cbox_Comuna.FormattingEnabled = true;
            this.Cbox_Comuna.Location = new System.Drawing.Point(489, 36);
            this.Cbox_Comuna.Name = "Cbox_Comuna";
            this.Cbox_Comuna.Size = new System.Drawing.Size(149, 21);
            this.Cbox_Comuna.TabIndex = 8;
            this.Cbox_Comuna.ValueMember = "id_Comuna";
            // 
            // Lbl_Comuna
            // 
            this.Lbl_Comuna.AutoSize = true;
            this.Lbl_Comuna.Location = new System.Drawing.Point(486, 20);
            this.Lbl_Comuna.Name = "Lbl_Comuna";
            this.Lbl_Comuna.Size = new System.Drawing.Size(46, 13);
            this.Lbl_Comuna.TabIndex = 7;
            this.Lbl_Comuna.Text = "Comuna";
            // 
            // Cbox_Region
            // 
            this.Cbox_Region.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.regionBindingSource, "id_region", true));
            this.Cbox_Region.DataSource = this.regionBindingSource;
            this.Cbox_Region.DisplayMember = "Nmbre_region";
            this.Cbox_Region.FormattingEnabled = true;
            this.Cbox_Region.Location = new System.Drawing.Point(302, 37);
            this.Cbox_Region.Name = "Cbox_Region";
            this.Cbox_Region.Size = new System.Drawing.Size(163, 21);
            this.Cbox_Region.TabIndex = 6;
            this.Cbox_Region.ValueMember = "id_region";
            // 
            // Lbl_Region
            // 
            this.Lbl_Region.AutoSize = true;
            this.Lbl_Region.Location = new System.Drawing.Point(299, 19);
            this.Lbl_Region.Name = "Lbl_Region";
            this.Lbl_Region.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Region.TabIndex = 5;
            this.Lbl_Region.Text = "Región";
            // 
            // Txt_Dig_Veri
            // 
            this.Txt_Dig_Veri.Location = new System.Drawing.Point(132, 79);
            this.Txt_Dig_Veri.MaxLength = 1;
            this.Txt_Dig_Veri.Name = "Txt_Dig_Veri";
            this.Txt_Dig_Veri.Size = new System.Drawing.Size(21, 20);
            this.Txt_Dig_Veri.TabIndex = 4;
            // 
            // Lbl_guion
            // 
            this.Lbl_guion.AutoSize = true;
            this.Lbl_guion.Location = new System.Drawing.Point(116, 86);
            this.Lbl_guion.Name = "Lbl_guion";
            this.Lbl_guion.Size = new System.Drawing.Size(10, 13);
            this.Lbl_guion.TabIndex = 3;
            this.Lbl_guion.Text = "-";
            // 
            // Txt_Ident
            // 
            this.Txt_Ident.Location = new System.Drawing.Point(10, 80);
            this.Txt_Ident.MaxLength = 12;
            this.Txt_Ident.Name = "Txt_Ident";
            this.Txt_Ident.Size = new System.Drawing.Size(99, 20);
            this.Txt_Ident.TabIndex = 2;
            this.Txt_Ident.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Ident_KeyPress);
            // 
            // Lbl_Ident
            // 
            this.Lbl_Ident.AutoSize = true;
            this.Lbl_Ident.Location = new System.Drawing.Point(10, 64);
            this.Lbl_Ident.Name = "Lbl_Ident";
            this.Lbl_Ident.Size = new System.Drawing.Size(70, 13);
            this.Lbl_Ident.TabIndex = 2;
            this.Lbl_Ident.Text = "Identificación";
            // 
            // Txt_Rso_social
            // 
            this.Txt_Rso_social.Location = new System.Drawing.Point(10, 37);
            this.Txt_Rso_social.Name = "Txt_Rso_social";
            this.Txt_Rso_social.Size = new System.Drawing.Size(230, 20);
            this.Txt_Rso_social.TabIndex = 1;
            this.Txt_Rso_social.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Rso_social_KeyPress);
            // 
            // Lbl_Rso_social
            // 
            this.Lbl_Rso_social.AutoSize = true;
            this.Lbl_Rso_social.Location = new System.Drawing.Point(7, 20);
            this.Lbl_Rso_social.Name = "Lbl_Rso_social";
            this.Lbl_Rso_social.Size = new System.Drawing.Size(70, 13);
            this.Lbl_Rso_social.TabIndex = 0;
            this.Lbl_Rso_social.Text = "Razon Social";
            // 
            // Gbox_Inf_Vehiculos
            // 
            this.Gbox_Inf_Vehiculos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gbox_Inf_Vehiculos.Controls.Add(this.Lbl_Tip_Comb);
            this.Gbox_Inf_Vehiculos.Controls.Add(this.Chk_Tip_Comb);
            this.Gbox_Inf_Vehiculos.Controls.Add(this.ChkBox_Estados_Vehi);
            this.Gbox_Inf_Vehiculos.Controls.Add(this.Lbl_Estados_Vehiculos);
            this.Gbox_Inf_Vehiculos.Controls.Add(this.ChkBox_Tipos_Vehiculos);
            this.Gbox_Inf_Vehiculos.Controls.Add(this.Tipo_Vehiculos);
            this.Gbox_Inf_Vehiculos.Location = new System.Drawing.Point(13, 187);
            this.Gbox_Inf_Vehiculos.Name = "Gbox_Inf_Vehiculos";
            this.Gbox_Inf_Vehiculos.Size = new System.Drawing.Size(687, 216);
            this.Gbox_Inf_Vehiculos.TabIndex = 2;
            this.Gbox_Inf_Vehiculos.TabStop = false;
            this.Gbox_Inf_Vehiculos.Text = "Información Vehiculos";
            // 
            // Lbl_Tip_Comb
            // 
            this.Lbl_Tip_Comb.AutoSize = true;
            this.Lbl_Tip_Comb.Location = new System.Drawing.Point(310, 20);
            this.Lbl_Tip_Comb.Name = "Lbl_Tip_Comb";
            this.Lbl_Tip_Comb.Size = new System.Drawing.Size(101, 13);
            this.Lbl_Tip_Comb.TabIndex = 5;
            this.Lbl_Tip_Comb.Text = "Tipo de Combustion";
            // 
            // Chk_Tip_Comb
            // 
            this.Chk_Tip_Comb.FormattingEnabled = true;
            this.Chk_Tip_Comb.Items.AddRange(new object[] {
            "Gasolina",
            "Diesel",
            "Hibrido",
            "Electrico",
            "Hidrogeno"});
            this.Chk_Tip_Comb.Location = new System.Drawing.Point(304, 36);
            this.Chk_Tip_Comb.Name = "Chk_Tip_Comb";
            this.Chk_Tip_Comb.Size = new System.Drawing.Size(120, 79);
            this.Chk_Tip_Comb.TabIndex = 4;
            // 
            // ChkBox_Estados_Vehi
            // 
            this.ChkBox_Estados_Vehi.FormattingEnabled = true;
            this.ChkBox_Estados_Vehi.Items.AddRange(new object[] {
            "Nuevos",
            "Semi-Nuevos",
            "Usados"});
            this.ChkBox_Estados_Vehi.Location = new System.Drawing.Point(156, 36);
            this.ChkBox_Estados_Vehi.Name = "ChkBox_Estados_Vehi";
            this.ChkBox_Estados_Vehi.Size = new System.Drawing.Size(120, 49);
            this.ChkBox_Estados_Vehi.TabIndex = 3;
            // 
            // Lbl_Estados_Vehiculos
            // 
            this.Lbl_Estados_Vehiculos.AutoSize = true;
            this.Lbl_Estados_Vehiculos.Location = new System.Drawing.Point(163, 20);
            this.Lbl_Estados_Vehiculos.Name = "Lbl_Estados_Vehiculos";
            this.Lbl_Estados_Vehiculos.Size = new System.Drawing.Size(89, 13);
            this.Lbl_Estados_Vehiculos.TabIndex = 2;
            this.Lbl_Estados_Vehiculos.Text = "Estado Vehiculos";
            // 
            // ChkBox_Tipos_Vehiculos
            // 
            this.ChkBox_Tipos_Vehiculos.FormattingEnabled = true;
            this.ChkBox_Tipos_Vehiculos.Items.AddRange(new object[] {
            "Camiones",
            "SUV",
            "Furgones",
            "Camionetas",
            "Sedanes"});
            this.ChkBox_Tipos_Vehiculos.Location = new System.Drawing.Point(6, 36);
            this.ChkBox_Tipos_Vehiculos.Name = "ChkBox_Tipos_Vehiculos";
            this.ChkBox_Tipos_Vehiculos.Size = new System.Drawing.Size(120, 79);
            this.ChkBox_Tipos_Vehiculos.TabIndex = 1;
            // 
            // Tipo_Vehiculos
            // 
            this.Tipo_Vehiculos.AutoSize = true;
            this.Tipo_Vehiculos.Location = new System.Drawing.Point(7, 20);
            this.Tipo_Vehiculos.Name = "Tipo_Vehiculos";
            this.Tipo_Vehiculos.Size = new System.Drawing.Size(92, 13);
            this.Tipo_Vehiculos.TabIndex = 0;
            this.Tipo_Vehiculos.Text = "Tipo de Vehiculos";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.Cbox_Comuna_CNC);
            this.groupBox1.Controls.Add(this.Lbl_Comuna_CNC);
            this.groupBox1.Controls.Add(this.Cbox_Region_CNC);
            this.groupBox1.Controls.Add(this.Lbl_Region_CNC);
            this.groupBox1.Controls.Add(this.Txt_Direccion_CNC);
            this.groupBox1.Controls.Add(this.Lbl_Direccion_CNC);
            this.groupBox1.Controls.Add(this.Txt_Dig_verificador_CNC);
            this.groupBox1.Controls.Add(this.Lbl_Guion_CNC);
            this.groupBox1.Controls.Add(this.Txt_Ident_CNC);
            this.groupBox1.Controls.Add(this.Lbl_Ident_CNC);
            this.groupBox1.Controls.Add(this.Txt_Ape_CNC);
            this.groupBox1.Controls.Add(this.Lbl_Ape_CNC);
            this.groupBox1.Controls.Add(this.Txt_Nombre_CNC);
            this.groupBox1.Controls.Add(this.Lbl_Nombre_CNT);
            this.groupBox1.Location = new System.Drawing.Point(12, 409);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 127);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Contactos";
            // 
            // Cbox_Comuna_CNC
            // 
            this.Cbox_Comuna_CNC.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.regionBindingSource1, "id_region", true));
            this.Cbox_Comuna_CNC.DataSource = this.comunasBindingSource1;
            this.Cbox_Comuna_CNC.DisplayMember = "Nmbre_comuna";
            this.Cbox_Comuna_CNC.FormattingEnabled = true;
            this.Cbox_Comuna_CNC.Location = new System.Drawing.Point(445, 83);
            this.Cbox_Comuna_CNC.Name = "Cbox_Comuna_CNC";
            this.Cbox_Comuna_CNC.Size = new System.Drawing.Size(175, 21);
            this.Cbox_Comuna_CNC.TabIndex = 13;
            this.Cbox_Comuna_CNC.ValueMember = "id_Comuna";
            // 
            // Lbl_Comuna_CNC
            // 
            this.Lbl_Comuna_CNC.AutoSize = true;
            this.Lbl_Comuna_CNC.Location = new System.Drawing.Point(442, 69);
            this.Lbl_Comuna_CNC.Name = "Lbl_Comuna_CNC";
            this.Lbl_Comuna_CNC.Size = new System.Drawing.Size(46, 13);
            this.Lbl_Comuna_CNC.TabIndex = 12;
            this.Lbl_Comuna_CNC.Text = "Comuna";
            // 
            // Cbox_Region_CNC
            // 
            this.Cbox_Region_CNC.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.regionBindingSource1, "id_region", true));
            this.Cbox_Region_CNC.DataSource = this.regionBindingSource1;
            this.Cbox_Region_CNC.DisplayMember = "Nmbre_region";
            this.Cbox_Region_CNC.FormattingEnabled = true;
            this.Cbox_Region_CNC.Location = new System.Drawing.Point(444, 49);
            this.Cbox_Region_CNC.Name = "Cbox_Region_CNC";
            this.Cbox_Region_CNC.Size = new System.Drawing.Size(175, 21);
            this.Cbox_Region_CNC.TabIndex = 11;
            this.Cbox_Region_CNC.ValueMember = "id_region";
            // 
            // Lbl_Region_CNC
            // 
            this.Lbl_Region_CNC.AutoSize = true;
            this.Lbl_Region_CNC.Location = new System.Drawing.Point(442, 29);
            this.Lbl_Region_CNC.Name = "Lbl_Region_CNC";
            this.Lbl_Region_CNC.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Region_CNC.TabIndex = 10;
            this.Lbl_Region_CNC.Text = "Región";
            // 
            // Txt_Direccion_CNC
            // 
            this.Txt_Direccion_CNC.Location = new System.Drawing.Point(221, 84);
            this.Txt_Direccion_CNC.Name = "Txt_Direccion_CNC";
            this.Txt_Direccion_CNC.Size = new System.Drawing.Size(147, 20);
            this.Txt_Direccion_CNC.TabIndex = 9;
            // 
            // Lbl_Direccion_CNC
            // 
            this.Lbl_Direccion_CNC.AutoSize = true;
            this.Lbl_Direccion_CNC.Location = new System.Drawing.Point(218, 69);
            this.Lbl_Direccion_CNC.Name = "Lbl_Direccion_CNC";
            this.Lbl_Direccion_CNC.Size = new System.Drawing.Size(52, 13);
            this.Lbl_Direccion_CNC.TabIndex = 8;
            this.Lbl_Direccion_CNC.Text = "Dirección";
            // 
            // Txt_Dig_verificador_CNC
            // 
            this.Txt_Dig_verificador_CNC.Location = new System.Drawing.Point(344, 46);
            this.Txt_Dig_verificador_CNC.MaxLength = 1;
            this.Txt_Dig_verificador_CNC.Name = "Txt_Dig_verificador_CNC";
            this.Txt_Dig_verificador_CNC.Size = new System.Drawing.Size(24, 20);
            this.Txt_Dig_verificador_CNC.TabIndex = 7;
            // 
            // Lbl_Guion_CNC
            // 
            this.Lbl_Guion_CNC.AutoSize = true;
            this.Lbl_Guion_CNC.Location = new System.Drawing.Point(327, 49);
            this.Lbl_Guion_CNC.Name = "Lbl_Guion_CNC";
            this.Lbl_Guion_CNC.Size = new System.Drawing.Size(10, 13);
            this.Lbl_Guion_CNC.TabIndex = 6;
            this.Lbl_Guion_CNC.Text = "-";
            // 
            // Txt_Ident_CNC
            // 
            this.Txt_Ident_CNC.Location = new System.Drawing.Point(221, 45);
            this.Txt_Ident_CNC.MaxLength = 12;
            this.Txt_Ident_CNC.Name = "Txt_Ident_CNC";
            this.Txt_Ident_CNC.Size = new System.Drawing.Size(100, 20);
            this.Txt_Ident_CNC.TabIndex = 5;
            this.Txt_Ident_CNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Ident_CNC_KeyPress);
            // 
            // Lbl_Ident_CNC
            // 
            this.Lbl_Ident_CNC.AutoSize = true;
            this.Lbl_Ident_CNC.Location = new System.Drawing.Point(218, 29);
            this.Lbl_Ident_CNC.Name = "Lbl_Ident_CNC";
            this.Lbl_Ident_CNC.Size = new System.Drawing.Size(70, 13);
            this.Lbl_Ident_CNC.TabIndex = 4;
            this.Lbl_Ident_CNC.Text = "Identificación";
            // 
            // Txt_Ape_CNC
            // 
            this.Txt_Ape_CNC.Location = new System.Drawing.Point(13, 85);
            this.Txt_Ape_CNC.Name = "Txt_Ape_CNC";
            this.Txt_Ape_CNC.Size = new System.Drawing.Size(161, 20);
            this.Txt_Ape_CNC.TabIndex = 3;
            this.Txt_Ape_CNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Ape_CNC_KeyPress);
            // 
            // Lbl_Ape_CNC
            // 
            this.Lbl_Ape_CNC.AutoSize = true;
            this.Lbl_Ape_CNC.Location = new System.Drawing.Point(10, 69);
            this.Lbl_Ape_CNC.Name = "Lbl_Ape_CNC";
            this.Lbl_Ape_CNC.Size = new System.Drawing.Size(52, 13);
            this.Lbl_Ape_CNC.TabIndex = 2;
            this.Lbl_Ape_CNC.Text = "Apellidos:";
            // 
            // Txt_Nombre_CNC
            // 
            this.Txt_Nombre_CNC.Location = new System.Drawing.Point(13, 46);
            this.Txt_Nombre_CNC.Name = "Txt_Nombre_CNC";
            this.Txt_Nombre_CNC.Size = new System.Drawing.Size(161, 20);
            this.Txt_Nombre_CNC.TabIndex = 1;
            this.Txt_Nombre_CNC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Nombre_CNC_KeyPress);
            // 
            // Lbl_Nombre_CNT
            // 
            this.Lbl_Nombre_CNT.AutoSize = true;
            this.Lbl_Nombre_CNT.Location = new System.Drawing.Point(10, 29);
            this.Lbl_Nombre_CNT.Name = "Lbl_Nombre_CNT";
            this.Lbl_Nombre_CNT.Size = new System.Drawing.Size(44, 13);
            this.Lbl_Nombre_CNT.TabIndex = 0;
            this.Lbl_Nombre_CNT.Text = "Nombre";
            // 
            // Gbox_Botonera
            // 
            this.Gbox_Botonera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gbox_Botonera.Controls.Add(this.button1);
            this.Gbox_Botonera.Controls.Add(this.Btn_Buscar);
            this.Gbox_Botonera.Controls.Add(this.Btn_Nuevo);
            this.Gbox_Botonera.Controls.Add(this.Btn_Guardar);
            this.Gbox_Botonera.Controls.Add(this.Btn_Limpiar);
            this.Gbox_Botonera.Controls.Add(this.Btn_Volver);
            this.Gbox_Botonera.Location = new System.Drawing.Point(13, 543);
            this.Gbox_Botonera.Name = "Gbox_Botonera";
            this.Gbox_Botonera.Size = new System.Drawing.Size(687, 36);
            this.Gbox_Botonera.TabIndex = 4;
            this.Gbox_Botonera.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir_test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(276, 5);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 4;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(357, 4);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Nuevo.TabIndex = 3;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.Location = new System.Drawing.Point(438, 5);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Guardar.TabIndex = 2;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = true;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(525, 6);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpiar.TabIndex = 1;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.Location = new System.Drawing.Point(606, 7);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.Btn_Volver.TabIndex = 0;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = true;
            // 
            // carga_Region_Marca
            // 
            this.carga_Region_Marca.DataSetName = "Carga_Region_Marca";
            this.carga_Region_Marca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regionBindingSource
            // 
            this.regionBindingSource.DataMember = "region";
            this.regionBindingSource.DataSource = this.carga_Region_Marca;
            // 
            // regionTableAdapter
            // 
            this.regionTableAdapter.ClearBeforeFill = true;
            // 
            // carga_Comunas_Marca
            // 
            this.carga_Comunas_Marca.DataSetName = "Carga_Comunas_Marca";
            this.carga_Comunas_Marca.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comunasBindingSource
            // 
            this.comunasBindingSource.DataMember = "Comunas";
            this.comunasBindingSource.DataSource = this.carga_Comunas_Marca;
            // 
            // comunasTableAdapter
            // 
            this.comunasTableAdapter.ClearBeforeFill = true;
            // 
            // carga_Region_Cnc
            // 
            this.carga_Region_Cnc.DataSetName = "Carga_Region_Cnc";
            this.carga_Region_Cnc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // regionBindingSource1
            // 
            this.regionBindingSource1.DataMember = "region";
            this.regionBindingSource1.DataSource = this.carga_Region_Cnc;
            // 
            // regionTableAdapter1
            // 
            this.regionTableAdapter1.ClearBeforeFill = true;
            // 
            // carga_Comunas_Cnc
            // 
            this.carga_Comunas_Cnc.DataSetName = "Carga_Comunas_Cnc";
            this.carga_Comunas_Cnc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comunasBindingSource1
            // 
            this.comunasBindingSource1.DataMember = "Comunas";
            this.comunasBindingSource1.DataSource = this.carga_Comunas_Cnc;
            // 
            // comunasTableAdapter1
            // 
            this.comunasTableAdapter1.ClearBeforeFill = true;
            // 
            // Adm_Marcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 579);
            this.Controls.Add(this.Gbox_Botonera);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Gbox_Inf_Vehiculos);
            this.Controls.Add(this.Gbox_Datos);
            this.Controls.Add(this.Lbl_Marcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Adm_Marcas";
            this.Text = "Adm_Marcas";
            this.Load += new System.EventHandler(this.Adm_Marcas_Load);
            this.Gbox_Datos.ResumeLayout(false);
            this.Gbox_Datos.PerformLayout();
            this.Gbox_Inf_Vehiculos.ResumeLayout(false);
            this.Gbox_Inf_Vehiculos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Gbox_Botonera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.carga_Region_Marca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carga_Comunas_Marca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carga_Region_Cnc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.regionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carga_Comunas_Cnc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comunasBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Marcas;
        private System.Windows.Forms.GroupBox Gbox_Datos;
        private System.Windows.Forms.TextBox Txt_Direccion;
        private System.Windows.Forms.Label Lbl_Direccion;
        private System.Windows.Forms.ComboBox Cbox_Comuna;
        private System.Windows.Forms.Label Lbl_Comuna;
        private System.Windows.Forms.ComboBox Cbox_Region;
        private System.Windows.Forms.Label Lbl_Region;
        private System.Windows.Forms.TextBox Txt_Dig_Veri;
        private System.Windows.Forms.Label Lbl_guion;
        private System.Windows.Forms.TextBox Txt_Ident;
        private System.Windows.Forms.Label Lbl_Ident;
        private System.Windows.Forms.TextBox Txt_Rso_social;
        private System.Windows.Forms.Label Lbl_Rso_social;
        private System.Windows.Forms.GroupBox Gbox_Inf_Vehiculos;
        private System.Windows.Forms.CheckedListBox ChkBox_Tipos_Vehiculos;
        private System.Windows.Forms.Label Tipo_Vehiculos;
        private System.Windows.Forms.CheckedListBox ChkBox_Estados_Vehi;
        private System.Windows.Forms.Label Lbl_Estados_Vehiculos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_Nombre_CNT;
        private System.Windows.Forms.ComboBox Cbox_Comuna_CNC;
        private System.Windows.Forms.Label Lbl_Comuna_CNC;
        private System.Windows.Forms.ComboBox Cbox_Region_CNC;
        private System.Windows.Forms.Label Lbl_Region_CNC;
        private System.Windows.Forms.TextBox Txt_Direccion_CNC;
        private System.Windows.Forms.Label Lbl_Direccion_CNC;
        private System.Windows.Forms.TextBox Txt_Dig_verificador_CNC;
        private System.Windows.Forms.Label Lbl_Guion_CNC;
        private System.Windows.Forms.TextBox Txt_Ident_CNC;
        private System.Windows.Forms.Label Lbl_Ident_CNC;
        private System.Windows.Forms.TextBox Txt_Ape_CNC;
        private System.Windows.Forms.Label Lbl_Ape_CNC;
        private System.Windows.Forms.TextBox Txt_Nombre_CNC;
        private System.Windows.Forms.GroupBox Gbox_Botonera;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_Tip_Comb;
        private System.Windows.Forms.CheckedListBox Chk_Tip_Comb;
        private Carga_Region_Marca carga_Region_Marca;
        private System.Windows.Forms.BindingSource regionBindingSource;
        private Carga_Region_MarcaTableAdapters.regionTableAdapter regionTableAdapter;
        private Carga_Comunas_Marca carga_Comunas_Marca;
        private System.Windows.Forms.BindingSource comunasBindingSource;
        private Carga_Comunas_MarcaTableAdapters.ComunasTableAdapter comunasTableAdapter;
        private Carga_Region_Cnc carga_Region_Cnc;
        private System.Windows.Forms.BindingSource regionBindingSource1;
        private Carga_Region_CncTableAdapters.regionTableAdapter regionTableAdapter1;
        private Carga_Comunas_Cnc carga_Comunas_Cnc;
        private System.Windows.Forms.BindingSource comunasBindingSource1;
        private Carga_Comunas_CncTableAdapters.ComunasTableAdapter comunasTableAdapter1;
    }
}