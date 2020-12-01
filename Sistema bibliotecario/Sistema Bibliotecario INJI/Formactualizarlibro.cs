using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_Bibliotecario_INJI
{
    public partial class Formactualizarlibro : Form
    {
        ConsultasLibros inserl = new ConsultasLibros();
        string IdCategoria;
        int IdCategoria2;

        string IdDistribucion;
        int IdDistribucion2;

        public void Validar()
        {
            string codigo = txtcodigoact.Text;
            string autor = txtautoract.Text;
            string nombre = txtnombrelibact.Text;
            string pais = txtpaisact.Text;
            string editorial = txteditorialact.Text;

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Debe ingresar el código", "actualización de libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              
                txtcodigoact.Focus();
            }else
            {
                if (string.IsNullOrEmpty(autor))
                {
                    MessageBox.Show("Debe ingresar el autor", "actualización de libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    
                    txtautoract.Focus();
                }else
                {
                    if (string.IsNullOrEmpty(nombre))
                    {
                        MessageBox.Show("Debe ingresar el nombre", "actualización de libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                       
                        txtnombrelibact.Focus();
                    }else
                    {
                        if (string.IsNullOrEmpty(pais))
                        {
                            MessageBox.Show("Debe ingresar el pais", "actualización de libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            
                            txtpaisact.Focus();
                        }else
                        {
                            if (string.IsNullOrEmpty(editorial))
                            {
                                MessageBox.Show("Debe ingresar la editorial", "actualización de libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                               
                                txteditorialact.Focus();
                            }else
                            {
                                inserl.Acatualizarlibro(txtcodigoact.Text, txtnombrelibact.Text, txtautoract.Text, txteditorialact.Text, Convert.ToInt32(nmpNumeroEjemplares.Value), txtpaisact.Text, Convert.ToInt32(cmbcategoria.SelectedValue), Convert.ToInt32(cmbdistribucion.SelectedValue), lblAutorViejo.Text);
                                MessageBox.Show("Libro ingresado correctamente", "actualización de libro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                              
                                Limpiar();
                            }
                        }
                    }
                }
            }   
            

            
        }
        public void Limpiar()
        {
            txtcodigoact.Clear();
            txtautoract.Clear();
            txtnombrelibact.Clear();
            txtpaisact.Clear();
            txtpaisact.Clear();
            nmpNumeroEjemplares.Value = 1;
            txteditorialact.Clear();
        }
        public Formactualizarlibro()
        {
            InitializeComponent();
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnactualizarlibro_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtcodigoact_Validated(object sender, EventArgs e)
        {
            string codigo = txtcodigoact.Text;
            if (string.IsNullOrEmpty(codigo))
            {
                errorProvider1.SetError(txtcodigoact , "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtautoract_Validated(object sender, EventArgs e)
        {
            string autor = txtautoract.Text;
            if (string.IsNullOrEmpty(autor))
            {
                errorProvider1.SetError(txtautoract , "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtnombrelibact_Validated(object sender, EventArgs e)
        {
            string nombre_libro = txtnombrelibact.Text;
            if (string.IsNullOrEmpty(nombre_libro))
            {
                errorProvider1.SetError(txtnombrelibact,"Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();

            }
        }

        private void txtpaisact_Validated(object sender, EventArgs e)
        {
            string pais = txtpaisact.Text;
            if (string.IsNullOrEmpty(pais))
            {
                errorProvider1.SetError(txtpaisact, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txteditorialact_Validated(object sender, EventArgs e)
        {
            string editorial = txteditorialact.Text;
            if (string.IsNullOrEmpty(editorial))
            {
                errorProvider1.SetError(txteditorialact, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtautoract_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                MessageBox.Show("Sólo se admiten letras", "Validación de autor", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              
               
            }
        }

        private void txtnombrelibact_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                MessageBox.Show("Sólo se admiten letras", "Validación de Nombre Libro",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtpaisact_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                MessageBox.Show("Sólo se admiten letras", "Validación de País",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txteditorialact_KeyPress(object sender, KeyPressEventArgs e)
        {
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
                MessageBox.Show("Sólo se admiten letras", "Validación de Editorial",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Formactualizarlibro_Load(object sender, EventArgs e)
        {
           
            listarcategorias();
            listareditorial();
            //------------------------

            ConverCategoria();
            ConverDistribucion();

            //------------------------
            cmbcategoria.SelectedIndex = IdCategoria2;
            cmbdistribucion.SelectedIndex = IdDistribucion2;
        }

        private void ConverCategoria()
        {
            MostrarLibros ConverCategoria = new MostrarLibros();
            SqlDataReader leer;

            leer = ConverCategoria.ConvertirCategoria(lblcategoria.Text);
             IdCategoria = leer.GetValue(0).ToString();
             IdCategoria2 = Convert.ToInt32(IdCategoria)-1;
            //MessageBox.Show(IdCategoria);


        }

        private void ConverDistribucion()
        {
            MostrarLibros ConverDist = new MostrarLibros();
            SqlDataReader leer;

            leer = ConverDist.ConvertirDistribucion(lbldistribución.Text);
            IdDistribucion  = leer.GetValue(0).ToString();
            IdDistribucion2 = Convert.ToInt32(IdDistribucion) - 1;
            //MessageBox.Show(IdCategoria);


        }

        private void listarcategorias()
        {
            ConsultasLibros listarcat = new ConsultasLibros();
            cmbcategoria.DataSource = listarcat.ListarCategorias();
            cmbcategoria.DisplayMember = "Nombre";
            cmbcategoria.ValueMember = "IDcategoria";

        }

        private void listareditorial()
        {
            ConsultasLibros listaredi = new ConsultasLibros();
            cmbdistribucion.DataSource = listaredi.ListarEditorial();
            cmbdistribucion.DisplayMember = "Nombre";
            cmbdistribucion.ValueMember = "IDdistribucion";

        }
    }
}
