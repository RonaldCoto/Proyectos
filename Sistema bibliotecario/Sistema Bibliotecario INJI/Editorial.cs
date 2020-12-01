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
    public partial class Editorial : Form
    {
        MostrarLibros crearcat = new MostrarLibros();
        public Editorial()
        {
            InitializeComponent();
        }
       
        public void Validar()
        {
            string nombre = txtnombre.Text;
            string pais = txtpais.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Debe agregar un nombre a la editorial", "Registrando editorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtnombre.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(pais))
                {
                    MessageBox.Show("Debe agregar un país", "Registrando editorial", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    txtpais.Focus();
                }
                else
                {
                    crearcat.insertareditorialnueva(txtnombre.Text, txtpais.Text);
                    
                    MessageBox.Show("Distribuvión agregada éxitosamente", "Registrando distribución", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    Limpiar();
                }
            }
        }

        public void Limpiar()
        {
            txtnombre.Clear();
            txtpais.Clear();
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardareditorial_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void txtnombre_Validated(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                errorProvider1.SetError(txtnombre, "Debe llenar el siguiente campo");
            }
            else
                errorProvider1.Clear();
        }

        private void txtpais_Validated(object sender, EventArgs e)
        {
            string pais = txtpais.Text;
            if (string.IsNullOrEmpty(pais))
            {
                errorProvider1.SetError(txtpais, "Debe llenar el siguiente campo");
            }
            else
                errorProvider1.Clear();
        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Solo se admiten letras", "Validación de pais",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
