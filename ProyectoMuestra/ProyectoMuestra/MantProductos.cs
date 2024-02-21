using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace ProyectoMuestra
{
    public partial class MantProductos : Mantenimiento
    {
        public MantProductos()
        {
            InitializeComponent();
        }

        public override Boolean Guardar()
        {
            if (Utiles.ValidacionFormulario(this,errorProvider1)== false)
            {

                try
                {
                    string cmd = string.Format("EXEC ActualizacionArticulos '{0}','{1}','{2}'", txtIdPro.Text.Trim(), txtNomPro.Text.Trim(), txtPrePro.Text.Trim());
                    Utiles.Ejecutar(cmd);

                    MessageBox.Show("Guardado Exitoso");

                    return true;
                }
                catch (Exception error)
                {
                    MessageBox.Show("Error: " + error.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }


        }

        public override void Eliminar()
        {
            try
            {
                string cmd = string.Format("EXEC EliminarArticulos '{0}'", a.Text.Trim());
                Utiles.Ejecutar(cmd);

                MessageBox.Show("Eliminacion exitosa");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void txtIdPro_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
