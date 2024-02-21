using MiLibreria;
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
    public partial class VentanaUsuario : FormBase
    {
        public VentanaUsuario()
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

        private void VentanaUsuario_Load(object sender, EventArgs e)
        {

            string cmd = "SELECT * FROM usuarios WHERE id_usuario=" + Loguin.Codigo;

            DataSet DS = Utiles.Ejecutar(cmd);

            lblUsuUs.Text = DS.Tables[0].Rows[0]["cuenta"].ToString();
            lblAlUsu.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblCodUs.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

            string url = DS.Tables[0].Rows[0]["Foto"].ToString();

            pictureUsu.Image = Image.FromFile(url);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ContenedorPri contenedor = new ContenedorPri();
            this.Show();
            contenedor.Show();
        }
    }
}
