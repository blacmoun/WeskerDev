﻿using System;
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
    public partial class Frame_InFrontOfTheDoor : UserControl
    {
        public Frame_hall Usercontrol5;

        public Frame_InFrontOfTheDoor()
        {
            InitializeComponent();
            Usercontrol5 = new Frame_hall();
            Usercontrol5.Visible = false;
            Controls.Add(Usercontrol5);
        }
    }
}

