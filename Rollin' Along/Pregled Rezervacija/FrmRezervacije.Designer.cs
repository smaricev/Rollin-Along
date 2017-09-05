namespace Rollin__Along.Pregled_Rezervacija
{
    partial class FrmRezervacije
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRezervacije));
            this.dgNajmovi = new System.Windows.Forms.DataGridView();
            this.rentidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datefromDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bicycleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userLabel = new System.Windows.Forms.Label();
            this.promjenaStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.changeStatusBtn = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.Button();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgNajmovi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgNajmovi
            // 
            this.dgNajmovi.AllowUserToAddRows = false;
            this.dgNajmovi.AllowUserToDeleteRows = false;
            this.dgNajmovi.AllowUserToOrderColumns = true;
            this.dgNajmovi.AutoGenerateColumns = false;
            this.dgNajmovi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNajmovi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rentidDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.datefromDataGridViewTextBoxColumn,
            this.datetoDataGridViewTextBoxColumn,
            this.bicycleDataGridViewTextBoxColumn,
            this.userDataGridViewTextBoxColumn});
            this.dgNajmovi.DataSource = this.rentBindingSource;
            this.dgNajmovi.Location = new System.Drawing.Point(191, 34);
            this.dgNajmovi.Name = "dgNajmovi";
            this.dgNajmovi.ReadOnly = true;
            this.dgNajmovi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNajmovi.Size = new System.Drawing.Size(776, 517);
            this.dgNajmovi.TabIndex = 0;
            this.dgNajmovi.SelectionChanged += new System.EventHandler(this.dgNajmovi_SelectionChanged);
            // 
            // rentidDataGridViewTextBoxColumn
            // 
            this.rentidDataGridViewTextBoxColumn.DataPropertyName = "Rentid";
            this.rentidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.rentidDataGridViewTextBoxColumn.Name = "rentidDataGridViewTextBoxColumn";
            this.rentidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // datefromDataGridViewTextBoxColumn
            // 
            this.datefromDataGridViewTextBoxColumn.DataPropertyName = "Date_from";
            this.datefromDataGridViewTextBoxColumn.HeaderText = "Date from";
            this.datefromDataGridViewTextBoxColumn.Name = "datefromDataGridViewTextBoxColumn";
            this.datefromDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datetoDataGridViewTextBoxColumn
            // 
            this.datetoDataGridViewTextBoxColumn.DataPropertyName = "Date_to";
            this.datetoDataGridViewTextBoxColumn.HeaderText = "Date to";
            this.datetoDataGridViewTextBoxColumn.Name = "datetoDataGridViewTextBoxColumn";
            this.datetoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bicycleDataGridViewTextBoxColumn
            // 
            this.bicycleDataGridViewTextBoxColumn.DataPropertyName = "Bicycle";
            this.bicycleDataGridViewTextBoxColumn.HeaderText = "Bicycle";
            this.bicycleDataGridViewTextBoxColumn.Name = "bicycleDataGridViewTextBoxColumn";
            this.bicycleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "User";
            this.userDataGridViewTextBoxColumn.HeaderText = "User";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            this.userDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rentBindingSource
            // 
            this.rentBindingSource.DataSource = typeof(Rollin__Along.Podatkovne_klase.Rent);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(12, 13);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(0, 13);
            this.userLabel.TabIndex = 1;
            // 
            // promjenaStatus
            // 
            this.promjenaStatus.FormattingEnabled = true;
            this.promjenaStatus.Location = new System.Drawing.Point(28, 131);
            this.promjenaStatus.Name = "promjenaStatus";
            this.promjenaStatus.Size = new System.Drawing.Size(121, 21);
            this.promjenaStatus.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Change Status:";
            // 
            // changeStatusBtn
            // 
            this.changeStatusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(92)))), ((int)(((byte)(99)))));
            this.changeStatusBtn.ForeColor = System.Drawing.Color.White;
            this.changeStatusBtn.Location = new System.Drawing.Point(74, 158);
            this.changeStatusBtn.Name = "changeStatusBtn";
            this.changeStatusBtn.Size = new System.Drawing.Size(75, 23);
            this.changeStatusBtn.TabIndex = 4;
            this.changeStatusBtn.Text = "Change";
            this.changeStatusBtn.UseVisualStyleBackColor = false;
            this.changeStatusBtn.Click += new System.EventHandler(this.changeStatusBtn_Click);
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(92)))), ((int)(((byte)(99)))));
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Location = new System.Drawing.Point(12, 8);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(75, 23);
            this.Menu.TabIndex = 5;
            this.Menu.Text = "Menu";
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(Rollin__Along.Podatkovne_klase.User);
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataSource = typeof(Rollin__Along.Podatkovne_klase.Status);
            // 
            // FrmRezervacije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1046, 588);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.changeStatusBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.promjenaStatus);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.dgNajmovi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmRezervacije";
            this.Text = "Rent";
            ((System.ComponentModel.ISupportInitialize)(this.dgNajmovi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgNajmovi;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.BindingSource rentBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datefromDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bicycleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox promjenaStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changeStatusBtn;
        private System.Windows.Forms.Button Menu;
    }
}