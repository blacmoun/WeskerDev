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
    public partial class Frame_ContinueAlone : UserControl
    {
        public Frame_cryAroundTheFire userControl9;
        public Frame_ToTheEndOfTheWay userControl10;


        public Frame_ContinueAlone()
        {
            InitializeComponent();
            userControl9 = new Frame_cryAroundTheFire();
            userControl9.Visible = false;
            Controls.Add(userControl9);

            userControl10 = new Frame_ToTheEndOfTheWay();
            userControl10.Visible = false;
            Controls.Add(userControl10);
        }

        private void Button_ContinueToTheEnd_Click(object sender, EventArgs e)
        {

        }
    }
}
