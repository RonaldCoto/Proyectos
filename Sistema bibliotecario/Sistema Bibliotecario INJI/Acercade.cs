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
    public partial class Acercade : Form
    {
        public Acercade()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }
    }
}
