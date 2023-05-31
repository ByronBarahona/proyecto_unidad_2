namespace Proyecto_Net_2.GUI
{
    partial class Principal
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
            this.Btn_Adm_Marca = new System.Windows.Forms.Button();
            this.Adm_Stock = new System.Windows.Forms.Button();
            this.Btn_Ventas = new System.Windows.Forms.Button();
            this.Btn_Reportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Adm_Marca
            // 
            this.Btn_Adm_Marca.Location = new System.Drawing.Point(39, 55);
            this.Btn_Adm_Marca.Name = "Btn_Adm_Marca";
            this.Btn_Adm_Marca.Size = new System.Drawing.Size(125, 23);
            this.Btn_Adm_Marca.TabIndex = 0;
            this.Btn_Adm_Marca.Text = "Administración Marcas";
            this.Btn_Adm_Marca.UseVisualStyleBackColor = true;
            this.Btn_Adm_Marca.Click += new System.EventHandler(this.Btn_Adm_Marca_Click);
            // 
            // Adm_Stock
            // 
            this.Adm_Stock.Location = new System.Drawing.Point(238, 55);
            this.Adm_Stock.Name = "Adm_Stock";
            this.Adm_Stock.Size = new System.Drawing.Size(121, 23);
            this.Adm_Stock.TabIndex = 1;
            this.Adm_Stock.Text = "Mantenimiento Stock";
            this.Adm_Stock.UseVisualStyleBackColor = true;
            this.Adm_Stock.Click += new System.EventHandler(this.Adm_Stock_Click);
            // 
            // Btn_Ventas
            // 
            this.Btn_Ventas.Location = new System.Drawing.Point(39, 176);
            this.Btn_Ventas.Name = "Btn_Ventas";
            this.Btn_Ventas.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ventas.TabIndex = 2;
            this.Btn_Ventas.Text = "Ventas";
            this.Btn_Ventas.UseVisualStyleBackColor = true;
            this.Btn_Ventas.Click += new System.EventHandler(this.Btn_Ventas_Click);
            // 
            // Btn_Reportes
            // 
            this.Btn_Reportes.Location = new System.Drawing.Point(238, 176);
            this.Btn_Reportes.Name = "Btn_Reportes";
            this.Btn_Reportes.Size = new System.Drawing.Size(75, 23);
            this.Btn_Reportes.TabIndex = 3;
            this.Btn_Reportes.Text = "Reporteria";
            this.Btn_Reportes.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(411, 276);
            this.Controls.Add(this.Btn_Reportes);
            this.Controls.Add(this.Btn_Ventas);
            this.Controls.Add(this.Adm_Stock);
            this.Controls.Add(this.Btn_Adm_Marca);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Adm_Marca;
        private System.Windows.Forms.Button Adm_Stock;
        private System.Windows.Forms.Button Btn_Ventas;
        private System.Windows.Forms.Button Btn_Reportes;
    }
}