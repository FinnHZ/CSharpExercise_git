using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS
{
    public partial class SelfNaveBar : UserControl
    {
        static System.Windows.Forms.Timer btnMoveTimer = new Timer();
        static int moveCount = 0;
        static bool isOpenBtn1 = false;
        static UserControl1 ucAnother = null;


        public SelfNaveBar()
        {
            InitializeComponent();
            btnMoveTimer.Tick += new EventHandler(moveAction);
            btnMoveTimer.Interval = 1;
            //ucAnother = new UserControl1();
            //this.Controls.Add(ucAnother);

        }

        private void navBtnMove_Click(object sender, EventArgs e)
        {
            btnMoveTimer.Start();
            if (!isOpenBtn1)
            {
                isOpenBtn1 = true;
            }
            else
            {
                isOpenBtn1 = false;
            }
        }


        public void moveAction(Object myObject, EventArgs myEventArgs)
        {
            int moveStep = 2;
            int moveMax = 50 / moveStep;

            if (isOpenBtn1)
            {
                beMovedBtn.Location = new Point(beMovedBtn.Location.X, beMovedBtn.Location.Y + moveStep);
                moveCount += 1;
                if (moveCount >= moveMax)
                {
                    btnMoveTimer.Stop();
                }
            }
            else { 
                beMovedBtn.Location = new Point(beMovedBtn.Location.X, beMovedBtn.Location.Y - moveStep);
                moveCount -= 1;
                if (moveCount <= 0)
                {
                    btnMoveTimer.Stop();
                }
            };



        }

        private void hideBtn1_Click(object sender, EventArgs e)
        {
            this.ParentForm.BackColor = Color.Yellow;
        }
    }
}
