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
    
    public partial class Buscarlibro : Form
    {
        
        MostrarLibros objetomostrarlb = new MostrarLibros();
        public Buscarlibro()
        {
            InitializeComponent();
        }
        private void ListarPorCategoria()
        {
            ConsultasLibros buscarporcategoria = new ConsultasLibros();

            dgvbusquedalibro.DataSource = buscarporcategoria.ListarPorCategoria(cmbcatego.Text);
        }
        private void ListarPorTitulo()
        {
            ConsultasLibros buscarportitulo = new ConsultasLibros();

            dgvbusquedalibro.DataSource = buscarportitulo.ListarPorTitulo(txtbusqueda.Text);
        }

        private void ListarPorAutor()
        {
            ConsultasLibros buscarporautor = new ConsultasLibros();

            dgvbusquedalibro.DataSource = buscarporautor.ListarPorAutor(txtbusqueda.Text);
        }
        private void ListarPorEditorial()
        {
            ConsultasLibros buscarporeditorial = new ConsultasLibros();

            dgvbusquedalibro.DataSource = buscarporeditorial.ListarPorEditorial(cmbeditorial.Text);
        }
        private void listarcat()
        {
            ConsultasLibros listargr = new ConsultasLibros();
            cmbcatego.DataSource = listargr.ListarCategorias();
            cmbcatego.DisplayMember = "Nombre";
            cmbcatego.ValueMember = "IDcategoria";

        }

        private void listaredi()
        {
            ConsultasLibros listargr = new ConsultasLibros();
            cmbeditorial.DataSource = listargr.ListarEditorial();
            cmbeditorial.DisplayMember = "Nombre";
            cmbeditorial.ValueMember = "IDdistribucion";

        }
        private void Buscarlibro_Load(object sender, EventArgs e)
        {
            
            cmb_buscarpor.SelectedIndex = 0;
            listarcat();
            listaredi();

        }

        private void lblcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnprestamo_Click(object sender, EventArgs e)
        {



            
            
            
            string codigo, titulo, autor, editorial, pais, categoria, distribucion;
            string stock, usuario;

            //IDlibro as Código, Titulo , Nombrecompleto as Autor ,Editorial , Stock , Ubicacion as Pais ,Categorias.Nombre as Categoria , Distribuciones.Nombre as Distribucion
            if (dgvbusquedalibro.SelectedRows.Count > 0)
            {
                stock = dgvbusquedalibro.CurrentRow.Cells["Stock"].Value.ToString();
                
                    if (Convert.ToInt32(stock) > 0)
                {
                    codigo = dgvbusquedalibro.CurrentRow.Cells["Código"].Value.ToString();
                    titulo = dgvbusquedalibro.CurrentRow.Cells["Titulo"].Value.ToString();
                    autor = dgvbusquedalibro.CurrentRow.Cells["Autor"].Value.ToString();
                    editorial = dgvbusquedalibro.CurrentRow.Cells["Editorial"].Value.ToString();
                    stock = dgvbusquedalibro.CurrentRow.Cells["Stock"].Value.ToString();
                    pais = dgvbusquedalibro.CurrentRow.Cells["País"].Value.ToString();
                    categoria = dgvbusquedalibro.CurrentRow.Cells["Categoría"].Value.ToString();
                    distribucion = dgvbusquedalibro.CurrentRow.Cells["Distribución"].Value.ToString();
                    usuario = lblusuariobl.Text;


                    Prestamolibro formac = new Prestamolibro();
                    formac.txtcodigopres.Text = codigo;
                    formac.txtautorpres.Text = autor;
                    formac.txtnombrelibpres.Text = titulo;
                    formac.txtcatepres.Text = categoria;
                    formac.txtdispres.Text = distribucion;
                    formac.txtpaispres.Text = pais;
                    formac.txteditorialpres.Text = editorial;
                    formac.texuser.Text = usuario;
                    //formac.cmbgradoactu.SelectedValue = Idgrad;

                    this.Hide();
                    formac.ShowDialog();

                    this.Show();


                }else
                {
                    MessageBox.Show("No hay copias de este libro", "Realizando prestamo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }





            }
            else
            {
                MessageBox.Show("Seleccione el libro a prestar");
            }
        }

        private void txtbusqueda_Validated(object sender, EventArgs e)
        {
            string busqueda = txtbusqueda.Text;

            if (string.IsNullOrEmpty(busqueda))
            {
                errorProvider1.SetError(txtbusqueda, "Por favor llene el campo");
            }
            else
                errorProvider1.Clear();

        }

      

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            if (cmb_buscarpor.SelectedItem.ToString() == "Categoría")
            {
                dgvbusquedalibro.DataSource = null;

                ListarPorCategoria();

            }else if (cmb_buscarpor.SelectedItem.ToString() == "Nombre")
            {
                dgvbusquedalibro.DataSource = null;

                ListarPorTitulo();
            }
            else if (cmb_buscarpor.SelectedItem.ToString() == "Autor")
            {
                dgvbusquedalibro.DataSource = null;

                ListarPorAutor();
            }
            else if (cmb_buscarpor.SelectedItem.ToString() == "Distribución")
            {
                dgvbusquedalibro.DataSource = null;

                ListarPorEditorial();
            }


        }

        private void cmb_buscarpor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_buscarpor.SelectedItem.ToString() == "Categoría")
            {
                cmbcatego.Visible = true;
                cmbeditorial.Visible = false;
                txtbusqueda.Visible = false;

            }
            else if (cmb_buscarpor.SelectedItem.ToString() == "Distribución")
            {
                cmbeditorial.Visible = true;
                cmbcatego.Visible = false;
                txtbusqueda.Visible = false;
            }
            else
            {
                txtbusqueda.Visible = true;
                cmbeditorial.Visible = false;
                cmbcatego.Visible = false;

            }
        }

        private void dgvbusquedalibro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
