namespace Condicionais_ex
{
    partial class frmex2
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
            this.lbllivros = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.txtlivros = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnresetar
            // 
            this.btnresetar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetar.Location = new System.Drawing.Point(272, 368);
            this.btnresetar.Name = "btnresetar";
            this.btnresetar.Size = new System.Drawing.Size(75, 23);
            this.btnresetar.TabIndex = 14;
            this.btnresetar.Text = "Resetar";
            this.btnresetar.UseVisualStyleBackColor = true;
            this.btnresetar.Click += new System.EventHandler(this.btnresetar_Click);
            // 
            // btncalcular
            // 
            this.btncalcular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(156, 368);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(86, 23);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(377, 368);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 12;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lbllivros
            // 
            this.lbllivros.AutoSize = true;
            this.lbllivros.Location = new System.Drawing.Point(84, 108);
            this.lbllivros.Name = "lbllivros";
            this.lbllivros.Size = new System.Drawing.Size(290, 18);
            this.lbllivros.TabIndex = 15;
            this.lbllivros.Text = "Digite a quantidade de livros comprados";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(174, 189);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(115, 18);
            this.lblvalor.TabIndex = 16;
            this.lblvalor.Text = "O valor total foi:";
            // 
            // txtlivros
            // 
            this.txtlivros.Location = new System.Drawing.Point(383, 105);
            this.txtlivros.Name = "txtlivros";
            this.txtlivros.Size = new System.Drawing.Size(100, 26);
            this.txtlivros.TabIndex = 17;
            // 
            // txtvalor
            // 
            this.txtvalor.Location = new System.Drawing.Point(295, 186);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.ReadOnly = true;
            this.txtvalor.Size = new System.Drawing.Size(100, 26);
            this.txtvalor.TabIndex = 18;
            // 
            // frmex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 420);
            this.ControlBox = false;
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtlivros);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.lbllivros);
            this.Controls.Add(this.btnresetar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnvoltar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmex2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnresetar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lbllivros;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.TextBox txtlivros;
        private System.Windows.Forms.TextBox txtvalor;
    }
}