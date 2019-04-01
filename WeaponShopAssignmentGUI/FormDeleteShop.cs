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
    public partial class FormDeleteShop : Form
    {
        FormManageShop FManageShop;
        FormMain FMain;

        public FormDeleteShop(FormMain F)
        {
            FMain = F;
            InitializeComponent();

            lblDeleteMessage.Visible = false;
            txtCurrentWeapons.Text = FMain.weaponShop.PrintInOrder();
            if (FMain.old_school_adv != null)
            {
                foreach (Label label in this.Controls.OfType<Label>())
                    label.Font = FMain.old_school_adv;
            }
        }

        //(Accident)
        private void FormDeleteShop_MouseHover(object sender, EventArgs e)
        {
            
        }

        //The Delete Weapon Button Label
        private void lblDeleteWeapon_MouseHover(object sender, EventArgs e)
        {
            lblDeleteWeapon.ForeColor = Color.Yellow;
        }

        private void lblDeleteWeapon_MouseLeave(object sender, EventArgs e)
        {
            lblDeleteWeapon.ForeColor = Color.White;
        }

        private void lblDeleteWeapon_Click(object sender, EventArgs e)
        {
            lblDeleteMessage.Visible = true;
            if (FMain.weaponShop.deleteNode(txtWeaponName.Text))
                lblDeleteMessage.Text = "Weapon melted into slag";
            else
                lblDeleteMessage.Text = "Can't find that";
        }

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
            FManageShop = new FormManageShop(FMain);
            FManageShop.Show();
            this.Dispose();
        }
        //

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

        //When Form is Forcably closed
        private void FormDeleteShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
