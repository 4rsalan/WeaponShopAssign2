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
    public partial class FormAddShop : Form
    {
        FormManageShop FManageShop;
        FormMain FMain;

        public FormAddShop(FormMain F)
        {
            FMain = F;
            InitializeComponent();

            txtCurrentWeapons.Text = FMain.weaponShop.PrintInOrder();

            lblWeaponNameError.Visible = false;
            lblWeightError.Visible = false;
            lblCostError.Visible = false;
            lblDamageError.Visible = false;
            lblRangeError.Visible = false;
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
        private void lblExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblExit_MouseHover(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.Yellow;
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            lblExit.ForeColor = Color.White;
        }
        //

        //When the Form is Forcably Closed
        private void FormAddShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //The Add Weapon Button Label
        private void lblAddWeapon_MouseHover(object sender, EventArgs e)
        {
            lblAddWeapon.ForeColor = Color.Yellow;
        }

        private void lblAddWeapon_MouseLeave(object sender, EventArgs e)
        {
            lblAddWeapon.ForeColor = Color.White;
        }

        private void lblAddWeapon_Click(object sender, EventArgs e)
        {
            bool valid = true;
            string name = txtWeaponName.Text;
            int range;
            int damage;
            double weight;
            double cost;
            lblWeaponNameError.Visible = false;
            lblWeightError.Visible = false;
            lblCostError.Visible = false;
            lblDamageError.Visible = false;
            lblRangeError.Visible = false;
            //Validation
            if (name == "")
            {
                lblWeaponNameError.Visible = true;
                valid = false;
            }
            if (!int.TryParse(txtRange.Text, out range))
            {
                lblRangeError.Visible = true;
                valid = false;
            }
            if (!int.TryParse(txtDamage.Text, out damage))
            {
                lblDamageError.Visible = true;
                valid = false;
            }
            if (!double.TryParse(txtWeight.Text, out weight))
            {
                lblWeightError.Visible = true;
                valid = false;
            }
            if (!double.TryParse(txtCost.Text, out cost))
            {
                lblCostError.Visible = true;
                valid = false;
            }
            if (valid)
            {
                FMain.weaponShop.AddToStore(name, range, damage, weight, cost, 1);
                txtCurrentWeapons.Text = FMain.weaponShop.PrintInOrder();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
