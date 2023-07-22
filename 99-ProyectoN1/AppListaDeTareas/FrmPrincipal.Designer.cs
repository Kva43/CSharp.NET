namespace AppListaDeTareas
{
    partial class FrmPrincipal
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
            btnAgregar = new Button();
            btnListar = new Button();
            btnCompletar = new Button();
            txtDescripcion = new TextBox();
            lstTareas = new ListBox();
            chkCompletada = new CheckBox();
            chkImportante = new CheckBox();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(31, 117);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(31, 166);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 1;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);

            // 
            // btnCompletar
            // 
            btnCompletar.Location = new Point(31, 211);
            btnCompletar.Name = "btnCompletar";
            btnCompletar.Size = new Size(75, 23);
            btnCompletar.TabIndex = 2;
            btnCompletar.Text = "Completar";
            btnCompletar.UseVisualStyleBackColor = true;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(31, 44);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(100, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // lstTareas
            // 
            lstTareas.FormattingEnabled = true;
            lstTareas.ItemHeight = 15;
            lstTareas.Location = new Point(212, 44);
            lstTareas.Name = "lstTareas";
            lstTareas.Size = new Size(256, 229);
            lstTareas.TabIndex = 4;
            // 
            // chkCompletada
            // 
            chkCompletada.AutoSize = true;
            chkCompletada.Location = new Point(112, 117);
            chkCompletada.Name = "chkCompletada";
            chkCompletada.Size = new Size(91, 19);
            chkCompletada.TabIndex = 5;
            chkCompletada.Text = "Completada";
            chkCompletada.UseVisualStyleBackColor = true;
            // 
            // chkImportante
            // 
            chkImportante.AutoSize = true;
            chkImportante.Location = new Point(112, 142);
            chkImportante.Name = "chkImportante";
            chkImportante.Size = new Size(85, 19);
            chkImportante.TabIndex = 6;
            chkImportante.Text = "Importante";
            chkImportante.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 303);
            Controls.Add(chkImportante);
            Controls.Add(chkCompletada);
            Controls.Add(lstTareas);
            Controls.Add(txtDescripcion);
            Controls.Add(btnCompletar);
            Controls.Add(btnListar);
            Controls.Add(btnAgregar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnListar;
        private Button btnCompletar;
        private TextBox txtDescripcion;
        private ListBox lstTareas;
        private CheckBox chkCompletada;
        private CheckBox chkImportante;
    }
}