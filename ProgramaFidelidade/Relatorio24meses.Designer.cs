namespace ProgramaFidelidade
{
    partial class Relatorio24meses
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
            this.textBox24meses = new System.Windows.Forms.TextBox();
            this.buttonVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox24meses
            // 
            this.textBox24meses.BackColor = System.Drawing.SystemColors.Control;
            this.textBox24meses.Enabled = false;
            this.textBox24meses.Location = new System.Drawing.Point(12, 50);
            this.textBox24meses.Multiline = true;
            this.textBox24meses.Name = "textBox24meses";
            this.textBox24meses.Size = new System.Drawing.Size(657, 414);
            this.textBox24meses.TabIndex = 0;
            this.textBox24meses.TextChanged += new System.EventHandler(this.textBox24meses_TextChanged);
            // 
            // buttonVoltar
            // 
            this.buttonVoltar.Location = new System.Drawing.Point(12, 470);
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
            this.label1.TabIndex = 5;
            this.label1.Text = "Relatório de Passagens";
            // 
            // Relatorio24meses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(681, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVoltar);
            this.Controls.Add(this.textBox24meses);
            this.Name = "Relatorio24meses";
            this.Text = "Relatorio24meses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Relatorio24meses_FormClosed);
            this.Load += new System.EventHandler(this.Relatorio24meses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox24meses;
        private System.Windows.Forms.Button buttonVoltar;
        private System.Windows.Forms.Label label1;
    }
}