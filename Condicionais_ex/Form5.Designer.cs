namespace Condicionais_ex
{
    partial class frmex4
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
            this.lblcod = new System.Windows.Forms.Label();
            this.txtcod = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblpreco = new System.Windows.Forms.Label();
            this.txtlanche = new System.Windows.Forms.TextBox();
            this.lbllanche = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnresetar
            // 
            this.btnresetar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetar.Location = new System.Drawing.Point(266, 358);
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
            this.btncalcular.Location = new System.Drawing.Point(121, 358);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(115, 23);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "Procurar Lanche";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(371, 358);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 12;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblcod
            // 
            this.lblcod.AutoSize = true;
            this.lblcod.Location = new System.Drawing.Point(39, 58);
            this.lblcod.Name = "lblcod";
            this.lblcod.Size = new System.Drawing.Size(293, 18);
            this.lblcod.TabIndex = 15;
            this.lblcod.Text = "Digite o código do lanche (de 100 a 103)";
            // 
            // txtcod
            // 
            this.txtcod.Location = new System.Drawing.Point(346, 55);
            this.txtcod.Name = "txtcod";
            this.txtcod.Size = new System.Drawing.Size(128, 26);
            this.txtcod.TabIndex = 16;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.Location = new System.Drawing.Point(209, 143);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(0, 18);
            this.lblnome.TabIndex = 17;
            // 
            // lblpreco
            // 
            this.lblpreco.AutoSize = true;
            this.lblpreco.Location = new System.Drawing.Point(180, 223);
            this.lblpreco.Name = "lblpreco";
            this.lblpreco.Size = new System.Drawing.Size(0, 18);
            this.lblpreco.TabIndex = 18;
            // 
            // txtlanche
            // 
            this.txtlanche.Location = new System.Drawing.Point(212, 185);
            this.txtlanche.Name = "txtlanche";
            this.txtlanche.ReadOnly = true;
            this.txtlanche.Size = new System.Drawing.Size(234, 26);
            this.txtlanche.TabIndex = 19;
            // 
            // lbllanche
            // 
            this.lbllanche.AutoSize = true;
            this.lbllanche.Location = new System.Drawing.Point(123, 188);
            this.lbllanche.Name = "lbllanche";
            this.lbllanche.Size = new System.Drawing.Size(86, 18);
            this.lbllanche.TabIndex = 20;
            this.lbllanche.Text = "O lanche é:";
            // 
            // frmex4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 427);
            this.ControlBox = false;
            this.Controls.Add(this.lbllanche);
            this.Controls.Add(this.txtlanche);
            this.Controls.Add(this.lblpreco);
            this.Controls.Add(this.lblnome);
            this.Controls.Add(this.txtcod);
            this.Controls.Add(this.lblcod);
            this.Controls.Add(this.btnresetar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnvoltar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmex4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercício 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnresetar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblcod;
        private System.Windows.Forms.TextBox txtcod;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblpreco;
        private System.Windows.Forms.TextBox txtlanche;
        private System.Windows.Forms.Label lbllanche;
    }
}