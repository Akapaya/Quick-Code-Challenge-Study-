namespace Prj_Palíndromo_31927
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
            this.bttcheck = new System.Windows.Forms.Button();
            this.txtpalavra = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bttcheck
            // 
            this.bttcheck.Location = new System.Drawing.Point(42, 124);
            this.bttcheck.Name = "bttcheck";
            this.bttcheck.Size = new System.Drawing.Size(75, 23);
            this.bttcheck.TabIndex = 0;
            this.bttcheck.Text = "Check";
            this.bttcheck.UseVisualStyleBackColor = true;
            this.bttcheck.Click += new System.EventHandler(this.bttcheck_Click);
            // 
            // txtpalavra
            // 
            this.txtpalavra.Location = new System.Drawing.Point(42, 56);
            this.txtpalavra.Name = "txtpalavra";
            this.txtpalavra.Size = new System.Drawing.Size(100, 20);
            this.txtpalavra.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 209);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtpalavra);
            this.Controls.Add(this.bttcheck);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttcheck;
        private System.Windows.Forms.TextBox txtpalavra;
        private System.Windows.Forms.TextBox textBox1;
    }
}

