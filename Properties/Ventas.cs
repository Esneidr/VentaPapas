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
using System.Data.Common;

namespace VENTAPAPAS.Properties
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        Conectar cnt = new Conectar();
        private void cmb_Papas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Papas.Items.Add("Mexicanas");
            cmb_Papas.Items.Add("Mixtas");
            cmb_Papas.Items.Add("Full Pollo");
            cmb_Papas.Items.Add("Full Tocineta");
            cmb_Papas.Items.Add("Repapitas");
        }

        private void cmb_Bebidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Bebidas.Items.Add("Cocacola");
            cmb_Bebidas.Items.Add("Toronja");
            cmb_Bebidas.Items.Add("Premio");
            cmb_Bebidas.Items.Add("Lima Limon");
            cmb_Bebidas.Items.Add("Agua");
        }

        private void lab_Salir_Click(object sender, EventArgs e)
        {
            cnt.CerrarBDD();
            Close();
        }
    }
}
