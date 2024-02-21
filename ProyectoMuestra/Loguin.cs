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
using System.Net.WebSockets;
using MiLibreria;

namespace ProyectoMuestra
{
    public partial class Loguin : FormBase
    {
        public Loguin()
        {
            InitializeComponent();
        }
        public static string Codigo = "";
        private void button1_Click(object sender, EventArgs e)
        {
            // Primero agregamos como referencia la libreria y su espacio de nombre. Asi podre acceder a sus metodos.
            try
            {
                // Vamos a crear nuestra consulta para pedir el nombre de cuenta y la contraseña del usuario.
                // Creamos la instancia CMD con el Format para darle formato a la cadena, dentro dle format introducimos el parametro.
                // El parametro lo que hace es que toma lo que esta puesto en el textbox de nombre (txtNomCue) y lo va a poner en el lugar del 0.
                // De la misma manera, donde esta la contraseña introducida en el formulario (txtCon) lo pondra en el 1.
                // El Trim sirve para que, en caso de que haya un espacio, agarre toda la cadena y no solamente un pedazo.
                string CMD = string.Format("Select * FROM usuarios WHERE cuenta = '{0}' AND contraseña = '{1}'", txtNomCue.Text.Trim(), txtCon.Text.Trim());

                // Despues de agregar el System.Data, creo un dataset. Lo hago porque el ejecutar devuelve un dataser (el return que tiene)
                // al que tengo que atrapar en una variable que tambien sea un DataSet. 
                // Ejecutar me recibe un CMD, asique le pasamos el que acabamos de crear.
                // En resumen, en la linea de arriba hago la peticion que me devuelve la cuenta y la contraseña, luego en la linea de abajo
                // lo guardo en el ds.

                DataSet ds = Utiles.Ejecutar(CMD);

                // La linea de arriba ahora funciona como una matriz.
                // En las siguientes lineas: ds hace referencia a la matriz. El "Tables[0]" (primeros corchetes) es que esta seleccionando la
                // tabla 0,el "Rows[0]" (segundos corchetes) es la fila numero 0 y el ["cuenta"] y ["contraseña"] (terceros corchetes) es la columna.
                // Con ToString lo estoy convirtiendo a String yy Trim ya lo escribi arriba.
                Codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                string cuenta = ds.Tables[0].Rows[0]["cuenta"].ToString().Trim();
                string contraseña = ds.Tables[0].Rows[0]["contraseña"].ToString().Trim();

                if (cuenta == txtNomCue.Text.Trim() && contraseña == txtCon.Text.Trim())
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]) == true) 
                    {
                        VentanaAdministrador AperturaAd = new VentanaAdministrador();
                        this.Hide();
                        AperturaAd.Show();
                    }
                    else
                    {
                        VentanaUsuario AperturaUs = new VentanaUsuario();
                        this.Hide();
                        AperturaUs.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Surgio un problema en el usuario o la contraseña. Vuelva a intentarlo.");
                }

            }
            catch (Exception error )
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void Loguin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
