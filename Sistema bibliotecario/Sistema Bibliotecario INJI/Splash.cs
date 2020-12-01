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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        public int timeLeft { get; set; }

        private void Splash_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;

            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;

            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;

            label5.Parent = pictureBox1;
            label5.BackColor = Color.Transparent;

            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;

            timeLeft = 25;
            tiempo.Start();
        }

        private void tiempo_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
            }
            else
            {
                tiempo.Stop();
                new Login().Show();
                this.Hide();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
