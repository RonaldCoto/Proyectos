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
    
    public partial class creandobibliotecaria : Form
        
    {
        MostrarLibros moslb = new MostrarLibros();
        
        
        public creandobibliotecaria()
        {
            InitializeComponent();
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtnombibliocr_Validated(object sender, EventArgs e)
        {
            string nombre = txtnombibliocr1.Text;
            if (string.IsNullOrEmpty(nombre))
                errorProvider1.SetError(txtnombibliocr1, "Debe llenar el campo");
            else
                errorProvider1.Clear();
        }

        private void txtapellbibliocr_Validated(object sender, EventArgs e)
        {
            string apellido = txtnombibliocr2.Text;
            if (string.IsNullOrEmpty(apellido))
                errorProvider1.SetError(txtnombibliocr2, "Debe llenar el campo");
            else
                errorProvider1.Clear();
        }

        private void txtusernamebi_Validated(object sender, EventArgs e)
        {
            string usuario = txtusernamebi.Text;
            if (string.IsNullOrEmpty(usuario))
                errorProvider1.SetError(txtusernamebi, "Debe llenar el campo");
            else
                errorProvider1.Clear();
        }

        private void txtcontcr_Validated(object sender, EventArgs e)
        {
            string contraseña = txtcontcr.Text;
            if (string.IsNullOrEmpty(contraseña))
                errorProvider1.SetError(txtcontcr, "Debe llenar el campo");
            else
                errorProvider1.Clear();
        }

        private void txtconfirmcontcr_Validated(object sender, EventArgs e)
        {
            string confirmar_contraseña = txtconfirmcontcr.Text;
            if (string.IsNullOrEmpty(confirmar_contraseña))
                errorProvider1.SetError(txtconfirmcontcr, "Debe llenar el campo");
            else
                errorProvider1.Clear();
        }

        private void btnguardarbiba_Click(object sender, EventArgs e)
        {

            string nombre1 = txtnombibliocr1.Text;
            string nombre2 = txtnombibliocr2.Text;
            string apellido1 = txtapellbibliocr1.Text;
            string apellido2 = txtapellbibliocr2.Text;
            string usuario = txtusernamebi.Text;
            string contraseña = txtcontcr.Text;
            string confirmar_contraseña = txtconfirmcontcr.Text;

            if (string.IsNullOrEmpty(nombre1))
                {
                MessageBox.Show("Debe llenar el campo Nombre1", "Registrando bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                txtnombibliocr1.Focus();
                }
                else
                {
                if (string.IsNullOrEmpty(nombre2))
                {
                    MessageBox.Show("Debe llenar el campo Nombre2", "Registrando Bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnombibliocr2.Focus();
                }else
                {
                    if (string.IsNullOrEmpty(apellido1))
                    {
                        MessageBox.Show("Debe llenar el campo Apellido1", "Registrando bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        txtnombibliocr1.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(apellido2))
                        {
                            MessageBox.Show("Debe llenar el campo Apellido2", "Registrando Bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtapellbibliocr2.Focus();
                        }else
                        {
                            if (string.IsNullOrEmpty(usuario))
                            {
                                MessageBox.Show("Debe llenar el campo Usuario", "Registrando bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                txtusernamebi.Focus();
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(contraseña))
                                {
                                    MessageBox.Show("Debe llenar el campo contraseña", "Registrando bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    txtcontcr.Focus();
                                }
                                else
                                {
                                    if (contraseña == confirmar_contraseña)
                                    {
                                        //Codigo
                                        moslb.insertarbibliotecaria(txtnombibliocr1.Text, txtnombibliocr2.Text, txtapellbibliocr1.Text, txtapellbibliocr2.Text, txtusernamebi.Text, txtcontcr.Text);
                                        MessageBox.Show("Datos enviado correctamente", "Registrando bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                                        txtnombibliocr1.Clear();
                                        txtnombibliocr2.Clear();
                                        txtusernamebi.Clear();
                                        txtcontcr.Clear();
                                        txtconfirmcontcr.Clear();

                                    }
                                    else
                                    {
                                        MessageBox.Show("Las contraseñas deben ser iguales", "Registrando bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                        txtcontcr.Focus();
                                    }
                                }

                            }
                        }

                    }
                }


                }
            }

        

        private void creandobibliotecaria_Load(object sender, EventArgs e)
        {

        }

        static void limpiar()
        {
            
        }

        private void txtnombibliocr_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Sólo se admiten letras", "Validación de Nombre",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtapellbibliocr_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapellbibliocr1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapellbibliocr2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapellbibliocr1_Validated(object sender, EventArgs e)
        {
            string apellido1 = txtapellbibliocr1.Text;
            if (string.IsNullOrEmpty(apellido1))
            {
                errorProvider1.SetError(txtapellbibliocr1, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtapellbibliocr2_Validated(object sender, EventArgs e)
        {
            string apellido2 = txtapellbibliocr2.Text;
            if (string.IsNullOrEmpty(apellido2))
            {
                errorProvider1.SetError(txtapellbibliocr2, "Debe llenar el campo");

            }else
            {
                errorProvider1.Clear();
            }
        }
    }
}

