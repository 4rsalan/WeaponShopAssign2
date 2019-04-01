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
    public partial class FormPlayerInfo : Form
    {
        FormFindWeapon fFindWeapon;
        FormMain fMain;

        public FormPlayerInfo(FormMain F)
        {
            fMain = F;
            InitializeComponent();
            txtCurrentWeapons.Text = fMain.player.printBackpack();
            txtPlayerName.Text = fMain.player.name;
            lblMoney.Text = Convert.ToString( fMain.player.money);
            lblPlayerWeight.Text = $"{Convert.ToString(fMain.player.backpack.presentWeight)} / {Convert.ToString(fMain.player.backpack.maxWeight)}";
            if (fMain.old_school_adv != null)
            {
                foreach (Label label in this.Controls.OfType<Label>())
                    label.Font = fMain.old_school_adv;
            }
        }

        private void FormPlayerInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //The Find Weapon Button Label
        private void ptbSword_MouseHover(object sender, EventArgs e)
        {
            lblFindWeapon.ForeColor = Color.Yellow;
        }

        private void ptbSword_MouseLeave(object sender, EventArgs e)
        {
            lblFindWeapon.ForeColor = Color.White;
        }

        private void ptbSword_Click(object sender, EventArgs e)
        {
            fFindWeapon = new FormFindWeapon(fMain);
            fFindWeapon.Show();
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
    }
}
