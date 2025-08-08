namespace Condicionais_ex
{
    partial class frmmenu
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
            this.tsmiexs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiex1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiex2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiex3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiexs,
            this.tsmisair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(502, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiexs
            // 
            this.tsmiexs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiex1,
            this.tsmiex2,
            this.tsmiex3});
            this.tsmiexs.Name = "tsmiexs";
            this.tsmiexs.Size = new System.Drawing.Size(71, 20);
            this.tsmiexs.Text = "Exercícios";
            // 
            // tsmiex1
            // 
            this.tsmiex1.Name = "tsmiex1";
            this.tsmiex1.Size = new System.Drawing.Size(180, 22);
            this.tsmiex1.Text = "Exercício 1";
            this.tsmiex1.Click += new System.EventHandler(this.tsmiex1_Click);
            // 
            // tsmiex2
            // 
            this.tsmiex2.Name = "tsmiex2";
            this.tsmiex2.Size = new System.Drawing.Size(180, 22);
            this.tsmiex2.Text = "Exercício 2";
            this.tsmiex2.Click += new System.EventHandler(this.tsmiex2_Click);
            // 
            // tsmiex3
            // 
            this.tsmiex3.Name = "tsmiex3";
            this.tsmiex3.Size = new System.Drawing.Size(180, 22);
            this.tsmiex3.Text = "Exercício 3";
            this.tsmiex3.Click += new System.EventHandler(this.tsmiex3_Click);
            // 
            // tsmisair
            // 
            this.tsmisair.Name = "tsmisair";
            this.tsmisair.Size = new System.Drawing.Size(38, 20);
            this.tsmisair.Text = "Sair";
            this.tsmisair.Click += new System.EventHandler(this.tsmisair_Click);
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 357);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiexs;
        private System.Windows.Forms.ToolStripMenuItem tsmiex1;
        private System.Windows.Forms.ToolStripMenuItem tsmiex2;
        private System.Windows.Forms.ToolStripMenuItem tsmiex3;
        private System.Windows.Forms.ToolStripMenuItem tsmisair;
    }
}

