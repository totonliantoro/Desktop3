//**********************************************************************************
//Programmer: Toton Liantoro
//CIT Number: CIT241675
//Software: Microsoft Visual Studio 2022 Community Edition. 
//Platform: Microsoft Windows 11 Home (64-Bit)
//Purpose: Comply Assessment 3 (Help page), Subject: Apply advanced object-oriented language skills 
//**********************************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment3_Toton
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            this.Width = 700;
            this.Height = 500;
        }

        private void help_Click(object sender, EventArgs e)
        {
            FrmAbout form = new FrmAbout();
            form.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void formOneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOne frmOne = new FrmOne();
            frmOne.ShowDialog();
                
        }

        private void formTwoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTwo frmTwo = new FrmTwo();
            frmTwo.ShowDialog();
        }

        private void formThreeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmThree frmThree = new FrmThree();
            frmThree.ShowDialog();
        }
    }
}
