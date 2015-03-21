namespace UltimateAutoFarmer
{
    partial class LoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWindow));
            this.ucLabel1 = new UltimateAutoFarmer.CustomControls.UCLabel();
            this.m_btn_Settings = new UltimateAutoFarmer.CustomControls.UCButton();
            this.m_btn_Add = new UltimateAutoFarmer.CustomControls.UCButton();
            this.ucExitButton1 = new UltimateAutoFarmer.CustomControls.UCExitButton();
            this.SuspendLayout();
            // 
            // ucLabel1
            // 
            this.ucLabel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ucLabel1.CustomFont = UltimateAutoFarmer.CustomControls.UCLabel.OwnFonts.Checkout;
            this.ucLabel1.FontSize = 12;
            this.ucLabel1.Location = new System.Drawing.Point(12, 8);
            this.ucLabel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucLabel1.Name = "ucLabel1";
            this.ucLabel1.Size = new System.Drawing.Size(192, 19);
            this.ucLabel1.TabIndex = 3;
            this.ucLabel1.Text = "Ultimate Auto Farmer";
            // 
            // m_btn_Settings
            // 
            this.m_btn_Settings.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_Settings.BackgroundImage = global::UltimateAutoFarmer.Properties.Resources.cogwheels;
            this.m_btn_Settings.BackgroundImageDefault = global::UltimateAutoFarmer.Properties.Resources.cogwheels;
            this.m_btn_Settings.BackgroundImageHover = global::UltimateAutoFarmer.Properties.Resources.cogwheels_h;
            this.m_btn_Settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_btn_Settings.Location = new System.Drawing.Point(183, 89);
            this.m_btn_Settings.Name = "m_btn_Settings";
            this.m_btn_Settings.Size = new System.Drawing.Size(30, 30);
            this.m_btn_Settings.TabIndex = 2;
            // 
            // m_btn_Add
            // 
            this.m_btn_Add.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_Add.BackgroundImage = global::UltimateAutoFarmer.Properties.Resources.add;
            this.m_btn_Add.BackgroundImageDefault = global::UltimateAutoFarmer.Properties.Resources.add;
            this.m_btn_Add.BackgroundImageHover = global::UltimateAutoFarmer.Properties.Resources.add_h;
            this.m_btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_btn_Add.Location = new System.Drawing.Point(136, 89);
            this.m_btn_Add.Name = "m_btn_Add";
            this.m_btn_Add.Size = new System.Drawing.Size(30, 30);
            this.m_btn_Add.TabIndex = 1;
            // 
            // ucExitButton1
            // 
            this.ucExitButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ucExitButton1.BackgroundImage")));
            this.ucExitButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ucExitButton1.Location = new System.Drawing.Point(248, 8);
            this.ucExitButton1.Name = "ucExitButton1";
            this.ucExitButton1.Size = new System.Drawing.Size(15, 15);
            this.ucExitButton1.TabIndex = 0;
            // 
            // LoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(284, 144);
            this.Controls.Add(this.ucLabel1);
            this.Controls.Add(this.m_btn_Settings);
            this.Controls.Add(this.m_btn_Add);
            this.Controls.Add(this.ucExitButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginWindow";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginWindow_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControls.UCExitButton ucExitButton1;
        private CustomControls.UCButton m_btn_Add;
        private CustomControls.UCButton m_btn_Settings;
        private CustomControls.UCLabel ucLabel1;

    }
}