﻿namespace WinFormsApp1
{
    partial class MDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejemplosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inssLaboralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilidadToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ejemplosToolStripMenuItem
            // 
            this.ejemplosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inssLaboralToolStripMenuItem,
            this.utilidadToolStripMenuItem1});
            this.ejemplosToolStripMenuItem.Name = "ejemplosToolStripMenuItem";
            this.ejemplosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ejemplosToolStripMenuItem.Text = "Ejemplos";
            // 
            // inssLaboralToolStripMenuItem
            // 
            this.inssLaboralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.utilidadToolStripMenuItem});
            this.inssLaboralToolStripMenuItem.Name = "inssLaboralToolStripMenuItem";
            this.inssLaboralToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.inssLaboralToolStripMenuItem.Text = "Inss Laboral";
            this.inssLaboralToolStripMenuItem.Click += new System.EventHandler(this.inssLaboralToolStripMenuItem_Click);
            // 
            // utilidadToolStripMenuItem
            // 
            this.utilidadToolStripMenuItem.Name = "utilidadToolStripMenuItem";
            this.utilidadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.utilidadToolStripMenuItem.Text = "Utilidad";
            // 
            // utilidadToolStripMenuItem1
            // 
            this.utilidadToolStripMenuItem1.Name = "utilidadToolStripMenuItem1";
            this.utilidadToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.utilidadToolStripMenuItem1.Text = "Utilidad";
            this.utilidadToolStripMenuItem1.Click += new System.EventHandler(this.utilidadToolStripMenuItem1_Click);
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDI";
            this.Text = "Sistema Ejemplo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem ejemplosToolStripMenuItem;
        private ToolStripMenuItem inssLaboralToolStripMenuItem;
        private ToolStripMenuItem utilidadToolStripMenuItem;
        private ToolStripMenuItem utilidadToolStripMenuItem1;
    }
}