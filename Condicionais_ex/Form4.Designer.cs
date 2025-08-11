namespace Condicionais_ex
{
    partial class frmex1
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
            this.btnresetar = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.lblpubli = new System.Windows.Forms.Label();
            this.lblrenda = new System.Windows.Forms.Label();
            this.txtpubli = new System.Windows.Forms.TextBox();
            this.txtrenda = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnresetar
            // 
            this.btnresetar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetar.Location = new System.Drawing.Point(251, 398);
            this.btnresetar.Name = "btnresetar";
            this.btnresetar.Size = new System.Drawing.Size(75, 23);
            this.btnresetar.TabIndex = 17;
            this.btnresetar.Text = "Resetar";
            this.btnresetar.UseVisualStyleBackColor = true;
            this.btnresetar.Click += new System.EventHandler(this.btnresetar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(135, 398);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(86, 23);
            this.btncalcular.TabIndex = 16;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(356, 398);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 15;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblpubli
            // 
            this.lblpubli.AutoSize = true;
            this.lblpubli.Location = new System.Drawing.Point(149, 124);
            this.lblpubli.Name = "lblpubli";
            this.lblpubli.Size = new System.Drawing.Size(150, 18);
            this.lblpubli.TabIndex = 18;
            this.lblpubli.Text = "Digite o público total";
            // 
            // lblrenda
            // 
            this.lblrenda.AutoSize = true;
            this.lblrenda.Location = new System.Drawing.Point(179, 210);
            this.lblrenda.Name = "lblrenda";
            this.lblrenda.Size = new System.Drawing.Size(120, 18);
            this.lblrenda.TabIndex = 19;
            this.lblrenda.Text = "A renda total foi:";
            // 
            // txtpubli
            // 
            this.txtpubli.Location = new System.Drawing.Point(305, 121);
            this.txtpubli.Name = "txtpubli";
            this.txtpubli.Size = new System.Drawing.Size(100, 26);
            this.txtpubli.TabIndex = 20;
            // 
            // txtrenda
            // 
            this.txtrenda.Location = new System.Drawing.Point(305, 207);
            this.txtrenda.Name = "txtrenda";
            this.txtrenda.ReadOnly = true;
            this.txtrenda.Size = new System.Drawing.Size(100, 26);
            this.txtrenda.TabIndex = 21;
            // 
            // frmex1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 451);
            this.ControlBox = false;
            this.Controls.Add(this.txtrenda);
            this.Controls.Add(this.txtpubli);
            this.Controls.Add(this.lblrenda);
            this.Controls.Add(this.lblpubli);
            this.Controls.Add(this.btnresetar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnvoltar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmex1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnresetar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblpubli;
        private System.Windows.Forms.Label lblrenda;
        private System.Windows.Forms.TextBox txtpubli;
        private System.Windows.Forms.TextBox txtrenda;
    }
}