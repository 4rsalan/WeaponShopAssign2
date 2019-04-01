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
    public partial class FormFindWeapon : Form
    {
        FormMain fMain;
        FormPlayerInfo fPlayerInfo;

        public FormFindWeapon(FormMain F)
        {
            fMain = F;
            InitializeComponent();
            lblWeaponInfo.Visible = false;
            txtCurrentWeapons.Text = fMain.player.printBackpack();
            if (fMain.old_school_adv != null)
            {
                foreach (Label label in this.Controls.OfType<Label>())
                    label.Font = fMain.old_school_adv;
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
            fPlayerInfo = new FormPlayerInfo(fMain);
            fPlayerInfo.Show();
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

         //The Find Weapon Button Label
        private void lblFindWeapon_Click(object sender, EventArgs e)
        {
            Weapon weapon = fMain.player.SearchBackpack(txtWeaponName.Text);
            lblWeaponInfo.Visible = true;
            if (weapon == null)
                lblWeaponInfo.Text = "Can't Find That";
            else
                lblWeaponInfo.Text = weapon.toString();
        }

        private void lblFindWeapon_MouseHover(object sender, EventArgs e)
        {
            lblFindWeapon.ForeColor = Color.Yellow;
        }

        private void lblFindWeapon_MouseLeave(object sender, EventArgs e)
        {
            lblFindWeapon.ForeColor = Color.White;
        }
        //

        //When the Form is forcably closed
        private void FormFindWeapon_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        //
    }
}
