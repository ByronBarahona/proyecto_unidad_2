namespace Proyecto_Net_2.GUI
{
    partial class Pago_Credito
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
            this.Gbox_Credito = new System.Windows.Forms.GroupBox();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Lbl_Val_Vhs = new System.Windows.Forms.Label();
            this.Txt_Valor_Vhs = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Pocert_Pie = new System.Windows.Forms.Label();
            this.Txt_Porc_Pie = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Valor_Pie = new System.Windows.Forms.Label();
            this.Txt_Val_Pie = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Cant_Cuotas = new System.Windows.Forms.Label();
            this.Cbox_Cuotas = new System.Windows.Forms.ComboBox();
            this.Gbox_Credito.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbox_Credito
            // 
            this.Gbox_Credito.Controls.Add(this.Cbox_Cuotas);
            this.Gbox_Credito.Controls.Add(this.Lbl_Cant_Cuotas);
            this.Gbox_Credito.Controls.Add(this.Txt_Val_Pie);
            this.Gbox_Credito.Controls.Add(this.Lbl_Valor_Pie);
            this.Gbox_Credito.Controls.Add(this.Txt_Porc_Pie);
            this.Gbox_Credito.Controls.Add(this.Lbl_Pocert_Pie);
            this.Gbox_Credito.Controls.Add(this.Txt_Valor_Vhs);
            this.Gbox_Credito.Controls.Add(this.Lbl_Val_Vhs);
            this.Gbox_Credito.Location = new System.Drawing.Point(12, 12);
            this.Gbox_Credito.Name = "Gbox_Credito";
            this.Gbox_Credito.Size = new System.Drawing.Size(330, 147);
            this.Gbox_Credito.TabIndex = 0;
            this.Gbox_Credito.TabStop = false;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Location = new System.Drawing.Point(71, 165);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Aceptar.TabIndex = 1;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(185, 165);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 2;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Lbl_Val_Vhs
            // 
            this.Lbl_Val_Vhs.AutoSize = true;
            this.Lbl_Val_Vhs.Location = new System.Drawing.Point(7, 20);
            this.Lbl_Val_Vhs.Name = "Lbl_Val_Vhs";
            this.Lbl_Val_Vhs.Size = new System.Drawing.Size(78, 13);
            this.Lbl_Val_Vhs.TabIndex = 0;
            this.Lbl_Val_Vhs.Text = "Valor Vehiculo:";
            // 
            // Txt_Valor_Vhs
            // 
            this.Txt_Valor_Vhs.Location = new System.Drawing.Point(112, 17);
            this.Txt_Valor_Vhs.Mask = "000.000.000";
            this.Txt_Valor_Vhs.Name = "Txt_Valor_Vhs";
            this.Txt_Valor_Vhs.Size = new System.Drawing.Size(69, 20);
            this.Txt_Valor_Vhs.TabIndex = 1;
            // 
            // Lbl_Pocert_Pie
            // 
            this.Lbl_Pocert_Pie.AutoSize = true;
            this.Lbl_Pocert_Pie.Location = new System.Drawing.Point(7, 58);
            this.Lbl_Pocert_Pie.Name = "Lbl_Pocert_Pie";
            this.Lbl_Pocert_Pie.Size = new System.Drawing.Size(79, 13);
            this.Lbl_Pocert_Pie.TabIndex = 2;
            this.Lbl_Pocert_Pie.Text = "Porcentaje Pie:";
            // 
            // Txt_Porc_Pie
            // 
            this.Txt_Porc_Pie.Location = new System.Drawing.Point(112, 51);
            this.Txt_Porc_Pie.Mask = "999";
            this.Txt_Porc_Pie.Name = "Txt_Porc_Pie";
            this.Txt_Porc_Pie.Size = new System.Drawing.Size(69, 20);
            this.Txt_Porc_Pie.TabIndex = 3;
            this.Txt_Porc_Pie.ValidatingType = typeof(int);
            // 
            // Lbl_Valor_Pie
            // 
            this.Lbl_Valor_Pie.AutoSize = true;
            this.Lbl_Valor_Pie.Location = new System.Drawing.Point(10, 90);
            this.Lbl_Valor_Pie.Name = "Lbl_Valor_Pie";
            this.Lbl_Valor_Pie.Size = new System.Drawing.Size(52, 13);
            this.Lbl_Valor_Pie.TabIndex = 4;
            this.Lbl_Valor_Pie.Text = "Valor Pie:";
            // 
            // Txt_Val_Pie
            // 
            this.Txt_Val_Pie.Location = new System.Drawing.Point(112, 83);
            this.Txt_Val_Pie.Mask = "000.000.000";
            this.Txt_Val_Pie.Name = "Txt_Val_Pie";
            this.Txt_Val_Pie.Size = new System.Drawing.Size(69, 20);
            this.Txt_Val_Pie.TabIndex = 5;
            // 
            // Lbl_Cant_Cuotas
            // 
            this.Lbl_Cant_Cuotas.AutoSize = true;
            this.Lbl_Cant_Cuotas.Location = new System.Drawing.Point(10, 121);
            this.Lbl_Cant_Cuotas.Name = "Lbl_Cant_Cuotas";
            this.Lbl_Cant_Cuotas.Size = new System.Drawing.Size(85, 13);
            this.Lbl_Cant_Cuotas.TabIndex = 6;
            this.Lbl_Cant_Cuotas.Text = "Cantidad Cuotas";
            // 
            // Cbox_Cuotas
            // 
            this.Cbox_Cuotas.FormattingEnabled = true;
            this.Cbox_Cuotas.Location = new System.Drawing.Point(112, 112);
            this.Cbox_Cuotas.Name = "Cbox_Cuotas";
            this.Cbox_Cuotas.Size = new System.Drawing.Size(69, 21);
            this.Cbox_Cuotas.TabIndex = 7;
            // 
            // Pago_Credito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(354, 205);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Gbox_Credito);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pago_Credito";
            this.Text = "Pago_Credito";
            this.Gbox_Credito.ResumeLayout(false);
            this.Gbox_Credito.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox_Credito;
        private System.Windows.Forms.ComboBox Cbox_Cuotas;
        private System.Windows.Forms.Label Lbl_Cant_Cuotas;
        private System.Windows.Forms.MaskedTextBox Txt_Val_Pie;
        private System.Windows.Forms.Label Lbl_Valor_Pie;
        private System.Windows.Forms.MaskedTextBox Txt_Porc_Pie;
        private System.Windows.Forms.Label Lbl_Pocert_Pie;
        private System.Windows.Forms.MaskedTextBox Txt_Valor_Vhs;
        private System.Windows.Forms.Label Lbl_Val_Vhs;
        private System.Windows.Forms.Button Btn_Aceptar;
        private System.Windows.Forms.Button Btn_Cancelar;
    }
}