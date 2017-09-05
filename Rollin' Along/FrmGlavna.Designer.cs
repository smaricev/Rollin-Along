namespace Rollin__Along
{
    partial class FrmGlavna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGlavna));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rezervacije = new System.Windows.Forms.PictureBox();
            this.incidenti = new System.Windows.Forms.PictureBox();
            this.biciklPregled = new System.Windows.Forms.PictureBox();
            this.opremaPregled = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rezervacije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.biciklPregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opremaPregled)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Incidents";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(376, 481);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reservations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(394, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Inventory";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Equipment";
            // 
            // rezervacije
            // 
            this.rezervacije.Image = global::Rollin__Along.Properties.Resources.rezervacije;
            this.rezervacije.Location = new System.Drawing.Point(316, 278);
            this.rezervacije.Name = "rezervacije";
            this.rezervacije.Size = new System.Drawing.Size(200, 200);
            this.rezervacije.TabIndex = 6;
            this.rezervacije.TabStop = false;
            this.rezervacije.Click += new System.EventHandler(this.rezervacije_Click);
            // 
            // incidenti
            // 
            this.incidenti.Image = global::Rollin__Along.Properties.Resources.inc;
            this.incidenti.Location = new System.Drawing.Point(55, 278);
            this.incidenti.Name = "incidenti";
            this.incidenti.Size = new System.Drawing.Size(200, 200);
            this.incidenti.TabIndex = 5;
            this.incidenti.TabStop = false;
            this.incidenti.Click += new System.EventHandler(this.incidenti_Click);
            // 
            // biciklPregled
            // 
            this.biciklPregled.Image = global::Rollin__Along.Properties.Resources.bic1;
            this.biciklPregled.Location = new System.Drawing.Point(316, 32);
            this.biciklPregled.Name = "biciklPregled";
            this.biciklPregled.Size = new System.Drawing.Size(200, 200);
            this.biciklPregled.TabIndex = 4;
            this.biciklPregled.TabStop = false;
            this.biciklPregled.Click += new System.EventHandler(this.biciklPregled_Click);
            // 
            // opremaPregled
            // 
            this.opremaPregled.Image = global::Rollin__Along.Properties.Resources.oprema11;
            this.opremaPregled.Location = new System.Drawing.Point(55, 32);
            this.opremaPregled.Name = "opremaPregled";
            this.opremaPregled.Size = new System.Drawing.Size(200, 200);
            this.opremaPregled.TabIndex = 3;
            this.opremaPregled.TabStop = false;
            this.opremaPregled.Click += new System.EventHandler(this.opremaPregled_Click);
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(574, 531);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rezervacije);
            this.Controls.Add(this.incidenti);
            this.Controls.Add(this.biciklPregled);
            this.Controls.Add(this.opremaPregled);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmGlavna";
            this.Text = "Rollin\' Along";
            ((System.ComponentModel.ISupportInitialize)(this.rezervacije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incidenti)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.biciklPregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opremaPregled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox opremaPregled;
        private System.Windows.Forms.PictureBox biciklPregled;
        private System.Windows.Forms.PictureBox incidenti;
        private System.Windows.Forms.PictureBox rezervacije;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}