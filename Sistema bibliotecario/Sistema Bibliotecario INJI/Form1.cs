using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Sistema_Bibliotecario_INJI
{
    public partial class Form1 : Form
    {
        MostrarLibros moslg = new MostrarLibros();
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport ("user32.DLL", EntryPoint ="SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnslide_Click(object sender, EventArgs e)
        {
            if (Menuvertical.Width == 250)
            {
                Menuvertical.Width = 77;
                pictureBox1.Width = 66;
            }
            else
            {
                Menuvertical.Width = 250;
                pictureBox1.Width = 223;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }


        private void AbrirForminPanel(object formhijo)
        {
            if (this.panelcontenedor.Controls.Count > 0)
                this.panelcontenedor.Controls.RemoveAt(0);
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelcontenedor.Controls.Add(fh);
            this.panelcontenedor.Tag = fh;
            fh.Show();
        }
        private void btnbuscarlibro_Click(object sender, EventArgs e)
        {
           // AbrirForminPanel(new Buscarlibro());
            string usuario = lblusuario.Text;
            string contraseña = lblcontraseña.Text;
            //MessageBox.Show(usuario, contraseña);

            // AbrirForminPanel(new Actualizarperfilbibliotecaria(usuario,contraseña));

            Buscarlibro bl = new Buscarlibro();

            bl.lblusuariobl.Text = lblusuario.Text;
            bl.ShowDialog();



            //MessageBox.Show(usuario, contraseña);

            // AbrirForminPanel(new Actualizarperfilbibliotecaria(usuario,contraseña));






        }

        private void btningresarlibro_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new RegistrarLibro());
        }

        private void btnperfil_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new CrearPerfilAlumno());
        }

        private void btnactualizarlibro_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new ActualizarLibro());
           
        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void btndevolucion_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new Devoluciones());
        }

        private void btnadministrar_Click(object sender, EventArgs e)
        {
            Formadministrador frmadmin = new Formadministrador();
            frmadmin.lblusuario.Text = lblusuario.Text;
            frmadmin.lblcontraseña.Text = lblcontraseña.Text;
            this.Hide();
            frmadmin.ShowDialog();
            this.Show();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menuvertical_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menuvertical_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelcontenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
