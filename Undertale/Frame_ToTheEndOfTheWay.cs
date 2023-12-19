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
    public partial class Frame_ToTheEndOfTheWay : UserControl
    {

        public Frame_EntrenceMarket usercontrol13;
        public Frame_ToTheEndOfTheWay()
        {
            InitializeComponent();

            usercontrol13 = new Frame_EntrenceMarket();
            usercontrol13.Visible = false;
            Controls.Add(usercontrol13);
        }

        private void Button_EnterInTheMarket_Click(object sender, EventArgs e)
        {
            Game parentForm = this.FindForm() as Game;
            if (parentForm != null)
            {
                parentForm.Invoke(new Action(() =>
                {

                    parentForm.EnterName_pictureBox.Visible = false;
                    parentForm.TextBox_EnterName.Visible = false;


                }));
            }

            Choice_Dungeon secondForm = new Choice_Dungeon();
            if (secondForm != null)
            {
                secondForm.ButtonEnterDungeon.Visible = false;
                secondForm.Button_exit_dungeon.Visible = false;
                Button_EnterInTheMarket.Visible = false;
                usercontrol13.Visible=true;
            }

        }
    }
}
