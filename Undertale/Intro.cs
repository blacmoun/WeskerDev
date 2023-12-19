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
    public partial class Intro : UserControl
    {


        public Choice_Dungeon userControl1;

        public Intro()
        {
            InitializeComponent();

            userControl1 = new Choice_Dungeon();
            userControl1.Visible = false;
            Controls.Add(userControl1);

            userControl1.Enabled = false;

        }

        private void button_skip_Click(object sender, EventArgs e)
        {

        }
    }
}
