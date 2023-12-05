using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Undertale
{
    public partial class Game : Form
    {
        private UserControl1 userControl1;
        public Game()
        {
            InitializeComponent();
            userControl1= new UserControl1();
            userControl1.Visible = false;
            Controls.Add(userControl1);

        }
        public void InitializeTimer()
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            userControl1.Visible = true;
            rjButton1.Visible = false;
            pictureBox1.Visible = false;

        }
    }
}
