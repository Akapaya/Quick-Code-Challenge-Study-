namespace prjAcad
{
    partial class frmAcad
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
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.grbPeriodo = new System.Windows.Forms.GroupBox();
            this.rdbTarde = new System.Windows.Forms.RadioButton();
            this.rdbNoite = new System.Windows.Forms.RadioButton();
            this.rdbManha = new System.Windows.Forms.RadioButton();
            this.grbDias = new System.Windows.Forms.GroupBox();
            this.chkSabado = new System.Windows.Forms.CheckBox();
            this.chkTerca = new System.Windows.Forms.CheckBox();
            this.chkSegunda = new System.Windows.Forms.CheckBox();
            this.chkSexta = new System.Windows.Forms.CheckBox();
            this.chkQuinta = new System.Windows.Forms.CheckBox();
            this.chkQuarta = new System.Windows.Forms.CheckBox();
            this.lstModalidades = new System.Windows.Forms.ListBox();
            this.lstEscolhidos = new System.Windows.Forms.ListBox();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtMensalidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.lblqtd = new System.Windows.Forms.Label();
            this.grbPeriodo.SuspendLayout();
            this.grbDias.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matrícula";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(61, 8);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(44, 20);
            this.maskedTextBox1.TabIndex = 1;
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(61, 44);
            this.textBox1.MaxLength = 35;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(287, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // grbPeriodo
            // 
            this.grbPeriodo.Controls.Add(this.rdbTarde);
            this.grbPeriodo.Controls.Add(this.rdbNoite);
            this.grbPeriodo.Controls.Add(this.rdbManha);
            this.grbPeriodo.Location = new System.Drawing.Point(25, 95);
            this.grbPeriodo.Name = "grbPeriodo";
            this.grbPeriodo.Size = new System.Drawing.Size(126, 87);
            this.grbPeriodo.TabIndex = 1;
            this.grbPeriodo.TabStop = false;
            this.grbPeriodo.Text = "Período";
            // 
            // rdbTarde
            // 
            this.rdbTarde.AutoSize = true;
            this.rdbTarde.Location = new System.Drawing.Point(16, 43);
            this.rdbTarde.Name = "rdbTarde";
            this.rdbTarde.Size = new System.Drawing.Size(53, 17);
            this.rdbTarde.TabIndex = 1;
            this.rdbTarde.Text = "Tarde";
            this.rdbTarde.UseVisualStyleBackColor = true;
            // 
            // rdbNoite
            // 
            this.rdbNoite.AutoSize = true;
            this.rdbNoite.Location = new System.Drawing.Point(16, 64);
            this.rdbNoite.Name = "rdbNoite";
            this.rdbNoite.Size = new System.Drawing.Size(50, 17);
            this.rdbNoite.TabIndex = 2;
            this.rdbNoite.Text = "Noite";
            this.rdbNoite.UseVisualStyleBackColor = true;
            // 
            // rdbManha
            // 
            this.rdbManha.AutoSize = true;
            this.rdbManha.Location = new System.Drawing.Point(16, 20);
            this.rdbManha.Name = "rdbManha";
            this.rdbManha.Size = new System.Drawing.Size(58, 17);
            this.rdbManha.TabIndex = 0;
            this.rdbManha.Text = "Manhã";
            this.rdbManha.UseVisualStyleBackColor = true;
            // 
            // grbDias
            // 
            this.grbDias.Controls.Add(this.chkSabado);
            this.grbDias.Controls.Add(this.chkTerca);
            this.grbDias.Controls.Add(this.chkSegunda);
            this.grbDias.Controls.Add(this.chkSexta);
            this.grbDias.Controls.Add(this.chkQuinta);
            this.grbDias.Controls.Add(this.chkQuarta);
            this.grbDias.Location = new System.Drawing.Point(166, 95);
            this.grbDias.Name = "grbDias";
            this.grbDias.Size = new System.Drawing.Size(254, 87);
            this.grbDias.TabIndex = 2;
            this.grbDias.TabStop = false;
            this.grbDias.Text = "Selecione os Dias da Semana";
            // 
            // chkSabado
            // 
            this.chkSabado.AutoSize = true;
            this.chkSabado.Location = new System.Drawing.Point(190, 40);
            this.chkSabado.Name = "chkSabado";
            this.chkSabado.Size = new System.Drawing.Size(63, 17);
            this.chkSabado.TabIndex = 11;
            this.chkSabado.Text = "Sábado";
            this.chkSabado.UseVisualStyleBackColor = true;
            // 
            // chkTerca
            // 
            this.chkTerca.AutoSize = true;
            this.chkTerca.Location = new System.Drawing.Point(104, 20);
            this.chkTerca.Name = "chkTerca";
            this.chkTerca.Size = new System.Drawing.Size(54, 17);
            this.chkTerca.TabIndex = 7;
            this.chkTerca.Text = "Terça";
            this.chkTerca.UseVisualStyleBackColor = true;
            // 
            // chkSegunda
            // 
            this.chkSegunda.AutoSize = true;
            this.chkSegunda.Location = new System.Drawing.Point(11, 21);
            this.chkSegunda.Name = "chkSegunda";
            this.chkSegunda.Size = new System.Drawing.Size(69, 17);
            this.chkSegunda.TabIndex = 6;
            this.chkSegunda.Text = "Segunda";
            this.chkSegunda.UseVisualStyleBackColor = true;
            // 
            // chkSexta
            // 
            this.chkSexta.AutoSize = true;
            this.chkSexta.Location = new System.Drawing.Point(104, 40);
            this.chkSexta.Name = "chkSexta";
            this.chkSexta.Size = new System.Drawing.Size(53, 17);
            this.chkSexta.TabIndex = 10;
            this.chkSexta.Text = "Sexta";
            this.chkSexta.UseVisualStyleBackColor = true;
            // 
            // chkQuinta
            // 
            this.chkQuinta.AutoSize = true;
            this.chkQuinta.Location = new System.Drawing.Point(11, 40);
            this.chkQuinta.Name = "chkQuinta";
            this.chkQuinta.Size = new System.Drawing.Size(57, 17);
            this.chkQuinta.TabIndex = 9;
            this.chkQuinta.Text = "Quinta";
            this.chkQuinta.UseVisualStyleBackColor = true;
            // 
            // chkQuarta
            // 
            this.chkQuarta.AutoSize = true;
            this.chkQuarta.Location = new System.Drawing.Point(190, 22);
            this.chkQuarta.Name = "chkQuarta";
            this.chkQuarta.Size = new System.Drawing.Size(58, 17);
            this.chkQuarta.TabIndex = 8;
            this.chkQuarta.Text = "Quarta";
            this.chkQuarta.UseVisualStyleBackColor = true;
            // 
            // lstModalidades
            // 
            this.lstModalidades.FormattingEnabled = true;
            this.lstModalidades.Items.AddRange(new object[] {
            "Balé",
            "Musculação",
            "Rítmica",
            "Spinning",
            "Natação",
            "Hidroginástica",
            "Judô",
            "Karatê"});
            this.lstModalidades.Location = new System.Drawing.Point(19, 211);
            this.lstModalidades.Name = "lstModalidades";
            this.lstModalidades.Size = new System.Drawing.Size(132, 95);
            this.lstModalidades.TabIndex = 3;
            // 
            // lstEscolhidos
            // 
            this.lstEscolhidos.FormattingEnabled = true;
            this.lstEscolhidos.Location = new System.Drawing.Point(279, 211);
            this.lstEscolhidos.Name = "lstEscolhidos";
            this.lstEscolhidos.Size = new System.Drawing.Size(149, 95);
            this.lstEscolhidos.TabIndex = 6;
            // 
            // btnIncluir
            // 
            this.btnIncluir.Location = new System.Drawing.Point(173, 228);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(71, 30);
            this.btnIncluir.TabIndex = 4;
            this.btnIncluir.Text = "Incluir -->";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(175, 276);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(69, 30);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "<-- Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(22, 316);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(142, 32);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular Mensalidade";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtMensalidade
            // 
            this.txtMensalidade.BackColor = System.Drawing.SystemColors.Window;
            this.txtMensalidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMensalidade.Enabled = false;
            this.txtMensalidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMensalidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.txtMensalidade.Location = new System.Drawing.Point(313, 330);
            this.txtMensalidade.Name = "txtMensalidade";
            this.txtMensalidade.Size = new System.Drawing.Size(115, 22);
            this.txtMensalidade.TabIndex = 8;
            this.txtMensalidade.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Valor da Mensalidade";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.maskedTextBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(22, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(405, 77);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seleção de Modalidades";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Modalidades Escolhidas";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Seg",
            "Ter",
            "Qua",
            "Qui",
            "Sex",
            "Sab",
            "Dom"});
            this.checkedListBox1.Location = new System.Drawing.Point(438, 15);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(54, 154);
            this.checkedListBox1.TabIndex = 16;
            this.checkedListBox1.SelectedValueChanged += new System.EventHandler(this.checkedListBox1_SelectedValueChanged);
            // 
            // lblqtd
            // 
            this.lblqtd.AutoSize = true;
            this.lblqtd.Location = new System.Drawing.Point(458, 138);
            this.lblqtd.Name = "lblqtd";
            this.lblqtd.Size = new System.Drawing.Size(13, 13);
            this.lblqtd.TabIndex = 17;
            this.lblqtd.Text = "?";
            // 
            // frmAcad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 360);
            this.Controls.Add(this.lblqtd);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.grbDias);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtMensalidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.lstEscolhidos);
            this.Controls.Add(this.lstModalidades);
            this.Controls.Add(this.grbPeriodo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAcad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Academia XYZ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAcad_FormClosing);
            this.Load += new System.EventHandler(this.frmXXXXXX_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAcad_KeyDown);
            this.grbPeriodo.ResumeLayout(false);
            this.grbPeriodo.PerformLayout();
            this.grbDias.ResumeLayout(false);
            this.grbDias.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox grbPeriodo;
        private System.Windows.Forms.RadioButton rdbTarde;
        private System.Windows.Forms.RadioButton rdbNoite;
        private System.Windows.Forms.RadioButton rdbManha;
        private System.Windows.Forms.GroupBox grbDias;
        private System.Windows.Forms.ListBox lstModalidades;
        private System.Windows.Forms.ListBox lstEscolhidos;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtMensalidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label lblqtd;
        private System.Windows.Forms.CheckBox chkSabado;
        private System.Windows.Forms.CheckBox chkSexta;
        private System.Windows.Forms.CheckBox chkQuinta;
        private System.Windows.Forms.CheckBox chkQuarta;
        private System.Windows.Forms.CheckBox chkTerca;
        private System.Windows.Forms.CheckBox chkSegunda;
    }
}

