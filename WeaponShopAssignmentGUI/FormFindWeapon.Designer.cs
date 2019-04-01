namespace WeaponShopAssignmentGUI
{
    partial class FormFindWeapon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFindWeapon));
            this.lblText0 = new System.Windows.Forms.Label();
            this.lblText6 = new System.Windows.Forms.Label();
            this.txtCurrentWeapons = new System.Windows.Forms.TextBox();
            this.lblText1 = new System.Windows.Forms.Label();
            this.txtWeaponName = new System.Windows.Forms.TextBox();
            this.lblWeaponInfo = new System.Windows.Forms.Label();
            this.lblFindWeapon = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblText0
            // 
            this.lblText0.BackColor = System.Drawing.Color.Transparent;
            this.lblText0.Font = new System.Drawing.Font("Old School Adventures", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText0.ForeColor = System.Drawing.Color.DarkGray;
            this.lblText0.Location = new System.Drawing.Point(323, 23);
            this.lblText0.Name = "lblText0";
            this.lblText0.Size = new System.Drawing.Size(628, 41);
            this.lblText0.TabIndex = 6;
            this.lblText0.Text = "Find Weapon:";
            this.lblText0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblText6
            // 
            this.lblText6.BackColor = System.Drawing.Color.Transparent;
            this.lblText6.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText6.ForeColor = System.Drawing.Color.Silver;
            this.lblText6.Location = new System.Drawing.Point(770, 80);
            this.lblText6.Name = "lblText6";
            this.lblText6.Size = new System.Drawing.Size(496, 56);
            this.lblText6.TabIndex = 31;
            this.lblText6.Text = "Current Weapons:";
            this.lblText6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCurrentWeapons
            // 
            this.txtCurrentWeapons.Font = new System.Drawing.Font("Old School Adventures", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentWeapons.Location = new System.Drawing.Point(803, 139);
            this.txtCurrentWeapons.Multiline = true;
            this.txtCurrentWeapons.Name = "txtCurrentWeapons";
            this.txtCurrentWeapons.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCurrentWeapons.Size = new System.Drawing.Size(438, 473);
            this.txtCurrentWeapons.TabIndex = 32;
            // 
            // lblText1
            // 
            this.lblText1.BackColor = System.Drawing.Color.Transparent;
            this.lblText1.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText1.ForeColor = System.Drawing.Color.Silver;
            this.lblText1.Location = new System.Drawing.Point(118, 80);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(503, 104);
            this.lblText1.TabIndex = 33;
            this.lblText1.Text = "Enter The Name Of the Weapon To Find:";
            this.lblText1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtWeaponName
            // 
            this.txtWeaponName.Font = new System.Drawing.Font("Old School Adventures", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeaponName.Location = new System.Drawing.Point(126, 187);
            this.txtWeaponName.Name = "txtWeaponName";
            this.txtWeaponName.Size = new System.Drawing.Size(470, 49);
            this.txtWeaponName.TabIndex = 34;
            // 
            // lblWeaponInfo
            // 
            this.lblWeaponInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblWeaponInfo.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeaponInfo.ForeColor = System.Drawing.Color.Silver;
            this.lblWeaponInfo.Location = new System.Drawing.Point(118, 316);
            this.lblWeaponInfo.Name = "lblWeaponInfo";
            this.lblWeaponInfo.Size = new System.Drawing.Size(503, 257);
            this.lblWeaponInfo.TabIndex = 35;
            this.lblWeaponInfo.Text = "(Found Weapon Info Goes Here)";
            this.lblWeaponInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFindWeapon
            // 
            this.lblFindWeapon.BackColor = System.Drawing.Color.Transparent;
            this.lblFindWeapon.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindWeapon.ForeColor = System.Drawing.Color.White;
            this.lblFindWeapon.Location = new System.Drawing.Point(180, 239);
            this.lblFindWeapon.Name = "lblFindWeapon";
            this.lblFindWeapon.Size = new System.Drawing.Size(354, 54);
            this.lblFindWeapon.TabIndex = 36;
            this.lblFindWeapon.Text = "Find Weapon";
            this.lblFindWeapon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFindWeapon.Click += new System.EventHandler(this.lblFindWeapon_Click);
            this.lblFindWeapon.MouseLeave += new System.EventHandler(this.lblFindWeapon_MouseLeave);
            this.lblFindWeapon.MouseHover += new System.EventHandler(this.lblFindWeapon_MouseHover);
            // 
            // lblBack
            // 
            this.lblBack.BackColor = System.Drawing.Color.Transparent;
            this.lblBack.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBack.Location = new System.Drawing.Point(12, 612);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(155, 60);
            this.lblBack.TabIndex = 37;
            this.lblBack.Text = "Back";
            this.lblBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            this.lblBack.MouseLeave += new System.EventHandler(this.lblBack_MouseLeave);
            this.lblBack.MouseHover += new System.EventHandler(this.lblBack_MouseHover);
            // 
            // lblExit
            // 
            this.lblExit.BackColor = System.Drawing.Color.Transparent;
            this.lblExit.Font = new System.Drawing.Font("Old School Adventures", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblExit.Location = new System.Drawing.Point(1093, 615);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(159, 57);
            this.lblExit.TabIndex = 38;
            this.lblExit.Text = "Exit";
            this.lblExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            this.lblExit.MouseLeave += new System.EventHandler(this.lblExit_MouseLeave);
            this.lblExit.MouseHover += new System.EventHandler(this.lblExit_MouseHover);
            // 
            // FormFindWeapon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WeaponShopAssignmentGUI.Properties.Resources.Background;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblBack);
            this.Controls.Add(this.lblFindWeapon);
            this.Controls.Add(this.lblWeaponInfo);
            this.Controls.Add(this.txtWeaponName);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.txtCurrentWeapons);
            this.Controls.Add(this.lblText6);
            this.Controls.Add(this.lblText0);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFindWeapon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFindWeapon";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFindWeapon_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblText0;
        private System.Windows.Forms.Label lblText6;
        private System.Windows.Forms.TextBox txtCurrentWeapons;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.TextBox txtWeaponName;
        private System.Windows.Forms.Label lblWeaponInfo;
        private System.Windows.Forms.Label lblFindWeapon;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Label lblExit;
    }
}