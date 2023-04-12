namespace prj_ex10_31927
{
    partial class Form_ex10_31927
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
            this.chema = new System.Windows.Forms.RadioButton();
            this.chefe = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtval1 = new System.Windows.Forms.TextBox();
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.txtval3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btcalc = new System.Windows.Forms.Button();
            this.btlim = new System.Windows.Forms.Button();
            this.btsai = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chema
            // 
            this.chema.AutoSize = true;
            this.chema.Location = new System.Drawing.Point(9, 19);
            this.chema.Name = "chema";
            this.chema.Size = new System.Drawing.Size(73, 17);
            this.chema.TabIndex = 0;
            this.chema.TabStop = true;
            this.chema.Text = "Masculino";
            this.chema.UseVisualStyleBackColor = true;
            // 
            // chefe
            // 
            this.chefe.AutoSize = true;
            this.chefe.Location = new System.Drawing.Point(88, 19);
            this.chefe.Name = "chefe";
            this.chefe.Size = new System.Drawing.Size(67, 17);
            this.chefe.TabIndex = 1;
            this.chefe.TabStop = true;
            this.chefe.Text = "Feminino";
            this.chefe.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chefe);
            this.groupBox1.Controls.Add(this.chema);
            this.groupBox1.Location = new System.Drawing.Point(3, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(164, 42);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altura";
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(3, 80);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(53, 20);
            this.txtval1.TabIndex = 5;
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(81, 80);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(53, 20);
            this.txtval2.TabIndex = 6;
            // 
            // txtval3
            // 
            this.txtval3.Location = new System.Drawing.Point(164, 80);
            this.txtval3.Name = "txtval3";
            this.txtval3.Size = new System.Drawing.Size(53, 20);
            this.txtval3.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Resultado";
            // 
            // btcalc
            // 
            this.btcalc.Location = new System.Drawing.Point(10, 116);
            this.btcalc.Name = "btcalc";
            this.btcalc.Size = new System.Drawing.Size(75, 23);
            this.btcalc.TabIndex = 9;
            this.btcalc.Text = "Calcular";
            this.btcalc.UseVisualStyleBackColor = true;
            this.btcalc.Click += new System.EventHandler(this.btcalc_Click);
            // 
            // btlim
            // 
            this.btlim.Location = new System.Drawing.Point(92, 116);
            this.btlim.Name = "btlim";
            this.btlim.Size = new System.Drawing.Size(75, 23);
            this.btlim.TabIndex = 10;
            this.btlim.Text = "Limpar";
            this.btlim.UseVisualStyleBackColor = true;
            this.btlim.Click += new System.EventHandler(this.btlim_Click);
            // 
            // btsai
            // 
            this.btsai.Location = new System.Drawing.Point(173, 116);
            this.btsai.Name = "btsai";
            this.btsai.Size = new System.Drawing.Size(75, 23);
            this.btsai.TabIndex = 11;
            this.btsai.Text = "Sair";
            this.btsai.UseVisualStyleBackColor = true;
            this.btsai.Click += new System.EventHandler(this.btsai_Click);
            // 
            // Form_ex10_31927
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 165);
            this.Controls.Add(this.btsai);
            this.Controls.Add(this.btlim);
            this.Controls.Add(this.btcalc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtval3);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.txtval1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_ex10_31927";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton chema;
        private System.Windows.Forms.RadioButton chefe;
        private System.Windows.Forms.GroupBox groupBox1;
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

