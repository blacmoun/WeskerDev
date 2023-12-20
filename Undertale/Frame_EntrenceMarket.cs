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
    public partial class Frame_EntrenceMarket : UserControl
    {
        public ArroundTheMarket usercontrol;
        public Frame_EntrenceMarket()
        {
            InitializeComponent();

            usercontrol = new ArroundTheMarket();
            usercontrol.Visible = false;
            Controls.Add(usercontrol);

            
        }

        private void Button_GoArroud_Click(object sender, EventArgs e)
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
            }

            Frame_TalkToGoatInDungeon thirdForm = new Frame_TalkToGoatInDungeon();
            if (thirdForm != null)
            {
                Button_GoArroud.Visible = false;
                usercontrol.Visible=true;
                thirdForm.Button_ContinueAlone.Visible = false;
                thirdForm.Button_FollowTheGoat_TalkToGoat.Visible = false;

                
            }

        }
    }
}
