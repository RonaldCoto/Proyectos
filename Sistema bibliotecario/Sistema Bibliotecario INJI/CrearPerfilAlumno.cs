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
    public partial class CrearPerfilAlumno : Form
    {
        ConsultasLibros insertaralum = new ConsultasLibros();

        public void Validar()
        {
            string nombre1 = txtnombrealum1.Text;
            string nombre2 = txtnombrealum2.Text;
            string apellido1 = txtapellido1.Text;
            string apellido2 = txtapellido2.Text;
           
            string nie = txtnie.Text;

            if (string.IsNullOrEmpty(nombre1))
            {
                MessageBox.Show("Debe ingresar el nombre1");
                txtnombrealum1.Focus();
            }else
            {
                if (string.IsNullOrEmpty(nombre2))
                {
                    MessageBox.Show("Debe ingresar el nombre2", "Validacion de Alumno", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnombrealum2.Focus();
                }else
                {
                    if (string.IsNullOrEmpty(apellido1))
                    {
                        MessageBox.Show("Debe ingresar el apellido1");
                        txtapellido1.Focus();
                    }
                    else
                    {

                        if (string.IsNullOrEmpty(apellido2))
                        {
                            MessageBox.Show("Debe ingresar el apellido2");
                            txtapellido2.Focus();
                        }else
                        {
                            if (string.IsNullOrEmpty(nie))
                            {
                                MessageBox.Show("Debe ingresar el nie");
                                txtnie.Focus();
                            }
                            else
                            {
                                try
                                {


                                    insertaralum.insertaralumno(Convert.ToInt32(txtnie.Text), txtnombrealum1.Text, txtnombrealum2.Text, txtapellido1.Text, txtapellido2.Text, Convert.ToInt32(cmbgrado.SelectedValue));
                                    MessageBox.Show("Alumno creado éxitosamente");
                                    Limpiar();

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("error" + ex.Message);
                                }


                            }
                        }
                    }
                }
            }
        }
        public void Limpiar()
        {
            txtnombrealum1.Clear();
            txtnombrealum2.Clear();
            txtapellido1.Clear();
            txtapellido2.Clear();
           
            txtnie.Clear();
        }
        public CrearPerfilAlumno()
        {
            InitializeComponent();
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnguardaralumno_Click(object sender, EventArgs e)
        {

            Validar();
               
            
        }

        private void txtnombrealum_Validated(object sender, EventArgs e)
        {
            string nombre = txtnombrealum1.Text;
            string apellido = txtnombrealum2.Text;
            
            string nie = txtnie.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                errorProvider1.SetError(txtnombrealum1, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtapellido_Validated(object sender, EventArgs e)
        {
            string apellido = txtnombrealum2.Text;
            if (string.IsNullOrEmpty(apellido))
            {
                errorProvider1.SetError(txtnombrealum2, "Debe llenar el campo");

            }else
            {
                errorProvider1.Clear();
            }
        

        }

        private void txtseccion_Validated(object sender, EventArgs e)
        {
           
            
        }

        private void txtnie_Validated(object sender, EventArgs e)
        {
            string nie = txtnie.Text;
            if (nie.Length == 7)
            {
                txtnie.Text = "0" + nie;
            }
            else
                txtnie.Text = nie;

           
            if (string.IsNullOrEmpty(nie))
            {
                errorProvider1.SetError(txtnie, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void CrearPerfilAlumno_Load(object sender, EventArgs e)
        {
            listargrado();
         
            
        }
        private void listargrado()
        {
            ConsultasLibros listargr = new ConsultasLibros();
            cmbgrado.DataSource = listargr.ListarGrado();
            cmbgrado.DisplayMember = "Grado";
            cmbgrado.ValueMember = "IDgrado";

        }

     
        private void txtnie_KeyPress(object sender, KeyPressEventArgs e)
        {

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
            else if ((e.KeyChar == '.') && (!txtnie.Text.Contains(".")))
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

        private void txtnombrealum_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapellido_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtseccion_KeyPress(object sender, KeyPressEventArgs e)
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
                MessageBox.Show("Sólo se admiten letras", "Validación de Sección",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void txtseccion_Validated_1(object sender, EventArgs e)
        {
          
    }

        private void txtapellido1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapellido2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapellido1_Validated(object sender, EventArgs e)
        {
            string apellido1 = txtapellido1.Text;
            if (string.IsNullOrEmpty(apellido1))
            {
                errorProvider1.SetError(txtapellido1, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtapellido2_Validated(object sender, EventArgs e)
        {
            string apellido2 = txtapellido2.Text;
            if (string.IsNullOrEmpty(apellido2))
            {
                errorProvider1.SetError(txtapellido2, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void cmbgrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}