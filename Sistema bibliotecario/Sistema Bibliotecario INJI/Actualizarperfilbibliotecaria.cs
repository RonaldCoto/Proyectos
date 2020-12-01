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

    public partial class Actualizarperfilbibliotecaria : Form
    {
        MostrarLibros mostrarabibliotecario = new MostrarLibros();
        private string usuario;
        private string contraseña;

        public void Validar()
        {
            string nombre1 = txtnombiblio1.Text;
            string nombre2 = txtapellbiblio2.Text;
            string apellido1 = txtapellbiblio1.Text;
            string apellido2 = txtapellbiblio2.Text;
            string usuario = txtusernamebiact.Text;
            string contraseña_antigua = txtcontraanti.Text;
            string contraseña_nueva = txtcontranueva.Text;
            string confirmar_contraseña = txtconfirmcont.Text;

            if (string.IsNullOrEmpty(nombre1))
            {
                MessageBox.Show("Debe ingresar el nombre1", "Actualización de bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
                txtnombiblio1.Focus();
            }
            else
            {
                if(string.IsNullOrEmpty(nombre2))
                {
                    MessageBox.Show("Debe ingresar el nombre2", "Actualización de Bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnombiblio2.Focus();
                }else
                {
                    if (string.IsNullOrEmpty(apellido1))
                    {
                        MessageBox.Show("Debe ingresar el apellido1", "Actualización de bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        txtnombiblio1.Focus();
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(apellido2))
                        {
                            MessageBox.Show("Debe ingresar el apellido2", "Actualizacion de Bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtapellbiblio2.Focus();
                        }else
                        {
                            if (string.IsNullOrEmpty(usuario))
                            {
                                MessageBox.Show("Debe ingresar un usuario", "Actualización de bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                txtusernamebiact.Focus();
                            }
                            else
                            {

                                if(contraseña_antigua== lblcontraseña.Text)
                                {
                                    if (contraseña_antigua == contraseña_nueva)
                                    {
                                        MessageBox.Show("La contraseña no puede ser la misma", "Actualización de bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                        txtcontranueva.Focus();
                                    }
                                    else
                                    {
                                        if (contraseña_nueva == confirmar_contraseña)
                                        {
                                            try
                                            {
                                                string resultado;
                                                resultado = Convert.ToString(MessageBox.Show("Actualizar Bibliotecario, requiere inicio de sesión, ¿Está seguro que desea continua?", "Confirmación de Actualización Bibliotecario", MessageBoxButtons.YesNo));

                                                if (resultado == "Yes")
                                                {
                                                    mostrarabibliotecario.EditarBibliotecario(txtnombiblio1.Text, txtnombiblio2.Text, txtapellbiblio1.Text, txtapellbiblio2.Text, txtusernamebiact.Text, txtconfirmcont.Text, lblusuario.Text, lblcontraseña.Text);
                                                    MessageBox.Show("Bibliotecario/a actualizado éxitosamente", "Actualización de Bibliotecario", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                                                    Limpiar();


                                                    Application.Restart();

                                                }

                                                
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }

                                        }
                                        else
                                        {
                                            MessageBox.Show("La contraseña debe ser igual", "Actualización de bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                            txtconfirmcont.Focus();
                                        }
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Debe ingresar la contraseña antigua", "Actualización de Bibliotecario/a", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                }
                            }
                        }
                    }
                }
            }
        }
        public void Limpiar()
        {
            txtnombiblio1.Clear();
            txtnombiblio2.Clear();
            txtapellbiblio1.Clear();
            txtapellbiblio2.Clear();
            txtusernamebiact.Clear();
            txtconfirmcont.Clear();
            txtcontraanti.Clear();
            txtcontranueva.Clear();
        }
        public Actualizarperfilbibliotecaria()
        {
           
            InitializeComponent();
        }

        public Actualizarperfilbibliotecaria(string usuario, string contraseña)
        {
            this.usuario = usuario;
            this.contraseña = contraseña;
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnactualibiblio_Click(object sender, EventArgs e)
        {
            Validar();

        }

        private void txtconfirmcont_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombiblio_Validated(object sender, EventArgs e)
        {
            string nombre = txtnombiblio1.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                errorProvider1.SetError(txtnombiblio1, "Introduzca un nombre");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtapellbiblio_Validated(object sender, EventArgs e)
        {
            string apellido = txtnombiblio2.Text;
            if (string.IsNullOrEmpty(apellido))
            {
                errorProvider1.SetError(txtnombiblio2, "Introduzca un apellido");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtusernamebiact_Validated(object sender, EventArgs e)
        {
            string usuario = txtusernamebiact.Text;
            if(string.IsNullOrEmpty(usuario))
            {
                errorProvider1.SetError(txtusernamebiact, "Por favor ingrese el nombre de usuario");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtcontraanti_Validated(object sender, EventArgs e)
        {
            string contraseña_antigua = txtcontraanti.Text;
            if(string.IsNullOrEmpty(contraseña_antigua ))
            {
                errorProvider1.SetError(txtcontraanti, "Por favor ingrese la contraseña antigua");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtcontranueva_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcontranueva_Validated(object sender, EventArgs e)
        {
            string contraseña_nueva = txtcontranueva.Text;
            if (string.IsNullOrEmpty(contraseña_nueva ))
            {
                errorProvider1.SetError(txtcontranueva, "Por favor llene el campo con la nueva contraseña");
            }
            else
            {
                errorProvider1.Clear();

            }


        }

        private void txtconfirmcont_Validated(object sender, EventArgs e)
        {
            string confirmar_contraseña = txtconfirmcont.Text;
            if(string.IsNullOrEmpty(confirmar_contraseña))
            {
                errorProvider1.SetError(txtconfirmcont, "Por favor llene el campo de confirmar contraseña");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Actualizarperfilbibliotecaria_Load(object sender, EventArgs e)
        {
            SqlDataReader leer;

            leer = mostrarabibliotecario.Mostrarbibliotecaria(lblusuario.Text, lblcontraseña.Text);
            txtnombiblio1.Text = leer.GetValue(1).ToString();
            txtnombiblio2.Text = leer.GetValue(2).ToString();
            txtapellbiblio1.Text = leer.GetValue(3).ToString();
            txtapellbiblio2.Text = leer.GetValue(4).ToString();
            txtusernamebiact.Text = leer.GetValue(5).ToString();
        }


        private void txtnombiblio_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapellbiblio_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Sólo se admiten letras", "Validación Apellido",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtapellbiblio1_Validated(object sender, EventArgs e)
        {
            string apellido1 = txtapellbiblio1.Text;
            if (string.IsNullOrEmpty(apellido1))
            {
                errorProvider1.SetError(txtapellbiblio1, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtapellbiblio2_Validated(object sender, EventArgs e)
        {
            string apellido2 = txtapellbiblio2.Text;
            if (string.IsNullOrEmpty(apellido2))
            {
                errorProvider1.SetError(txtapellbiblio2, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtapellbiblio2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapellbiblio1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnombiblio1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }
    }
}
