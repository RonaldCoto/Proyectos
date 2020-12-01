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
    public partial class ActualizarLibro : Form
    {
        MostrarLibros objetomostrarlb = new MostrarLibros();
        private string idlibro;
        public ActualizarLibro()
        {
            InitializeComponent();
        }

        private void ListarTodosLibros()
        {
            ConsultasLibros buscargrad = new ConsultasLibros();
            dgvlistadolibro.DataSource = buscargrad.ListarTodosLibros();
        }

        private void ListarPorTitulo()
        {
            ConsultasLibros buscarportitulo = new ConsultasLibros();
            
            dgvlistadolibro.DataSource = buscarportitulo.ListarPorTitulo(txtbuscar.Text);
        }

        private void ListarPorAutor()
        {
            ConsultasLibros buscarporautor = new ConsultasLibros();
            
            dgvlistadolibro.DataSource = buscarporautor.ListarPorAutor(txtbuscar.Text);
        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void btnactualizarlib_Click(object sender, EventArgs e)
        {
          

            Formactualizarlibro frmac = new Formactualizarlibro();
            frmac.Show();


        }

       
        private void ActualizarLibro_Load(object sender, EventArgs e)
        {
            ListarTodosLibros();
            cmbbuscarpor.SelectedIndex = 0;
            lbltitulo.Visible = true;
            lblautor.Visible = false;
            
        }

        private void MostrarLibros()
        {
            dgvlistadolibro.DataSource = objetomostrarlb.mostrarlibro();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnactualizarlib_Click_1(object sender, EventArgs e)
        {
           
           
        }

        private void btnactualizarlib_Click_2(object sender, EventArgs e)
        {
            string Codigo,  Autor, NombreLibro, Categoria, AutorViejo;
            string Distribución,Pais,Editorial,Stock;

            if (dgvlistadolibro.SelectedRows.Count > 0)
            {
                Codigo = dgvlistadolibro.CurrentRow.Cells["Código"].Value.ToString();
                NombreLibro = dgvlistadolibro.CurrentRow.Cells["Titulo"].Value.ToString();
                Autor = dgvlistadolibro.CurrentRow.Cells["Autor"].Value.ToString();
                Editorial  = dgvlistadolibro.CurrentRow.Cells["Editorial"].Value.ToString();
                Stock  = dgvlistadolibro.CurrentRow.Cells["Stock"].Value.ToString();
                Pais  = dgvlistadolibro.CurrentRow.Cells["País"].Value.ToString();
                AutorViejo = dgvlistadolibro.CurrentRow.Cells["Autor"].Value.ToString();
                Categoria = dgvlistadolibro.CurrentRow.Cells["Categoría"].Value.ToString();
                Distribución  = dgvlistadolibro.CurrentRow.Cells["Distribución"].Value.ToString();

                //MessageBox.Show(Categoria);
                //MessageBox.Show(Distribución);

                Formactualizarlibro FrmActuLibro = new Formactualizarlibro();
                FrmActuLibro.txtcodigoact.Text = Codigo;
                FrmActuLibro.txtautoract.Text = Autor;
                FrmActuLibro.txtnombrelibact.Text = NombreLibro;
                FrmActuLibro.txtpaisact.Text = Pais;
                FrmActuLibro.txteditorialact.Text = Editorial;
                //FrmActuLibro.nmpNumeroEjemplares = Convert.ToDecimal(Stock);
                FrmActuLibro.lblAutorViejo.Text = AutorViejo;
                // FrmActuLibro.cmbdistribucion.DisplayMember =  Categoria;
                //FrmActuLibro.cmbcategoria.ValueMember = Categoria;
                FrmActuLibro.lblcategoria.Text = Categoria;
                FrmActuLibro.lbldistribución.Text = Distribución;



                this.Hide();
                FrmActuLibro.ShowDialog();
                this.Show();

                dgvlistadolibro.DataSource = null;
                ListarTodosLibros();

            }
            else
            {
                MessageBox.Show("Seleccione la fila a actualizar");
            }

        }

        private void btneliminarlib_Click(object sender, EventArgs e)
        {
            if (dgvlistadolibro.SelectedRows.Count > 0)
            {


                string resultado;
                resultado = Convert.ToString(MessageBox.Show("Está seguro que quiere eliminar el libro?", "Confirmación de Eliminación", MessageBoxButtons.YesNo));

                if (resultado == "Yes")
                {
                    idlibro = dgvlistadolibro.CurrentRow.Cells["Código"].Value.ToString();
                    objetomostrarlb.EliminarLibro(idlibro);
                    MessageBox.Show("Libro eliminado");
                    dgvlistadolibro.DataSource = null;
                    ListarTodosLibros();

                }



            }
            else
            {
                MessageBox.Show("Debe seleccionar una fila por favor");
            }
        }

        private void btnbuscarestu_Click(object sender, EventArgs e)
        {
            string cmb = cmbbuscarpor.SelectedItem.ToString();
            if (cmb == "Título")
            {

                dgvlistadolibro.DataSource = null;

                ListarPorTitulo();

            }
            else if (cmb == "Autor")
            {
                dgvlistadolibro.DataSource = null;

                ListarPorAutor();
            }

        }

        private void txtbuscar_Validated(object sender, EventArgs e)
        {
            string busqueda = txtbuscar.Text;
            if(string.IsNullOrEmpty(busqueda))
            {
                errorProvider1.SetError(txtbuscar, "Debe ingresar parámetro de búsqueda");
            }
            else
            {
                errorProvider1.Clear();

            }

        }

        private void cmbbuscarpor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cmb = cmbbuscarpor.SelectedItem.ToString();
            if ( cmb == "Título")
            {
                lbltitulo.Visible = true;
                lblautor.Visible = false;
            }
            else if(cmb == "Autor")
            {
                lblautor.Visible = true;
                lbltitulo.Visible = false;
            }
               
        }

        private void dgvlistadolibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
