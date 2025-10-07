namespace UserManagementApp
{
    partial class MainForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            txtEmails = new Guna.UI2.WinForms.Guna2TextBox();
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPasswords = new Guna.UI2.WinForms.Guna2TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 0;
            label1.Text = "Profile Information";
            // 
            // txtEmails
            // 
            txtEmails.BorderRadius = 18;
            txtEmails.CustomizableEdges = customizableEdges1;
            txtEmails.DefaultText = "";
            txtEmails.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtEmails.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtEmails.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtEmails.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtEmails.FillColor = Color.FromArgb(224, 224, 224);
            txtEmails.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmails.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmails.ForeColor = Color.FromArgb(255, 128, 128);
            txtEmails.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtEmails.Location = new Point(10, 51);
            txtEmails.Margin = new Padding(7, 8, 7, 8);
            txtEmails.Name = "txtEmails";
            txtEmails.PlaceholderText = "Email";
            txtEmails.SelectedText = "";
            txtEmails.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtEmails.Size = new Size(424, 50);
            txtEmails.TabIndex = 1;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Transparent;
            txtUsername.BorderRadius = 18;
            txtUsername.CustomizableEdges = customizableEdges3;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FillColor = Color.FromArgb(224, 224, 224);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = Color.FromArgb(255, 128, 128);
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(12, 136);
            txtUsername.Margin = new Padding(7, 8, 7, 8);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges4;
            txtUsername.Size = new Size(424, 50);
            txtUsername.TabIndex = 2;
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
            txtPasswords.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPasswords.ForeColor = Color.FromArgb(255, 128, 128);
            txtPasswords.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPasswords.Location = new Point(12, 221);
            txtPasswords.Margin = new Padding(7, 8, 7, 8);
            txtPasswords.Name = "txtPasswords";
            txtPasswords.PasswordChar = '*';
            txtPasswords.PlaceholderText = "Passwords";
            txtPasswords.SelectedText = "";
            txtPasswords.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtPasswords.Size = new Size(424, 50);
            txtPasswords.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.BackgroundImage = (Image)resources.GetObject("btnBack.BackgroundImage");
            btnBack.BackgroundImageLayout = ImageLayout.Zoom;
            btnBack.Location = new Point(404, 296);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(32, 31);
            btnBack.TabIndex = 6;
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(450, 339);
            Controls.Add(btnBack);
            Controls.Add(txtPasswords);
            Controls.Add(txtUsername);
            Controls.Add(txtEmails);
            Controls.Add(label1);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserManagementApp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtEmails;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2TextBox txtPasswords;
        private Button btnBack;
    }
}