namespace Rollin__Along.Unos_i_upravljanje_inventara
{
    partial class FrmBicikli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBicikli));
            this.txtNewCat = new System.Windows.Forms.TextBox();
            this.cbChooseCat = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAddEqu = new System.Windows.Forms.Button();
            this.dgBicycles = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtPpD = new System.Windows.Forms.TextBox();
            this.txtPpH = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSaveCat = new System.Windows.Forms.Button();
            this.lbNameNewCat = new System.Windows.Forms.Label();
            this.gbAddCat = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbPpH = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbCurrency = new System.Windows.Forms.Label();
            this.lbPpD = new System.Windows.Forms.Label();
            this.lbChooseCat = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgBicycles)).BeginInit();
            this.gbAddCat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNewCat
            // 
            this.txtNewCat.Location = new System.Drawing.Point(127, 31);
            this.txtNewCat.Name = "txtNewCat";
            this.txtNewCat.Size = new System.Drawing.Size(130, 20);
            this.txtNewCat.TabIndex = 30;
            // 
            // cbChooseCat
            // 
            this.cbChooseCat.FormattingEnabled = true;
            this.cbChooseCat.Location = new System.Drawing.Point(117, 317);
            this.cbChooseCat.Name = "cbChooseCat";
            this.cbChooseCat.Size = new System.Drawing.Size(155, 21);
            this.cbChooseCat.TabIndex = 29;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(199, 375);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(107, 375);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddEqu
            // 
            this.btnAddEqu.Location = new System.Drawing.Point(21, 33);
            this.btnAddEqu.Name = "btnAddEqu";
            this.btnAddEqu.Size = new System.Drawing.Size(146, 41);
            this.btnAddEqu.TabIndex = 26;
            this.btnAddEqu.Text = "Add equipments for bicycle";
            this.btnAddEqu.UseVisualStyleBackColor = true;
            this.btnAddEqu.Click += new System.EventHandler(this.btnAddEqu_Click_1);
            // 
            // dgBicycles
            // 
            this.dgBicycles.Location = new System.Drawing.Point(296, 30);
            this.dgBicycles.Name = "dgBicycles";
            this.dgBicycles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBicycles.Size = new System.Drawing.Size(752, 530);
            this.dgBicycles.TabIndex = 25;
            this.dgBicycles.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgBicycles_MouseClick_1);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 375);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 24;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(117, 291);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(155, 20);
            this.txtCurrency.TabIndex = 23;
            // 
            // txtPpD
            // 
            this.txtPpD.Location = new System.Drawing.Point(117, 264);
            this.txtPpD.Name = "txtPpD";
            this.txtPpD.Size = new System.Drawing.Size(155, 20);
            this.txtPpD.TabIndex = 22;
            // 
            // txtPpH
            // 
            this.txtPpH.Location = new System.Drawing.Point(117, 237);
            this.txtPpH.Name = "txtPpH";
            this.txtPpH.Size = new System.Drawing.Size(155, 20);
            this.txtPpH.TabIndex = 21;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(117, 210);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(155, 20);
            this.txtState.TabIndex = 20;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 183);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(155, 20);
            this.txtName.TabIndex = 19;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(117, 157);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(155, 20);
            this.txtID.TabIndex = 18;
            // 
            // btnSaveCat
            // 
            this.btnSaveCat.Location = new System.Drawing.Point(87, 63);
            this.btnSaveCat.Name = "btnSaveCat";
            this.btnSaveCat.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCat.TabIndex = 17;
            this.btnSaveCat.Text = "Save";
            this.btnSaveCat.UseVisualStyleBackColor = true;
            this.btnSaveCat.Click += new System.EventHandler(this.btnSaveCat_Click_1);
            // 
            // lbNameNewCat
            // 
            this.lbNameNewCat.AutoSize = true;
            this.lbNameNewCat.Location = new System.Drawing.Point(6, 34);
            this.lbNameNewCat.Name = "lbNameNewCat";
            this.lbNameNewCat.Size = new System.Drawing.Size(117, 13);
            this.lbNameNewCat.TabIndex = 16;
            this.lbNameNewCat.Text = "Name of new category:";
            // 
            // gbAddCat
            // 
            this.gbAddCat.Controls.Add(this.txtNewCat);
            this.gbAddCat.Controls.Add(this.lbNameNewCat);
            this.gbAddCat.Controls.Add(this.btnSaveCat);
            this.gbAddCat.Location = new System.Drawing.Point(17, 30);
            this.gbAddCat.Name = "gbAddCat";
            this.gbAddCat.Size = new System.Drawing.Size(263, 100);
            this.gbAddCat.TabIndex = 31;
            this.gbAddCat.TabStop = false;
            this.gbAddCat.Text = "Add categories:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAddEqu);
            this.groupBox1.Location = new System.Drawing.Point(55, 440);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 102);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add equipment";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(23, 160);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 33;
            this.lbID.Text = "ID:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(23, 186);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 34;
            this.lbName.Text = "Name:";
            // 
            // lbPpH
            // 
            this.lbPpH.AutoSize = true;
            this.lbPpH.Location = new System.Drawing.Point(23, 239);
            this.lbPpH.Name = "lbPpH";
            this.lbPpH.Size = new System.Drawing.Size(76, 13);
            this.lbPpH.TabIndex = 36;
            this.lbPpH.Text = "Price per hour:";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(23, 213);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(35, 13);
            this.lbState.TabIndex = 35;
            this.lbState.Text = "State;";
            // 
            // lbCurrency
            // 
            this.lbCurrency.AutoSize = true;
            this.lbCurrency.Location = new System.Drawing.Point(23, 291);
            this.lbCurrency.Name = "lbCurrency";
            this.lbCurrency.Size = new System.Drawing.Size(52, 13);
            this.lbCurrency.TabIndex = 38;
            this.lbCurrency.Text = "Currency:";
            // 
            // lbPpD
            // 
            this.lbPpD.AutoSize = true;
            this.lbPpD.Location = new System.Drawing.Point(23, 267);
            this.lbPpD.Name = "lbPpD";
            this.lbPpD.Size = new System.Drawing.Size(72, 13);
            this.lbPpD.TabIndex = 37;
            this.lbPpD.Text = "Price per day:";
            // 
            // lbChooseCat
            // 
            this.lbChooseCat.AutoSize = true;
            this.lbChooseCat.Location = new System.Drawing.Point(23, 320);
            this.lbChooseCat.Name = "lbChooseCat";
            this.lbChooseCat.Size = new System.Drawing.Size(90, 13);
            this.lbChooseCat.TabIndex = 39;
            this.lbChooseCat.Text = "Choose category:";
            // 
            // FrmBicikli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 572);
            this.Controls.Add(this.lbChooseCat);
            this.Controls.Add(this.lbCurrency);
            this.Controls.Add(this.lbPpD);
            this.Controls.Add(this.lbPpH);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAddCat);
            this.Controls.Add(this.cbChooseCat);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgBicycles);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.txtPpD);
            this.Controls.Add(this.txtPpH);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBicikli";
            this.Text = "Bicycles";
            this.Load += new System.EventHandler(this.FrmBicikli_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgBicycles)).EndInit();
            this.gbAddCat.ResumeLayout(false);
            this.gbAddCat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNewCat;
        private System.Windows.Forms.ComboBox cbChooseCat;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddEqu;
        private System.Windows.Forms.DataGridView dgBicycles;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtPpD;
        private System.Windows.Forms.TextBox txtPpH;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSaveCat;
        private System.Windows.Forms.Label lbNameNewCat;
        private System.Windows.Forms.GroupBox gbAddCat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbPpH;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbCurrency;
        private System.Windows.Forms.Label lbPpD;
        private System.Windows.Forms.Label lbChooseCat;
    }
}