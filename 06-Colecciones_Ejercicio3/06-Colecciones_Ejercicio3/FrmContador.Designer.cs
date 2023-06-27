namespace _06_Colecciones_Ejercicio3
{
    partial class FrmContador
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
            rtbContador = new RichTextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // rtbContador
            // 
            rtbContador.Location = new Point(12, 12);
            rtbContador.Name = "rtbContador";
            rtbContador.Size = new Size(276, 282);
            rtbContador.TabIndex = 0;
            rtbContador.Text = "";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(157, 318);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(131, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // FrmContador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(302, 353);
            Controls.Add(btnCalcular);
            Controls.Add(rtbContador);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmContador";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Contador de palabras";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox rtbContador;
        private Button btnCalcular;
    }
}