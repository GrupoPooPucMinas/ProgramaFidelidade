namespace ProgramaFidelidade
{
    partial class Relatorio12meses
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
            this.textBox12meses = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox12meses
            // 
            this.textBox12meses.BackColor = System.Drawing.SystemColors.Control;
            this.textBox12meses.Enabled = false;
            this.textBox12meses.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox12meses.Location = new System.Drawing.Point(12, 50);
            this.textBox12meses.Multiline = true;
            this.textBox12meses.Name = "textBox12meses";
            this.textBox12meses.Size = new System.Drawing.Size(584, 407);
            this.textBox12meses.TabIndex = 0;
            this.textBox12meses.TextChanged += new System.EventHandler(this.textBox12meses_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(12, 463);
            this.buttonVoltar.Name = "buttonVoltar";
            this.buttonVoltar.Size = new System.Drawing.Size(68, 29);
            this.buttonVoltar.TabIndex = 1;
            this.buttonVoltar.Text = "< Voltar";
            this.buttonVoltar.UseVisualStyleBackColor = true;
            this.buttonVoltar.Click += new System.EventHandler(this.buttonVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Relatório de Passagens";
            // 
            // Relatorio12meses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(608, 504);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.textBox12meses);
            this.Name = "Relatorio12meses";
            this.Text = "Relatorio12meses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Relatorio12meses_FormClosed);
            this.Load += new System.EventHandler(this.Relatorio12meses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox12meses;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label label1;
    }
}