namespace Principal
{
    partial class Menu
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
            btUsuario = new Button();
            btCrear = new Button();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip1 = new ToolStrip();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btUsuario
            // 
            btUsuario.Location = new Point(163, 131);
            btUsuario.Name = "btUsuario";
            btUsuario.Size = new Size(153, 90);
            btUsuario.TabIndex = 0;
            btUsuario.Text = "Usuarios";
            btUsuario.UseVisualStyleBackColor = true;
            btUsuario.Click += btUsuario_Click;
            // 
            // btCrear
            // 
            btCrear.Location = new Point(365, 131);
            btCrear.Name = "btCrear";
            btCrear.Size = new Size(165, 90);
            btCrear.TabIndex = 1;
            btCrear.Text = "Guardar Usuario";
            btCrear.UseVisualStyleBackColor = true;
            btCrear.Click += btCrear_Click;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.ForeColor = Color.White;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(155, 46);
            toolStripLabel1.Text = "BIKERIDE";
            toolStripLabel1.Click += toolStripLabel1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Blue;
            toolStrip1.Font = new Font("Segoe UI", 25F);
            toolStrip1.GripMargin = new Padding(4);
            toolStrip1.ImageScalingSize = new Size(26, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 49);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(btCrear);
            Controls.Add(btUsuario);
            Name = "Menu";
            Text = "Menu";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btUsuario;
        private Button btCrear;
        private ToolStripLabel toolStripLabel1;
        private ToolStrip toolStrip1;
    }
}