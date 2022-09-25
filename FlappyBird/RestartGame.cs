using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBird
{
    public partial class RestartGame : Form
    {
        public RestartGame()
        {
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            WindowState = FormWindowState.Maximized;
            InitializeComponent();

        }

        private void start_Click(object sender, EventArgs e)
        {
            Form1 newGame = new Form1();
            newGame.Show();
            this.Close();
        }
    }
}
