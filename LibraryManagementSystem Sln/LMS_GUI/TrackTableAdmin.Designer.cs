
namespace LMS_GUI
{
    partial class TrackTableAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackTableAdmin));
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.uID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblBackToHome = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uID,
            this.uName,
            this.bID,
            this.bName,
            this.bDate,
            this.rDate,
            this.fine});
            this.dataGridView4.Location = new System.Drawing.Point(36, 36);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 51;
            this.dataGridView4.RowTemplate.Height = 29;
            this.dataGridView4.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView4.Size = new System.Drawing.Size(869, 477);
            this.dataGridView4.TabIndex = 2;
            this.dataGridView4.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView4_CellClick);
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
            this.linkLabel1.Location = new System.Drawing.Point(454, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(143, 23);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "All Tracking Info";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnReturn.Location = new System.Drawing.Point(955, 169);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(94, 57);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Book Returned";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblBackToHome
            // 
            this.lblBackToHome.AutoSize = true;
            this.lblBackToHome.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBackToHome.Location = new System.Drawing.Point(991, 376);
            this.lblBackToHome.Name = "lblBackToHome";
            this.lblBackToHome.Size = new System.Drawing.Size(70, 23);
            this.lblBackToHome.TabIndex = 5;
            this.lblBackToHome.Text = "<Home";
            this.lblBackToHome.Click += new System.EventHandler(this.lblBackToHome_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::LMS_GUI.Properties.Resources.icons8_synchronize_24;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(955, 69);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(85, 29);
            this.btnRefresh.TabIndex = 36;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // TrackTableAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 525);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblBackToHome);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.dataGridView4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TrackTableAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tracking Table";
            this.Load += new System.EventHandler(this.TrackTableAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridViewTextBoxColumn uID;
        private System.Windows.Forms.DataGridViewTextBoxColumn uName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn rDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn fine;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblBackToHome;
        private System.Windows.Forms.Button btnRefresh;
    }
}