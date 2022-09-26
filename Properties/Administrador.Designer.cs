
namespace VENTAPAPAS.Properties
{
    partial class Administrador
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
            this.btn_Empleados = new System.Windows.Forms.Button();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_Ventas = new System.Windows.Forms.Button();
            this.lab_Salir = new System.Windows.Forms.Label();
            this.lab_Bienvenido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Empleados
            // 
            this.btn_Empleados.BackColor = System.Drawing.Color.Yellow;
            this.btn_Empleados.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleados.Location = new System.Drawing.Point(42, 64);
            this.btn_Empleados.Name = "btn_Empleados";
            this.btn_Empleados.Size = new System.Drawing.Size(102, 58);
            this.btn_Empleados.TabIndex = 0;
            this.btn_Empleados.Text = "Empleados";
            this.btn_Empleados.UseVisualStyleBackColor = false;
            this.btn_Empleados.Click += new System.EventHandler(this.btn_Empleados_Click);
            // 
            // btn_Productos
            // 
            this.btn_Productos.BackColor = System.Drawing.Color.Yellow;
            this.btn_Productos.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Productos.Location = new System.Drawing.Point(170, 64);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(102, 58);
            this.btn_Productos.TabIndex = 1;
            this.btn_Productos.Text = "Productos";
            this.btn_Productos.UseVisualStyleBackColor = false;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);
            // 
            // btn_Ventas
            // 
            this.btn_Ventas.BackColor = System.Drawing.Color.Yellow;
            this.btn_Ventas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ventas.Location = new System.Drawing.Point(298, 64);
            this.btn_Ventas.Name = "btn_Ventas";
            this.btn_Ventas.Size = new System.Drawing.Size(102, 58);
            this.btn_Ventas.TabIndex = 2;
            this.btn_Ventas.Text = "Ventas";
            this.btn_Ventas.UseVisualStyleBackColor = false;
            this.btn_Ventas.Click += new System.EventHandler(this.btn_Ventas_Click);
            // 
            // lab_Salir
            // 
            this.lab_Salir.AutoSize = true;
            this.lab_Salir.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Salir.Location = new System.Drawing.Point(431, 153);
            this.lab_Salir.Name = "lab_Salir";
            this.lab_Salir.Size = new System.Drawing.Size(51, 24);
            this.lab_Salir.TabIndex = 3;
            this.lab_Salir.Text = "Salir";
            this.lab_Salir.Click += new System.EventHandler(this.lab_Salir_Click);
            // 
            // lab_Bienvenido
            // 
            this.lab_Bienvenido.AutoSize = true;
            this.lab_Bienvenido.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Bienvenido.Location = new System.Drawing.Point(12, 9);
            this.lab_Bienvenido.Name = "lab_Bienvenido";
            this.lab_Bienvenido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_Bienvenido.Size = new System.Drawing.Size(147, 24);
            this.lab_Bienvenido.TabIndex = 4;
            this.lab_Bienvenido.Text = "Administrador";
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 183);
            this.Controls.Add(this.lab_Bienvenido);
            this.Controls.Add(this.lab_Salir);
            this.Controls.Add(this.btn_Ventas);
            this.Controls.Add(this.btn_Productos);
            this.Controls.Add(this.btn_Empleados);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Empleados;
        private System.Windows.Forms.Button btn_Productos;
        private System.Windows.Forms.Button btn_Ventas;
        private System.Windows.Forms.Label lab_Salir;
        private System.Windows.Forms.Label lab_Bienvenido;
    }
}