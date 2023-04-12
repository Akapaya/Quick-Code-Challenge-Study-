namespace Ex_31927
{
    partial class frm_ex_31927
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
            this.cmblista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtval1 = new System.Windows.Forms.TextBox();
            this.txtval2 = new System.Windows.Forms.TextBox();
            this.txtval3 = new System.Windows.Forms.TextBox();
            this.txtval4 = new System.Windows.Forms.TextBox();
            this.txtval5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lstb = new System.Windows.Forms.ListBox();
            this.pcb1 = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmblista
            // 
            this.cmblista.FormattingEnabled = true;
            this.cmblista.Items.AddRange(new object[] {
            "Retangulo",
            "Triangulo",
            "Circulo"});
            this.cmblista.Location = new System.Drawing.Point(103, 32);
            this.cmblista.Name = "cmblista";
            this.cmblista.Size = new System.Drawing.Size(121, 21);
            this.cmblista.TabIndex = 0;
            this.cmblista.SelectedIndexChanged += new System.EventHandler(this.cmblista_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo";
            // 
            // txtval1
            // 
            this.txtval1.Location = new System.Drawing.Point(103, 59);
            this.txtval1.Name = "txtval1";
            this.txtval1.Size = new System.Drawing.Size(121, 20);
            this.txtval1.TabIndex = 2;
            // 
            // txtval2
            // 
            this.txtval2.Location = new System.Drawing.Point(103, 85);
            this.txtval2.Name = "txtval2";
            this.txtval2.Size = new System.Drawing.Size(121, 20);
            this.txtval2.TabIndex = 3;
            // 
            // txtval3
            // 
            this.txtval3.Location = new System.Drawing.Point(103, 111);
            this.txtval3.Name = "txtval3";
            this.txtval3.Size = new System.Drawing.Size(121, 20);
            this.txtval3.TabIndex = 4;
            // 
            // txtval4
            // 
            this.txtval4.Location = new System.Drawing.Point(103, 137);
            this.txtval4.Name = "txtval4";
            this.txtval4.Size = new System.Drawing.Size(121, 20);
            this.txtval4.TabIndex = 5;
            // 
            // txtval5
            // 
            this.txtval5.Location = new System.Drawing.Point(103, 163);
            this.txtval5.Name = "txtval5";
            this.txtval5.Size = new System.Drawing.Size(121, 20);
            this.txtval5.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Comprimento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Largura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Base";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Altura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Raio";
            // 
            // lstb
            // 
            this.lstb.FormattingEnabled = true;
            this.lstb.Location = new System.Drawing.Point(359, 170);
            this.lstb.Name = "lstb";
            this.lstb.Size = new System.Drawing.Size(340, 290);
            this.lstb.TabIndex = 17;
            // 
            // pcb1
            // 
            this.pcb1.BackgroundImage = global::Ex_31927.Properties.Resources.retangulo;
            this.pcb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcb1.Location = new System.Drawing.Point(359, 32);
            this.pcb1.Name = "pcb1";
            this.pcb1.Size = new System.Drawing.Size(340, 117);
            this.pcb1.TabIndex = 16;
            this.pcb1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.BackgroundImage = global::Ex_31927.Properties.Resources.Limpar1;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(181, 273);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(139, 78);
            this.button4.TabIndex = 15;
            this.button4.Text = "Limpar Memória";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.BackgroundImage = global::Ex_31927.Properties.Resources.sair;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(19, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 78);
            this.button3.TabIndex = 14;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.BackgroundImage = global::Ex_31927.Properties.Resources.Limpar;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(181, 189);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 78);
            this.button2.TabIndex = 13;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImage = global::Ex_31927.Properties.Resources.calcular;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(19, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 78);
            this.button1.TabIndex = 12;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_ex_31927
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 484);
            this.Controls.Add(this.lstb);
            this.Controls.Add(this.pcb1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtval5);
            this.Controls.Add(this.txtval4);
            this.Controls.Add(this.txtval3);
            this.Controls.Add(this.txtval2);
            this.Controls.Add(this.txtval1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmblista);
            this.Name = "frm_ex_31927";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmblista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtval1;
        private System.Windows.Forms.TextBox txtval2;
        private System.Windows.Forms.TextBox txtval3;
        private System.Windows.Forms.TextBox txtval4;
        private System.Windows.Forms.TextBox txtval5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pcb1;
        private System.Windows.Forms.ListBox lstb;
    }
}

