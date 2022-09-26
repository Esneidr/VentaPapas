
namespace VENTAPAPAS
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lab_Usuario = new System.Windows.Forms.Label();
            this.lab_Contraseña = new System.Windows.Forms.Label();
            this.lab_Salir = new System.Windows.Forms.Label();
            this.txt_Usuario = new System.Windows.Forms.TextBox();
            this.txt_Contraseña = new System.Windows.Forms.TextBox();
            this.btn_Acceder = new System.Windows.Forms.Button();
            this.lab_Bienvenidos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lab_Usuario
            // 
            this.lab_Usuario.AutoSize = true;
            this.lab_Usuario.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Usuario.Location = new System.Drawing.Point(169, 108);
            this.lab_Usuario.Name = "lab_Usuario";
            this.lab_Usuario.Size = new System.Drawing.Size(82, 24);
            this.lab_Usuario.TabIndex = 0;
            this.lab_Usuario.Text = "Usuario";
            // 
            // lab_Contraseña
            // 
            this.lab_Contraseña.AutoSize = true;
            this.lab_Contraseña.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Contraseña.Location = new System.Drawing.Point(160, 207);
            this.lab_Contraseña.Name = "lab_Contraseña";
            this.lab_Contraseña.Size = new System.Drawing.Size(119, 24);
            this.lab_Contraseña.TabIndex = 1;
            this.lab_Contraseña.Text = "Contraseña";
            // 
            // lab_Salir
            // 
            this.lab_Salir.AutoSize = true;
            this.lab_Salir.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Salir.Location = new System.Drawing.Point(379, 349);
            this.lab_Salir.Name = "lab_Salir";
            this.lab_Salir.Size = new System.Drawing.Size(51, 24);
            this.lab_Salir.TabIndex = 2;
            this.lab_Salir.Text = "Salir";
            this.lab_Salir.Click += new System.EventHandler(this.lab_Salir_Click);
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.BackColor = System.Drawing.Color.Yellow;
            this.txt_Usuario.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.Location = new System.Drawing.Point(34, 79);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(360, 26);
            this.txt_Usuario.TabIndex = 3;
            // 
            // txt_Contraseña
            // 
            this.txt_Contraseña.BackColor = System.Drawing.Color.Yellow;
            this.txt_Contraseña.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contraseña.Location = new System.Drawing.Point(34, 178);
            this.txt_Contraseña.Name = "txt_Contraseña";
            this.txt_Contraseña.PasswordChar = '*';
            this.txt_Contraseña.Size = new System.Drawing.Size(360, 26);
            this.txt_Contraseña.TabIndex = 4;
            // 
            // btn_Acceder
            // 
            this.btn_Acceder.BackColor = System.Drawing.Color.Gold;
            this.btn_Acceder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Acceder.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acceder.Location = new System.Drawing.Point(173, 299);
            this.btn_Acceder.Name = "btn_Acceder";
            this.btn_Acceder.Size = new System.Drawing.Size(78, 37);
            this.btn_Acceder.TabIndex = 5;
            this.btn_Acceder.Text = "Acceder";
            this.btn_Acceder.UseVisualStyleBackColor = false;
            this.btn_Acceder.Click += new System.EventHandler(this.button1_Click);
            // 
            // lab_Bienvenidos
            // 
            this.lab_Bienvenidos.AutoSize = true;
            this.lab_Bienvenidos.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Bienvenidos.Location = new System.Drawing.Point(12, 9);
            this.lab_Bienvenidos.Name = "lab_Bienvenidos";
            this.lab_Bienvenidos.Size = new System.Drawing.Size(126, 24);
            this.lab_Bienvenidos.TabIndex = 6;
            this.lab_Bienvenidos.Text = "Bienvenidos";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 382);
            this.Controls.Add(this.lab_Bienvenidos);
            this.Controls.Add(this.btn_Acceder);
            this.Controls.Add(this.txt_Contraseña);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.lab_Salir);
            this.Controls.Add(this.lab_Contraseña);
            this.Controls.Add(this.lab_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Login";
            this.Text = "Acceder";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Usuario;
        private System.Windows.Forms.Label lab_Contraseña;
        private System.Windows.Forms.Label lab_Salir;
        private System.Windows.Forms.TextBox txt_Usuario;
        private System.Windows.Forms.TextBox txt_Contraseña;
        private System.Windows.Forms.Button btn_Acceder;
        private System.Windows.Forms.Label lab_Bienvenidos;
    }
}

