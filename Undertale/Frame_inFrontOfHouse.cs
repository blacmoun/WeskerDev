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
    public partial class Frame_inFrontOfHouse : UserControl
    {
        public Frame_InFrontOfTheDoor userControl4;

        public Frame_inFrontOfHouse()
        {
            InitializeComponent();
            userControl4 = new Frame_InFrontOfTheDoor();
            userControl4.Visible = false;
            Controls.Add(userControl4);
        }
    }
}
