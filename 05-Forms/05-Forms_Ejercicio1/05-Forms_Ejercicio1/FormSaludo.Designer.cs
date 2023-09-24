namespace _05_Forms_Ejercicio1
{
    partial class FormSaludo
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
            labelSaludo = new Label();
            labelSaludoWinForms = new Label();
            SuspendLayout();
            // 
            // labelSaludo
            // 
            labelSaludo.AutoSize = true;
            labelSaludo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelSaludo.Location = new Point(12, 65);
            labelSaludo.Name = "labelSaludo";
            labelSaludo.Size = new Size(195, 21);
            labelSaludo.TabIndex = 0;
            labelSaludo.Text = "(Aca aparecerá el mensaje)";
            // 
            // labelSaludoWinForms
            // 
            labelSaludoWinForms.AutoSize = true;
            labelSaludoWinForms.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelSaludoWinForms.Location = new Point(12, 9);
            labelSaludoWinForms.Name = "labelSaludoWinForms";
            labelSaludoWinForms.Size = new Size(235, 33);
            labelSaludoWinForms.TabIndex = 1;
            labelSaludoWinForms.Text = "¡Hola, Windows Forms!";
            // 
            // FormSaludo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 134);
            Controls.Add(labelSaludoWinForms);
            Controls.Add(labelSaludo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormSaludo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Saludo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelSaludo;
        private Label labelSaludoWinForms;
    }
}