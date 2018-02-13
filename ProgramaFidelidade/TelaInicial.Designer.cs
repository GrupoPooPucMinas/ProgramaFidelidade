namespace ProgramaFidelidade
{
    partial class TelaInicial
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
            this.BemVindo = new System.Windows.Forms.Label();
            this.buttonMenuInicial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BemVindo
            // 
            this.BemVindo.AutoSize = true;
            this.BemVindo.BackColor = System.Drawing.Color.Transparent;
            this.BemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BemVindo.ForeColor = System.Drawing.Color.White;
            this.BemVindo.Location = new System.Drawing.Point(4, 11);
            this.BemVindo.Name = "BemVindo";
            this.BemVindo.Size = new System.Drawing.Size(381, 37);
            this.BemVindo.TabIndex = 0;
            this.BemVindo.Text = "Programa de Fidelidade";
            this.BemVindo.Click += new System.EventHandler(this.BemVindo_Click);
            // 
            // buttonMenuInicial
            // 
            this.buttonMenuInicial.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonMenuInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuInicial.Location = new System.Drawing.Point(101, 206);
            this.buttonMenuInicial.Name = "buttonMenuInicial";
            this.buttonMenuInicial.Size = new System.Drawing.Size(182, 23);
            this.buttonMenuInicial.TabIndex = 1;
            this.buttonMenuInicial.Text = "Vá para o Menu Inicial";
            this.buttonMenuInicial.UseVisualStyleBackColor = false;
            this.buttonMenuInicial.Click += new System.EventHandler(this.buttonMenuInicial_Click);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProgramaFidelidade.Properties.Resources.Aviao;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(391, 247);
            this.Controls.Add(this.buttonMenuInicial);
            this.Controls.Add(this.BemVindo);
            this.Name = "TelaInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bem Vindo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TelaInicial_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BemVindo;
        private System.Windows.Forms.Button buttonMenuInicial;
    }
}

