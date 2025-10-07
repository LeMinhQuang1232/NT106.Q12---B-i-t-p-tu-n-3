namespace UserManagementApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            btnNext = new Button();
            btnDangNhap = new Guna.UI2.WinForms.Guna2Button();
            txtPasswords = new Guna.UI2.WinForms.Guna2TextBox();
            lblPasswordStatus = new Label();
            txtEmails = new Guna.UI2.WinForms.Guna2TextBox();
            lblEmailStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 23);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Zoom;
            btnNext.Location = new Point(406, 363);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(32, 31);
            btnNext.TabIndex = 2;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click_1;
            // 
            // btnDangNhap
            // 
            btnDangNhap.CustomizableEdges = customizableEdges1;
            btnDangNhap.DisabledState.BorderColor = Color.DarkGray;
            btnDangNhap.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDangNhap.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDangNhap.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDangNhap.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.White;
            btnDangNhap.Location = new Point(162, 321);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnDangNhap.Size = new Size(127, 52);
            btnDangNhap.TabIndex = 14;
            btnDangNhap.Text = "ĐĂNG NHẬP";
            btnDangNhap.Click += btnDangNhap_Click_1;
            // 
            // txtPasswords
            // 
            txtPasswords.BorderRadius = 18;
            txtPasswords.CustomizableEdges = customizableEdges3;
            txtPasswords.DefaultText = "";
            txtPasswords.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPasswords.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPasswords.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPasswords.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPasswords.FillColor = Color.FromArgb(224, 224, 224);
            txtPasswords.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPasswords.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPasswords.ForeColor = Color.FromArgb(255, 128, 128);
            txtPasswords.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPasswords.Location = new Point(136, 237);
            txtPasswords.Margin = new Padding(4);
            txtPasswords.Name = "txtPasswords";
            txtPasswords.PasswordChar = '*';
            txtPasswords.PlaceholderText = "Passwords";
            txtPasswords.SelectedText = "";
            txtPasswords.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtPasswords.Size = new Size(179, 50);
            txtPasswords.TabIndex = 16;
            txtPasswords.TextChanged += txtPasswords_TextChanged_1;
            // 
            // lblPasswordStatus
            // 
            lblPasswordStatus.AutoSize = true;
            lblPasswordStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordStatus.Location = new Point(322, 249);
            lblPasswordStatus.Name = "lblPasswordStatus";
            lblPasswordStatus.Size = new Size(0, 21);
            lblPasswordStatus.TabIndex = 18;
            // 
            // txtEmails
            // 
            txtEmails.BorderRadius = 18;
            txtEmails.CustomizableEdges = customizableEdges5;
            txtEmails.DefaultText = "";
            txtEmails.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmails.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmails.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmails.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmails.FillColor = Color.FromArgb(224, 224, 224);
            txtEmails.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmails.ForeColor = Color.FromArgb(255, 128, 128);
            txtEmails.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmails.Location = new Point(136, 178);
            txtEmails.Margin = new Padding(4);
            txtEmails.Name = "txtEmails";
            txtEmails.PlaceholderText = "Email";
            txtEmails.SelectedText = "";
            txtEmails.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtEmails.Size = new Size(179, 50);
            txtEmails.TabIndex = 19;
            txtEmails.TextChanged += txtEmails_TextChanged_1;
            // 
            // lblEmailStatus
            // 
            lblEmailStatus.AutoSize = true;
            lblEmailStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailStatus.Location = new Point(322, 197);
            lblEmailStatus.Name = "lblEmailStatus";
            lblEmailStatus.Size = new Size(0, 21);
            lblEmailStatus.TabIndex = 20;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(450, 406);
            Controls.Add(lblEmailStatus);
            Controls.Add(txtEmails);
            Controls.Add(lblPasswordStatus);
            Controls.Add(txtPasswords);
            Controls.Add(btnDangNhap);
            Controls.Add(btnNext);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login User";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnNext;
        private Guna.UI2.WinForms.Guna2Button btnDangNhap;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswords;
        private Label lblPasswordStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtEmails;
        private Label lblEmailStatus;
    }
}