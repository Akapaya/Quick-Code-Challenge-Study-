namespace prj_ex02_31927
{
    partial class Form_ex02_31927
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
            this.btnmenor = new System.Windows.Forms.Button();
            this.btnlim = new System.Windows.Forms.Button();
            this.btnsai = new System.Windows.Forms.Button();
            this.txtval1 = new System.Windows.Forms.TextBox();
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.txtval3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmenor
            // 
            this.btnmenor.Location = new System.Drawing.Point(13, 114);
            this.btnmenor.Name = "btnmenor";
            this.btnmenor.Size = new System.Drawing.Size(75, 23);
            this.btnmenor.TabIndex = 0;
            this.btnmenor.Text = "Menor";
            this.btnmenor.UseVisualStyleBackColor = true;
            this.btnmenor.Click += new System.EventHandler(this.btnmenor_Click);
            // 
            // btnlim
            // 
            this.btnlim.Location = new System.Drawing.Point(94, 114);
            this.btnlim.Name = "btnlim";
            this.btnlim.Size = new System.Drawing.Size(75, 23);
            this.btnlim.TabIndex = 1;
            this.btnlim.Text = "Limpar";
            this.btnlim.UseVisualStyleBackColor = true;
            this.btnlim.Click += new System.EventHandler(this.btnlim_Click);
            // 
            // btnsai
            // 
            this.btnsai.Location = new System.Drawing.Point(175, 114);
            this.btnsai.Name = "btnsai";
            this.btnsai.Size = new System.Drawing.Size(75, 23);
            this.btnsai.TabIndex = 2;
            this.btnsai.Text = "Sair";
            this.btnsai.UseVisualStyleBackColor = true;
            this.btnsai.Click += new System.EventHandler(this.btnsai_Click);
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(13, 59);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(67, 20);
            this.txtval1.TabIndex = 3;
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(94, 59);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(67, 20);
            this.txtval2.TabIndex = 4;
            this.txtval2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtval3
            // 
            this.txtval3.Location = new System.Drawing.Point(175, 59);
            this.txtval3.Name = "txtval3";
            this.txtval3.ReadOnly = true;
            this.txtval3.Size = new System.Drawing.Size(67, 20);
            this.txtval3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "1º valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "2º valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Menor";
            // 
            // Form_ex02_31927
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 172);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtval3);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.txtval1);
            this.Controls.Add(this.btnsai);
            this.Controls.Add(this.btnlim);
            this.Controls.Add(this.btnmenor);
            this.Name = "Form_ex02_31927";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmenor;
        private System.Windows.Forms.Button btnlim;
        private System.Windows.Forms.Button btnsai;
        private System.Windows.Forms.TextBox txtval1;
        private System.Windows.Forms.TextBox txtval2;
        private System.Windows.Forms.TextBox txtval3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

