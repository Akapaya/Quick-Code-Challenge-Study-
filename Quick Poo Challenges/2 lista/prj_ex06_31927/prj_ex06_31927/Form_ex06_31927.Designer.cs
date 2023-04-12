namespace prj_ex06_31927
{
    partial class Form_ex06_31927
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
            this.txtval1 = new System.Windows.Forms.TextBox();
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.txtval3 = new System.Windows.Forms.TextBox();
            this.txtval4 = new System.Windows.Forms.TextBox();
            this.valor1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btcalc = new System.Windows.Forms.Button();
            this.btlim = new System.Windows.Forms.Button();
            this.btsai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(13, 41);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(56, 20);
            this.txtval1.TabIndex = 0;
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(75, 41);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(56, 20);
            this.txtval2.TabIndex = 1;
            // 
            // txtval3
            // 
            this.txtval3.Location = new System.Drawing.Point(137, 41);
            this.txtval3.Name = "txtval3";
            this.txtval3.Size = new System.Drawing.Size(56, 20);
            this.txtval3.TabIndex = 2;
            // 
            // txtval4
            // 
            this.txtval4.Location = new System.Drawing.Point(199, 41);
            this.txtval4.Name = "txtval4";
            this.txtval4.ReadOnly = true;
            this.txtval4.Size = new System.Drawing.Size(56, 20);
            this.txtval4.TabIndex = 3;
            // 
            // valor1
            // 
            this.valor1.AutoSize = true;
            this.valor1.Location = new System.Drawing.Point(22, 25);
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(39, 13);
            this.valor1.TabIndex = 4;
            this.valor1.Text = "valor 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "valor 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "valor 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(209, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Maior";
            // 
            // btcalc
            // 
            this.btcalc.Location = new System.Drawing.Point(13, 82);
            this.btcalc.Name = "btcalc";
            this.btcalc.Size = new System.Drawing.Size(75, 23);
            this.btcalc.TabIndex = 8;
            this.btcalc.Text = "Calcular";
            this.btcalc.UseVisualStyleBackColor = true;
            this.btcalc.Click += new System.EventHandler(this.btcalc_Click);
            // 
            // btlim
            // 
            this.btlim.Location = new System.Drawing.Point(110, 82);
            this.btlim.Name = "btlim";
            this.btlim.Size = new System.Drawing.Size(75, 23);
            this.btlim.TabIndex = 9;
            this.btlim.Text = "Limpar";
            this.btlim.UseVisualStyleBackColor = true;
            this.btlim.Click += new System.EventHandler(this.btlim_Click);
            // 
            // btsai
            // 
            this.btsai.Location = new System.Drawing.Point(199, 82);
            this.btsai.Name = "btsai";
            this.btsai.Size = new System.Drawing.Size(75, 23);
            this.btsai.TabIndex = 10;
            this.btsai.Text = "Sair";
            this.btsai.UseVisualStyleBackColor = true;
            this.btsai.Click += new System.EventHandler(this.btsai_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 127);
            this.Controls.Add(this.btsai);
            this.Controls.Add(this.btlim);
            this.Controls.Add(this.btcalc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.valor1);
            this.Controls.Add(this.txtval4);
            this.Controls.Add(this.txtval3);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.txtval1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtval1;
        private System.Windows.Forms.TextBox txtval2;
        private System.Windows.Forms.TextBox txtval3;
        private System.Windows.Forms.TextBox txtval4;
        private System.Windows.Forms.Label valor1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btcalc;
        private System.Windows.Forms.Button btlim;
        private System.Windows.Forms.Button btsai;
    }
}

