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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Load += Form1_Load;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            SetActivePanel(userControl11);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetActivePanel(userControl11);
        }

        public void SetActivePanel(UserControl controlObj)
        {
            userControl11.Visible = false;
            userControl21.Visible = false;
            controlObj.Visible = true;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SetActivePanel(userControl21);
        }
    }
}
