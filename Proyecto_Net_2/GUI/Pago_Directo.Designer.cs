namespace Proyecto_Net_2.GUI
{
    partial class Pago_Directo
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
            this.Gbox_Pago_Directo = new System.Windows.Forms.GroupBox();
            this.Lbl_Valor_VHS = new System.Windows.Forms.Label();
            this.Txt_Valor_VHS = new System.Windows.Forms.MaskedTextBox();
            this.Lbl_Valor_Pago = new System.Windows.Forms.Label();
            this.Txt_Valor_Pago = new System.Windows.Forms.MaskedTextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Aceptar = new System.Windows.Forms.Button();
            this.Gbox_Pago_Directo.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbox_Pago_Directo
            // 
            this.Gbox_Pago_Directo.Controls.Add(this.Txt_Valor_Pago);
            this.Gbox_Pago_Directo.Controls.Add(this.Lbl_Valor_Pago);
            this.Gbox_Pago_Directo.Controls.Add(this.Txt_Valor_VHS);
            this.Gbox_Pago_Directo.Controls.Add(this.Lbl_Valor_VHS);
            this.Gbox_Pago_Directo.Location = new System.Drawing.Point(12, 12);
            this.Gbox_Pago_Directo.Name = "Gbox_Pago_Directo";
            this.Gbox_Pago_Directo.Size = new System.Drawing.Size(247, 100);
            this.Gbox_Pago_Directo.TabIndex = 0;
            this.Gbox_Pago_Directo.TabStop = false;
            // 
            // Lbl_Valor_VHS
            // 
            this.Lbl_Valor_VHS.AutoSize = true;
            this.Lbl_Valor_VHS.Location = new System.Drawing.Point(7, 20);
            this.Lbl_Valor_VHS.Name = "Lbl_Valor_VHS";
            this.Lbl_Valor_VHS.Size = new System.Drawing.Size(78, 13);
            this.Lbl_Valor_VHS.TabIndex = 0;
            this.Lbl_Valor_VHS.Text = "Valor Vehiculo:";
            // 
            // Txt_Valor_VHS
            // 
            this.Txt_Valor_VHS.Location = new System.Drawing.Point(91, 13);
            this.Txt_Valor_VHS.Mask = "000.000.000";
            this.Txt_Valor_VHS.Name = "Txt_Valor_VHS";
            this.Txt_Valor_VHS.Size = new System.Drawing.Size(74, 20);
            this.Txt_Valor_VHS.TabIndex = 1;
            // 
            // Lbl_Valor_Pago
            // 
            this.Lbl_Valor_Pago.AutoSize = true;
            this.Lbl_Valor_Pago.Location = new System.Drawing.Point(10, 49);
            this.Lbl_Valor_Pago.Name = "Lbl_Valor_Pago";
            this.Lbl_Valor_Pago.Size = new System.Drawing.Size(74, 13);
            this.Lbl_Valor_Pago.TabIndex = 2;
            this.Lbl_Valor_Pago.Text = "Valor a Pagar:";
            // 
            // Txt_Valor_Pago
            // 
            this.Txt_Valor_Pago.Location = new System.Drawing.Point(91, 46);
            this.Txt_Valor_Pago.Mask = "000.000.000";
            this.Txt_Valor_Pago.Name = "Txt_Valor_Pago";
            this.Txt_Valor_Pago.Size = new System.Drawing.Size(74, 20);
            this.Txt_Valor_Pago.TabIndex = 3;
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Location = new System.Drawing.Point(184, 135);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancelar.TabIndex = 1;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Btn_Aceptar
            // 
            this.Btn_Aceptar.Location = new System.Drawing.Point(103, 135);
            this.Btn_Aceptar.Name = "Btn_Aceptar";
            this.Btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.Btn_Aceptar.TabIndex = 2;
            this.Btn_Aceptar.Text = "Aceptar";
            this.Btn_Aceptar.UseVisualStyleBackColor = true;
            // 
            // Pago_Directo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(271, 161);
            this.Controls.Add(this.Btn_Aceptar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.Gbox_Pago_Directo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pago_Directo";
            this.Text = "Pago_Directo";
            this.Gbox_Pago_Directo.ResumeLayout(false);
            this.Gbox_Pago_Directo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox_Pago_Directo;
        private System.Windows.Forms.MaskedTextBox Txt_Valor_Pago;
        private System.Windows.Forms.Label Lbl_Valor_Pago;
        private System.Windows.Forms.MaskedTextBox Txt_Valor_VHS;
        private System.Windows.Forms.Label Lbl_Valor_VHS;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Aceptar;
    }
}