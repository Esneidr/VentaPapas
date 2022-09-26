using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VENTAPAPAS.Properties
{
    public partial class Productos : Form
    {
        Conectar conectar = new Conectar();
        public Productos()
        {
            InitializeComponent();
        }

        private void lab_Salir_Click(object sender, EventArgs e)
        {
            conectar.CerrarBDD();
            Close();
        }

        private void btn_Papas_Click(object sender, EventArgs e)
        {
            Papas ventPap = new Papas();
            ventPap.Show();
        }

        private void btn_Bebidas_Click(object sender, EventArgs e)
        {
            Bebidas ventBeb = new Bebidas();
            ventBeb.Show();
        }
    }
}
