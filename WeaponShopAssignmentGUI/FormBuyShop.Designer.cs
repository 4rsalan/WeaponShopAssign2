namespace WeaponShopAssignmentGUI
{
    partial class FormBuyShop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuyShop));
            this.lblText0 = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.txtCurrentWeapons = new System.Windows.Forms.TextBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblText3 = new System.Windows.Forms.Label();
            this.txtWeaponName = new System.Windows.Forms.TextBox();
            this.lblBuyWeapon = new System.Windows.Forms.Label();
            this.lblWeaponMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText0
            // 
            this.lblText0.BackColor = System.Drawing.Color.Transparent;
            this.lblText0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText0.ForeColor = System.Drawing.Color.DarkGray;
            this.lblText0.Location = new System.Drawing.Point(321, 9);
            this.lblText0.Name = "lblText0";
            this.lblText0.Size = new System.Drawing.Size(628, 41);
            this.lblText0.TabIndex = 6;
            this.lblText0.Text = "Welcome To The Shop!";
            this.lblText0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText1
            // 
            this.lblText1.BackColor = System.Drawing.Color.Transparent;
            this.lblText1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblText1.Location = new System.Drawing.Point(12, 78);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(496, 56);
            this.lblText1.TabIndex = 31;
            this.lblText1.Text = "Weapons For Sale:";
            this.lblText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentWeapons
            // 
            this.txtCurrentWeapons.Enabled = false;
            this.txtCurrentWeapons.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentWeapons.Location = new System.Drawing.Point(35, 137);
            this.txtCurrentWeapons.Multiline = true;
            this.txtCurrentWeapons.Name = "txtCurrentWeapons";
            this.txtCurrentWeapons.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCurrentWeapons.Size = new System.Drawing.Size(438, 473);
            this.txtCurrentWeapons.TabIndex = 32;
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBack.Location = new System.Drawing.Point(12, 613);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(155, 60);
            this.lblBack.TabIndex = 33;
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseLeave += new System.EventHandler(this.lblBack_MouseLeave);
            this.lblBack.MouseHover += new System.EventHandler(this.lblBack_MouseHover);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExit.Location = new System.Drawing.Point(966, 613);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(159, 57);
            this.lblExit.TabIndex = 34;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // lblText2
            // 
            this.lblText2.BackColor = System.Drawing.Color.Transparent;
            this.lblText2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.ForeColor = System.Drawing.Color.DarkGray;
            this.lblText2.Location = new System.Drawing.Point(878, 78);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(162, 56);
            this.lblText2.TabIndex = 35;
            this.lblText2.Text = "Money:";
            this.lblText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMoney
            // 
            this.lblMoney.BackColor = System.Drawing.Color.Transparent;
            this.lblMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.ForeColor = System.Drawing.Color.Gold;
            this.lblMoney.Location = new System.Drawing.Point(1046, 80);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(162, 56);
            this.lblMoney.TabIndex = 36;
            this.lblMoney.Text = "{}";
            this.lblMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText3
            // 
            this.lblText3.BackColor = System.Drawing.Color.Transparent;
            this.lblText3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText3.ForeColor = System.Drawing.Color.DarkGray;
            this.lblText3.Location = new System.Drawing.Point(595, 184);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(546, 113);
            this.lblText3.TabIndex = 38;
            this.lblText3.Text = "Specify the Weapon Name to Buy";
            this.lblText3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWeaponName
            // 
            this.txtWeaponName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeaponName.Location = new System.Drawing.Point(591, 344);
            this.txtWeaponName.Name = "txtWeaponName";
            this.txtWeaponName.Size = new System.Drawing.Size(562, 40);
            this.txtWeaponName.TabIndex = 39;
            // 
            // lblBuyWeapon
            // 
            this.lblBuyWeapon.BackColor = System.Drawing.Color.Transparent;
            this.lblBuyWeapon.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyWeapon.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBuyWeapon.Location = new System.Drawing.Point(701, 396);
            this.lblBuyWeapon.Name = "lblBuyWeapon";
            this.lblBuyWeapon.Size = new System.Drawing.Size(361, 62);
            this.lblBuyWeapon.TabIndex = 40;
            this.lblBuyWeapon.Text = "Buy Weapon";
            this.lblBuyWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBuyWeapon.Click += new System.EventHandler(this.lblBuyWeapon_Click);
            this.lblBuyWeapon.MouseLeave += new System.EventHandler(this.lblBuyWeapon_MouseLeave);
            this.lblBuyWeapon.MouseHover += new System.EventHandler(this.lblBuyWeapon_MouseHover);
            // 
            // lblWeaponMessage
            // 
            this.lblWeaponMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeaponMessage.ForeColor = System.Drawing.Color.Red;
            this.lblWeaponMessage.Location = new System.Drawing.Point(479, 458);
            this.lblWeaponMessage.Name = "lblWeaponMessage";
            this.lblWeaponMessage.Size = new System.Drawing.Size(773, 50);
            this.lblWeaponMessage.TabIndex = 41;
            this.lblWeaponMessage.Text = "<massage>";
            this.lblWeaponMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWeaponMessage.Click += new System.EventHandler(this.lblWeaponMessage_Click);
            // 
            // FormBuyShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeaponShopAssignmentGUI.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblWeaponMessage);
            this.Controls.Add(this.lblBuyWeapon);
            this.Controls.Add(this.txtWeaponName);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.lblMoney);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.txtCurrentWeapons);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblText0);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBuyShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buy Weapon From Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBuyShop_FormClosed);
            this.Load += new System.EventHandler(this.FormBuyShop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText0;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.TextBox txtCurrentWeapons;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.TextBox txtWeaponName;
        private System.Windows.Forms.Label lblBuyWeapon;
        private System.Windows.Forms.Label lblWeaponMessage;
    }
}