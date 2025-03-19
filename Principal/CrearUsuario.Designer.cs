namespace Principal
{
    partial class CrearUsuario
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
            btGuardar = new Button();
            lbResultado = new Label();
            tbNombre = new TextBox();
            tbDescription = new TextBox();
            SuspendLayout();
            // 
            // btGuardar
            // 
            btGuardar.Location = new Point(276, 176);
            btGuardar.Name = "btGuardar";
            btGuardar.Size = new Size(75, 23);
            btGuardar.TabIndex = 0;
            btGuardar.Text = "Crear";
            btGuardar.UseVisualStyleBackColor = true;
            btGuardar.Click += btGuardar_Click;
            // 
            // lbResultado
            // 
            lbResultado.AutoSize = true;
            lbResultado.Location = new Point(276, 241);
            lbResultado.Name = "lbResultado";
            lbResultado.Size = new Size(38, 15);
            lbResultado.TabIndex = 1;
            lbResultado.Text = "label1";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(276, 57);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(175, 23);
            tbNombre.TabIndex = 2;
            // 
            // tbDescription
            // 
            tbDescription.Location = new Point(276, 120);
            tbDescription.Name = "tbDescription";
            tbDescription.Size = new Size(175, 23);
            tbDescription.TabIndex = 3;
            // 
            // CrearUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tbDescription);
            Controls.Add(tbNombre);
            Controls.Add(lbResultado);
            Controls.Add(btGuardar);
            Name = "CrearUsuario";
            Text = "CrearUsuario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btGuardar;
        private Label lbResultado;
        private TextBox tbNombre;
        private TextBox tbDescription;
    }
}