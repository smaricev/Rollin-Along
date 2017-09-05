namespace Rollin__Along.Unos_i_upravljanje_inventara
{
    partial class FrmOprema
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOprema));
            this.dgEquipment = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lbPpH = new System.Windows.Forms.Label();
            this.lbPpD = new System.Windows.Forms.Label();
            this.lbState = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.txtCurrency = new System.Windows.Forms.TextBox();
            this.txtPph = new System.Windows.Forms.TextBox();
            this.txtPpd = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipment)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgEquipment
            // 
            this.dgEquipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgEquipment.Location = new System.Drawing.Point(277, 28);
            this.dgEquipment.Name = "dgEquipment";
            this.dgEquipment.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgEquipment.Size = new System.Drawing.Size(784, 475);
            this.dgEquipment.TabIndex = 52;
            this.dgEquipment.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgEquipment_MouseClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(183, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 33);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(102, 296);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 33);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 49;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Currency:";
            // 
            // lbPpH
            // 
            this.lbPpH.AutoSize = true;
            this.lbPpH.Location = new System.Drawing.Point(23, 233);
            this.lbPpH.Name = "lbPpH";
            this.lbPpH.Size = new System.Drawing.Size(76, 13);
            this.lbPpH.TabIndex = 47;
            this.lbPpH.Text = "Price per hour:";
            // 
            // lbPpD
            // 
            this.lbPpD.AutoSize = true;
            this.lbPpD.Location = new System.Drawing.Point(23, 206);
            this.lbPpD.Name = "lbPpD";
            this.lbPpD.Size = new System.Drawing.Size(72, 13);
            this.lbPpD.TabIndex = 46;
            this.lbPpD.Text = "Price per day:";
            // 
            // lbState
            // 
            this.lbState.AutoSize = true;
            this.lbState.Location = new System.Drawing.Point(23, 179);
            this.lbState.Name = "lbState";
            this.lbState.Size = new System.Drawing.Size(35, 13);
            this.lbState.TabIndex = 45;
            this.lbState.Text = "State:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(23, 152);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 44;
            this.lbName.Text = "Name:";
            // 
            // txtCurrency
            // 
            this.txtCurrency.Location = new System.Drawing.Point(114, 257);
            this.txtCurrency.Name = "txtCurrency";
            this.txtCurrency.Size = new System.Drawing.Size(144, 20);
            this.txtCurrency.TabIndex = 43;
            // 
            // txtPph
            // 
            this.txtPph.Location = new System.Drawing.Point(114, 230);
            this.txtPph.Name = "txtPph";
            this.txtPph.Size = new System.Drawing.Size(144, 20);
            this.txtPph.TabIndex = 42;
            // 
            // txtPpd
            // 
            this.txtPpd.Location = new System.Drawing.Point(114, 203);
            this.txtPpd.Name = "txtPpd";
            this.txtPpd.Size = new System.Drawing.Size(144, 20);
            this.txtPpd.TabIndex = 41;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(114, 176);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(144, 20);
            this.txtState.TabIndex = 40;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(114, 149);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(144, 20);
            this.txtName.TabIndex = 39;
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(23, 125);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(21, 13);
            this.lbID.TabIndex = 38;
            this.lbID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(114, 122);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(144, 20);
            this.txtID.TabIndex = 37;
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(6, 22);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(52, 13);
            this.lbCategory.TabIndex = 36;
            this.lbCategory.Text = "Category:";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(93, 19);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(144, 21);
            this.cbCategory.TabIndex = 35;
            this.cbCategory.SelectedIndexChanged += new System.EventHandler(this.cbCategory_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbCategory);
            this.groupBox1.Controls.Add(this.cbCategory);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 56);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choosing category";
            // 
            // FrmOprema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 515);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgEquipment);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbPpH);
            this.Controls.Add(this.lbPpD);
            this.Controls.Add(this.lbState);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.txtCurrency);
            this.Controls.Add(this.txtPph);
            this.Controls.Add(this.txtPpd);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.txtID);
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOprema";
            this.Text = "Equipment";
            this.Load += new System.EventHandler(this.FrmOprema_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgEquipment)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgEquipment;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbPpH;
        private System.Windows.Forms.Label lbPpD;
        private System.Windows.Forms.Label lbState;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.TextBox txtPph;
        private System.Windows.Forms.TextBox txtPpd;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}