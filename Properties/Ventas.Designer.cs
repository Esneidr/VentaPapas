
namespace VENTAPAPAS.Properties
{
    partial class Ventas
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
            this.lab_Ventas = new System.Windows.Forms.Label();
            this.cmb_Papas = new System.Windows.Forms.ComboBox();
            this.cmb_Bebidas = new System.Windows.Forms.ComboBox();
            this.lab_Salir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_Ventas
            // 
            this.lab_Ventas.AutoSize = true;
            this.lab_Ventas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Ventas.Location = new System.Drawing.Point(12, 9);
            this.lab_Ventas.Name = "lab_Ventas";
            this.lab_Ventas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_Ventas.Size = new System.Drawing.Size(76, 24);
            this.lab_Ventas.TabIndex = 8;
            this.lab_Ventas.Text = "Ventas";
            // 
            // cmb_Papas
            // 
            this.cmb_Papas.BackColor = System.Drawing.Color.Yellow;
            this.cmb_Papas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Papas.FormattingEnabled = true;
            this.cmb_Papas.Items.AddRange(new object[] {
            "Mexicanas",
            "Mixtas",
            "Full Pollo",
            "Full Tocineta",
            "Repapitas"});
            this.cmb_Papas.Location = new System.Drawing.Point(16, 57);
            this.cmb_Papas.Name = "cmb_Papas";
            this.cmb_Papas.Size = new System.Drawing.Size(252, 26);
            this.cmb_Papas.TabIndex = 23;
            this.cmb_Papas.Text = "Papas";
            this.cmb_Papas.SelectedIndexChanged += new System.EventHandler(this.cmb_Papas_SelectedIndexChanged);
            // 
            // cmb_Bebidas
            // 
            this.cmb_Bebidas.BackColor = System.Drawing.Color.Yellow;
            this.cmb_Bebidas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Bebidas.FormattingEnabled = true;
            this.cmb_Bebidas.Items.AddRange(new object[] {
            "Cocacola",
            "Toronja",
            "Premio",
            "Lima Limon",
            "Agua"});
            this.cmb_Bebidas.Location = new System.Drawing.Point(308, 57);
            this.cmb_Bebidas.Name = "cmb_Bebidas";
            this.cmb_Bebidas.Size = new System.Drawing.Size(252, 26);
            this.cmb_Bebidas.TabIndex = 24;
            this.cmb_Bebidas.Text = "Bebidas";
            this.cmb_Bebidas.SelectedIndexChanged += new System.EventHandler(this.cmb_Bebidas_SelectedIndexChanged);
            // 
            // lab_Salir
            // 
            this.lab_Salir.AutoSize = true;
            this.lab_Salir.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Salir.Location = new System.Drawing.Point(509, 136);
            this.lab_Salir.Name = "lab_Salir";
            this.lab_Salir.Size = new System.Drawing.Size(51, 24);
            this.lab_Salir.TabIndex = 27;
            this.lab_Salir.Text = "Salir";
            this.lab_Salir.Click += new System.EventHandler(this.lab_Salir_Click);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 165);
            this.Controls.Add(this.lab_Salir);
            this.Controls.Add(this.cmb_Bebidas);
            this.Controls.Add(this.cmb_Papas);
            this.Controls.Add(this.lab_Ventas);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Ventas;
        private System.Windows.Forms.ComboBox cmb_Papas;
        private System.Windows.Forms.ComboBox cmb_Bebidas;
        private System.Windows.Forms.Label lab_Salir;
    }
}