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
    public partial class Frame_LivingRoom : UserControl
    {
        public Frame_kitchen userControl8;

        public Frame_LivingRoom()
        {
            InitializeComponent();
            userControl8 = new Frame_kitchen();
            userControl8.Visible = false;
            Controls.Add(userControl8);
        }
    }
}
