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
    public partial class Papas : Form
    {
        public Papas()
        {
            InitializeComponent();
        }

        Conectar cnt = new Conectar();

        public void LLenarDataGrey()
        {
            string Consulta = "SELECT * FROM Papas";
            SqlDataAdapter adata = new SqlDataAdapter(Consulta, cnt.conect);
            DataTable data = new DataTable();
            Consulta.Fill(data);
            dGV_Papas.DataSource = data;
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

            string agregar = "INSERT INTO Papas VALUES ('" +txt_Codigo.Text+ "','" + txt_Nombre.Text + "','" + txt_Precio.Text + "'," + cmb_Estado.SelectedIndex + ") ";
            SqlCommand comando = new SqlCommand(agregar, cnt.conect);

            comando.ExecuteNonQuery();
            MessageBox.Show("Elementos Agregados correctamente");
            LLenarDataGrey();
            LimpiarCampos();

            cnt.CerrarBDD();
        }

        private void cmb_Estado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Estado.Items.Add("Activo");
            cmb_Estado.Items.Add("Inactivo");
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            cnt.AbrirBDD();
            string Modifiar = "UPADTE Papas SET IdPapas='" +txt_Codigo+ "', Tipo='" +txt_Nombre+ "', Precio='" +txt_Precio+ "', Estado='" +cmb_Estado+
                              "' WHERE IdPapas='" +txt_Codigo+ "',Tipo='" +txt_Nombre+ "', Precio='" +txt_Precio+ "',Estado='" + cmb_Estado + "'";
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

        private void lab_Salir_Click(object sender, EventArgs e)
        {
            cnt.CerrarBDD();
            Close();
        }

        private void dGV_Papas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Codigo.Text = dGV_Papas.SelectedCells[0].Value.ToString();
            txt_Nombre.Text = dGV_Papas.SelectedCells[1].Value.ToString();
            txt_Precio.Text = dGV_Papas.SelectedCells[2].Value.ToString();
            cmb_Estado.SelectedItem = dGV_Papas.SelectedCells[3].Value.ToString();
        }

        private void Papas_Load(object sender, EventArgs e)
        {
            string Consulta = "SELECT * FROM Papas";
            SqlDataAdapter adata = new SqlDataAdapter(Consulta, cnt.conect);
            DataTable data = new DataTable();
            Consulta.Fill(data);
            dGV_Papas.DataSource = data;
        }
    }
}
