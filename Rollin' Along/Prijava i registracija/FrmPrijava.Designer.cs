namespace Rollin__Along
{
    partial class Prijava
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prijava));
            this.PrijavaButton = new System.Windows.Forms.Button();
            this.RegistracijaButton = new System.Windows.Forms.Button();
            this.korisnickoImeTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBoX = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrijavaButton
            // 
            this.PrijavaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(92)))), ((int)(((byte)(99)))));
            this.PrijavaButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrijavaButton.ForeColor = System.Drawing.Color.White;
            this.PrijavaButton.Location = new System.Drawing.Point(67, 203);
            this.PrijavaButton.Name = "PrijavaButton";
            this.PrijavaButton.Size = new System.Drawing.Size(75, 32);
            this.PrijavaButton.TabIndex = 0;
            this.PrijavaButton.Text = "Prijava";
            this.PrijavaButton.UseVisualStyleBackColor = false;
            this.PrijavaButton.Click += new System.EventHandler(this.PrijavaButton_Click);
            // 
            // RegistracijaButton
            // 
            this.RegistracijaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(92)))), ((int)(((byte)(99)))));
            this.RegistracijaButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistracijaButton.ForeColor = System.Drawing.Color.White;
            this.RegistracijaButton.Location = new System.Drawing.Point(148, 203);
            this.RegistracijaButton.Name = "RegistracijaButton";
            this.RegistracijaButton.Size = new System.Drawing.Size(75, 32);
            this.RegistracijaButton.TabIndex = 1;
            this.RegistracijaButton.Text = "Registracija";
            this.RegistracijaButton.UseVisualStyleBackColor = false;
            this.RegistracijaButton.Click += new System.EventHandler(this.RegistracijaButton_Click);
            // 
            // korisnickoImeTextBox
            // 
            this.korisnickoImeTextBox.Location = new System.Drawing.Point(93, 151);
            this.korisnickoImeTextBox.Name = "korisnickoImeTextBox";
            this.korisnickoImeTextBox.Size = new System.Drawing.Size(100, 20);
            this.korisnickoImeTextBox.TabIndex = 2;
            // 
            // passwordTextBoX
            // 
            this.passwordTextBoX.Location = new System.Drawing.Point(93, 177);
            this.passwordTextBoX.Name = "passwordTextBoX";
            this.passwordTextBoX.Size = new System.Drawing.Size(100, 20);
            this.passwordTextBoX.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rollin__Along.Properties.Resources.RA1;
            this.pictureBox1.Location = new System.Drawing.Point(93, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Prijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordTextBoX);
            this.Controls.Add(this.korisnickoImeTextBox);
            this.Controls.Add(this.RegistracijaButton);
            this.Controls.Add(this.PrijavaButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prijava";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrijavaButton;
        private System.Windows.Forms.Button RegistracijaButton;
        private System.Windows.Forms.TextBox korisnickoImeTextBox;
        private System.Windows.Forms.TextBox passwordTextBoX;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

