namespace prj_ex11_31927
{
    partial class Form_ex11_31927
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
            this.btmaior = new System.Windows.Forms.Button();
            this.txtval1 = new System.Windows.Forms.TextBox();
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.txtval3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btlim = new System.Windows.Forms.Button();
            this.btsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1 valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2 valor";
            // 
            // btmaior
            // 
            this.btmaior.Location = new System.Drawing.Point(12, 103);
            this.btmaior.Name = "btmaior";
            this.btmaior.Size = new System.Drawing.Size(75, 23);
            this.btmaior.TabIndex = 2;
            this.btmaior.Text = "Maior";
            this.btmaior.UseVisualStyleBackColor = true;
            this.btmaior.Click += new System.EventHandler(this.btmaior_Click);
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(26, 66);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(36, 20);
            this.txtval1.TabIndex = 3;
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(99, 66);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(36, 20);
            this.txtval2.TabIndex = 4;
            // 
            // txtval3
            // 
            this.txtval3.Location = new System.Drawing.Point(168, 66);
            this.txtval3.Name = "txtval3";
            this.txtval3.ReadOnly = true;
            this.txtval3.Size = new System.Drawing.Size(36, 20);
            this.txtval3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Maior";
            // 
            // btlim
            // 
            this.btlim.Location = new System.Drawing.Point(99, 103);
            this.btlim.Name = "btlim";
            this.btlim.Size = new System.Drawing.Size(75, 23);
            this.btlim.TabIndex = 7;
            this.btlim.Text = "Limpar";
            this.btlim.UseVisualStyleBackColor = true;
            this.btlim.Click += new System.EventHandler(this.btlim_Click);
            // 
            // btsair
            // 
            this.btsair.Location = new System.Drawing.Point(180, 103);
            this.btsair.Name = "btsair";
            this.btsair.Size = new System.Drawing.Size(75, 23);
            this.btsair.TabIndex = 8;
            this.btsair.Text = "Sair";
            this.btsair.UseVisualStyleBackColor = true;
            this.btsair.Click += new System.EventHandler(this.btsair_Click);
            // 
            // Form_ex11_31927
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 152);
            this.Controls.Add(this.btsair);
            this.Controls.Add(this.btlim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtval3);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.txtval1);
            this.Controls.Add(this.btmaior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form_ex11_31927";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmaior;
        private System.Windows.Forms.TextBox txtval1;
        private System.Windows.Forms.TextBox txtval2;
        private System.Windows.Forms.TextBox txtval3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btlim;
        private System.Windows.Forms.Button btsair;
    }
}

