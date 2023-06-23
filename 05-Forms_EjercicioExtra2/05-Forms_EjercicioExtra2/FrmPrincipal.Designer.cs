namespace _05_Forms_EjercicioExtra2
{
    partial class FrmTabla
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
            txtNumero = new TextBox();
            lstTabla = new ListBox();
            label1 = new Label();
            btnLimpiar = new Button();
            SuspendLayout();
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(172, 46);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(100, 23);
            txtNumero.TabIndex = 0;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // lstTabla
            // 
            lstTabla.FormattingEnabled = true;
            lstTabla.ItemHeight = 15;
            lstTabla.Location = new Point(27, 95);
            lstTabla.Name = "lstTabla";
            lstTabla.Size = new Size(258, 214);
            lstTabla.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 47);
            label1.Name = "label1";
            label1.Size = new Size(125, 17);
            label1.TabIndex = 2;
            label1.Text = "Ingrese un número: ";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(104, 336);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 23);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmTabla
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 386);
            Controls.Add(btnLimpiar);
            Controls.Add(label1);
            Controls.Add(lstTabla);
            Controls.Add(txtNumero);
            Name = "FrmTabla";
            Text = "Tabla";
            FormClosing += FrmTabla_FormClosing;
            KeyPress += txtNumero_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNumero;
        private ListBox lstTabla;
        private Label label1;
        private Button btnLimpiar;
    }
}