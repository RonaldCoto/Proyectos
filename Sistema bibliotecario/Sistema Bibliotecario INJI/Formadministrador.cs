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
    public partial class Formadministrador : Form
    {
        public Formadministrador()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconmaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnbuscarlibro_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new categoria());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new Adminestudiantes());
        }

        private void btnperfil_Click(object sender, EventArgs e)
        {
            string usuario = lblusuario.Text;
            string contraseña = lblcontraseña.Text;
            //MessageBox.Show(usuario, contraseña);

          // AbrirForminPanel(new Actualizarperfilbibliotecaria(usuario,contraseña));

            Actualizarperfilbibliotecaria formularioactualizarbibiotecaria = new Actualizarperfilbibliotecaria();

            formularioactualizarbibiotecaria.lblusuario.Text = lblusuario.Text;
            formularioactualizarbibiotecaria.lblcontraseña.Text = lblcontraseña .Text;
            formularioactualizarbibiotecaria.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new creandobibliotecaria());
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panelcontenedor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForminPanel(new Editorial());
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void lblusuario_Click(object sender, EventArgs e)
        {

        }

        private void panelcontenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
