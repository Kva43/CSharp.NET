namespace _05_Forms_Ejercicio1
{
    partial class FormDatos
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
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            labelNombre = new Label();
            labelApellido = new Label();
            buttonSaludar = new Button();
            comboBoxMaterias = new ComboBox();
            labelMateriaFavorita = new Label();
            SuspendLayout();
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(22, 39);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(146, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Location = new Point(211, 39);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.Size = new Size(146, 23);
            textBoxApellido.TabIndex = 1;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNombre.Location = new Point(22, 21);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(53, 15);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            labelApellido.AutoSize = true;
            labelApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelApellido.Location = new Point(211, 21);
            labelApellido.Name = "labelApellido";
            labelApellido.Size = new Size(52, 15);
            labelApellido.TabIndex = 3;
            labelApellido.Text = "Apellido";
            // 
            // buttonSaludar
            // 
            buttonSaludar.Location = new Point(211, 142);
            buttonSaludar.Name = "buttonSaludar";
            buttonSaludar.Size = new Size(146, 23);
            buttonSaludar.TabIndex = 4;
            buttonSaludar.Text = "Saludar";
            buttonSaludar.UseVisualStyleBackColor = true;
            buttonSaludar.Click += buttonSaludar_Click;
            // 
            // comboBoxMaterias
            // 
            comboBoxMaterias.FormattingEnabled = true;
            comboBoxMaterias.Location = new Point(22, 101);
            comboBoxMaterias.Name = "comboBoxMaterias";
            comboBoxMaterias.Size = new Size(335, 23);
            comboBoxMaterias.TabIndex = 5;
            // 
            // labelMateriaFavorita
            // 
            labelMateriaFavorita.AutoSize = true;
            labelMateriaFavorita.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelMateriaFavorita.Location = new Point(22, 83);
            labelMateriaFavorita.Name = "labelMateriaFavorita";
            labelMateriaFavorita.Size = new Size(97, 15);
            labelMateriaFavorita.TabIndex = 6;
            labelMateriaFavorita.Text = "Materia favorita";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(380, 177);
            Controls.Add(labelMateriaFavorita);
            Controls.Add(comboBoxMaterias);
            Controls.Add(buttonSaludar);
            Controls.Add(labelApellido);
            Controls.Add(labelNombre);
            Controls.Add(textBoxApellido);
            Controls.Add(textBoxNombre);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "¡Hola, Windows Forms!";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNombre;
        private TextBox textBoxApellido;
        private Label labelNombre;
        private Label labelApellido;
        private Button buttonSaludar;
        private ComboBox comboBoxMaterias;
        private Label labelMateriaFavorita;
    }
}