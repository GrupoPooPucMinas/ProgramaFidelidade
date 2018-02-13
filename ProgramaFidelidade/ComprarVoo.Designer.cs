namespace ProgramaFidelidade
{
    partial class ComprarVoo
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
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.comboBoxCidadeOrigem = new System.Windows.Forms.ComboBox();
            this.comboBoxCidadeDestino = new System.Windows.Forms.ComboBox();
            this.textBoxExibirViagens = new System.Windows.Forms.TextBox();
            this.buttonEnviarCidades = new System.Windows.Forms.Button();
            this.cb_formapgto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Filtrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(12, 396);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(68, 29);
            this.buttonVoltar.TabIndex = 0;
            this.buttonVoltar.Text = "< Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // comboBoxCidadeOrigem
            // 
            this.comboBoxCidadeOrigem.FormattingEnabled = true;
            this.comboBoxCidadeOrigem.Location = new System.Drawing.Point(52, 27);
            this.comboBoxCidadeOrigem.Name = "comboBoxCidadeOrigem";
            this.comboBoxCidadeOrigem.Size = new System.Drawing.Size(219, 21);
            this.comboBoxCidadeOrigem.TabIndex = 1;
            this.comboBoxCidadeOrigem.Text = "Escolha a cidade";
            // 
            // comboBoxCidadeDestino
            // 
            this.comboBoxCidadeDestino.FormattingEnabled = true;
            this.comboBoxCidadeDestino.Location = new System.Drawing.Point(52, 53);
            this.comboBoxCidadeDestino.Name = "comboBoxCidadeDestino";
            this.comboBoxCidadeDestino.Size = new System.Drawing.Size(219, 21);
            this.comboBoxCidadeDestino.TabIndex = 3;
            this.comboBoxCidadeDestino.Text = "Escolha a cidade";
            // 
            // textBoxExibirViagens
            // 
            this.textBoxExibirViagens.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBoxExibirViagens.Location = new System.Drawing.Point(12, 143);
            this.textBoxExibirViagens.Multiline = true;
            this.textBoxExibirViagens.Name = "textBoxExibirViagens";
            this.textBoxExibirViagens.ReadOnly = true;
            this.textBoxExibirViagens.Size = new System.Drawing.Size(616, 194);
            this.textBoxExibirViagens.TabIndex = 5;
            // 
            // buttonEnviarCidades
            // 
            this.buttonEnviarCidades.Location = new System.Drawing.Point(547, 396);
            this.buttonEnviarCidades.Name = "buttonEnviarCidades";
            this.buttonEnviarCidades.Size = new System.Drawing.Size(81, 29);
            this.buttonEnviarCidades.TabIndex = 7;
            this.buttonEnviarCidades.Text = "Comprar";
            this.buttonEnviarCidades.UseVisualStyleBackColor = true;
            this.buttonEnviarCidades.Click += new System.EventHandler(this.buttonEnviarCidades_Click);
            // 
            // cb_formapgto
            // 
            this.cb_formapgto.FormattingEnabled = true;
            this.cb_formapgto.Items.AddRange(new object[] {
            "Normal",
            "Promocional",
            "Fidelidade"});
            this.cb_formapgto.Location = new System.Drawing.Point(507, 343);
            this.cb_formapgto.Name = "cb_formapgto";
            this.cb_formapgto.Size = new System.Drawing.Size(121, 21);
            this.cb_formapgto.TabIndex = 30;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(393, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Forma de Pagamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Destino";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Filtrar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.comboBoxCidadeDestino);
            this.groupBox1.Controls.Add(this.comboBoxCidadeOrigem);
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(616, 87);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // Filtrar
            // 
            this.Filtrar.Location = new System.Drawing.Point(535, 30);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(75, 23);
            this.Filtrar.TabIndex = 1;
            this.Filtrar.Text = "Filtrar";
            this.Filtrar.UseVisualStyleBackColor = true;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Origem";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Compra de Passagens";
            // 
            // ComprarVoo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(637, 437);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_formapgto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonEnviarCidades);
            this.Controls.Add(this.textBoxExibirViagens);
            this.Controls.Add(this.buttonVoltar);
            this.Name = "ComprarVoo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comprar Voo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ComprarVoo_FormClosed_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.ComboBox comboBoxCidadeOrigem;
        private System.Windows.Forms.ComboBox comboBoxCidadeDestino;
        private System.Windows.Forms.TextBox textBoxExibirViagens;
        private System.Windows.Forms.Button buttonEnviarCidades;
        private System.Windows.Forms.ComboBox cb_formapgto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Filtrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
    }
}