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


namespace VENTAPAPAS.Properties
{
    public partial class Administrador : Form
    {

        Conectar conectar = new Conectar();
        public Administrador()
        {
            InitializeComponent();
        }

        private void btn_Empleados_Click(object sender, EventArgs e)
        {
            Empleados ventEmp = new Empleados();
            ventEmp.Show();
        }

        private void btn_Productos_Click(object sender, EventArgs e)
        {
            Productos ventPro = new Productos();
            ventPro.Show();
        }

        private void btn_Ventas_Click(object sender, EventArgs e)
        {
            Ventas ventVent = new Ventas();
            ventVent.Show();
        }

        private void lab_Salir_Click(object sender, EventArgs e)
        {
            conectar.CerrarBDD();
            Close();
        }
    }
}
