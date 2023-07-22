namespace AppAerolinea
{
    partial class FrmLogin
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
            lblCorreo = new Label();
            lblContrasenia = new Label();
            txtBoxCorreo = new TextBox();
            txtBoxContraseña = new TextBox();
            btnEntrar = new Button();
            SuspendLayout();
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblCorreo.Location = new Point(98, 65);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(111, 15);
            lblCorreo.TabIndex = 0;
            lblCorreo.Text = "Correo electronico";
            // 
            // lblContrasenia
            // 
            lblContrasenia.AutoSize = true;
            lblContrasenia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblContrasenia.Location = new Point(114, 168);
            lblContrasenia.Name = "lblContrasenia";
            lblContrasenia.Size = new Size(69, 15);
            lblContrasenia.TabIndex = 1;
            lblContrasenia.Text = "Contraseña";
            // 
            // txtBoxCorreo
            // 
            txtBoxCorreo.Location = new Point(44, 93);
            txtBoxCorreo.Name = "txtBoxCorreo";
            txtBoxCorreo.Size = new Size(213, 23);
            txtBoxCorreo.TabIndex = 2;
            // 
            // txtBoxContraseña
            // 
            txtBoxContraseña.Location = new Point(44, 195);
            txtBoxContraseña.Name = "txtBoxContraseña";
            txtBoxContraseña.Size = new Size(213, 23);
            txtBoxContraseña.TabIndex = 3;
            // 
            // btnEntrar
            // 
            btnEntrar.Location = new Point(114, 265);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 316);
            Controls.Add(btnEntrar);
            Controls.Add(txtBoxContraseña);
            Controls.Add(txtBoxCorreo);
            Controls.Add(lblContrasenia);
            Controls.Add(lblCorreo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCorreo;
        private Label lblContrasenia;
        private TextBox txtBoxCorreo;
        private TextBox txtBoxContraseña;
        private Button btnEntrar;
    }
}