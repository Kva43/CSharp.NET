namespace _05_Forms_EjercicioExtra
{
    partial class FrmSaludo
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
            lblSaludo = new Label();
            btnSaludo = new Button();
            SuspendLayout();
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblSaludo.Location = new Point(35, 58);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(275, 30);
            lblSaludo.TabIndex = 0;
            lblSaludo.Text = "¡¡¡Hola mundo WinForm!!!";
            // 
            // btnSaludo
            // 
            btnSaludo.Location = new Point(93, 134);
            btnSaludo.Name = "btnSaludo";
            btnSaludo.Size = new Size(144, 50);
            btnSaludo.TabIndex = 1;
            btnSaludo.Text = "Haga click aquí";
            btnSaludo.UseVisualStyleBackColor = true;
            btnSaludo.Click += btnSaludo_Click;
            // 
            // FrmSaludo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 229);
            Controls.Add(btnSaludo);
            Controls.Add(lblSaludo);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSaludo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saludo desde un Form";
            Load += FrmSaludo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSaludo;
        private Button btnSaludo;
    }
}