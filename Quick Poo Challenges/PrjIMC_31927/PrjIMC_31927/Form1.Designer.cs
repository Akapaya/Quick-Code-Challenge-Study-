namespace PrjIMC_31927
{
    partial class Form1
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
            this.RadbttM = new System.Windows.Forms.RadioButton();
            this.RadbttF = new System.Windows.Forms.RadioButton();
            this.Opção = new System.Windows.Forms.GroupBox();
            this.txtAlt = new System.Windows.Forms.TextBox();
            this.txtPes = new System.Windows.Forms.TextBox();
            this.txtImc = new System.Windows.Forms.TextBox();
            this.bttCalc = new System.Windows.Forms.Button();
            this.bttLimpar = new System.Windows.Forms.Button();
            this.BttSai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblres = new System.Windows.Forms.Label();
            this.Opção.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadbttM
            // 
            this.RadbttM.AutoSize = true;
            this.RadbttM.Checked = true;
            this.RadbttM.Location = new System.Drawing.Point(6, 11);
            this.RadbttM.Name = "RadbttM";
            this.RadbttM.Size = new System.Drawing.Size(73, 17);
            this.RadbttM.TabIndex = 0;
            this.RadbttM.TabStop = true;
            this.RadbttM.Text = "Masculino";
            this.RadbttM.UseVisualStyleBackColor = true;
            // 
            // RadbttF
            // 
            this.RadbttF.AutoSize = true;
            this.RadbttF.Location = new System.Drawing.Point(102, 11);
            this.RadbttF.Name = "RadbttF";
            this.RadbttF.Size = new System.Drawing.Size(67, 17);
            this.RadbttF.TabIndex = 1;
            this.RadbttF.Text = "Feminino";
            this.RadbttF.UseVisualStyleBackColor = true;
            // 
            // Opção
            // 
            this.Opção.Controls.Add(this.RadbttF);
            this.Opção.Controls.Add(this.RadbttM);
            this.Opção.Location = new System.Drawing.Point(16, 5);
            this.Opção.Name = "Opção";
            this.Opção.Size = new System.Drawing.Size(175, 34);
            this.Opção.TabIndex = 2;
            this.Opção.TabStop = false;
            this.Opção.Text = "Sexo";
            // 
            // txtAlt
            // 
            this.txtAlt.Location = new System.Drawing.Point(22, 64);
            this.txtAlt.Name = "txtAlt";
            this.txtAlt.Size = new System.Drawing.Size(100, 20);
            this.txtAlt.TabIndex = 3;
            // 
            // txtPes
            // 
            this.txtPes.Location = new System.Drawing.Point(151, 63);
            this.txtPes.Name = "txtPes";
            this.txtPes.Size = new System.Drawing.Size(100, 20);
            this.txtPes.TabIndex = 4;
            // 
            // txtImc
            // 
            this.txtImc.Location = new System.Drawing.Point(85, 122);
            this.txtImc.Name = "txtImc";
            this.txtImc.Size = new System.Drawing.Size(100, 20);
            this.txtImc.TabIndex = 5;
            // 
            // bttCalc
            // 
            this.bttCalc.Location = new System.Drawing.Point(22, 196);
            this.bttCalc.Name = "bttCalc";
            this.bttCalc.Size = new System.Drawing.Size(75, 23);
            this.bttCalc.TabIndex = 6;
            this.bttCalc.Text = "Calcular";
            this.bttCalc.UseVisualStyleBackColor = true;
            this.bttCalc.Click += new System.EventHandler(this.bttCalc_Click);
            // 
            // bttLimpar
            // 
            this.bttLimpar.Location = new System.Drawing.Point(109, 196);
            this.bttLimpar.Name = "bttLimpar";
            this.bttLimpar.Size = new System.Drawing.Size(75, 23);
            this.bttLimpar.TabIndex = 7;
            this.bttLimpar.Text = "Limpar";
            this.bttLimpar.UseVisualStyleBackColor = true;
            this.bttLimpar.Click += new System.EventHandler(this.bttLimpar_Click);
            // 
            // BttSai
            // 
            this.BttSai.Location = new System.Drawing.Point(191, 196);
            this.BttSai.Name = "BttSai";
            this.BttSai.Size = new System.Drawing.Size(75, 23);
            this.BttSai.TabIndex = 8;
            this.BttSai.Text = "Sair";
            this.BttSai.UseVisualStyleBackColor = true;
            this.BttSai.Click += new System.EventHandler(this.BttSai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(191, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "IMC";
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.Location = new System.Drawing.Point(108, 161);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(0, 13);
            this.lblres.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BttSai);
            this.Controls.Add(this.bttLimpar);
            this.Controls.Add(this.bttCalc);
            this.Controls.Add(this.txtImc);
            this.Controls.Add(this.txtPes);
            this.Controls.Add(this.txtAlt);
            this.Controls.Add(this.Opção);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Opção.ResumeLayout(false);
            this.Opção.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton RadbttM;
        private System.Windows.Forms.RadioButton RadbttF;
        private System.Windows.Forms.GroupBox Opção;
        private System.Windows.Forms.TextBox txtAlt;
        private System.Windows.Forms.TextBox txtPes;
        private System.Windows.Forms.TextBox txtImc;
        private System.Windows.Forms.Button bttCalc;
        private System.Windows.Forms.Button bttLimpar;
        private System.Windows.Forms.Button BttSai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblres;
    }
}

