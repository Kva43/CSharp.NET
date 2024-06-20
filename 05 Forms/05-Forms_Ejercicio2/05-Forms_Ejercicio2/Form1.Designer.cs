namespace _05_Forms_Ejercicio2
{
    partial class FormRegistro
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
            groupBoxDetallesUsuario = new GroupBox();
            labelEdad = new Label();
            labelDireccion = new Label();
            labelNombre = new Label();
            numericUpDownEdad = new NumericUpDown();
            textBoxDireccion = new TextBox();
            textBoxNombre = new TextBox();
            groupBoxGenero = new GroupBox();
            radioButtonNoBinario = new RadioButton();
            radioButtonFemenino = new RadioButton();
            radioButtonMasculino = new RadioButton();
            groupBoxCursos = new GroupBox();
            checkBoxJS = new CheckBox();
            checkBoxCPlus = new CheckBox();
            checkBoxCSharp = new CheckBox();
            listBoxPais = new ListBox();
            labelPais = new Label();
            buttonIngresar = new Button();
            groupBoxDetallesUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).BeginInit();
            groupBoxGenero.SuspendLayout();
            groupBoxCursos.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxDetallesUsuario
            // 
            groupBoxDetallesUsuario.Controls.Add(labelEdad);
            groupBoxDetallesUsuario.Controls.Add(labelDireccion);
            groupBoxDetallesUsuario.Controls.Add(labelNombre);
            groupBoxDetallesUsuario.Controls.Add(numericUpDownEdad);
            groupBoxDetallesUsuario.Controls.Add(textBoxDireccion);
            groupBoxDetallesUsuario.Controls.Add(textBoxNombre);
            groupBoxDetallesUsuario.Location = new Point(68, 67);
            groupBoxDetallesUsuario.Name = "groupBoxDetallesUsuario";
            groupBoxDetallesUsuario.Size = new Size(312, 159);
            groupBoxDetallesUsuario.TabIndex = 0;
            groupBoxDetallesUsuario.TabStop = false;
            groupBoxDetallesUsuario.Text = "Detalles del usuario";
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(25, 127);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(33, 15);
            labelEdad.TabIndex = 5;
            labelEdad.Text = "Edad";
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(25, 86);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(57, 15);
            labelDireccion.TabIndex = 4;
            labelDireccion.Text = "Dirección";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(25, 42);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(51, 15);
            labelNombre.TabIndex = 3;
            labelNombre.Text = "Nombre";
            // 
            // numericUpDownEdad
            // 
            numericUpDownEdad.Location = new Point(123, 119);
            numericUpDownEdad.Name = "numericUpDownEdad";
            numericUpDownEdad.Size = new Size(151, 23);
            numericUpDownEdad.TabIndex = 2;
            // 
            // textBoxDireccion
            // 
            textBoxDireccion.Location = new Point(123, 78);
            textBoxDireccion.Name = "textBoxDireccion";
            textBoxDireccion.Size = new Size(151, 23);
            textBoxDireccion.TabIndex = 1;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(123, 34);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.Size = new Size(151, 23);
            textBoxNombre.TabIndex = 0;
            // 
            // groupBoxGenero
            // 
            groupBoxGenero.Controls.Add(radioButtonNoBinario);
            groupBoxGenero.Controls.Add(radioButtonFemenino);
            groupBoxGenero.Controls.Add(radioButtonMasculino);
            groupBoxGenero.Location = new Point(451, 67);
            groupBoxGenero.Name = "groupBoxGenero";
            groupBoxGenero.Size = new Size(123, 159);
            groupBoxGenero.TabIndex = 1;
            groupBoxGenero.TabStop = false;
            groupBoxGenero.Text = "Género";
            // 
            // radioButtonNoBinario
            // 
            radioButtonNoBinario.AutoSize = true;
            radioButtonNoBinario.Location = new Point(16, 119);
            radioButtonNoBinario.Name = "radioButtonNoBinario";
            radioButtonNoBinario.Size = new Size(81, 19);
            radioButtonNoBinario.TabIndex = 2;
            radioButtonNoBinario.TabStop = true;
            radioButtonNoBinario.Text = "No binario";
            radioButtonNoBinario.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemenino
            // 
            radioButtonFemenino.AutoSize = true;
            radioButtonFemenino.Location = new Point(16, 78);
            radioButtonFemenino.Name = "radioButtonFemenino";
            radioButtonFemenino.Size = new Size(78, 19);
            radioButtonFemenino.TabIndex = 1;
            radioButtonFemenino.TabStop = true;
            radioButtonFemenino.Text = "Femenino";
            radioButtonFemenino.UseVisualStyleBackColor = true;
            // 
            // radioButtonMasculino
            // 
            radioButtonMasculino.AutoSize = true;
            radioButtonMasculino.Location = new Point(16, 38);
            radioButtonMasculino.Name = "radioButtonMasculino";
            radioButtonMasculino.Size = new Size(80, 19);
            radioButtonMasculino.TabIndex = 0;
            radioButtonMasculino.TabStop = true;
            radioButtonMasculino.Text = "Masculino";
            radioButtonMasculino.UseVisualStyleBackColor = true;
            // 
            // groupBoxCursos
            // 
            groupBoxCursos.Controls.Add(checkBoxJS);
            groupBoxCursos.Controls.Add(checkBoxCPlus);
            groupBoxCursos.Controls.Add(checkBoxCSharp);
            groupBoxCursos.Location = new Point(451, 247);
            groupBoxCursos.Name = "groupBoxCursos";
            groupBoxCursos.Size = new Size(123, 143);
            groupBoxCursos.TabIndex = 2;
            groupBoxCursos.TabStop = false;
            groupBoxCursos.Text = "Cursos";
            // 
            // checkBoxJS
            // 
            checkBoxJS.AutoSize = true;
            checkBoxJS.Location = new Point(35, 103);
            checkBoxJS.Name = "checkBoxJS";
            checkBoxJS.Size = new Size(77, 19);
            checkBoxJS.TabIndex = 2;
            checkBoxJS.Text = "Javascript";
            checkBoxJS.UseVisualStyleBackColor = true;
            // 
            // checkBoxCPlus
            // 
            checkBoxCPlus.AutoSize = true;
            checkBoxCPlus.Location = new Point(35, 69);
            checkBoxCPlus.Name = "checkBoxCPlus";
            checkBoxCPlus.Size = new Size(50, 19);
            checkBoxCPlus.TabIndex = 1;
            checkBoxCPlus.Text = "C++";
            checkBoxCPlus.UseVisualStyleBackColor = true;
            // 
            // checkBoxCSharp
            // 
            checkBoxCSharp.AutoSize = true;
            checkBoxCSharp.Location = new Point(35, 35);
            checkBoxCSharp.Name = "checkBoxCSharp";
            checkBoxCSharp.Size = new Size(41, 19);
            checkBoxCSharp.TabIndex = 0;
            checkBoxCSharp.Text = "C#";
            checkBoxCSharp.UseVisualStyleBackColor = true;
            // 
            // listBoxPais
            // 
            listBoxPais.FormattingEnabled = true;
            listBoxPais.ItemHeight = 15;
            listBoxPais.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            listBoxPais.Location = new Point(78, 296);
            listBoxPais.Name = "listBoxPais";
            listBoxPais.Size = new Size(120, 94);
            listBoxPais.TabIndex = 3;
            // 
            // labelPais
            // 
            labelPais.AutoSize = true;
            labelPais.Location = new Point(82, 275);
            labelPais.Name = "labelPais";
            labelPais.Size = new Size(28, 15);
            labelPais.TabIndex = 4;
            labelPais.Text = "País";
            // 
            // buttonIngresar
            // 
            buttonIngresar.Location = new Point(451, 410);
            buttonIngresar.Name = "buttonIngresar";
            buttonIngresar.Size = new Size(123, 23);
            buttonIngresar.TabIndex = 5;
            buttonIngresar.Text = "Ingresar";
            buttonIngresar.UseVisualStyleBackColor = true;
            buttonIngresar.Click += buttonIngresar_Click;
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(603, 450);
            Controls.Add(buttonIngresar);
            Controls.Add(labelPais);
            Controls.Add(listBoxPais);
            Controls.Add(groupBoxCursos);
            Controls.Add(groupBoxGenero);
            Controls.Add(groupBoxDetallesUsuario);
            Name = "FormRegistro";
            Text = "Registro";
            groupBoxDetallesUsuario.ResumeLayout(false);
            groupBoxDetallesUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownEdad).EndInit();
            groupBoxGenero.ResumeLayout(false);
            groupBoxGenero.PerformLayout();
            groupBoxCursos.ResumeLayout(false);
            groupBoxCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxDetallesUsuario;
        private Label labelEdad;
        private Label labelDireccion;
        private Label labelNombre;
        private NumericUpDown numericUpDownEdad;
        private TextBox textBoxDireccion;
        private TextBox textBoxNombre;
        private GroupBox groupBoxGenero;
        private RadioButton radioButtonNoBinario;
        private RadioButton radioButtonFemenino;
        private RadioButton radioButtonMasculino;
        private GroupBox groupBoxCursos;
        private CheckBox checkBoxJS;
        private CheckBox checkBoxCPlus;
        private CheckBox checkBoxCSharp;
        private ListBox listBoxPais;
        private Label labelPais;
        private Button buttonIngresar;
    }
}