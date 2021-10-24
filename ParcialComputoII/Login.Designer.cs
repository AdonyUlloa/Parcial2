
namespace ParcialComputoII
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.mlbLogin = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnLogin = new MetroFramework.Controls.MetroButton();
            this.txtbUsername = new MetroFramework.Controls.MetroTextBox();
            this.txtbPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.mlbSignUp = new MetroFramework.Controls.MetroLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(0, 481);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(331, 35);
            this.btnExit.Style = MetroFramework.MetroColorStyle.White;
            this.btnExit.TabIndex = 38;
            this.btnExit.Text = "Exit";
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.UseStyleColors = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // mlbLogin
            // 
            this.mlbLogin.BackColor = System.Drawing.Color.Transparent;
            this.mlbLogin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.mlbLogin.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.mlbLogin.ForeColor = System.Drawing.Color.Transparent;
            this.mlbLogin.Location = new System.Drawing.Point(12, 9);
            this.mlbLogin.Name = "mlbLogin";
            this.mlbLogin.Size = new System.Drawing.Size(107, 27);
            this.mlbLogin.Style = MetroFramework.MetroColorStyle.Orange;
            this.mlbLogin.TabIndex = 81;
            this.mlbLogin.Text = "Login Form";
            this.mlbLogin.UseCustomBackColor = true;
            this.mlbLogin.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(42, 164);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(74, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 82;
            this.metroLabel1.Text = "Username:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(42, 246);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(70, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 84;
            this.metroLabel2.Text = "Password:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(43, 326);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(244, 35);
            this.btnLogin.Style = MetroFramework.MetroColorStyle.White;
            this.btnLogin.TabIndex = 85;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseCustomBackColor = true;
            this.btnLogin.UseSelectable = true;
            this.btnLogin.UseStyleColors = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtbUsername
            // 
            // 
            // 
            // 
            this.txtbUsername.CustomButton.Image = null;
            this.txtbUsername.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtbUsername.CustomButton.Name = "";
            this.txtbUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbUsername.CustomButton.TabIndex = 1;
            this.txtbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbUsername.CustomButton.UseSelectable = true;
            this.txtbUsername.CustomButton.Visible = false;
            this.txtbUsername.DisplayIcon = true;
            this.txtbUsername.Lines = new string[0];
            this.txtbUsername.Location = new System.Drawing.Point(118, 164);
            this.txtbUsername.MaxLength = 32767;
            this.txtbUsername.Name = "txtbUsername";
            this.txtbUsername.PasswordChar = '\0';
            this.txtbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbUsername.SelectedText = "";
            this.txtbUsername.SelectionLength = 0;
            this.txtbUsername.SelectionStart = 0;
            this.txtbUsername.ShortcutsEnabled = true;
            this.txtbUsername.Size = new System.Drawing.Size(168, 23);
            this.txtbUsername.TabIndex = 86;
            this.txtbUsername.UseSelectable = true;
            this.txtbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtbPassword
            // 
            // 
            // 
            // 
            this.txtbPassword.CustomButton.Image = null;
            this.txtbPassword.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtbPassword.CustomButton.Name = "";
            this.txtbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtbPassword.CustomButton.TabIndex = 1;
            this.txtbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtbPassword.CustomButton.UseSelectable = true;
            this.txtbPassword.CustomButton.Visible = false;
            this.txtbPassword.Lines = new string[0];
            this.txtbPassword.Location = new System.Drawing.Point(118, 246);
            this.txtbPassword.MaxLength = 32767;
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '*';
            this.txtbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbPassword.SelectedText = "";
            this.txtbPassword.SelectionLength = 0;
            this.txtbPassword.SelectionStart = 0;
            this.txtbPassword.ShortcutsEnabled = true;
            this.txtbPassword.Size = new System.Drawing.Size(168, 23);
            this.txtbPassword.TabIndex = 87;
            this.txtbPassword.UseSelectable = true;
            this.txtbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtbPassword.Click += new System.EventHandler(this.txtbPassword_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel3.Location = new System.Drawing.Point(92, 410);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 15);
            this.metroLabel3.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLabel3.TabIndex = 88;
            this.metroLabel3.Text = "Are you new?";
            // 
            // mlbSignUp
            // 
            this.mlbSignUp.AutoSize = true;
            this.mlbSignUp.BackColor = System.Drawing.SystemColors.HotTrack;
            this.mlbSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mlbSignUp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.mlbSignUp.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.mlbSignUp.Location = new System.Drawing.Point(164, 406);
            this.mlbSignUp.Name = "mlbSignUp";
            this.mlbSignUp.Size = new System.Drawing.Size(57, 19);
            this.mlbSignUp.Style = MetroFramework.MetroColorStyle.Blue;
            this.mlbSignUp.TabIndex = 89;
            this.mlbSignUp.Text = "Sign Up";
            this.mlbSignUp.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mlbSignUp.Click += new System.EventHandler(this.mlbSign_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(256, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 90;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ParcialComputoII.Properties.Resources.perfil;
            this.pictureBox1.Location = new System.Drawing.Point(108, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 92;
            this.pictureBox1.TabStop = false;
            // 
            // cbPassword
            // 
            this.cbPassword.AutoSize = true;
            this.cbPassword.Location = new System.Drawing.Point(189, 275);
            this.cbPassword.Name = "cbPassword";
            this.cbPassword.Size = new System.Drawing.Size(98, 17);
            this.cbPassword.TabIndex = 93;
            this.cbPassword.Text = "Ver contraseña";
            this.cbPassword.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(331, 516);
            this.Controls.Add(this.cbPassword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mlbSignUp);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUsername);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.mlbLogin);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnExit);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroLabel mlbLogin;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        public MetroFramework.Controls.MetroButton btnLogin;
        private MetroFramework.Controls.MetroTextBox txtbUsername;
        private MetroFramework.Controls.MetroTextBox txtbPassword;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel mlbSignUp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cbPassword;
    }
}

