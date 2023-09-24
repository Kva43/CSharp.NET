namespace _05_Forms_EjercicioExtra3
{
    partial class FrmDescuento
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
            groupBoxInformacion = new GroupBox();
            txtBoxTotal = new TextBox();
            txtBoxDescuento = new TextBox();
            txtBoxIngreso = new TextBox();
            lblTotal = new Label();
            lblDescuento = new Label();
            lblIngresoImporte = new Label();
            btnAceptar = new Button();
            btnLimpiar = new Button();
            groupBoxInformacion.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxInformacion
            // 
            groupBoxInformacion.Controls.Add(txtBoxTotal);
            groupBoxInformacion.Controls.Add(txtBoxDescuento);
            groupBoxInformacion.Controls.Add(txtBoxIngreso);
            groupBoxInformacion.Controls.Add(lblTotal);
            groupBoxInformacion.Controls.Add(lblDescuento);
            groupBoxInformacion.Controls.Add(lblIngresoImporte);
            groupBoxInformacion.Location = new Point(29, 25);
            groupBoxInformacion.Name = "groupBoxInformacion";
            groupBoxInformacion.Size = new Size(376, 189);
            groupBoxInformacion.TabIndex = 0;
            groupBoxInformacion.TabStop = false;
            groupBoxInformacion.Text = "Información";
            // 
            // txtBoxTotal
            // 
            txtBoxTotal.Enabled = false;
            txtBoxTotal.Location = new Point(206, 138);
            txtBoxTotal.Name = "txtBoxTotal";
            txtBoxTotal.Size = new Size(152, 23);
            txtBoxTotal.TabIndex = 5;
            // 
            // txtBoxDescuento
            // 
            txtBoxDescuento.Enabled = false;
            txtBoxDescuento.Location = new Point(206, 95);
            txtBoxDescuento.Name = "txtBoxDescuento";
            txtBoxDescuento.Size = new Size(152, 23);
            txtBoxDescuento.TabIndex = 4;
            // 
            // txtBoxIngreso
            // 
            txtBoxIngreso.Location = new Point(206, 48);
            txtBoxIngreso.Name = "txtBoxIngreso";
            txtBoxIngreso.Size = new Size(152, 23);
            txtBoxIngreso.TabIndex = 3;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(90, 139);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(94, 17);
            lblTotal.TabIndex = 2;
            lblTotal.Text = "Total a pagar:";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Location = new Point(72, 98);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(112, 15);
            lblDescuento.TabIndex = 1;
            lblDescuento.Text = "Descuento recibido:";
            // 
            // lblIngresoImporte
            // 
            lblIngresoImporte.AutoSize = true;
            lblIngresoImporte.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblIngresoImporte.Location = new Point(14, 49);
            lblIngresoImporte.Name = "lblIngresoImporte";
            lblIngresoImporte.Size = new Size(170, 17);
            lblIngresoImporte.TabIndex = 0;
            lblIngresoImporte.Text = "Ingresar importe a cobrar:";
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(78, 230);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(103, 32);
            btnAceptar.TabIndex = 1;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(235, 230);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 32);
            btnLimpiar.TabIndex = 2;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmDescuento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 281);
            Controls.Add(btnLimpiar);
            Controls.Add(btnAceptar);
            Controls.Add(groupBoxInformacion);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDescuento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Descuento";
            groupBoxInformacion.ResumeLayout(false);
            groupBoxInformacion.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxInformacion;
        private TextBox txtBoxTotal;
        private TextBox txtBoxDescuento;
        private TextBox txtBoxIngreso;
        private Label lblTotal;
        private Label lblDescuento;
        private Label lblIngresoImporte;
        private Button btnAceptar;
        private Button btnLimpiar;
    }
}