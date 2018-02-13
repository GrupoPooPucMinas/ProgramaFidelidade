namespace ProgramaFidelidade
{
    partial class Relatorio
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
            this.components = new System.ComponentModel.Container();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.textBoxInfRelatorios = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(705, 402);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(75, 23);
            this.buttonVoltar.TabIndex = 0;
            this.buttonVoltar.Text = "Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // textBoxInfRelatorios
            // 
            this.textBoxInfRelatorios.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxInfRelatorios.Enabled = false;
            this.textBoxInfRelatorios.Location = new System.Drawing.Point(12, 50);
            this.textBoxInfRelatorios.Multiline = true;
            this.textBoxInfRelatorios.Name = "textBoxInfRelatorios";
            this.textBoxInfRelatorios.Size = new System.Drawing.Size(599, 370);
            this.textBoxInfRelatorios.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 426);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "< Voltar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Relatório de Passagens";
            // 
            // Relatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(623, 467);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxInfRelatorios);
            this.Controls.Add(this.buttonVoltar);
            this.Name = "Relatorio";
            this.Text = "Relatorio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Relatorio_FormClosed);
            this.Load += new System.EventHandler(this.Relatorio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.TextBox textBoxInfRelatorios;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}