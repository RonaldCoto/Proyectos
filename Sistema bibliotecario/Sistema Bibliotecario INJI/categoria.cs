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
    public partial class categoria : Form
    {
        MostrarLibros crearcat = new MostrarLibros();
        public void Validar()
        {
            string nombre = txtcodcateg.Text;
            string descripción = txtdesccat.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe agregar un nombre a la categoría", "Registrando categoría", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
              
                txtcodcateg.Focus();
            }else
            {
                if(string.IsNullOrEmpty(descripción))
                {
                    MessageBox.Show("Debe ingresar una descripción", "Registrando categoría", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                   
                    txtdesccat.Focus();
                }else
                {
                    crearcat.insertarCategorianueva(txtcodcateg.Text, txtdesccat.Text);
                    MessageBox.Show("Categoría agregada éxitosamente", "Registrando categoría", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                   
                    Limpiar();
                }
            }
        }
        public void Limpiar()
        {
            txtcodcateg.Clear();
            txtdesccat.Clear();
        }
        public categoria()
        {
            InitializeComponent();
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtcodcateg_Validated(object sender, EventArgs e)
        {
            string nombre = txtcodcateg.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                errorProvider1.SetError(txtcodcateg, "Debe llenar el siguiente campo");
            }
            else
                errorProvider1.Clear();
        }

        private void txtdesccat_Validated(object sender, EventArgs e)
        {
            string descripcion = txtdesccat.Text;
            if (string.IsNullOrEmpty(descripcion))
            {
                errorProvider1.SetError(txtdesccat, "Debe llenar el campo");
            }
            else
                errorProvider1.Clear();

        }

        private void btncategoria_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtcodcateg_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se admiten letras", "Validación de nombre",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
    }
}
