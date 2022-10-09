
namespace LMS_GUI
{
    partial class TrackingInformation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackingInformation));
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.uID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uID,
            this.uName,
            this.bID,
            this.bName,
            this.bDate,
            this.rDate,
            this.fine});
            this.dataGridView3.Location = new System.Drawing.Point(17, 42);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 29;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(863, 365);
            this.dataGridView3.TabIndex = 1;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // uID
            // 
            this.uID.DataPropertyName = "UserID";
            this.uID.HeaderText = "User ID";
            this.uID.MinimumWidth = 6;
            this.uID.Name = "uID";
            this.uID.ReadOnly = true;
            this.uID.Width = 125;
            // 
            // uName
            // 
            this.uName.DataPropertyName = "UserName";
            this.uName.HeaderText = "User Name";
            this.uName.MinimumWidth = 6;
            this.uName.Name = "uName";
            this.uName.ReadOnly = true;
            this.uName.Width = 125;
            // 
            // bID
            // 
            this.bID.DataPropertyName = "BookID";
            this.bID.HeaderText = "Book ID";
            this.bID.MinimumWidth = 6;
            this.bID.Name = "bID";
            this.bID.ReadOnly = true;
            this.bID.Width = 125;
            // 
            // bName
            // 
            this.bName.DataPropertyName = "BookName";
            this.bName.HeaderText = "Book Name";
            this.bName.MinimumWidth = 6;
            this.bName.Name = "bName";
            this.bName.ReadOnly = true;
            this.bName.Width = 125;
            // 
            // bDate
            // 
            this.bDate.DataPropertyName = "BorrowDate";
            this.bDate.HeaderText = "Borrow Date";
            this.bDate.MinimumWidth = 6;
            this.bDate.Name = "bDate";
            this.bDate.ReadOnly = true;
            this.bDate.Width = 125;
            // 
            // rDate
            // 
            this.rDate.DataPropertyName = "ReturnDate";
            this.rDate.HeaderText = "Return Date";
            this.rDate.MinimumWidth = 6;
            this.rDate.Name = "rDate";
            this.rDate.ReadOnly = true;
            this.rDate.Width = 125;
            // 
            // fine
            // 
            this.fine.DataPropertyName = "Fine";
            this.fine.HeaderText = "Fine";
            this.fine.MinimumWidth = 6;
            this.fine.Name = "fine";
            this.fine.ReadOnly = true;
            this.fine.Width = 125;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(342, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(210, 23);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Your Borrow Information";
            // 
            // TrackingInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 424);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrackingInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tracking Information";
            this.Load += new System.EventHandler(this.TrackingInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn uID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}