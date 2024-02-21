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
    public partial class VentanaAdministrador : FormBase
    {
        public VentanaAdministrador()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }


        private void Loguin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void VentanaAdministrador_Load(object sender, EventArgs e)
        {
            string cmd = "SELECT * FROM usuarios WHERE id_usuario=" + Loguin.Codigo;

            DataSet DS = Utiles.Ejecutar(cmd);

            lblUsuAd.Text = DS.Tables[0].Rows[0]["cuenta"].ToString();
            lblAlAd.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblCodAd.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

            //El siguiente codigo agrega una imagen. Desde la base de datos se debe agregar la direccion correcta de la imagen antes de eliminar las barras que comentan el codigo.

            //string url = DS.Tables[0].Rows[0]["Foto"].ToString();

            //pictureAd.Image = Image.FromFile(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContenedorPri contenedor = new ContenedorPri();
            this.Show();
            contenedor.Show();
        }
    }
}
