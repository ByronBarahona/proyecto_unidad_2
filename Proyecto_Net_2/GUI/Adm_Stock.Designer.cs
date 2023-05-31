namespace Proyecto_Net_2.GUI
{
    partial class Adm_Stock
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
            this.Lbl_Stock = new System.Windows.Forms.Label();
            this.Gboc_Filtros = new System.Windows.Forms.GroupBox();
            this.Cbox_Tip_Veh = new System.Windows.Forms.ComboBox();
            this.Lbl_Clase_Veh = new System.Windows.Forms.Label();
            this.Txt_Rso_Soc = new System.Windows.Forms.TextBox();
            this.Lbl_Rso_Soc = new System.Windows.Forms.Label();
            this.Txt_Dig_Ver = new System.Windows.Forms.TextBox();
            this.Lbl_guion = new System.Windows.Forms.Label();
            this.Txt_Ident_Marca = new System.Windows.Forms.TextBox();
            this.Lbl_ident_Marca = new System.Windows.Forms.Label();
            this.Gbox_Data = new System.Windows.Forms.GroupBox();
            this.DtGridView_Stock = new System.Windows.Forms.DataGridView();
            this.Gbox_Botonera = new System.Windows.Forms.GroupBox();
            this.Btn_Buscar = new System.Windows.Forms.Button();
            this.Btn_Volver = new System.Windows.Forms.Button();
            this.Btn_Limpiar = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.cAR_MANAGERDataSet5 = new Proyecto_Net_2.CAR_MANAGERDataSet5();
            this.mARCASvhsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mARCAS_vhsTableAdapter = new Proyecto_Net_2.CAR_MANAGERDataSet5TableAdapters.MARCAS_vhsTableAdapter();
            this.idMARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreMARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rUTMARCADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvmarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gboc_Filtros.SuspendLayout();
            this.Gbox_Data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridView_Stock)).BeginInit();
            this.Gbox_Botonera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cAR_MANAGERDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCASvhsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Stock
            // 
            this.Lbl_Stock.AutoSize = true;
            this.Lbl_Stock.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Stock.Location = new System.Drawing.Point(228, 9);
            this.Lbl_Stock.Name = "Lbl_Stock";
            this.Lbl_Stock.Size = new System.Drawing.Size(267, 31);
            this.Lbl_Stock.TabIndex = 1;
            this.Lbl_Stock.Text = "Administración Stock";
            // 
            // Gboc_Filtros
            // 
            this.Gboc_Filtros.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gboc_Filtros.Controls.Add(this.Cbox_Tip_Veh);
            this.Gboc_Filtros.Controls.Add(this.Lbl_Clase_Veh);
            this.Gboc_Filtros.Controls.Add(this.Txt_Rso_Soc);
            this.Gboc_Filtros.Controls.Add(this.Lbl_Rso_Soc);
            this.Gboc_Filtros.Controls.Add(this.Txt_Dig_Ver);
            this.Gboc_Filtros.Controls.Add(this.Lbl_guion);
            this.Gboc_Filtros.Controls.Add(this.Txt_Ident_Marca);
            this.Gboc_Filtros.Controls.Add(this.Lbl_ident_Marca);
            this.Gboc_Filtros.Location = new System.Drawing.Point(12, 59);
            this.Gboc_Filtros.Name = "Gboc_Filtros";
            this.Gboc_Filtros.Size = new System.Drawing.Size(756, 107);
            this.Gboc_Filtros.TabIndex = 2;
            this.Gboc_Filtros.TabStop = false;
            // 
            // Cbox_Tip_Veh
            // 
            this.Cbox_Tip_Veh.FormattingEnabled = true;
            this.Cbox_Tip_Veh.Location = new System.Drawing.Point(352, 31);
            this.Cbox_Tip_Veh.Name = "Cbox_Tip_Veh";
            this.Cbox_Tip_Veh.Size = new System.Drawing.Size(138, 21);
            this.Cbox_Tip_Veh.TabIndex = 7;
            // 
            // Lbl_Clase_Veh
            // 
            this.Lbl_Clase_Veh.AutoSize = true;
            this.Lbl_Clase_Veh.Location = new System.Drawing.Point(269, 38);
            this.Lbl_Clase_Veh.Name = "Lbl_Clase_Veh";
            this.Lbl_Clase_Veh.Size = new System.Drawing.Size(77, 13);
            this.Lbl_Clase_Veh.TabIndex = 6;
            this.Lbl_Clase_Veh.Text = "Clase Vehiculo";
            // 
            // Txt_Rso_Soc
            // 
            this.Txt_Rso_Soc.Location = new System.Drawing.Point(10, 76);
            this.Txt_Rso_Soc.Name = "Txt_Rso_Soc";
            this.Txt_Rso_Soc.Size = new System.Drawing.Size(172, 20);
            this.Txt_Rso_Soc.TabIndex = 5;
            // 
            // Lbl_Rso_Soc
            // 
            this.Lbl_Rso_Soc.AutoSize = true;
            this.Lbl_Rso_Soc.Location = new System.Drawing.Point(7, 59);
            this.Lbl_Rso_Soc.Name = "Lbl_Rso_Soc";
            this.Lbl_Rso_Soc.Size = new System.Drawing.Size(70, 13);
            this.Lbl_Rso_Soc.TabIndex = 4;
            this.Lbl_Rso_Soc.Text = "Razón Social";
            // 
            // Txt_Dig_Ver
            // 
            this.Txt_Dig_Ver.Location = new System.Drawing.Point(131, 32);
            this.Txt_Dig_Ver.Name = "Txt_Dig_Ver";
            this.Txt_Dig_Ver.Size = new System.Drawing.Size(25, 20);
            this.Txt_Dig_Ver.TabIndex = 3;
            // 
            // Lbl_guion
            // 
            this.Lbl_guion.AutoSize = true;
            this.Lbl_guion.Location = new System.Drawing.Point(115, 35);
            this.Lbl_guion.Name = "Lbl_guion";
            this.Lbl_guion.Size = new System.Drawing.Size(10, 13);
            this.Lbl_guion.TabIndex = 2;
            this.Lbl_guion.Text = "-";
            // 
            // Txt_Ident_Marca
            // 
            this.Txt_Ident_Marca.Location = new System.Drawing.Point(9, 32);
            this.Txt_Ident_Marca.Name = "Txt_Ident_Marca";
            this.Txt_Ident_Marca.Size = new System.Drawing.Size(100, 20);
            this.Txt_Ident_Marca.TabIndex = 1;
            // 
            // Lbl_ident_Marca
            // 
            this.Lbl_ident_Marca.AutoSize = true;
            this.Lbl_ident_Marca.Location = new System.Drawing.Point(6, 16);
            this.Lbl_ident_Marca.Name = "Lbl_ident_Marca";
            this.Lbl_ident_Marca.Size = new System.Drawing.Size(103, 13);
            this.Lbl_ident_Marca.TabIndex = 0;
            this.Lbl_ident_Marca.Text = "Identificación Marca";
            // 
            // Gbox_Data
            // 
            this.Gbox_Data.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gbox_Data.Controls.Add(this.DtGridView_Stock);
            this.Gbox_Data.Location = new System.Drawing.Point(13, 173);
            this.Gbox_Data.Name = "Gbox_Data";
            this.Gbox_Data.Size = new System.Drawing.Size(755, 175);
            this.Gbox_Data.TabIndex = 3;
            this.Gbox_Data.TabStop = false;
            // 
            // DtGridView_Stock
            // 
            this.DtGridView_Stock.AutoGenerateColumns = false;
            this.DtGridView_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridView_Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMARCADataGridViewTextBoxColumn,
            this.nombreMARCADataGridViewTextBoxColumn,
            this.rUTMARCADataGridViewTextBoxColumn,
            this.dvmarcaDataGridViewTextBoxColumn,
            this.telefonoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.DtGridView_Stock.DataSource = this.mARCASvhsBindingSource;
            this.DtGridView_Stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtGridView_Stock.Location = new System.Drawing.Point(3, 16);
            this.DtGridView_Stock.Name = "DtGridView_Stock";
            this.DtGridView_Stock.Size = new System.Drawing.Size(749, 156);
            this.DtGridView_Stock.TabIndex = 0;
            // 
            // Gbox_Botonera
            // 
            this.Gbox_Botonera.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Gbox_Botonera.Controls.Add(this.Btn_Buscar);
            this.Gbox_Botonera.Controls.Add(this.Btn_Volver);
            this.Gbox_Botonera.Controls.Add(this.Btn_Limpiar);
            this.Gbox_Botonera.Controls.Add(this.Btn_Modificar);
            this.Gbox_Botonera.Controls.Add(this.Btn_Nuevo);
            this.Gbox_Botonera.Location = new System.Drawing.Point(16, 355);
            this.Gbox_Botonera.Name = "Gbox_Botonera";
            this.Gbox_Botonera.Size = new System.Drawing.Size(749, 49);
            this.Gbox_Botonera.TabIndex = 4;
            this.Gbox_Botonera.TabStop = false;
            // 
            // Btn_Buscar
            // 
            this.Btn_Buscar.Location = new System.Drawing.Point(340, 20);
            this.Btn_Buscar.Name = "Btn_Buscar";
            this.Btn_Buscar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Buscar.TabIndex = 4;
            this.Btn_Buscar.Text = "Buscar";
            this.Btn_Buscar.UseVisualStyleBackColor = true;
            // 
            // Btn_Volver
            // 
            this.Btn_Volver.Location = new System.Drawing.Point(667, 18);
            this.Btn_Volver.Name = "Btn_Volver";
            this.Btn_Volver.Size = new System.Drawing.Size(75, 23);
            this.Btn_Volver.TabIndex = 3;
            this.Btn_Volver.Text = "Volver";
            this.Btn_Volver.UseVisualStyleBackColor = true;
            // 
            // Btn_Limpiar
            // 
            this.Btn_Limpiar.Location = new System.Drawing.Point(583, 18);
            this.Btn_Limpiar.Name = "Btn_Limpiar";
            this.Btn_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Limpiar.TabIndex = 2;
            this.Btn_Limpiar.Text = "Limpiar";
            this.Btn_Limpiar.UseVisualStyleBackColor = true;
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.Location = new System.Drawing.Point(502, 18);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Modificar.TabIndex = 1;
            this.Btn_Modificar.Text = "Modificar";
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Location = new System.Drawing.Point(421, 19);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(75, 23);
            this.Btn_Nuevo.TabIndex = 0;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            // 
            // cAR_MANAGERDataSet5
            // 
            this.cAR_MANAGERDataSet5.DataSetName = "CAR_MANAGERDataSet5";
            this.cAR_MANAGERDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mARCASvhsBindingSource
            // 
            this.mARCASvhsBindingSource.DataMember = "MARCAS_vhs";
            this.mARCASvhsBindingSource.DataSource = this.cAR_MANAGERDataSet5;
            // 
            // mARCAS_vhsTableAdapter
            // 
            this.mARCAS_vhsTableAdapter.ClearBeforeFill = true;
            // 
            // idMARCADataGridViewTextBoxColumn
            // 
            this.idMARCADataGridViewTextBoxColumn.DataPropertyName = "id_MARCA";
            this.idMARCADataGridViewTextBoxColumn.HeaderText = "Codigo Marca";
            this.idMARCADataGridViewTextBoxColumn.Name = "idMARCADataGridViewTextBoxColumn";
            this.idMARCADataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreMARCADataGridViewTextBoxColumn
            // 
            this.nombreMARCADataGridViewTextBoxColumn.DataPropertyName = "Nombre_MARCA";
            this.nombreMARCADataGridViewTextBoxColumn.HeaderText = "Razón Social";
            this.nombreMARCADataGridViewTextBoxColumn.Name = "nombreMARCADataGridViewTextBoxColumn";
            // 
            // rUTMARCADataGridViewTextBoxColumn
            // 
            this.rUTMARCADataGridViewTextBoxColumn.DataPropertyName = "RUT_MARCA";
            this.rUTMARCADataGridViewTextBoxColumn.HeaderText = "Rut Marca";
            this.rUTMARCADataGridViewTextBoxColumn.Name = "rUTMARCADataGridViewTextBoxColumn";
            // 
            // dvmarcaDataGridViewTextBoxColumn
            // 
            this.dvmarcaDataGridViewTextBoxColumn.DataPropertyName = "Dv_marca";
            this.dvmarcaDataGridViewTextBoxColumn.HeaderText = "Digito Verificador";
            this.dvmarcaDataGridViewTextBoxColumn.Name = "dvmarcaDataGridViewTextBoxColumn";
            // 
            // telefonoDataGridViewTextBoxColumn
            // 
            this.telefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono";
            this.telefonoDataGridViewTextBoxColumn.HeaderText = "Telefono";
            this.telefonoDataGridViewTextBoxColumn.Name = "telefonoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // Adm_Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 424);
            this.Controls.Add(this.Gbox_Botonera);
            this.Controls.Add(this.Gbox_Data);
            this.Controls.Add(this.Gboc_Filtros);
            this.Controls.Add(this.Lbl_Stock);
            this.Name = "Adm_Stock";
            this.Text = "Adm_Stock";
            this.Load += new System.EventHandler(this.Adm_Stock_Load);
            this.Gboc_Filtros.ResumeLayout(false);
            this.Gboc_Filtros.PerformLayout();
            this.Gbox_Data.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtGridView_Stock)).EndInit();
            this.Gbox_Botonera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cAR_MANAGERDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mARCASvhsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Stock;
        private System.Windows.Forms.GroupBox Gboc_Filtros;
        private System.Windows.Forms.TextBox Txt_Dig_Ver;
        private System.Windows.Forms.Label Lbl_guion;
        private System.Windows.Forms.TextBox Txt_Ident_Marca;
        private System.Windows.Forms.Label Lbl_ident_Marca;
        private System.Windows.Forms.TextBox Txt_Rso_Soc;
        private System.Windows.Forms.Label Lbl_Rso_Soc;
        private System.Windows.Forms.GroupBox Gbox_Data;
        private System.Windows.Forms.DataGridView DtGridView_Stock;
        private System.Windows.Forms.ComboBox Cbox_Tip_Veh;
        private System.Windows.Forms.Label Lbl_Clase_Veh;
        private System.Windows.Forms.GroupBox Gbox_Botonera;
        private System.Windows.Forms.Button Btn_Buscar;
        private System.Windows.Forms.Button Btn_Volver;
        private System.Windows.Forms.Button Btn_Limpiar;
        private System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private CAR_MANAGERDataSet5 cAR_MANAGERDataSet5;
        private System.Windows.Forms.BindingSource mARCASvhsBindingSource;
        private CAR_MANAGERDataSet5TableAdapters.MARCAS_vhsTableAdapter mARCAS_vhsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreMARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rUTMARCADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dvmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}