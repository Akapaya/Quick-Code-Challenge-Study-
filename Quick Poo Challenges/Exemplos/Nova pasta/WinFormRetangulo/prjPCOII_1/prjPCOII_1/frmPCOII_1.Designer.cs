namespace prjPCOII_1
{
    partial class frmPCOII_1
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
            this.label3 = new System.Windows.Forms.Label();
            this.lblLargura = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPerimetro = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRetQua = new System.Windows.Forms.Label();
            this.txtLargura = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnInformado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Largura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Área:";
            // 
            // lblLargura
            // 
            this.lblLargura.AutoSize = true;
            this.lblLargura.Location = new System.Drawing.Point(123, 27);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(0, 13);
            this.lblLargura.TabIndex = 3;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(123, 55);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(0, 13);
            this.lblAltura.TabIndex = 4;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(123, 89);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(0, 13);
            this.lblArea.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Perímetro:";
            // 
            // lblPerimetro
            // 
            this.lblPerimetro.AutoSize = true;
            this.lblPerimetro.Location = new System.Drawing.Point(123, 122);
            this.lblPerimetro.Name = "lblPerimetro";
            this.lblPerimetro.Size = new System.Drawing.Size(0, 13);
            this.lblPerimetro.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Retangulo Quadrado:";
            // 
            // lblRetQua
            // 
            this.lblRetQua.AutoSize = true;
            this.lblRetQua.Location = new System.Drawing.Point(158, 152);
            this.lblRetQua.Name = "lblRetQua";
            this.lblRetQua.Size = new System.Drawing.Size(0, 13);
            this.lblRetQua.TabIndex = 9;
            // 
            // txtLargura
            // 
            this.txtLargura.Location = new System.Drawing.Point(231, 24);
            this.txtLargura.Name = "txtLargura";
            this.txtLargura.Size = new System.Drawing.Size(49, 20);
            this.txtLargura.TabIndex = 10;
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(231, 52);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(49, 20);
            this.txtAltura.TabIndex = 11;
            // 
            // btnInformado
            // 
            this.btnInformado.Location = new System.Drawing.Point(213, 89);
            this.btnInformado.Name = "btnInformado";
            this.btnInformado.Size = new System.Drawing.Size(66, 22);
            this.btnInformado.TabIndex = 12;
            this.btnInformado.Text = "Informado";
            this.btnInformado.UseVisualStyleBackColor = true;
            this.btnInformado.Click += new System.EventHandler(this.btnInformado_Click);
            // 
            // frmPCOII_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 183);
            this.Controls.Add(this.btnInformado);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtLargura);
            this.Controls.Add(this.lblRetQua);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPerimetro);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblLargura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPCOII_1";
            this.Text = "Introdução Classes";
            this.Load += new System.EventHandler(this.frmPCOII_1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPerimetro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRetQua;
        private System.Windows.Forms.TextBox txtLargura;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnInformado;
    }
}

