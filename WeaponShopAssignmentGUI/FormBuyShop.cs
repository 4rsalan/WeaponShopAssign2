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
    public partial class FormBuyShop : Form
    {
        FormMain FMain;
        FormManageShop FManageShop;

        public FormBuyShop(FormMain F)
        {
            FMain = F;
            InitializeComponent();

            lblMoney.Text = Convert.ToString(FMain.player.money);
            txtCurrentWeapons.Text = FMain.weaponShop.PrintInOrder();
            lblWeaponMessage.Visible = false;

            if (FMain.old_school_adv != null)
            {
                foreach (Label label in this.Controls.OfType<Label>())
                    label.Font = FMain.old_school_adv;
            }
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

        //The Buy Weapon Button Label
        private void lblBuyWeapon_Click(object sender, EventArgs e)
        {
            Weapon weapon = FMain.weaponShop.Search(txtWeaponName.Text);
            lblWeaponMessage.Visible = true;
            if (weapon == null)
            {
                lblWeaponMessage.Text = "We are all Sold Out of That";
                return;
            }
            lblWeaponMessage.Text = FMain.player.buyFromShop(FMain.weaponShop, weapon, 1);
            lblMoney.Text = Convert.ToString(FMain.player.money);
            txtCurrentWeapons.Text = FMain.weaponShop.PrintInOrder();
        }

        private void lblBuyWeapon_MouseHover(object sender, EventArgs e)
        {
            lblBuyWeapon.ForeColor = Color.Yellow;
        }

        private void lblBuyWeapon_MouseLeave(object sender, EventArgs e)
        {
            lblBuyWeapon.ForeColor = Color.White;
        }
        //

        private void FormBuyShop_Load(object sender, EventArgs e)
        {

        }

        private void FormBuyShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblWeaponMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
