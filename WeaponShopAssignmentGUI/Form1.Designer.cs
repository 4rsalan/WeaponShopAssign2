namespace WeaponShopAssignmentGUI
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblText0 = new System.Windows.Forms.Label();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblText3 = new System.Windows.Forms.Label();
            this.ptbCoin = new System.Windows.Forms.PictureBox();
            this.ptbBackpack = new System.Windows.Forms.PictureBox();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackpack)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(349, 280);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(588, 53);
            this.txtPlayerName.TabIndex = 0;
            // 
            // lblText0
            // 
            this.lblText0.BackColor = System.Drawing.Color.Transparent;
            this.lblText0.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText0.ForeColor = System.Drawing.Color.DarkGray;
            this.lblText0.Location = new System.Drawing.Point(192, 197);
            this.lblText0.Name = "lblText0";
            this.lblText0.Size = new System.Drawing.Size(925, 54);
            this.lblText0.TabIndex = 1;
            this.lblText0.Text = "Please enter a Player Name:";
            this.lblText0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirm.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirm.ForeColor = System.Drawing.Color.White;
            this.lblConfirm.Location = new System.Drawing.Point(537, 370);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.Size = new System.Drawing.Size(201, 46);
            this.lblConfirm.TabIndex = 2;
            this.lblConfirm.Text = "Confirm\r\n";
            this.lblConfirm.Click += new System.EventHandler(this.lblConfirm_Click);
            this.lblConfirm.MouseLeave += new System.EventHandler(this.lblConfirm_MouseLeave);
            this.lblConfirm.MouseHover += new System.EventHandler(this.lblConfirm_MouseHover);
            // 
            // lblText1
            // 
            this.lblText1.BackColor = System.Drawing.Color.Transparent;
            this.lblText1.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.ForeColor = System.Drawing.Color.DarkGray;
            this.lblText1.Location = new System.Drawing.Point(299, 29);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(620, 56);
            this.lblText1.TabIndex = 3;
            this.lblText1.Text = "Select an Option:\r\n";
            this.lblText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblText1.Visible = false;
            // 
            // lblText2
            // 
            this.lblText2.BackColor = System.Drawing.Color.Transparent;
            this.lblText2.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblText2.Location = new System.Drawing.Point(197, 170);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(285, 52);
            this.lblText2.TabIndex = 4;
            this.lblText2.Text = "Visit Shop";
            this.lblText2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblText2.Visible = false;
            // 
            // lblText3
            // 
            this.lblText3.BackColor = System.Drawing.Color.Transparent;
            this.lblText3.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblText3.Location = new System.Drawing.Point(707, 166);
            this.lblText3.Name = "lblText3";
            this.lblText3.Size = new System.Drawing.Size(438, 60);
            this.lblText3.TabIndex = 5;
            this.lblText3.Text = "Manage Player";
            this.lblText3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblText3.Visible = false;
            // 
            // ptbCoin
            // 
            this.ptbCoin.BackColor = System.Drawing.Color.Transparent;
            this.ptbCoin.BackgroundImage = global::WeaponShopAssignmentGUI.Properties.Resources.Pixel_Coin;
            this.ptbCoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbCoin.Location = new System.Drawing.Point(205, 238);
            this.ptbCoin.Name = "ptbCoin";
            this.ptbCoin.Size = new System.Drawing.Size(256, 256);
            this.ptbCoin.TabIndex = 6;
            this.ptbCoin.TabStop = false;
            this.ptbCoin.Visible = false;
            this.ptbCoin.Click += new System.EventHandler(this.ptbCoin_Click);
            this.ptbCoin.MouseLeave += new System.EventHandler(this.ptbCoin_MouseLeave);
            this.ptbCoin.MouseHover += new System.EventHandler(this.ptbCoin_MouseHover);
            // 
            // ptbBackpack
            // 
            this.ptbBackpack.BackColor = System.Drawing.Color.Transparent;
            this.ptbBackpack.BackgroundImage = global::WeaponShopAssignmentGUI.Properties.Resources.Pixel_Backpack;
            this.ptbBackpack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbBackpack.Location = new System.Drawing.Point(804, 254);
            this.ptbBackpack.Name = "ptbBackpack";
            this.ptbBackpack.Size = new System.Drawing.Size(256, 256);
            this.ptbBackpack.TabIndex = 7;
            this.ptbBackpack.TabStop = false;
            this.ptbBackpack.Visible = false;
            this.ptbBackpack.Click += new System.EventHandler(this.ptbBackpack_Click);
            this.ptbBackpack.MouseLeave += new System.EventHandler(this.ptbBackpack_MouseLeave);
            this.ptbBackpack.MouseHover += new System.EventHandler(this.ptbBackpack_MouseHover);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExit.Location = new System.Drawing.Point(1076, 593);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(176, 68);
            this.lblExit.TabIndex = 8;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeaponShopAssignmentGUI.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.ptbBackpack);
            this.Controls.Add(this.ptbCoin);
            this.Controls.Add(this.lblText3);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.lblConfirm);
            this.Controls.Add(this.lblText0);
            this.Controls.Add(this.txtPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Weapon Shops Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBackpack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblText0;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Label lblText3;
        private System.Windows.Forms.PictureBox ptbCoin;
        private System.Windows.Forms.PictureBox ptbBackpack;
        private System.Windows.Forms.Label lblExit;
    }
}

