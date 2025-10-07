namespace UserManagementApp
{
    partial class RegisterForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pictureBox1 = new PictureBox();
            btnNext = new Button();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtEmails = new Guna.UI2.WinForms.Guna2TextBox();
            txtPasswords = new Guna.UI2.WinForms.Guna2TextBox();
            txtConfirmPasswords = new Guna.UI2.WinForms.Guna2TextBox();
            btnDangKi = new Guna.UI2.WinForms.Guna2Button();
            lblUserStatus = new Label();
            lblEmailStatus = new Label();
            lblConfirmStatus = new Label();
            lblPasswordStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(176, 11);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(99, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.BackgroundImage = (Image)resources.GetObject("btnNext.BackgroundImage");
            btnNext.BackgroundImageLayout = ImageLayout.Zoom;
            btnNext.Location = new Point(406, 423);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(32, 31);
            btnNext.TabIndex = 5;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Transparent;
            txtUsername.BorderRadius = 18;
            txtUsername.CustomizableEdges = customizableEdges1;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FillColor = Color.FromArgb(224, 224, 224);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(255, 128, 128);
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(131, 197);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtUsername.Size = new Size(179, 50);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtEmails
            // 
            txtEmails.BorderRadius = 18;
            txtEmails.CustomizableEdges = customizableEdges3;
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
            txtEmails.Location = new Point(131, 120);
            txtEmails.Margin = new Padding(4);
            txtEmails.Name = "txtEmails";
            txtEmails.PlaceholderText = "Email";
            txtEmails.SelectedText = "";
            txtEmails.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtEmails.Size = new Size(179, 50);
            txtEmails.TabIndex = 0;
            txtEmails.TextChanged += txtEmails_TextChanged;
            // 
            // txtPasswords
            // 
            txtPasswords.BorderRadius = 18;
            txtPasswords.CustomizableEdges = customizableEdges5;
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
            txtPasswords.Location = new Point(131, 277);
            txtPasswords.Margin = new Padding(4);
            txtPasswords.Name = "txtPasswords";
            txtPasswords.PasswordChar = '*';
            txtPasswords.PlaceholderText = "Passwords";
            txtPasswords.SelectedText = "";
            txtPasswords.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPasswords.Size = new Size(179, 50);
            txtPasswords.TabIndex = 2;
            txtPasswords.TextChanged += txtPasswords_TextChanged;
            // 
            // txtConfirmPasswords
            // 
            txtConfirmPasswords.BorderRadius = 18;
            txtConfirmPasswords.CustomizableEdges = customizableEdges7;
            txtConfirmPasswords.DefaultText = "";
            txtConfirmPasswords.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmPasswords.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmPasswords.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPasswords.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPasswords.FillColor = Color.FromArgb(224, 224, 224);
            txtConfirmPasswords.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPasswords.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtConfirmPasswords.ForeColor = Color.FromArgb(255, 128, 128);
            txtConfirmPasswords.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPasswords.Location = new Point(131, 350);
            txtConfirmPasswords.Margin = new Padding(4);
            txtConfirmPasswords.Name = "txtConfirmPasswords";
            txtConfirmPasswords.PasswordChar = '*';
            txtConfirmPasswords.PlaceholderText = "ConfirmPasswords";
            txtConfirmPasswords.SelectedText = "";
            txtConfirmPasswords.ShadowDecoration.CustomizableEdges = customizableEdges8;
            txtConfirmPasswords.Size = new Size(179, 50);
            txtConfirmPasswords.TabIndex = 3;
            txtConfirmPasswords.TextChanged += txtConfirmPasswords_TextChanged;
            // 
            // btnDangKi
            // 
            btnDangKi.CustomizableEdges = customizableEdges9;
            btnDangKi.DisabledState.BorderColor = Color.DarkGray;
            btnDangKi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDangKi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDangKi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDangKi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDangKi.ForeColor = Color.White;
            btnDangKi.Location = new Point(159, 419);
            btnDangKi.Name = "btnDangKi";
            btnDangKi.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnDangKi.Size = new Size(133, 35);
            btnDangKi.TabIndex = 4;
            btnDangKi.Text = "ĐĂNG KÝ";
            btnDangKi.Click += btnDangKi_Click;
            // 
            // lblUserStatus
            // 
            lblUserStatus.AutoSize = true;
            lblUserStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserStatus.Location = new Point(317, 214);
            lblUserStatus.Name = "lblUserStatus";
            lblUserStatus.Size = new Size(57, 21);
            lblUserStatus.TabIndex = 7;
            lblUserStatus.Text = "label1";
            // 
            // lblEmailStatus
            // 
            lblEmailStatus.AutoSize = true;
            lblEmailStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmailStatus.Location = new Point(317, 138);
            lblEmailStatus.Name = "lblEmailStatus";
            lblEmailStatus.Size = new Size(57, 21);
            lblEmailStatus.TabIndex = 6;
            lblEmailStatus.Text = "label1";
            // 
            // lblConfirmStatus
            // 
            lblConfirmStatus.AutoSize = true;
            lblConfirmStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConfirmStatus.Location = new Point(317, 364);
            lblConfirmStatus.Name = "lblConfirmStatus";
            lblConfirmStatus.Size = new Size(57, 21);
            lblConfirmStatus.TabIndex = 9;
            lblConfirmStatus.Text = "label1";
            // 
            // lblPasswordStatus
            // 
            lblPasswordStatus.AutoSize = true;
            lblPasswordStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPasswordStatus.Location = new Point(317, 286);
            lblPasswordStatus.Name = "lblPasswordStatus";
            lblPasswordStatus.Size = new Size(57, 21);
            lblPasswordStatus.TabIndex = 8;
            lblPasswordStatus.Text = "label1";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(450, 466);
            Controls.Add(lblConfirmStatus);
            Controls.Add(lblPasswordStatus);
            Controls.Add(lblEmailStatus);
            Controls.Add(lblUserStatus);
            Controls.Add(btnDangKi);
            Controls.Add(txtConfirmPasswords);
            Controls.Add(txtPasswords);
            Controls.Add(txtEmails);
            Controls.Add(txtUsername);
            Controls.Add(btnNext);
            Controls.Add(pictureBox1);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register User";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnNext;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtEmails;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswords;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPasswords;
        private Guna.UI2.WinForms.Guna2Button btnDangKi;
        private Label lblUserStatus;
        private Label lblEmailStatus;
        private Label lblConfirmStatus;
        private Label lblPasswordStatus;
    }
}
