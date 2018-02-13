namespace ProgramaFidelidade
{
    partial class MenuInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuInicial));
            this.LabelPreencherNome = new System.Windows.Forms.Label();
            this.buttonEnviarNome = new System.Windows.Forms.Button();
            this.textBoxPreencherNome = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelPreencherNome
            // 
            this.LabelPreencherNome.AutoSize = true;
            this.LabelPreencherNome.Location = new System.Drawing.Point(23, 131);
            this.LabelPreencherNome.Name = "LabelPreencherNome";
            this.LabelPreencherNome.Size = new System.Drawing.Size(30, 13);
            this.LabelPreencherNome.TabIndex = 0;
            this.LabelPreencherNome.Text = "CPF:";
            // 
            // buttonEnviarNome
            // 
            this.buttonEnviarNome.Location = new System.Drawing.Point(95, 169);
            this.buttonEnviarNome.Name = "buttonEnviarNome";
            this.buttonEnviarNome.Size = new System.Drawing.Size(75, 20);
            this.buttonEnviarNome.TabIndex = 1;
            this.buttonEnviarNome.Text = "Acessar";
            this.buttonEnviarNome.UseVisualStyleBackColor = true;
            this.buttonEnviarNome.Click += new System.EventHandler(this.buttonEnviarNome_Click);
            // 
            // textBoxPreencherNome
            // 
            this.textBoxPreencherNome.Location = new System.Drawing.Point(59, 128);
            this.textBoxPreencherNome.Mask = "000.000.000-00";
            this.textBoxPreencherNome.Name = "textBoxPreencherNome";
            this.textBoxPreencherNome.Size = new System.Drawing.Size(182, 20);
            this.textBoxPreencherNome.TabIndex = 4;
            this.textBoxPreencherNome.ValidatingType = typeof(int);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(63, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(142, 82);
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(274, 210);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBoxPreencherNome);
            this.Controls.Add(this.buttonEnviarNome);
            this.Controls.Add(this.LabelPreencherNome);
            this.Name = "MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuInicial_FormClosed);
            this.Load += new System.EventHandler(this.MenuInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelPreencherNome;
        private System.Windows.Forms.Button buttonEnviarNome;
        private System.Windows.Forms.MaskedTextBox textBoxPreencherNome;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}