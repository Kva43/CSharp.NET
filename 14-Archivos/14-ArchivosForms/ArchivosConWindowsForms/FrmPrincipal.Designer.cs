namespace ArchivosConWindowsForms
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
            btnNombre = new Button();
            btnApellido = new Button();
            btnLegajo = new Button();
            btnCorreo = new Button();
            btnClave = new Button();
            btnPerfil = new Button();
            SuspendLayout();
            // 
            // btnNombre
            // 
            btnNombre.Location = new Point(27, 51);
            btnNombre.Name = "btnNombre";
            btnNombre.Size = new Size(75, 23);
            btnNombre.TabIndex = 0;
            btnNombre.Text = "Nombre";
            btnNombre.UseVisualStyleBackColor = true;
            btnNombre.Click += btnNombre_Click;
            // 
            // btnApellido
            // 
            btnApellido.Location = new Point(120, 51);
            btnApellido.Name = "btnApellido";
            btnApellido.Size = new Size(75, 23);
            btnApellido.TabIndex = 1;
            btnApellido.Text = "Apellido";
            btnApellido.UseVisualStyleBackColor = true;
            btnApellido.Click += btnApellido_Click;
            // 
            // btnLegajo
            // 
            btnLegajo.Location = new Point(210, 51);
            btnLegajo.Name = "btnLegajo";
            btnLegajo.Size = new Size(75, 23);
            btnLegajo.TabIndex = 2;
            btnLegajo.Text = "Legajo";
            btnLegajo.UseVisualStyleBackColor = true;
            btnLegajo.Click += btnLegajo_Click;
            // 
            // btnCorreo
            // 
            btnCorreo.Location = new Point(27, 107);
            btnCorreo.Name = "btnCorreo";
            btnCorreo.Size = new Size(75, 23);
            btnCorreo.TabIndex = 3;
            btnCorreo.Text = "Correo";
            btnCorreo.UseVisualStyleBackColor = true;
            btnCorreo.Click += btnCorreo_Click;
            // 
            // btnClave
            // 
            btnClave.Location = new Point(120, 107);
            btnClave.Name = "btnClave";
            btnClave.Size = new Size(75, 23);
            btnClave.TabIndex = 4;
            btnClave.Text = "Clave";
            btnClave.UseVisualStyleBackColor = true;
            btnClave.Click += btnClave_Click;
            // 
            // btnPerfil
            // 
            btnPerfil.Location = new Point(210, 107);
            btnPerfil.Name = "btnPerfil";
            btnPerfil.Size = new Size(75, 23);
            btnPerfil.TabIndex = 5;
            btnPerfil.Text = "Perfil";
            btnPerfil.UseVisualStyleBackColor = true;
            btnPerfil.Click += btnPerfil_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(336, 185);
            Controls.Add(btnPerfil);
            Controls.Add(btnClave);
            Controls.Add(btnCorreo);
            Controls.Add(btnLegajo);
            Controls.Add(btnApellido);
            Controls.Add(btnNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnNombre;
        private Button btnApellido;
        private Button btnLegajo;
        private Button btnCorreo;
        private Button btnClave;
        private Button btnPerfil;
    }
}