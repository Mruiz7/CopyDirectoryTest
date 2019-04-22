namespace CopyDirectory
{
    partial class FormCopyDirectory
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
            this.btnCopyDirectory = new System.Windows.Forms.Button();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtDestinationDirectory = new System.Windows.Forms.TextBox();
            this.txtSourceDirectory = new System.Windows.Forms.TextBox();
            this.btnSourceDirectory = new System.Windows.Forms.Button();
            this.btnDestination = new System.Windows.Forms.Button();
            this.folderBrowserDialogSource = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialogDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.btnClearDirectorySelected = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.dataGridViewProgress = new System.Windows.Forms.DataGridView();
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDestination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTimeCopy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgress)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCopyDirectory
            // 
            this.btnCopyDirectory.Location = new System.Drawing.Point(186, 84);
            this.btnCopyDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopyDirectory.Name = "btnCopyDirectory";
            this.btnCopyDirectory.Size = new System.Drawing.Size(144, 24);
            this.btnCopyDirectory.TabIndex = 10;
            this.btnCopyDirectory.Text = "Copy files in Directory";
            this.btnCopyDirectory.UseVisualStyleBackColor = true;
            this.btnCopyDirectory.Click += new System.EventHandler(this.btnCopyDirectory_Click);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(53, 54);
            this.Label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(105, 13);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Destination Directory";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(64, 23);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 13);
            this.Label1.TabIndex = 6;
            this.Label1.Text = "Source Directory";
            // 
            // txtDestinationDirectory
            // 
            this.txtDestinationDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationDirectory.Location = new System.Drawing.Point(161, 51);
            this.txtDestinationDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.txtDestinationDirectory.Name = "txtDestinationDirectory";
            this.txtDestinationDirectory.Size = new System.Drawing.Size(166, 20);
            this.txtDestinationDirectory.TabIndex = 9;
            // 
            // txtSourceDirectory
            // 
            this.txtSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSourceDirectory.Location = new System.Drawing.Point(161, 20);
            this.txtSourceDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.txtSourceDirectory.Name = "txtSourceDirectory";
            this.txtSourceDirectory.Size = new System.Drawing.Size(166, 20);
            this.txtSourceDirectory.TabIndex = 7;
            // 
            // btnSourceDirectory
            // 
            this.btnSourceDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSourceDirectory.Location = new System.Drawing.Point(336, 20);
            this.btnSourceDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.btnSourceDirectory.Name = "btnSourceDirectory";
            this.btnSourceDirectory.Size = new System.Drawing.Size(24, 19);
            this.btnSourceDirectory.TabIndex = 20;
            this.btnSourceDirectory.Text = "...";
            this.btnSourceDirectory.UseVisualStyleBackColor = true;
            this.btnSourceDirectory.Click += new System.EventHandler(this.btnOrigin_Click);
            // 
            // btnDestination
            // 
            this.btnDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDestination.Location = new System.Drawing.Point(336, 51);
            this.btnDestination.Margin = new System.Windows.Forms.Padding(2);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(24, 19);
            this.btnDestination.TabIndex = 21;
            this.btnDestination.Text = "...";
            this.btnDestination.UseVisualStyleBackColor = true;
            this.btnDestination.Click += new System.EventHandler(this.btnDestination_Click);
            // 
            // btnClearDirectorySelected
            // 
            this.btnClearDirectorySelected.Location = new System.Drawing.Point(67, 84);
            this.btnClearDirectorySelected.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearDirectorySelected.Name = "btnClearDirectorySelected";
            this.btnClearDirectorySelected.Size = new System.Drawing.Size(91, 24);
            this.btnClearDirectorySelected.TabIndex = 22;
            this.btnClearDirectorySelected.Text = "Clear";
            this.btnClearDirectorySelected.UseVisualStyleBackColor = true;
            this.btnClearDirectorySelected.Click += new System.EventHandler(this.btnClearDirectorySelected_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(13, 121);
            this.lblProgress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(48, 13);
            this.lblProgress.TabIndex = 24;
            this.lblProgress.Text = "Progress";
            // 
            // dataGridViewProgress
            // 
            this.dataGridViewProgress.AllowUserToAddRows = false;
            this.dataGridViewProgress.AllowUserToDeleteRows = false;
            this.dataGridViewProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewProgress.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProgress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProgress.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnSource,
            this.ColumnDestination,
            this.ColumnStatus,
            this.ColumnTimeCopy});
            this.dataGridViewProgress.Location = new System.Drawing.Point(9, 137);
            this.dataGridViewProgress.Name = "dataGridViewProgress";
            this.dataGridViewProgress.ReadOnly = true;
            this.dataGridViewProgress.Size = new System.Drawing.Size(395, 149);
            this.dataGridViewProgress.TabIndex = 25;
            // 
            // ColumnId
            // 
            this.ColumnId.HeaderText = "Id";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Visible = false;
            // 
            // ColumnSource
            // 
            this.ColumnSource.HeaderText = "Source";
            this.ColumnSource.Name = "ColumnSource";
            this.ColumnSource.ReadOnly = true;
            // 
            // ColumnDestination
            // 
            this.ColumnDestination.HeaderText = "Destination";
            this.ColumnDestination.Name = "ColumnDestination";
            this.ColumnDestination.ReadOnly = true;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            this.ColumnStatus.ReadOnly = true;
            // 
            // ColumnTimeCopy
            // 
            this.ColumnTimeCopy.HeaderText = "Time to Copy";
            this.ColumnTimeCopy.Name = "ColumnTimeCopy";
            this.ColumnTimeCopy.ReadOnly = true;
            // 
            // FormCopyDirectory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 291);
            this.Controls.Add(this.dataGridViewProgress);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.btnClearDirectorySelected);
            this.Controls.Add(this.btnDestination);
            this.Controls.Add(this.btnSourceDirectory);
            this.Controls.Add(this.btnCopyDirectory);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtDestinationDirectory);
            this.Controls.Add(this.txtSourceDirectory);
            this.Name = "FormCopyDirectory";
            this.Text = "CopyDirectory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnCopyDirectory;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtDestinationDirectory;
        internal System.Windows.Forms.TextBox txtSourceDirectory;
        private System.Windows.Forms.Button btnSourceDirectory;
        private System.Windows.Forms.Button btnDestination;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSource;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogDestination;
        internal System.Windows.Forms.Button btnClearDirectorySelected;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.DataGridView dataGridViewProgress;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTimeCopy;
    }
}