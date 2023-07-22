namespace AltaBajaAerolinea
{
    partial class FrmMain
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
            txtBoxMail = new TextBox();
            txtBoxPassword = new TextBox();
            lblMail = new Label();
            lblPassword = new Label();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // txtBoxMail
            // 
            txtBoxMail.Location = new Point(37, 59);
            txtBoxMail.Name = "txtBoxMail";
            txtBoxMail.Size = new Size(160, 23);
            txtBoxMail.TabIndex = 0;
            // 
            // txtBoxPassword
            // 
            txtBoxPassword.Location = new Point(37, 145);
            txtBoxPassword.Name = "txtBoxPassword";
            txtBoxPassword.Size = new Size(160, 23);
            txtBoxPassword.TabIndex = 1;
            // 
            // lblMail
            // 
            lblMail.AutoSize = true;
            lblMail.Location = new Point(96, 30);
            lblMail.Name = "lblMail";
            lblMail.Size = new Size(30, 15);
            lblMail.TabIndex = 2;
            lblMail.Text = "Mail";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(87, 107);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(57, 15);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(78, 194);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 255);
            Controls.Add(btnLogin);
            Controls.Add(lblPassword);
            Controls.Add(lblMail);
            Controls.Add(txtBoxPassword);
            Controls.Add(txtBoxMail);
            Name = "FrmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += FrmMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxMail;
        private TextBox txtBoxPassword;
        private Label lblMail;
        private Label lblPassword;
        private Button btnLogin;
    }
}