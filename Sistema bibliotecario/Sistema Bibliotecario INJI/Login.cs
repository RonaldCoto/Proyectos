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
using System.Data;
using System.Data.SqlClient;

namespace Sistema_Bibliotecario_INJI
{
    public partial class Login : Form

    {
        SesionBibliotecario sesion = new Sistema_Bibliotecario_INJI.SesionBibliotecario();
        public Login()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Gray;
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            if (txtpassword.Text == "CONTRASEÑA")
            {
                txtpassword.Text = "";
                txtpassword.ForeColor = Color.Black;
                txtpassword.UseSystemPasswordChar = true;
            }
        }

        private void txtpassword_Leave(object sender, EventArgs e)
        {
            if (txtpassword.Text == "")
            {
                txtpassword.Text = "CONTRASEÑA";
                txtpassword.ForeColor = Color.Gray;
                txtpassword.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            MostrarLibros moslg = new MostrarLibros();
            SqlDataReader loguear;
            moslg.Usuario = txtuser.Text;
            moslg.Contraseña = txtpassword.Text;

          
            if (moslg.Usuario == txtuser.Text)
            {
                label2.Visible = false;

                if (moslg.Contraseña == txtpassword.Text)
                {
                    label3.Visible = false;

                    loguear = moslg.Iniciarsesion();
                if (loguear.Read() == true)
                {
                        
                        
                        //SqlDataReader id;
                        //id = moslg.ObtenerID();
                        //MessageBox.Show("msg del login ", sesion.Idbibliotecario );
                      

                    Form1 frm1 = new Form1();
                       
                        frm1.lblusuario.Text = txtuser.Text;
                        frm1.lblcontraseña.Text = txtpassword.Text;

                        



                    this.Hide();
                   frm1.ShowDialog();
                    this.Close();
                        
                    }
                else

                    {
                        label4.Text = "Usuario o contraseña erroneos, intentelo de nuevo";
                        label4.Visible = true;
						txtuser.Text = "";
                        txtpassword.Text = "";
                        txtpassword_Leave(null, e);
                        txtuser.Focus();
                    }
                

            }
                else
                {
                    label3.Text = moslg.Contraseña;
                    label3.Visible = true;
                }
                
            
        }
            else {
                label2.Text = moslg.Usuario;
                label2.Visible = true;
            }
            
        }




        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Acercade acr = new Acercade();
            acr.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
