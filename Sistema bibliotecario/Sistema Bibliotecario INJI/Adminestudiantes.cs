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
    public partial class Adminestudiantes : Form

    {
        string inicio = "0";
        
        MostrarLibros objetomostrarlb = new MostrarLibros();
        private string nie;
        private void mostrarestudiantes()
        {
            dgvlistalum.DataSource = objetomostrarlb.mostrarAlumno();
        }
        public Adminestudiantes()
        {
            InitializeComponent();
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbbuscarpor.SelectedItem.ToString()== "NIE")
            {
                txtbusquedaalum.Visible = true;
                label4.Visible = true;
                label3.Visible = false;
                cmbbusgrado.Visible = false;

            }
            else if(cmbbuscarpor.SelectedItem.ToString()=="Grado") {
                cmbbusgrado.Visible = true;
                label3.Visible = true;

                txtbusquedaalum.Visible = false;
                label4.Visible = false;


            }
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnactuaestu_Click(object sender, EventArgs e)
        {
            string nombre1,nombre2, apellido1, apellido2;
            string NIE, Grado ;

            if(dgvlistalum.SelectedRows.Count > 0)
            {
                nombre1 = dgvlistalum.CurrentRow.Cells["Nombre1"].Value.ToString();
                nombre2 = dgvlistalum.CurrentRow.Cells["Nombre2"].Value.ToString();
                apellido1 = dgvlistalum.CurrentRow.Cells["Apellido1"].Value.ToString();
                apellido2 = dgvlistalum.CurrentRow.Cells["Apellido2"].Value.ToString();
                Grado = dgvlistalum.CurrentRow.Cells["Grado"].Value.ToString();
                NIE = dgvlistalum.CurrentRow.Cells["NIE"].Value.ToString();
                
               

                Actualizarestudiante formac = new Actualizarestudiante();
                formac.txtnomact1.Text = nombre1;
                formac.txtnomact2.Text = nombre2;
                formac.txtapellactu1.Text = apellido1;
                formac.txtapellactu2.Text = apellido2;
                formac.txtnieactu.Text = NIE;
                formac.lblgrado.Text = Grado;
                //formac.cmbgradoactu.SelectedValue = Idgrad;
              
                this.Hide();
                formac.ShowDialog();
                this.Show();

                dgvlistalum.DataSource = null;
                ListarTodosAlumnos();

            }
            else
            {
                MessageBox.Show("Seleccione la fila a actualizar");
            }



           
        }

        private void listandoalumnos()
         {
            ConsultasLibros buscargrad = new ConsultasLibros();
            // dgvlistalum.DataSource = buscargrad.Listaralumngra(Convert.ToInt32( null));
            dgvlistalum.DataSource = buscargrad.Listaralumngra(Convert.ToInt32(txtbusquedaalum.Text));
          }

        private void listandoalumnosgrado()
        {
            ConsultasLibros buscargrad = new ConsultasLibros();
            //dgvlistalum.DataSource = buscargrad.Listaralumngra2(null);
            dgvlistalum.DataSource = buscargrad.Listaralumngra2(cmbbusgrado.Text);
            
         }
        private void ListarTodosAlumnos()
        {
            ConsultasLibros buscargrad = new ConsultasLibros();
            dgvlistalum.DataSource = buscargrad.ListarTodosAlumnos();
        }
        
        private void Adminestudiantes_Load(object sender, EventArgs e)
        {
            cmbbuscarpor.SelectedIndex = 0;
            cmbbusgrado.SelectedIndex = 0;
            ListarTodosAlumnos();
            listargrado();
        }

      

        private void listargrado()
        {
            ConsultasLibros listargr = new ConsultasLibros();
            cmbbusgrado.DataSource = listargr.ListarGrado();
            cmbbusgrado.DisplayMember = "Grado";
            cmbbusgrado.ValueMember = "IDgrado";

        }
        private void txtbusquedaalum_Validated(object sender, EventArgs e)
        {
            string nie = txtbusquedaalum.Text;
            if (nie.Length == 7)
            {
                txtbusquedaalum.Text = "0" + nie;
            }
            else
                txtbusquedaalum.Text = nie;

            if (string.IsNullOrEmpty(nie))
            {
                errorProvider1.SetError(txtbusquedaalum, "Debe llenar el campo");
            }else
            {
                errorProvider1.Clear();
            }
        }

        private void txtbusquedaalum_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!txtbusquedaalum.Text.Contains(".")))
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

        private void btnbuscarestu_Click(object sender, EventArgs e)
        {
            
            string busquedanie = txtbusquedaalum.Text;

            
            if (cmbbusgrado.Visible == true)
            {
               dgvlistalum.DataSource = null;
               
                listandoalumnosgrado();
               
                

            }
            else
            {
                if (string.IsNullOrEmpty(busquedanie))
                {
                    MessageBox.Show("Debe ingresar el NIE de busqueda");
                }
                else
                {
                    
                    if (busquedanie == inicio)
                    {
                        MessageBox.Show("Registro buscado previamente");
                    }
                    else
                    {


                        //MUESTRA BUSQUEDA
                        dgvlistalum.DataSource = null;
                        dgvlistalum.DataSource = null;
                        listandoalumnos();
                        
                        //
                        dgvlistalum.Refresh();
                        inicio = busquedanie;
                        txtbusquedaalum.Clear();

                    }

                }

            }



        }

        private void btnelimestu_Click(object sender, EventArgs e)
        {
            if (dgvlistalum.SelectedRows.Count > 0)
            {


                string resultado;
                resultado = Convert.ToString(MessageBox.Show("Está seguro que quiere eliminar al alumno", "Confirmación de Eliminación", MessageBoxButtons.YesNo));

                if (resultado == "Yes")
                {
                    nie = dgvlistalum.CurrentRow.Cells["NIE"].Value.ToString();
                    objetomostrarlb.EliminarAlumno(nie);
                    MessageBox.Show("Alumno eliminado");
                    dgvlistalum.DataSource = null;
                    ListarTodosAlumnos();

                }



            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila por favor");
            }
        }

        private void dgvlistalum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Adminestudiantes formulario = new Sistema_Bibliotecario_INJI.Adminestudiantes();
            formulario.Close();
            formulario.Show();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login log = new Login();
            
        }

        private void dgvlistalum_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbbusgrado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
