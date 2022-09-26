
namespace VENTAPAPAS.Properties
{
    partial class Papas
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
            this.lab_Bienvenido = new System.Windows.Forms.Label();
            this.lab_Papas = new System.Windows.Forms.Label();
            this.lab_Precio = new System.Windows.Forms.Label();
            this.lab_Tipo = new System.Windows.Forms.Label();
            this.lab_Codigo = new System.Windows.Forms.Label();
            this.txt_Codigo = new System.Windows.Forms.TextBox();
            this.txt_Precio = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.cmb_Estado = new System.Windows.Forms.ComboBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.dGV_Papas = new System.Windows.Forms.DataGridView();
            this.lab_Salir = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Papas)).BeginInit();
            this.SuspendLayout();
            // 
            // lab_Bienvenido
            // 
            this.lab_Bienvenido.AutoSize = true;
            this.lab_Bienvenido.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Bienvenido.Location = new System.Drawing.Point(12, 9);
            this.lab_Bienvenido.Name = "lab_Bienvenido";
            this.lab_Bienvenido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_Bienvenido.Size = new System.Drawing.Size(0, 24);
            this.lab_Bienvenido.TabIndex = 5;
            // 
            // lab_Papas
            // 
            this.lab_Papas.AutoSize = true;
            this.lab_Papas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Papas.Location = new System.Drawing.Point(12, 9);
            this.lab_Papas.Name = "lab_Papas";
            this.lab_Papas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lab_Papas.Size = new System.Drawing.Size(69, 24);
            this.lab_Papas.TabIndex = 6;
            this.lab_Papas.Text = "Papas";
            // 
            // lab_Precio
            // 
            this.lab_Precio.AutoSize = true;
            this.lab_Precio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Precio.Location = new System.Drawing.Point(12, 86);
            this.lab_Precio.Name = "lab_Precio";
            this.lab_Precio.Size = new System.Drawing.Size(76, 24);
            this.lab_Precio.TabIndex = 10;
            this.lab_Precio.Text = "Precio:";
            // 
            // lab_Tipo
            // 
            this.lab_Tipo.AutoSize = true;
            this.lab_Tipo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Tipo.Location = new System.Drawing.Point(290, 52);
            this.lab_Tipo.Name = "lab_Tipo";
            this.lab_Tipo.Size = new System.Drawing.Size(98, 24);
            this.lab_Tipo.TabIndex = 11;
            this.lab_Tipo.Text = "Nombre: ";
            // 
            // lab_Codigo
            // 
            this.lab_Codigo.AutoSize = true;
            this.lab_Codigo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Codigo.Location = new System.Drawing.Point(12, 52);
            this.lab_Codigo.Name = "lab_Codigo";
            this.lab_Codigo.Size = new System.Drawing.Size(87, 24);
            this.lab_Codigo.TabIndex = 12;
            this.lab_Codigo.Text = "Codigo: ";
            // 
            // txt_Codigo
            // 
            this.txt_Codigo.BackColor = System.Drawing.Color.Yellow;
            this.txt_Codigo.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Codigo.Location = new System.Drawing.Point(105, 50);
            this.txt_Codigo.Name = "txt_Codigo";
            this.txt_Codigo.Size = new System.Drawing.Size(179, 26);
            this.txt_Codigo.TabIndex = 15;
            // 
            // txt_Precio
            // 
            this.txt_Precio.BackColor = System.Drawing.Color.Yellow;
            this.txt_Precio.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Precio.Location = new System.Drawing.Point(105, 86);
            this.txt_Precio.Name = "txt_Precio";
            this.txt_Precio.Size = new System.Drawing.Size(171, 26);
            this.txt_Precio.TabIndex = 16;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.BackColor = System.Drawing.Color.Yellow;
            this.txt_Nombre.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(394, 52);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(200, 26);
            this.txt_Nombre.TabIndex = 17;
            // 
            // cmb_Estado
            // 
            this.cmb_Estado.BackColor = System.Drawing.Color.Yellow;
            this.cmb_Estado.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Estado.FormattingEnabled = true;
            this.cmb_Estado.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmb_Estado.Location = new System.Drawing.Point(341, 84);
            this.cmb_Estado.Name = "cmb_Estado";
            this.cmb_Estado.Size = new System.Drawing.Size(253, 26);
            this.cmb_Estado.TabIndex = 20;
            this.cmb_Estado.Text = "Estado";
            this.cmb_Estado.SelectedIndexChanged += new System.EventHandler(this.cmb_Estado_SelectedIndexChanged);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.BackColor = System.Drawing.Color.Gold;
            this.btn_Agregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Agregar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(16, 146);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(99, 50);
            this.btn_Agregar.TabIndex = 21;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = false;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.Gold;
            this.btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Modificar.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(16, 212);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(99, 50);
            this.btn_Modificar.TabIndex = 22;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // dGV_Papas
            // 
            this.dGV_Papas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV_Papas.Location = new System.Drawing.Point(137, 135);
            this.dGV_Papas.Name = "dGV_Papas";
            this.dGV_Papas.ReadOnly = true;
            this.dGV_Papas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGV_Papas.Size = new System.Drawing.Size(457, 143);
            this.dGV_Papas.TabIndex = 23;
            this.dGV_Papas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV_Papas_CellClick);
            // 
            // lab_Salir
            // 
            this.lab_Salir.AutoSize = true;
            this.lab_Salir.Font = new System.Drawing.Font("Berlin Sans FB Demi", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Salir.Location = new System.Drawing.Point(562, 287);
            this.lab_Salir.Name = "lab_Salir";
            this.lab_Salir.Size = new System.Drawing.Size(51, 24);
            this.lab_Salir.TabIndex = 24;
            this.lab_Salir.Text = "Salir";
            this.lab_Salir.Click += new System.EventHandler(this.lab_Salir_Click);
            // 
            // Papas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 320);
            this.Controls.Add(this.lab_Salir);
            this.Controls.Add(this.dGV_Papas);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.cmb_Estado);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.txt_Precio);
            this.Controls.Add(this.txt_Codigo);
            this.Controls.Add(this.lab_Codigo);
            this.Controls.Add(this.lab_Tipo);
            this.Controls.Add(this.lab_Precio);
            this.Controls.Add(this.lab_Papas);
            this.Controls.Add(this.lab_Bienvenido);
            this.Name = "Papas";
            this.Text = "Papas";
            this.Load += new System.EventHandler(this.Papas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV_Papas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Bienvenido;
        private System.Windows.Forms.Label lab_Papas;
        private System.Windows.Forms.Label lab_Precio;
        private System.Windows.Forms.Label lab_Tipo;
        private System.Windows.Forms.Label lab_Codigo;
        private System.Windows.Forms.TextBox txt_Codigo;
        private System.Windows.Forms.TextBox txt_Precio;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.ComboBox cmb_Estado;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.DataGridView dGV_Papas;
        private System.Windows.Forms.Label lab_Salir;
    }
}