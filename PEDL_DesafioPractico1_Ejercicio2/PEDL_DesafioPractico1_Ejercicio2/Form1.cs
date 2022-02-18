using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PEDL_DesafioPractico1_Ejercicio2
{
    public partial class Form1 : Form
    {

        List<Material> Materiales = new List<Material>();
        List<Material> validador = new List<Material>();
        private int editindex = -1;

        private void actualizargrid()
        {
            DGVdatos.DataSource = null;
            DGVdatos.DataSource = Materiales;
        }

        private void Limpiarcampos()
        {
            txtautor.Clear();
            txtnombre.Clear();
            txtprecio.Clear();
            masckcod.Clear();
            masckcod.Focus();
        }

        private bool validarCampos()
        {
            //variable que verifica si algo ha sido validado
            bool validado = true;

            if (txtnombre.Text == "") //vefica que no quede vacío el campo
            {
                validado = false; 
                errorProvider1.SetError(txtnombre, "Ingresar nombre");
            }

            if (txtautor.Text == "")
            {
                validado = false;
                //digo que verifico a txtapellido y si no cumple mando ese mensaje
                errorProvider1.SetError(txtautor, "Ingrese autor");
            }

            if (txtprecio.Text == "")
            {
                validado = false;
                //digo que verifico a txtapellido y si no cumple mando ese mensaje
                errorProvider1.SetError(txtprecio, "Ingrese precio");
            }

            if (cbtipo.Text == "")
            {
                validado = false;
                //digo que verifico a txtapellido y si no cumple mando ese mensaje
                errorProvider1.SetError(cbtipo, "Elija un tipo");
            }

            if (masckcod.Text == "")
            {
                validado = false;
                //digo que verifico a txtapellido y si no cumple mando ese mensaje
                errorProvider1.SetError(masckcod, "Ingrese un codigo");
            }


            return validado;
        }

        public void BorrarMensaje()
        {
            errorProvider1.SetError(txtautor, "");
            errorProvider1.SetError(txtnombre, "");
            errorProvider1.SetError(txtprecio, "");
            errorProvider1.SetError(cbtipo, "");
            errorProvider1.SetError(masckcod, "");
        }

        public Form1()
        {
            InitializeComponent();
            
        }

        private void DGVdatos_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow seleccion = DGVdatos.SelectedRows[0];
                int pos = DGVdatos.Rows.IndexOf(seleccion); //Para saber en que fila estoy
                editindex = pos;

                Material mat = Materiales[pos]; //En esta variable se cargan los valores de la lista

                txtautor.Text = mat.Autor;
                txtnombre.Text = mat.Nombre;
                txtprecio.Text = Convert.ToString(mat.Precio);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            Material mat = new Material();

            BorrarMensaje();

            if (validarCampos())
            {
                
                mat.Codigo = "ADS" + masckcod.Text;
                mat.Nombre = txtnombre.Text;
                mat.Autor = txtautor.Text;
                mat.Tipo = cbtipo.Text;
                mat.Precio = txtprecio.Text;

                if (editindex < -1) //Verifica si hay un indice seleccionado
                {
                    Materiales[editindex] = mat;
                    editindex = -1; //Seteamos de nuevo el indice en -1
                }
                else
                {
                    Materiales.Add(mat); //Agrego todos los dats que recolecté, en la lista
                }
                actualizargrid();
                Limpiarcampos();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (editindex > -1) //Verificamos si tenemos seleccionado alguna fila
            {


                Materiales.RemoveAt(editindex);
                editindex = -1;
                actualizargrid();
            }
            else
            {
                MessageBox.Show("Debe dar doble click primero sobre la fila");
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            //Obtenemos los datos ingresados en el textbox
            string busqueda = txtbrowser.Text;

            busqueda = busqueda.ToLower(); //Los hacemos en minusculas, para luego trabajar todo en minusculas

            if (busqueda.Equals("")) //Si no se ingresaron datos, devolver error
            {
                MessageBox.Show("Ingresa un dato en la búsqueda.");
            }
            else
            {

                if (busqueda.Equals("todos")) // Si la busqueda es igual a todos, mostramos todos los datos
                {
                    DGVdatos.DataSource = Materiales;
                }
                else
                {
                    //Filtramos los datos de la lista tratando de buscar donde sea igual o el codigo o el nombre del producto
                    DGVdatos.DataSource = Materiales.FindAll(x => x.Codigo.ToString().ToLower() == busqueda || x.Nombre.ToLower() == busqueda || x.Autor.ToLower() == busqueda);
                }

            }
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            if (editindex > -1) //Verificamos si tenemos seleccionado alguna fila
            {
                Material mat = new Material();

                Materiales.RemoveAt(editindex);

                if (validarCampos())
                {

                    mat.Codigo = "ADS" + masckcod.Text;
                    mat.Nombre = txtnombre.Text;
                    mat.Autor = txtautor.Text;
                    mat.Tipo = cbtipo.Text;
                    mat.Precio = txtprecio.Text;

                    
                        Materiales.Insert(editindex,mat); //Agrego todos los dats que recolecté, en la lista
                }

                editindex = -1;
                actualizargrid();
            }
            else
            {
                MessageBox.Show("Debe dar doble click primero sobre la fila");
            }
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtautor_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            //para backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //para que admita tecla de espacio
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            //si no cumple nada de lo anterior que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten letras", "validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //condicion para solo números
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            //para tecla backspace
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            /*verifica que pueda ingresar punto y también que solo pueda
           ingresar un punto*/
            else if ((e.KeyChar == '.') && (!txtnombre.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo se admiten datos numéricos", "validación de números", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
