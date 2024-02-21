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
    public partial class Facturación : Procesos
    {
        public Facturación()
        {
            InitializeComponent();
        }
        public static int Contador = 0;
        public static double total;
        private void Facturación_Load(object sender, EventArgs e)
        {
            string cmd = "Select * from Usuarios Where id_usuario= " + Loguin.Codigo;

            DataSet ds;

            ds = Utiles.Ejecutar(cmd);

            lblAtiende.Text = ds.Tables[0].Rows[0]["Nom_usu"].ToString().Trim();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodbus.Text.Trim()) == false)
            {
                try
                {

                    string cmd = string.Format("Select Nom_cli FROM cliente WHERE id_clientes= '{0}'", txtCodbus.Text.Trim());

                    DataSet ds = Utiles.Ejecutar(cmd);

                    txtCli.Text = ds.Tables[0].Rows[0]["Nom_cli"].ToString().Trim();

                    txtCod.Focus();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocurrio un error: " + ex.Message);
                }
            }
        }

        private void btnCol_Click(object sender, EventArgs e)
        {
            if (Utiles.ValidacionFormulario(this, errorProvider1) == false)
            {
                bool existencia = false;

                int numerofila = 0;

                if (Contador == 0)
                {
                    dataGridView1.Rows.Add(txtCod.Text, txtDes.Text, txtPre.Text, txtCan.Text);
                    double Importe = Convert.ToDouble(dataGridView1.Rows[Contador].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[Contador].Cells[3].Value);
                    dataGridView1.Rows[Contador].Cells[4].Value = Importe;
                    Contador++;
                }
                else
                {
                    foreach (DataGridViewRow Fila in dataGridView1.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == txtCod.Text)
                        {
                            existencia = true;
                            numerofila = Fila.Index;
                        }
                    }

                    if (existencia == true)
                    {
                        dataGridView1.Rows[numerofila].Cells[3].Value = (Convert.ToDouble(txtCan.Text) + Convert.ToDouble(dataGridView1.Rows[numerofila].Cells[3].Value)).ToString();
                        double Importe = Convert.ToDouble(dataGridView1.Rows[numerofila].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[numerofila].Cells[3].Value);

                        dataGridView1.Rows[numerofila].Cells[4].Value = Importe;
                    }
                    else
                    {
                        dataGridView1.Rows.Add(txtCod.Text, txtDes.Text, txtPre.Text, txtCan.Text);
                        double Importe = Convert.ToDouble(dataGridView1.Rows[Contador].Cells[2].Value) * Convert.ToDouble(dataGridView1.Rows[Contador].Cells[3].Value);
                        dataGridView1.Rows[Contador].Cells[4].Value = Importe;
                        Contador++;
                    }
                }

                total = 0;

                foreach (DataGridViewRow Fila in dataGridView1.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[4].Value);
                }
                lblTotal.Text = "RD$ " + total.ToString();
            }
        }

        private void btnEli_Click(object sender, EventArgs e)
        {
            if (Contador > 0)
            {
                total = total - (Convert.ToDouble(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[4].Value));
                lblTotal.Text = "RD$ " + total.ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);

                Contador--;
            }
        }

        private void btnCli_Click(object sender, EventArgs e)
        {
            ConsultarClientes Concli = new ConsultarClientes();
            Concli.ShowDialog();


            if (Concli.DialogResult == DialogResult.OK)
            {
                txtCodbus.Text = Concli.dataGridView1.Rows[Concli.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtCli.Text = Concli.dataGridView1.Rows[Concli.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();

                txtCod.Focus();
            }
        }

        private void btnPro_Click(object sender, EventArgs e)
        {
            ConsultarProductos ConPro = new ConsultarProductos();
            ConPro.ShowDialog();


            if (ConPro.DialogResult == DialogResult.OK)
            {
                txtCod.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                txtDes.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                txtPre.Text = ConPro.dataGridView1.Rows[ConPro.dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                txtCan.Focus();

            }
        }

        private void btnNue_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        public override void Nuevo()
        {
            txtCodbus.Text = "";
            txtCli.Text = "";
            txtCod.Text = "";
            txtDes.Text = "";
            txtPre.Text = "";
            txtCan.Text = "";
            lblTotal.Text = "RD $0";
            dataGridView1.Rows.Clear();
            Contador = 0;
            total = 0;
            txtCodbus.Focus();
        }

        private void btnFac_Click(object sender, EventArgs e)
        {

            if (Contador != 0)
            {
                try
                {
                    string cmd = string.Format("Exec ActualizaFacturas '{0}'",txtCodbus.Text.Trim());

                    DataSet ds = Utiles.Ejecutar(cmd);

                    string NumFac = ds.Tables[0].Rows[0]["NumFac"].ToString().Trim();

                    if (dataGridView1.Rows.Count > 0)
                    {
                        foreach (DataGridViewRow Fila in dataGridView1.Rows)
                        {
                            cmd = string.Format("Exec ActualizaDetalles '{0}','{1}','{2}','{3}'", NumFac, Fila.Cells[0].Value.ToString(), Fila.Cells[2].Value.ToString(), Fila.Cells[3].Value.ToString());
                            ds = Utiles.Ejecutar(cmd);
                        }
                    }

                    cmd = "Exec DatosFactura " + NumFac;
                    ds = Utiles.Ejecutar(cmd);

                    //Ventana Reporte

                    Reporte rp = new Reporte();

                    rp.reportViewer1.LocalReport.DataSources[0].Value = ds.Tables[0];
                    rp.ShowDialog();

                    Nuevo();
                }
                catch(Exception error)
                {
                    MessageBox.Show("Error" + error.Message);
                }
            }
        }
    }
}
