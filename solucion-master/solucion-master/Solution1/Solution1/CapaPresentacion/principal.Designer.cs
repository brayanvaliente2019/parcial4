namespace CapaPresentacion
{
    partial class principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.enfermoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pantillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enfermoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(433, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // enfermoToolStripMenuItem
            // 
            this.enfermoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hospitalToolStripMenuItem,
            this.hospitalToolStripMenuItem1,
            this.doctorToolStripMenuItem,
            this.salaToolStripMenuItem,
            this.pantillaToolStripMenuItem,
            this.deToolStripMenuItem,
            this.emoToolStripMenuItem});
            this.enfermoToolStripMenuItem.Name = "enfermoToolStripMenuItem";
            this.enfermoToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.enfermoToolStripMenuItem.Text = "enfermo";
            // 
            // hospitalToolStripMenuItem
            // 
            this.hospitalToolStripMenuItem.Name = "hospitalToolStripMenuItem";
            this.hospitalToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.hospitalToolStripMenuItem.Text = "enfermo";
            this.hospitalToolStripMenuItem.Click += new System.EventHandler(this.hospitalToolStripMenuItem_Click);
            // 
            // hospitalToolStripMenuItem1
            // 
            this.hospitalToolStripMenuItem1.Name = "hospitalToolStripMenuItem1";
            this.hospitalToolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            this.hospitalToolStripMenuItem1.Text = "hospital";
            this.hospitalToolStripMenuItem1.Click += new System.EventHandler(this.hospitalToolStripMenuItem1_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.doctorToolStripMenuItem.Text = "doctor";
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.salaToolStripMenuItem.Text = "sala";
            // 
            // pantillaToolStripMenuItem
            // 
            this.pantillaToolStripMenuItem.Name = "pantillaToolStripMenuItem";
            this.pantillaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.pantillaToolStripMenuItem.Text = "pantilla";
            // 
            // deToolStripMenuItem
            // 
            this.deToolStripMenuItem.Name = "deToolStripMenuItem";
            this.deToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.deToolStripMenuItem.Text = "departamento(hospital)";
            // 
            // emoToolStripMenuItem
            // 
            this.emoToolStripMenuItem.Name = "emoToolStripMenuItem";
            this.emoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.emoToolStripMenuItem.Text = "emo";
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 245);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "principal";
            this.Text = "principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem enfermoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pantillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emoToolStripMenuItem;

    }
}



