namespace WeaponShopAssignmentGUI
{
    partial class FormManageShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManageShop));
            this.lblText0 = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblText3 = new System.Windows.Forms.Label();
            this.ptbSword = new System.Windows.Forms.PictureBox();
            this.ptbX = new System.Windows.Forms.PictureBox();
            this.ptbCoin = new System.Windows.Forms.PictureBox();
            this.lblBack = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbSword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblText0
            // 
            this.lblText0.BackColor = System.Drawing.Color.Transparent;
            this.lblText0.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText0.ForeColor = System.Drawing.Color.DarkGray;
            this.lblText0.Location = new System.Drawing.Point(226, 9);
            this.lblText0.Name = "lblText0";
            this.lblText0.Size = new System.Drawing.Size(802, 70);
            this.lblText0.TabIndex = 4;
            this.lblText0.Text = "Choose an Option for the Shop:";
            this.lblText0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExit.Location = new System.Drawing.Point(1081, 614);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(171, 49);
            this.lblExit.TabIndex = 9;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // lblText1
            // 
            this.lblText1.BackColor = System.Drawing.Color.Transparent;
            this.lblText1.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblText1.Location = new System.Drawing.Point(82, 122);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(316, 106);
            this.lblText1.TabIndex = 10;
            this.lblText1.Text = "Add Weapon To Shop";
            this.lblText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText2
            // 
            this.lblText2.BackColor = System.Drawing.Color.Transparent;
            this.lblText2.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblText2.Location = new System.Drawing.Point(462, 122);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(381, 106);
            this.lblText2.TabIndex = 11;
            this.lblText2.Text = "Delete Weapon From Shop";
            this.lblText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText3
            // 
            this.lblText3.BackColor = System.Drawing.Color.Transparent;
            this.lblText3.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblText3.Location = new System.Drawing.Point(874, 120);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(354, 108);
            this.lblText3.TabIndex = 12;
            this.lblText3.Text = "Buy Weapon From Shop";
            this.lblText3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptbSword
            // 
            this.ptbSword.BackColor = System.Drawing.Color.Transparent;
            this.ptbSword.BackgroundImage = global::WeaponShopAssignmentGUI.Properties.Resources.Pixel_Art_Sword;
            this.ptbSword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbSword.Location = new System.Drawing.Point(102, 231);
            this.ptbSword.Name = "ptbSword";
            this.ptbSword.Size = new System.Drawing.Size(256, 256);
            this.ptbSword.TabIndex = 13;
            this.ptbSword.TabStop = false;
            this.ptbSword.Click += new System.EventHandler(this.ptbSword_Click);
            this.ptbSword.MouseLeave += new System.EventHandler(this.ptbSword_MouseLeave);
            this.ptbSword.MouseHover += new System.EventHandler(this.ptbSword_MouseHover);
            // 
            // ptbX
            // 
            this.ptbX.BackColor = System.Drawing.Color.Transparent;
            this.ptbX.BackgroundImage = global::WeaponShopAssignmentGUI.Properties.Resources.Pixel_Red_X;
            this.ptbX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbX.Location = new System.Drawing.Point(514, 231);
            this.ptbX.Name = "ptbX";
            this.ptbX.Size = new System.Drawing.Size(256, 256);
            this.ptbX.TabIndex = 14;
            this.ptbX.TabStop = false;
            this.ptbX.Click += new System.EventHandler(this.ptbX_Click);
            this.ptbX.MouseLeave += new System.EventHandler(this.ptbX_MouseLeave);
            this.ptbX.MouseHover += new System.EventHandler(this.ptbX_MouseHover);
            // 
            // ptbCoin
            // 
            this.ptbCoin.BackColor = System.Drawing.Color.Transparent;
            this.ptbCoin.BackgroundImage = global::WeaponShopAssignmentGUI.Properties.Resources.Pixel_Coin;
            this.ptbCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbCoin.Location = new System.Drawing.Point(925, 231);
            this.ptbCoin.Name = "ptbCoin";
            this.ptbCoin.Size = new System.Drawing.Size(256, 256);
            this.ptbCoin.TabIndex = 15;
            this.ptbCoin.TabStop = false;
            this.ptbCoin.Click += new System.EventHandler(this.ptbCoin_Click);
            this.ptbCoin.MouseLeave += new System.EventHandler(this.ptbCoin_MouseLeave);
            this.ptbCoin.MouseHover += new System.EventHandler(this.ptbCoin_MouseHover);
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBack.Location = new System.Drawing.Point(12, 604);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(161, 59);
            this.lblBack.TabIndex = 16;
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseLeave += new System.EventHandler(this.lblBack_MouseLeave);
            this.lblBack.MouseHover += new System.EventHandler(this.lblBack_MouseHover);
            // 
            // FormManageShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeaponShopAssignmentGUI.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.ptbCoin);
            this.Controls.Add(this.ptbX);
            this.Controls.Add(this.ptbSword);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblText0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormManageShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visit Shop";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormManageShop_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.ptbSword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.Label lblText0;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.PictureBox ptbSword;
        private System.Windows.Forms.PictureBox ptbX;
        private System.Windows.Forms.PictureBox ptbCoin;
        private System.Windows.Forms.Label lblBack;
        // */
    }
}