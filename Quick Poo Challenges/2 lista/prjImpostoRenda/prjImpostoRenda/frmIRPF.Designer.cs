namespace prjImpostoRenda
{
    partial class frmIRPF
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
            this.btnPadrao = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblImpRetido = new System.Windows.Forms.Label();
            this.lblSalLiquido = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQtdHoras = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtvValorHora = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnInformado = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPadrao
            // 
            this.btnPadrao.Location = new System.Drawing.Point(90, 10);
            this.btnPadrao.Name = "btnPadrao";
            this.btnPadrao.Size = new System.Drawing.Size(78, 23);
            this.btnPadrao.TabIndex = 9;
            this.btnPadrao.Text = "Padrão";
            this.btnPadrao.UseVisualStyleBackColor = true;
            this.btnPadrao.Click += new System.EventHandler(this.btnPadrao_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblImpRetido);
            this.groupBox2.Controls.Add(this.lblSalLiquido);
            this.groupBox2.Controls.Add(this.lblSalBruto);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtQtdHoras);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtvValorHora);
            this.groupBox2.Controls.Add(this.txtNome);
            this.groupBox2.Controls.Add(this.txtSexo);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtIdade);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(69, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 267);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saída dos Dados";
            // 
            // lblImpRetido
            // 
            this.lblImpRetido.AutoSize = true;
            this.lblImpRetido.Location = new System.Drawing.Point(125, 240);
            this.lblImpRetido.Name = "lblImpRetido";
            this.lblImpRetido.Size = new System.Drawing.Size(81, 13);
            this.lblImpRetido.TabIndex = 26;
            this.lblImpRetido.Text = "Imposto Retido:";
            this.lblImpRetido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalLiquido
            // 
            this.lblSalLiquido.AutoSize = true;
            this.lblSalLiquido.Location = new System.Drawing.Point(124, 208);
            this.lblSalLiquido.Name = "lblSalLiquido";
            this.lblSalLiquido.Size = new System.Drawing.Size(81, 13);
            this.lblSalLiquido.TabIndex = 25;
            this.lblSalLiquido.Text = "Salário Líquido:";
            this.lblSalLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(135, 177);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(70, 13);
            this.lblSalBruto.TabIndex = 24;
            this.lblSalBruto.Text = "Salário Bruto:";
            this.lblSalBruto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(81, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "Imposto Retido:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 208);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Salário Líquido:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 177);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Salário Bruto:";
            // 
            // txtQtdHoras
            // 
            this.txtQtdHoras.Location = new System.Drawing.Point(157, 115);
            this.txtQtdHoras.Name = "txtQtdHoras";
            this.txtQtdHoras.Size = new System.Drawing.Size(42, 20);
            this.txtQtdHoras.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Nome:";
            // 
            // txtvValorHora
            // 
            this.txtvValorHora.Location = new System.Drawing.Point(95, 89);
            this.txtvValorHora.Name = "txtvValorHora";
            this.txtvValorHora.Size = new System.Drawing.Size(60, 20);
            this.txtvValorHora.TabIndex = 19;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(142, 20);
            this.txtNome.TabIndex = 12;
            // 
            // txtSexo
            // 
            this.txtSexo.Location = new System.Drawing.Point(157, 53);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(42, 20);
            this.txtSexo.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Idade:";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(57, 53);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(42, 20);
            this.txtIdade.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(117, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Sexo:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Quantidade de Horas:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Valor da Hora:";
            // 
            // btnInformado
            // 
            this.btnInformado.Location = new System.Drawing.Point(207, 4);
            this.btnInformado.Name = "btnInformado";
            this.btnInformado.Size = new System.Drawing.Size(78, 35);
            this.btnInformado.TabIndex = 5;
            this.btnInformado.Text = "Mostrar Informado";
            this.btnInformado.UseVisualStyleBackColor = true;
            this.btnInformado.Click += new System.EventHandler(this.btnInformado_Click);
            // 
            // frmIRPF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 321);
            this.Controls.Add(this.btnInformado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnPadrao);
            this.Name = "frmIRPF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Classe Funcionário - Cálculo do IRPF";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPadrao;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtQtdHoras;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtvValorHora;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnInformado;
        private System.Windows.Forms.Label lblImpRetido;
        private System.Windows.Forms.Label lblSalLiquido;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

