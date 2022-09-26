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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        int cmbCargo, cmbEstado, Edad, validacion = 0;

        private void cmb_Cargo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Cargo.Items.Add("Administrador");
            cmb_Cargo.Items.Add("Vendedor");
        }

        private void cmb_Esatdo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_Esatdo.Items.Add("Activo");
            cmb_Esatdo.Items.Add("Inactivo");
        }

        private void lab_Salir_Click(object sender, EventArgs e)
        {
            cn.CerrarBDD();
            Close();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            cn.AbrirBDD();
            string Eliminar = "DELETE FROM Empleados WHERE Cedula='"+Cedula+"'";
            SqlCommand Comand = new SqlCommand(Eliminar,cn.conect);
            Comand.ExecuteNonQuery();
            MessageBox.Show("Dato Eliminado Correctamente.");

            LLenarDataGrey();
            LimpiarCampos();
            cn.CerrarBDD();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            cn.AbrirBDD();
            string Modifiar = "UPADTE Empleados SET Cedula='"+Cedula+"',NombreEmpleado='"+Nombre+"',Edad="+Edad+",Telefono='"+Telefono+"',Contraseña='"+Contraseña+"', Cargo='"+cmbCargo+"', Estado='"+cmbEstado+
                              "' WHERE Cedula='"+Cedula+"',NombreEmpleado='"+Nombre+"',Edad="+Edad+",Telefono='"+Telefono+"',Contraseña='"+Contraseña+"',Cargo='"+cmbCargo+"',Estado='"+cmbEstado+"'";
            SqlCommand comandoM = new SqlCommand(Modifiar,cn.conect);
            int Cant;
            Cant = comandoM.ExecuteNonQuery();
   
            if(Cant > 0)
            {
                MessageBox.Show("Dato Modificado");
            }

            LLenarDataGrey();
            LimpiarCampos();
            cn.CerrarBDD();
        }

        public void LLenarDataGrey()
        {
            string Consulta = "SELECT * FROM Empleados";
            SqlDataAdapter adata = new SqlDataAdapter(Consulta, cn.conect);
            DataTable data = new DataTable();
            Consulta.Fill(data);
            dgv_Empleados.DataSource = data;
        }

        public void LimpiarCampos()
        {
            txt_Cedula.Clear();
            txt_Nombre.Clear();
            txt_Edad.Clear();
            txt_Telefono.Clear();
            txt_Contraseña.Clear();
            txt_Cedula.Focus();
        }
        private void Empleados_Load(object sender, EventArgs e)
        {
            string Consulta = "SELECT * FROM Empleados";
            SqlDataAdapter adata = new SqlDataAdapter(Consulta,cn.conect);
            DataTable data = new DataTable();
            Consulta.Fill(data);
            dgv_Empleados.DataSource = data;
        }

        private void dgv_Empleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Cedula.Text = dgv_Empleados.SelectedCells[0].Value.ToString();
            txt_Nombre.Text = dgv_Empleados.SelectedCells[1].Value.ToString();
            txt_Edad.Text = dgv_Empleados.SelectedCells[2].Value.ToString();
            txt_Telefono.Text = dgv_Empleados.SelectedCells[3].Value.ToString();
            txt_Contraseña.Text = dgv_Empleados.SelectedCells[4].Value.ToString();
            cmb_Cargo.SelectedItem = dgv_Empleados.SelectedCells[5].Value.ToString();
            cmb_Esatdo.SelectedItem = dgv_Empleados.SelectedCells[6].Value.ToString();

        }

        string Cedula, Nombre, Telefono, Contraseña;

        Conectar cn = new Conectar();

        
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            cn.AbrirBDD();
            Cedula = txt_Cedula.Text;
            Nombre = txt_Nombre.Text;
            Edad = int.Parse(txt_Edad.Text);
            Telefono = txt_Telefono.Text;
            Contraseña = txt_Contraseña.Text;
            cmbCargo = cmb_Cargo.SelectedIndex;
            cmbEstado = cmb_Esatdo.SelectedIndex;


            if (Cedula.Equals(""))
            {
                txt_Cedula.BackColor = Color.Red;
                validacion++;
            }

            if (Nombre.Equals(""))
            {
                txt_Nombre.BackColor = Color.Red;
                validacion++;
            }

            if (Edad.Equals(""))
            {
                txt_Edad.BackColor = Color.Red;
                validacion++;
            }

            if (Telefono.Equals(""))
            {
               txt_Telefono.BackColor = Color.Red;
               validacion++;
            }

            if (Contraseña.Equals(""))
            {
                txt_Contraseña.BackColor = Color.Red;
                validacion++;
            }

            SqlCommand datos = new SqlCommand("SELECT Cedula FROM Empleados WHERE Cedula = '"+ Cedula +"'");
            SqlDataReader leer = datos.ExecuteReader();

            if (leer.Read())
                {
               txt_Cedula.BackColor = Color.Red;
;              MessageBox.Show("Número de documento invalido");
            }
            else
            {
                cn.CerrarBDD();
            }

            string agregar = "INSERT INTO Empleados VALUES ('" + Cedula + "','" + Nombre + "'," + Edad + ",'" + Telefono + "','" + Contraseña + "','" + cmbCargo + "','" + cmbEstado + "') ";
            SqlCommand comando = new SqlCommand(agregar,cn.conect);

            comando.ExecuteNonQuery();
            MessageBox.Show("Elementos Agregados correctamente");
            LLenarDataGrey();
            LimpiarCampos();

            cn.CerrarBDD();
     
        }
    }
}
