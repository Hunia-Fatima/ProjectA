using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExpandablePanelSample
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            Left = Top = 0;

            pnlMenuGroup1.Height = 25;
            pnlMenuGroup2.Height = 25;
            pnlMenuGroup3.Height = 25;
            pnlMenuGroup4.Height = 25;

            btnMenuGroup1.Image = Properties.Resources.down;
            btnMenuGroup2.Image = Properties.Resources.down;
            btnMenuGroup3.Image = Properties.Resources.down;
            btnMenuGroup4.Image = Properties.Resources.down;
        }

        private void btnMenuGroup1_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup1.Height == 25)
            {
                pnlMenuGroup1.Height = (25 *5);
                btnMenuGroup1.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup1.Height = 25;
                btnMenuGroup1.Image = Properties.Resources.down;
            }
        }

        private void btnMenuGroup2_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup2.Height == 25)
            {
                pnlMenuGroup2.Height = (25 * 3) + 2;
                btnMenuGroup2.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup2.Height = 25;
                btnMenuGroup2.Image = Properties.Resources.down;
            }
        }

        private void btnMenuGroup3_Click(object sender, EventArgs e)
        {
            if (pnlMenuGroup3.Height == 25)
            {
                pnlMenuGroup3.Height = (25 * 3) + 2;
                btnMenuGroup3.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup3.Height = 25;
                btnMenuGroup3.Image = Properties.Resources.down;
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AddStudent frmChild = new AddStudent();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            if (pnlMenuGroup4.Height == 25)
            {
                pnlMenuGroup4.Height = (25 * 3) + 2;
                btnMenuGroup4.Image = Properties.Resources.up;
            }
            else
            {
                pnlMenuGroup4.Height = 25;
                btnMenuGroup4.Image = Properties.Resources.down;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            StudentData frmChild = new StudentData();
            frmChild.MdiParent = this;
            frmChild.Show();
        }
    }
}
