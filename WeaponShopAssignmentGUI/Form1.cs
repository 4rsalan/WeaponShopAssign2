using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeaponShopAssignmentGUI
{
    public partial class FormMain : Form
    {
        

        // */
        public Shop weaponShop { get; private set; }
        public Player player { get; private set; }

        FormManageShop FManageShop;
        FormPlayerInfo FPlayerInfo;

        public Font old_school_adv;

        public FormMain()
        {
            InitializeComponent();
            try
            {
                // Load Custom Font
                string dir = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\")) + "Resources\\Old School Adventures.ttf";
                PrivateFontCollection font_collection_OSA = new PrivateFontCollection();
                font_collection_OSA.AddFontFile(dir);
                old_school_adv = new Font(font_collection_OSA.Families[0], 18, FontStyle.Regular);

                foreach (Label label in this.Controls.OfType<Label>())
                    label.Font = old_school_adv;
            } catch(Exception ex)
            {
                //no cool font ):
            }
            weaponShop = new Shop();
            player = null;
            // seed shop
            weaponShop.AddToStore("Long Sword", 1, 8, 4.0, 15, 7);
            weaponShop.AddToStore("Short Sword", 1, 6, 2.5, 10, 9);
            weaponShop.AddToStore("Battle Axe", 1, 8, 5, 10, 6);
            weaponShop.AddToStore("Boar Spear", 2, 6, 3, 3, 8);
            weaponShop.AddToStore("Glaive", 2, 10, 5.0, 12, 5);
            weaponShop.AddToStore("War Hammer", 1, 8, 4.5, 12, 3);
            weaponShop.AddToStore("Mace", 1, 6, 4.5, 8, 10);
            weaponShop.AddToStore("Crossbow", 50, 8, 3.5, 15, 6);
            weaponShop.AddToStore("Long Bow", 50, 8, 2.0, 12, 7);
            weaponShop.AddToStore("Short Bow", 30, 6, 1.5, 9, 6);
            weaponShop.AddToStore("Halberd", 2, 10, 5.0, 12, 2);
            weaponShop.AddToStore("Pike", 3, 8, 3.5, 10, 10);
            weaponShop.AddToStore("Lance", 2, 8, 2.5, 15, 4);
            weaponShop.AddToStore("Pole Axe", 2, 10, 5.0, 12, 2);
            weaponShop.AddToStore("Great Sword", 1, 12, 4.5, 18, 6);
            weaponShop.AddToStore("Morning Star", 1, 8, 4.0, 12, 4);
            weaponShop.AddToStore("Rapier", 1, 6, 2.5, 16, 3);
            weaponShop.AddToStore("Trident", 2, 6, 3, 12, 2);
            weaponShop.AddToStore("Javalin", 15, 6, 1.0, 2, 18);
            weaponShop.AddToStore("Daggar", 1, 4, 1.0, 3, 13);
            weaponShop.AddToStore("Arbalast", 65, 10, 4.0, 18, 1);
        }

        //Loads up the second part of the Main Page
        public void FormLoadUp()
        {
            lblText0.Visible = false;
            txtPlayerName.Visible = false;
            lblConfirm.Visible = false;
            lblText1.Visible = true;
            lblText2.Visible = true;
            lblText3.Visible = true;
            ptbCoin.Visible = true;
            ptbBackpack.Visible = true;
        }

        //The Confirm Button Label
        private void lblConfirm_MouseHover(object sender, EventArgs e)
        {
            lblConfirm.ForeColor = Color.Yellow;
        }

        private void lblConfirm_MouseLeave(object sender, EventArgs e)
        {
            lblConfirm.ForeColor = Color.White;
        }

        private void lblConfirm_Click(object sender, EventArgs e)
        {
            if (txtPlayerName.Text == "")
                lblText0.Text = "You MUST enter a player name:";
            else
            {
                player = new Player(txtPlayerName.Text, 100);
                //playerName = txtPlayerName.Text;
                FormLoadUp();
            }
        }
        //

        //The "Manage Player" Button Label
        private void ptbCoin_MouseHover(object sender, EventArgs e)
        {
            lblText2.ForeColor = Color.Yellow;
        }

        private void ptbCoin_MouseLeave(object sender, EventArgs e)
        {
            lblText2.ForeColor = Color.White;
        }

        private void ptbCoin_Click(object sender, EventArgs e)
        {
            FManageShop = new FormManageShop(this);
            FManageShop.Show();
            this.Hide();
        }
        //

        //The "Visit Shop" Button Label
        private void ptbBackpack_MouseHover(object sender, EventArgs e)
        {
            lblText3.ForeColor = Color.Yellow;
        }

        private void ptbBackpack_MouseLeave(object sender, EventArgs e)
        {
            lblText3.ForeColor = Color.White;
        }

        private void ptbBackpack_Click(object sender, EventArgs e)
        {
            FPlayerInfo = new FormPlayerInfo(this);
            FPlayerInfo.Show();
            this.Hide();
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

        //When the Form Loads
        private void FormMain_Load(object sender, EventArgs e)
        {
            if (player != null)
                FormLoadUp();
        }

        //When Form is forcably closed
        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
