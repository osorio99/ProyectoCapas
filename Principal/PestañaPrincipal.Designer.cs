namespace Principal
{
    partial class PestañaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PestañaPrincipal));
            agregar = new Button();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            toolStripButton1 = new ToolStripButton();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // agregar
            // 
            agregar.Location = new Point(686, 52);
            agregar.Name = "agregar";
            agregar.Size = new Size(102, 23);
            agregar.TabIndex = 0;
            agregar.Text = "Agregar";
            agregar.UseVisualStyleBackColor = true;
            agregar.Click += button1_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = Color.Blue;
            toolStrip1.Font = new Font("Segoe UI", 25F);
            toolStrip1.GripMargin = new Padding(4);
            toolStrip1.ImageScalingSize = new Size(26, 30);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 49);
            toolStrip1.TabIndex = 3;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.ForeColor = Color.White;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(155, 46);
            toolStripLabel1.Text = "BIKERIDE";
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(30, 46);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // PestañaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(agregar);
            Name = "PestañaPrincipal";
            Text = "PestañaPrincipal";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button agregar;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton toolStripButton1;
    }
}