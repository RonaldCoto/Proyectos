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
    public partial class Actualizarestudiante : Form
    {
        MostrarLibros mostraralumno = new MostrarLibros();
        string IdGrado;
        int IdGrado2;

        private void listargrado()
            {
            ConsultasLibros listargr = new ConsultasLibros();
            cmbgradoactu.DataSource = listargr.ListarGrado();
            cmbgradoactu.DisplayMember = "Grado";
            cmbgradoactu.ValueMember = "IDgrado";

        }
        public void Validar()
        {
            string nombre1 = txtnomact1.Text;
            string nombre2 = txtnomact2.Text;
            string apellido1 = txtapellactu1.Text;
            string apellido2 = txtapellactu2.Text;
            string grado = Convert.ToString(cmbgradoactu.SelectedValue);

           
           
            string nie = txtnieactu.Text;

            if (string.IsNullOrEmpty(nombre1))
            {
                MessageBox.Show("Debe llenar el campo con el nombre1", "Actualización de estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                txtnomact1.Focus();
            }
            else
            {
                if (string.IsNullOrEmpty(nombre2))
                {
                    MessageBox.Show("Debe llenar el campo con el  nombre2", "Actualización de estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtnomact2.Focus();
                }else
                {
                    if (string.IsNullOrEmpty(apellido1))
                    {
                        MessageBox.Show("Debe llenar el campo apellido1", "Actualización de estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        txtapellactu1.Focus();
                    }
                    else
                    {
                        if(string.IsNullOrEmpty(apellido2))
                        {
                            MessageBox.Show("Debe llenar el campo apellido2", "Actualización de estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtapellactu2.Focus();
                        }else
                        {
                            
                                if (string.IsNullOrEmpty(nie))
                                {
                                    MessageBox.Show("Debe ingresar el NIE", "Actualización de estudiante", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                    txtnieactu.Focus();
                                }
                                else
                                {
                                    try
                                    {
                                        mostraralumno.EditarAlumno(txtnieactu.Text, txtnomact1.Text, txtnomact2.Text, txtapellactu1.Text, txtapellactu2.Text, Convert.ToString(cmbgradoactu.SelectedValue));
                                        MessageBox.Show("Alumno actualizado éxitosamente", "Actualización de estudiante", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);


                                        Limpiar();

                                   
                                   
                                    

                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.Message);
                                    }

                                }
                            
                        }
                    }
                }
            }

        }
        public void Limpiar()
        {
            txtnomact1.Clear();
            txtnomact2.Clear();
            txtapellactu1.Clear();
            txtapellactu2.Clear();
           
            txtnieactu.Clear();

        }
        public Actualizarestudiante()
        {
            InitializeComponent();
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnactualizaralum_Click(object sender, EventArgs e)
        {
            


            Validar();       
             
            
           

        }

        private void txtnomact_Validated(object sender, EventArgs e)
        {
            string nombre = txtnomact1.Text;
            if (string.IsNullOrEmpty(nombre))
            {
                errorProvider1.SetError(txtnomact1, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtapellactu_Validated(object sender, EventArgs e)
        {
            string apellido = txtnomact2.Text;
            if (string.IsNullOrEmpty(apellido))
            {
                errorProvider1.SetError(txtnomact2, "Debe llenar el campo");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void Actualizarestudiante_Load(object sender, EventArgs e)
        {
            
            listargrado();
            ConvertirGrado();
            cmbgradoactu.SelectedIndex = IdGrado2;

        }

        private void ConvertirGrado()
        {
            MostrarLibros ConverGrado = new MostrarLibros();
            SqlDataReader leer;

            leer = ConverGrado.ConvertirGrado(lblgrado.Text);
            IdGrado = leer.GetValue(0).ToString();
            IdGrado2 = Convert.ToInt32(IdGrado) - 1;
            //MessageBox.Show(IdCategoria);


        }

        private void txtseccionactu_Validated(object sender, EventArgs e)
        {
            
        }

        private void txtnieactu_Validated(object sender, EventArgs e)
        {
            string nie = txtnieactu.Text;
            if (nie.Length == 7)
            {
                txtnieactu.Text = "0" + nie;
            }
            else
                txtnieactu.Text = nie;


        }

        private void txtnieactu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnieactu_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!txtnieactu.Text.Contains(".")))
            {
                e.Handled = false;
            }
            //si no se cumple nada de lo anterior entonces que no lo deje pasar
            else
            {
                e.Handled = true;
                MessageBox.Show("Sólo se admiten datos numéricos", "Validación de NIE",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void txtnomact_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapellactu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtseccionactu_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtseccionactu_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapellactu1_Validated(object sender, EventArgs e)
        {
            string apellido1=txtapellactu1.Text;
            if (string.IsNullOrEmpty(apellido1))
            {
                errorProvider1.SetError(txtapellactu1, "Debe llenar este campo");
            }
            else
            {
                errorProvider1.Clear();
            }


        }

        private void txtapellactu2_Validated(object sender, EventArgs e)
        {
            string apellido2 = txtapellactu2.Text;
            if (string.IsNullOrEmpty(apellido2))
            {
                errorProvider1.SetError(txtapellactu2, "Debe llenar este campo");

            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtapellactu1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtapellactu2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void lblgrado_Click(object sender, EventArgs e)
        {

        }
    }
}
