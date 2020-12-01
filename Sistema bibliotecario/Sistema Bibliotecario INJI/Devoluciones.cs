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
    public partial class Devoluciones : Form
    {
       
        public Devoluciones()
        {
            InitializeComponent();
        }


        private void MostrarLibrosdev()
        {

            MostrarLibros listdevo = new MostrarLibros();
            dgvdevoluciones.DataSource = listdevo.mostrarDevolucion();

        }
        private void Devoluciones_Load(object sender, EventArgs e)
        {

          
        }

        private void dgvdevoluciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvdevoluciones.Columns[e.ColumnIndex].Name == "Fecha Devolución")
            {

                try
                {
                    if (e.Value.GetType() != typeof(System.DBNull))
                    {


                        if (Convert.ToDateTime(e.Value) < DateTime.Now.Date)
                        {

                            e.CellStyle.BackColor = Color.IndianRed;
                        }

                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show(" " + ex);
                }
                
               
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  select NombreLibro as Libro, NIEprestamo as NIE,(NombreAlumno1 + ' ' + NombreAlumno2 + ' ' + ApellidoAlumno1 + ' ' + ApellidoAlumno2) as [Nombre del Alumno],Grado, (Bibliotecarios.nombre1 + ' ' + Bibliotecarios.apellido1) AS[Bibliotecario / a], Fecha_entrega,Fecha_devolucion from Prestamos inner join Libros on Prestamos.ID_libro = Libros.IDlibro inner join Grados on Prestamos.IDgra = Grados.IDgrado inner join Bibliotecarios on Prestamos.IDBibliotecarioPrestamo = Bibliotecarios.IDbibliotecario
            ;
            string idpres;
            string titulo;
            if (dgvdevoluciones.SelectedRows.Count > 0)
            {

                string resultado;
                resultado = Convert.ToString(MessageBox.Show("Está seguro que quiere finalizar el prestamo", "Confirmación de finzlizacion", MessageBoxButtons.YesNo));

                if (resultado == "Yes")
                {
                   

                    idpres = dgvdevoluciones.CurrentRow.Cells["#"].Value.ToString();
                    titulo = dgvdevoluciones.CurrentRow.Cells["Libro"].Value.ToString();
                    int codigo = Convert.ToInt32(idpres);
                    ConsultasLibros devolver = new ConsultasLibros();
                    devolver.Devolucionlib(codigo, titulo, "lb");

                    MessageBox.Show("Prestamo finalizado", "Finalizando prestamo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dgvdevoluciones.DataSource = null;
               
                    MostrarLibrosdev();

                }

              

              
                
             
                

            
            }
            else
            {
                MessageBox.Show("Seleccione la fila a actualizar");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarLibrosdev();
        }
    }
    }

