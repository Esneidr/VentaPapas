using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using VENTAPAPAS.Properties;

namespace VENTAPAPAS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); 
        }

        public static String NombreEmpleado = "";
        string Contraseña = "";
        Conectar conectar = new Conectar();

        private void Login_Load(object sender, EventArgs e)
        {
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            

            NombreEmpleado = txt_Usuario.Text;
            Contraseña = txt_Contraseña.Text;

            if (!NombreEmpleado.Equals("") || !Contraseña.Equals(""))
            {
                conectar.AbrirBDD();
                SqlCommand datos = new SqlCommand("SELECT Cargo, Estado FROM Empleados WHERE NombreEmpleado = '" + NombreEmpleado +
                                                  "' AND Contraseña = '" + Contraseña + "'");

                SqlDataReader leer = datos.ExecuteReader();

                if (leer.Read())
                {
                    string Cargo = leer.GetString("Cargo");
                    string Estado = leer.GetString("Estado");

                    if (Cargo.Equals("Administrador") && Estado.Equals("Activo"))
                    {
                        Dispose();
                        Administrador ventAdm = new Administrador();
                        ventAdm.Show();
                    }
                    else if (Cargo.Equals("Vendedor") && Estado.Equals("Activo"))
                    {
                        Dispose();
                        Ventas ventVen = new Ventas();
                        ventVen.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Datos incorrectos, vuelve a validar");
                    txt_Usuario.Text = "";
                    txt_Contraseña.Text = "";
                }

            }

        }

        private void lab_Salir_Click(object sender, EventArgs e)
        {
            conectar.CerrarBDD();
            Close();
        }
    }
}
