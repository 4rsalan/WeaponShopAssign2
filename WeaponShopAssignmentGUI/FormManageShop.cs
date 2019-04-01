using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaponShopAssignmentGUI
{
    public partial class FormManageShop : Form
    {
        FormMain fMain;

        public FormManageShop(FormMain F)
        {
            fMain = F;
            InitializeComponent();
            if (fMain.old_school_adv != null)
            {
                foreach (Label label in this.Controls.OfType<Label>())
                    label.Font = fMain.old_school_adv;
            }
        }
        
        //The Exit Button Label
        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Yellow;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.White;
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //

        //The "Add Weapon To Shop" Button Label
        private void ptbSword_MouseHover(object sender, EventArgs e)
        {
            lblText1.ForeColor = Color.Yellow;
        }

        private void ptbSword_MouseLeave(object sender, EventArgs e)
        {
            lblText1.ForeColor = Color.White;
        }

        private void ptbSword_Click(object sender, EventArgs e)
        {
            FormAddShop fAddShop = new FormAddShop(fMain);
            fAddShop.Show();
            this.Dispose(true);
        }
        //

        //The "Delete Weapon From Shop" Button Label
        private void ptbX_MouseHover(object sender, EventArgs e)
        {
            lblText2.ForeColor = Color.Yellow;
        }

        private void ptbX_MouseLeave(object sender, EventArgs e)
        {
            lblText2.ForeColor = Color.White;
        }

        private void ptbX_Click(object sender, EventArgs e)
        {
            FormDeleteShop fDeleteShop = new FormDeleteShop(fMain);
            fDeleteShop.Show();
            this.Dispose(true);
        }
        //

        //The "Buy Weapon From Shop" Button Label
        private void ptbCoin_MouseHover(object sender, EventArgs e)
        {
            lblText3.ForeColor = Color.Yellow;
        }

        private void ptbCoin_MouseLeave(object sender, EventArgs e)
        {
            lblText3.ForeColor = Color.White;
        }

        private void ptbCoin_Click(object sender, EventArgs e)
        {
            FormBuyShop fBuyShop = new FormBuyShop(fMain);
            fBuyShop.Show();
            this.Dispose(true);
        }
        //

        //The Back Button Label
        private void lblBack_MouseHover(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.Yellow;
        }

        private void lblBack_MouseLeave(object sender, EventArgs e)
        {
            lblBack.ForeColor = Color.White;
        }
        
        private void lblBack_Click(object sender, EventArgs e)
        {
            fMain.Show();
            this.Dispose(true);
        }
        //

        //When Form is forcably closed
        private void FormManageShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }// 
    }
}
