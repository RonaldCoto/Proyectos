using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sistema_Bibliotecario_INJI
{
    
    public partial class Prestamolibro : Form
    {
        Buscarlibro bsclb = new Buscarlibro();
        ConsultasLibros registrarprestamo = new ConsultasLibros();
        public void Validar()
        {
            string codigo = txtcodigopres.Text;
            string nie = txtniepres.Text;
            string nombrelibro = txtnombrelibpres.Text;
            string nombrealumno = txtnombrealumpres1.Text;
            DateTime fechaprestamo = dtpprestamo.Value;
            DateTime fechadevolucion = dtpdevolucion.Value;
            string fechapress = fechaprestamo.ToShortDateString();
            string fechadevv = fechadevolucion.ToShortDateString();

            string biblio = texuser.Text;
            //string fechadevv = Convert.ToString( dtpdevolucion.Value.ToShortDateString());
            if (string.IsNullOrEmpty(nombrelibro))
            {
                MessageBox.Show("Error en la información de libro", "Validando prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }else
            {
                if (string.IsNullOrEmpty(nombrealumno))
                {
                    MessageBox.Show("Error en la información del alumno", "Validando prestamo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                   
                }else
                {
                    if (fechadevolucion< fechaprestamo )
                    {
                        MessageBox.Show("La fecha de devolución no puede ser menor que la de préstamo", "Validando prestamo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                      
                    }
                    else
                    {

                        try
                        {
                           
                            registrarprestamo.insertaprestamo(txtcodigopres.Text,txtnombrelibpres.Text,Convert.ToInt32(txtniepres.Text), txtnombrealumpres1.Text, txtnombrealumpres2.Text ,txtapellidopres1.Text, txtapellidopres2.Text, txtgradopres.Text, biblio, fechapress, fechadevv,1,1);
                        MessageBox.Show("Préstamo realizado éxitosamente", "Validando prestamo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                       
                        this.Close();
                            
                        }
                         catch (Exception ex)
                         {
                         MessageBox.Show("error" + ex.Message);
                        }
                    }
                }
            }
        }
        public void Limpiar()
        {
            txtnombrealumpres1.Clear();
            txtnombrealumpres2.Clear();
            txtapellidopres1.Clear();
            txtapellidopres2.Clear();
            txtgradopres.Clear();
            txtcodigopres.Clear();
            txtautorpres.Clear();
            txtnombrelibpres.Clear();
            txtcatepres.Clear();
            txtdispres.Clear();
            txtpaispres.Clear();
            txteditorialpres.Clear();
        }
        public Prestamolibro()
        {
            InitializeComponent();
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprestamolibro_Click(object sender, EventArgs e)
        {
            //Realizar prestamo
            
            bsclb.dgvbusquedalibro.DataSource = null;
            
            Validar();
           

        }

        private void Prestamolibro_Load(object sender, EventArgs e)
        {

         
          
        }

        private void txtcodpres_Validated(object sender, EventArgs e)
        {
            string codigo = txtcodigopres.Text;
            if (string.IsNullOrEmpty(codigo))
            {
                errorProvider1.SetError(txtcodigopres, "Debe llenar el campo");
            }
            else
                errorProvider1.Clear();
        }

        private void txtniepres_Validated(object sender, EventArgs e)
        {
            string nie = txtniepres.Text;

            
            if (nie.Length == 7)
            {
                txtniepres.Text = "0" + nie;
            }
            else
                txtniepres.Text = nie;

            if (string.IsNullOrEmpty(nie))
            {
                errorProvider1.SetError(txtniepres,"Debe llenar el campo");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void btnbuscarcodig_Click(object sender, EventArgs e)
        {
            string codigo = txtcodigopres.Text;
          
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Debe ingresar el codigo del libro", "Validando prestamo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            else
            {
                //realizar busqueda
                MessageBox.Show("Gracias", "Validando prestamo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                
            }

        }

        private void btnbuscarnie_Click(object sender, EventArgs e)
        {
            string nie = txtniepres.Text;
            if (string.IsNullOrEmpty(nie))
            {
                MessageBox.Show("Debe ingresar el NIE", "Validando prestamo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
            else
            {
                //realizar busqueda
                MessageBox.Show("Gracias", "Validando prestamo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
               
            }
        }

        private void txtcodigopres_Validated(object sender, EventArgs e)
        {
            string codigo = txtcodigopres.Text;
            if (string.IsNullOrEmpty(codigo))
            {
                errorProvider1.SetError(txtcodigopres, "Debe llenar el campo");
            }
            else
            {
                //realizar busqueda
                errorProvider1.Clear();
            }
        }

        private void dtpdevolucion_Validated(object sender, EventArgs e)
        {
           
        }

        private void dtpdevolucion_Leave(object sender, EventArgs e)
        {
            DateTime fechaprestamo = dtpprestamo.Value.Date;
            DateTime fechadevolucion = dtpdevolucion.Value.Date;

            if (fechadevolucion < fechaprestamo)
            {
                //errorProvider1.SetError(dtpdevolucion, "La fecha no puede ser menor");
                MessageBox.Show("la fecha de devolución debe ser mayor que la fecha de préstamo", "Validando prestamo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                dtpdevolucion.Value = DateTime.Now;  
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtniepres_KeyPress(object sender, KeyPressEventArgs e)
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
            else if ((e.KeyChar == '.') && (!txtniepres.Text.Contains(".")))
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

        private void btnautollenado_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader leer;
                ConsultasLibros autollenado = new ConsultasLibros();
                leer = autollenado.Listaralumngrapres(txtniepres.Text);
                txtnombrealumpres1.Text = leer.GetValue(1).ToString();
                txtnombrealumpres2.Text = leer.GetValue(2).ToString();
                txtapellidopres1.Text = leer.GetValue(3).ToString();
                txtapellidopres2.Text = leer.GetValue(4).ToString();
                txtgradopres.Text = leer.GetValue(5).ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error, NIE no existente");
            }

        
      
        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
