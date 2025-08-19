namespace Condicionais_ex
{
    partial class frmex5
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
            this.lblpeso = new System.Windows.Forms.Label();
            this.lblaltura = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.lblimc = new System.Windows.Forms.Label();
            this.txtimc = new System.Windows.Forms.TextBox();
            this.lblclasse = new System.Windows.Forms.Label();
            this.txtclasse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnresetar
            // 
            this.btnresetar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresetar.Location = new System.Drawing.Point(303, 368);
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
            this.btncalcular.Location = new System.Drawing.Point(145, 368);
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
            this.btnvoltar.Location = new System.Drawing.Point(440, 368);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 15;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // lblpeso
            // 
            this.lblpeso.AutoSize = true;
            this.lblpeso.Location = new System.Drawing.Point(142, 57);
            this.lblpeso.Name = "lblpeso";
            this.lblpeso.Size = new System.Drawing.Size(118, 18);
            this.lblpeso.TabIndex = 18;
            this.lblpeso.Text = "Digite seu peso";
            this.lblpeso.Click += new System.EventHandler(this.lblpeso_Click);
            // 
            // lblaltura
            // 
            this.lblaltura.AutoSize = true;
            this.lblaltura.Location = new System.Drawing.Point(142, 117);
            this.lblaltura.Name = "lblaltura";
            this.lblaltura.Size = new System.Drawing.Size(121, 18);
            this.lblaltura.TabIndex = 19;
            this.lblaltura.Text = "Digite sua altura";
            this.lblaltura.Click += new System.EventHandler(this.lblaltura_Click);
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(303, 54);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 26);
            this.txtpeso.TabIndex = 20;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(303, 114);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(100, 26);
            this.txtaltura.TabIndex = 21;
            // 
            // lblimc
            // 
            this.lblimc.AutoSize = true;
            this.lblimc.Location = new System.Drawing.Point(142, 199);
            this.lblimc.Name = "lblimc";
            this.lblimc.Size = new System.Drawing.Size(98, 18);
            this.lblimc.TabIndex = 22;
            this.lblimc.Text = "O seu IMC é:";
            this.lblimc.Click += new System.EventHandler(this.lblimc_Click);
            // 
            // txtimc
            // 
            this.txtimc.Location = new System.Drawing.Point(303, 196);
            this.txtimc.Name = "txtimc";
            this.txtimc.ReadOnly = true;
            this.txtimc.Size = new System.Drawing.Size(212, 26);
            this.txtimc.TabIndex = 23;
            // 
            // lblclasse
            // 
            this.lblclasse.AutoSize = true;
            this.lblclasse.Location = new System.Drawing.Point(142, 253);
            this.lblclasse.Name = "lblclasse";
            this.lblclasse.Size = new System.Drawing.Size(148, 18);
            this.lblclasse.TabIndex = 24;
            this.lblclasse.Text = "Sua classificação é:";
            // 
            // txtclasse
            // 
            this.txtclasse.Location = new System.Drawing.Point(303, 250);
            this.txtclasse.Name = "txtclasse";
            this.txtclasse.ReadOnly = true;
            this.txtclasse.Size = new System.Drawing.Size(212, 26);
            this.txtclasse.TabIndex = 25;
            // 
            // frmex5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 437);
            this.ControlBox = false;
            this.Controls.Add(this.txtclasse);
            this.Controls.Add(this.lblclasse);
            this.Controls.Add(this.txtimc);
            this.Controls.Add(this.lblimc);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.lblaltura);
            this.Controls.Add(this.lblpeso);
            this.Controls.Add(this.btnresetar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.btnvoltar);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmex5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnresetar;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Label lblpeso;
        private System.Windows.Forms.Label lblaltura;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label lblimc;
        private System.Windows.Forms.TextBox txtimc;
        private System.Windows.Forms.Label lblclasse;
        private System.Windows.Forms.TextBox txtclasse;
    }
}