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
    public partial class Bebidas : Form
    {
        public Bebidas()
        {
            InitializeComponent();
        }

        Conectar cnt = new Conectar();
        private void Bebidas_Load(object sender, EventArgs e)
        {
            string Consulta = "SELECT * FROM Bebidas";
            SqlDataAdapter adata = new SqlDataAdapter(Consulta, cnt.conect);
            DataTable data = new DataTable();
            Consulta.Fill(data);
            dGV_Bebidas.DataSource = data;
        }

        public void LLenarDataGrey()
        {
            string Consulta = "SELECT * FROM Bebidas";
            SqlDataAdapter adata = new SqlDataAdapter(Consulta, cnt.conect);
            DataTable data = new DataTable();
            Consulta.Fill(data);
            dGV_Bebidas.DataSource = data;
        }

        public void LimpiarCampos()
        {
            txt_Codigo.Clear();
            txt_Nombre.Clear();
            txt_Precio.Clear();
            txt_Codigo.Focus();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            cnt.AbrirBDD();

            string agregar = "INSERT INTO Bebidas VALUES ('" + txt_Codigo.Text + "','" + txt_Nombre.Text + "','" + txt_Precio.Text + "'," + cmb_Estado.SelectedIndex + ") ";
            SqlCommand comando = new SqlCommand(agregar, cnt.conect);

            comando.ExecuteNonQuery();
            MessageBox.Show("Elementos Agregados correctamente");
            LLenarDataGrey();
            LimpiarCampos();

            cnt.CerrarBDD();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            cnt.AbrirBDD();
            string Modifiar = "UPADTE Bebidas SET IdBebidas='" + txt_Codigo + "', Tipo='" + txt_Nombre + "', Precio='" + txt_Precio + "', Estado='" + cmb_Estado +
                              "' WHERE IdBebidas='" + txt_Codigo + "',Tipo='" + txt_Nombre + "', Precio='" + txt_Precio + "',Estado='" + cmb_Estado + "'";
            SqlCommand comandoM = new SqlCommand(Modifiar, cnt.conect);
            int Cant;
            Cant = comandoM.ExecuteNonQuery();

            if (Cant > 0)
            {
                MessageBox.Show("Dato Modificado");
            }

            LLenarDataGrey();
            LimpiarCampos();
            cnt.CerrarBDD();
        }

        private void cmb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Estado.Items.Add("Activo");
            cmb_Estado.Items.Add("Inactivo");
        }

        private void lab_Salir_Click(object sender, EventArgs e)
        {
            cnt.CerrarBDD();
            Close();
        }
    }
}
