using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace VENTAPAPAS.Properties
{
    class Conectar
    {
        string Conexion = "Data source =XXXXXXXXXXXXX; initial BDD_PAPAS; integrated security=true";

        public SqlConnection conect = new SqlConnection();

        public Conectar() 
        {
            conect.ConnectionString = Conexion; 
        }

        public void AbrirBDD()
        {
            try 
            {
                conect.Open();
                MessageBox.Show("Conexion Exitosa");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Fallo la Conexion" + ex.Message);
            }
        }

        public void CerrarBDD()
        {
            conect.Close();
        }
    }
}
