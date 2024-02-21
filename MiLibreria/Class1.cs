using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MiLibreria
{
    public class Utiles
    {
        // Ya teniendo el espacio de nombre System.Data, preparamos la conexion y el DataSet.
        public static DataSet Ejecutar(string cmd)
        {
            // Ya que importe el espacio de nombre System.Data.SqlClient, puedo hacer uso de las variables de conexion.
            // Procedo a crear una conexion. Para ello necesito una instancia de la conexion y pasar como parametro
            // la cadena de conexion a la BD.
            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=PMuestra;Integrated Security=True");
            // Ahora procedo a abrir la conexion.
            Con.Open();


           // Creo una instancia del DataSet
            DataSet DatSt = new DataSet();
            // Creo una instancia del DataAdapter para adaptar los datos que devuelva la consulta al DataSet.
            // Por parametro se pasa la conexion (cmd) y luego la consulta (Con).
            SqlDataAdapter Adapter = new SqlDataAdapter(cmd, Con);


            // Ahora tiene que rellenar el Dataset que le voy a pasar por parametro. Pasar por parametro la instancia del DataSet.
            Adapter.Fill(DatSt);

            // Cierro la conexion a la base de datos.
            Con.Close();

            //Le pido que devuelva el DataSet.
            return DatSt;
        }

        public static Boolean ValidacionFormulario(Control ctrl, ErrorProvider EProvider)
        {
            Boolean ErroresEncontrados = false;

            foreach (Control c in ctrl.Controls)
            {
                if (c is ErrorBox) 
                {
                    ErrorBox Objeto = (ErrorBox)c;

                    if (Objeto.Validar == true)
                    {
                        if (string.IsNullOrEmpty(Objeto.Text.Trim()))
                        {

                            EProvider.SetError(Objeto, "Vacio o nulo");
                            ErroresEncontrados = true;
                                
                        }

                    }
                    if (Objeto.Numeros == true)
                    {
                        int Contador = 0;
                        int Letras = 0;

                        foreach (char letra in Objeto.Text.Trim())
                        {
                            if(char.IsLetter(Objeto.Text.Trim(), Contador))
                            {
                                Letras++;
                            
                            }
                            Contador++;
                        }
                        if (Letras != 0)
                        {
                            ErroresEncontrados = true;
                            EProvider.SetError(Objeto, "Solo Numeros");
                        }
                    }
                }

            }
            return ErroresEncontrados;
        }
    }
}
