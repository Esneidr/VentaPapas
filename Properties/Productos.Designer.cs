
namespace VENTAPAPAS.Properties
{
    partial class Productos
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
            this.lab_Productos = new System.Windows.Forms.Label();
            this.lab_Salir = new System.Windows.Forms.Label();
            this.btn_Papas = new System.Windows.Forms.Button();
            this.btn_Bebidas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab_Productos
            // 
            this.lab_Productos.AutoSize = true;
            this.lab_Productos.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Productos.Location = new System.Drawing.Point(12, 9);
            this.lab_Productos.Name = "lab_Productos";
            this.lab_Productos.Size = new System.Drawing.Size(105, 24);
            this.lab_Productos.TabIndex = 5;
            this.lab_Productos.Text = "Productos";
            // 
            // lab_Salir
            // 
            this.lab_Salir.AutoSize = true;
            this.lab_Salir.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Salir.Location = new System.Drawing.Point(181, 169);
            this.lab_Salir.Name = "lab_Salir";
            this.lab_Salir.Size = new System.Drawing.Size(51, 24);
            this.lab_Salir.TabIndex = 6;
            this.lab_Salir.Text = "Salir";
            this.lab_Salir.Click += new System.EventHandler(this.lab_Salir_Click);
            // 
            // btn_Papas
            // 
            this.btn_Papas.BackColor = System.Drawing.Color.Yellow;
            this.btn_Papas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Papas.Location = new System.Drawing.Point(12, 72);
            this.btn_Papas.Name = "btn_Papas";
            this.btn_Papas.Size = new System.Drawing.Size(102, 58);
            this.btn_Papas.TabIndex = 7;
            this.btn_Papas.Text = "Papas";
            this.btn_Papas.UseVisualStyleBackColor = false;
            this.btn_Papas.Click += new System.EventHandler(this.btn_Papas_Click);
            // 
            // btn_Bebidas
            // 
            this.btn_Bebidas.BackColor = System.Drawing.Color.Yellow;
            this.btn_Bebidas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bebidas.Location = new System.Drawing.Point(130, 72);
            this.btn_Bebidas.Name = "btn_Bebidas";
            this.btn_Bebidas.Size = new System.Drawing.Size(102, 58);
            this.btn_Bebidas.TabIndex = 8;
            this.btn_Bebidas.Text = "Bebidas";
            this.btn_Bebidas.UseVisualStyleBackColor = false;
            this.btn_Bebidas.Click += new System.EventHandler(this.btn_Bebidas_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 207);
            this.Controls.Add(this.btn_Bebidas);
            this.Controls.Add(this.btn_Papas);
            this.Controls.Add(this.lab_Salir);
            this.Controls.Add(this.lab_Productos);
            this.Name = "Productos";
            this.Text = "Productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Productos;
        private System.Windows.Forms.Label lab_Salir;
        private System.Windows.Forms.Button btn_Papas;
        private System.Windows.Forms.Button btn_Bebidas;
    }
}