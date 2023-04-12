namespace prj_ex07_31927
{
    partial class Form_ex07_31927
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtval1 = new System.Windows.Forms.TextBox();
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.txtval3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btcalc = new System.Windows.Forms.Button();
            this.btlim = new System.Windows.Forms.Button();
            this.btsai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura";
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(17, 56);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(49, 20);
            this.txtval1.TabIndex = 2;
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(86, 56);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(49, 20);
            this.txtval2.TabIndex = 3;
            // 
            // txtval3
            // 
            this.txtval3.Location = new System.Drawing.Point(176, 56);
            this.txtval3.Name = "txtval3";
            this.txtval3.ReadOnly = true;
            this.txtval3.Size = new System.Drawing.Size(57, 20);
            this.txtval3.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Resultado";
            // 
            // btcalc
            // 
            this.btcalc.Location = new System.Drawing.Point(3, 95);
            this.btcalc.Name = "btcalc";
            this.btcalc.Size = new System.Drawing.Size(75, 23);
            this.btcalc.TabIndex = 6;
            this.btcalc.Text = "Calcular";
            this.btcalc.UseVisualStyleBackColor = true;
            this.btcalc.Click += new System.EventHandler(this.btcalc_Click);
            // 
            // btlim
            // 
            this.btlim.Location = new System.Drawing.Point(95, 95);
            this.btlim.Name = "btlim";
            this.btlim.Size = new System.Drawing.Size(75, 23);
            this.btlim.TabIndex = 7;
            this.btlim.Text = "Limpar";
            this.btlim.UseVisualStyleBackColor = true;
            this.btlim.Click += new System.EventHandler(this.btlim_Click);
            // 
            // btsai
            // 
            this.btsai.Location = new System.Drawing.Point(181, 95);
            this.btsai.Name = "btsai";
            this.btsai.Size = new System.Drawing.Size(75, 23);
            this.btsai.TabIndex = 8;
            this.btsai.Text = "Sair";
            this.btsai.UseVisualStyleBackColor = true;
            this.btsai.Click += new System.EventHandler(this.btsai_Click);
            // 
            // Form_ex07_31927
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 147);
            this.Controls.Add(this.btsai);
            this.Controls.Add(this.btlim);
            this.Controls.Add(this.btcalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtval3);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.txtval1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_ex07_31927";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_ex07_31927_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtval1;
        private System.Windows.Forms.TextBox txtval2;
        private System.Windows.Forms.TextBox txtval3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btcalc;
        private System.Windows.Forms.Button btlim;
        private System.Windows.Forms.Button btsai;
    }
}

