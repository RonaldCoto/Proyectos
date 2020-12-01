using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Bibliotecario_INJI
{
    public partial class RegistrarLibro : Form
    {
        ConsultasLibros inserl = new ConsultasLibros();
        public void Validar()
        {
            string codigo = txtcodigo.Text;
            string autor = txtnomautor.Text;
            string nombre = txtnombrelib.Text;
            string pais = txtpais.Text;
            string editorial = txteditorial.Text;

            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Debe ingresar el código", "Registrando libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                txtcodigo.Focus();
            }else
            {
                if (string.IsNullOrEmpty(autor))
                {
                    MessageBox.Show("Debe ingresar el nombre del autor", "Registrando libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                    txtnomautor.Focus();
                }else
                {
                    if (string.IsNullOrEmpty(nombre))
                    {
                        MessageBox.Show("Debe ingresar el nombre del libro", "Registrando libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        
                        txtnombrelib.Focus();
                    }else
                    {
                        if (string.IsNullOrEmpty(pais))
                        {
                            MessageBox.Show("Debe ingresar el país", "Registrando libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                         
                            txtpais.Focus();
                        }else
                        {
                            if (string.IsNullOrEmpty(editorial))
                            {
                                MessageBox.Show("Debe ingresar la editorial", "Registrando libro", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            
                                txteditorial.Focus();
                            } else
                            {
                               inserl.insertarlibro(txtcodigo.Text, 1, txtnombrelib.Text, txteditorial.Text,Convert.ToInt32( nudNumeroEjemplares.Value), txtpais.Text, Convert.ToInt32( cmbdistribucion.SelectedValue), Convert.ToInt32( cmbcategoria.SelectedValue), txtnomautor.Text);
                                MessageBox.Show("Libro Registrado Correctamente", "registro de libro", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                
                               
                                
                                    Limpiar();
                                
                               
                              
                            }
                        }
                    }
                }
            }
        }
        public void Limpiar()
        {
            txtcodigo.Clear();
            txtnomautor.Clear();
            txtnombrelib.Clear();
            txtpais.Clear();
            txteditorial.Clear();
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

        public RegistrarLibro()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistrarLibro_Load(object sender, EventArgs e)
        {
            listarcategorias();
            listareditorial();

        }

        private void txtcodigo_Validated(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text;

            if (string.IsNullOrEmpty(codigo))
            {
                errorProvider1.SetError(txtcodigo , "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtautor_Validated(object sender, EventArgs e)
        {
            string autor = txtnomautor.Text;
            if (string.IsNullOrEmpty(autor))
            {
                errorProvider1.SetError(txtnomautor,"Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtnombrelib_Validated(object sender, EventArgs e)
        {
            string nombre = txtnombrelib.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                errorProvider1.SetError(txtnombrelib,"Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtpais_Validated(object sender, EventArgs e)
        {
            string pais = txtpais.Text;
            if (string.IsNullOrEmpty(pais))
            {
                errorProvider1.SetError(txtpais,"Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txteditorial_Validated(object sender, EventArgs e)
        {
            string editorial = txteditorial.Text;
            if (string.IsNullOrEmpty(editorial))
            {
                errorProvider1.SetError(txteditorial,"Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void btnguardarlibro_Click(object sender, EventArgs e)
        {
                Validar();
        }

        private void txtnomautor_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Sólo se admiten letras", "Validación de Autor",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtapellau_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Sólo se admiten letras", "Validación de Apellido",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtnombrelib_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Sólo se admiten letras", "Validación de Nombre de Libro",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtpais_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txteditorial_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapellau_Validated(object sender, EventArgs e)
        {
            string apellido = txtnomautor.Text;
            if (string.IsNullOrEmpty(apellido))
            {
                errorProvider1.SetError(txtnomautor, "Debe llenar el campo");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

		private void label10_Click(object sender, EventArgs e)
		{

		}

        private void txtnomautor_KeyPress_1(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtnombrelib_KeyPress_1(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtpais_KeyPress_1(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txteditorial_KeyPress_1(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se admiten letras", "validación de texto",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtcodigo_Validated_1(object sender, EventArgs e)
        {
            string codigo = txtcodigo.Text;
            if (string.IsNullOrEmpty(codigo))
            {
                errorProvider1.SetError(txtcodigo, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtnomautor_Validated(object sender, EventArgs e)
        {
            string autor = txtnomautor.Text;
            if (string.IsNullOrEmpty(autor))
            {
                errorProvider1.SetError(txtnomautor, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtnombrelib_Validated_1(object sender, EventArgs e)
        {
            string nombrelibro = txtnombrelib.Text;
            if (string.IsNullOrEmpty(nombrelibro))
            {
                errorProvider1.SetError(txtnombrelib, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtpais_Validated_1(object sender, EventArgs e)
        {
            string pais = txtpais.Text;
            if (string.IsNullOrEmpty(pais))
            {
                errorProvider1.SetError(txtpais, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txteditorial_Validated_1(object sender, EventArgs e)
        {
            string editorial = txteditorial.Text;
            if (string.IsNullOrEmpty(editorial))
            {
                errorProvider1.SetError(txteditorial, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }
    }
}
