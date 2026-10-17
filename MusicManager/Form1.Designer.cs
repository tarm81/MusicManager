namespace MusicManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtSearch = new TextBox();
            cmbSearchType = new ComboBox();
            btnSearch = new Button();
            btnClear = new Button();
            dgvSongs = new DataGridView();
            lblResults = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSongs).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.Top;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 13F);
            lblTitle.Location = new Point(309, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(251, 52);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Music Library";
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSearch.Location = new Point(230, 88);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(416, 43);
            txtSearch.TabIndex = 1;
            // 
            // cmbSearchType
            // 
            cmbSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbSearchType.FormattingEnabled = true;
            cmbSearchType.Items.AddRange(new object[] { "Song Title", "Artist Name", "Album Name", "Release Year" });
            cmbSearchType.Location = new Point(12, 86);
            cmbSearchType.Name = "cmbSearchType";
            cmbSearchType.Size = new Size(212, 45);
            cmbSearchType.TabIndex = 2;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(652, 86);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(103, 45);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClear.Location = new Point(761, 88);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(99, 45);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // dgvSongs
            // 
            dgvSongs.AllowUserToAddRows = false;
            dgvSongs.AllowUserToDeleteRows = false;
            dgvSongs.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSongs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSongs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSongs.Location = new Point(12, 137);
            dgvSongs.MultiSelect = false;
            dgvSongs.Name = "dgvSongs";
            dgvSongs.ReadOnly = true;
            dgvSongs.RowHeadersWidth = 92;
            dgvSongs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSongs.Size = new Size(848, 285);
            dgvSongs.TabIndex = 5;
            // 
            // lblResults
            // 
            lblResults.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblResults.AutoSize = true;
            lblResults.Location = new Point(12, 425);
            lblResults.Name = "lblResults";
            lblResults.Size = new Size(0, 37);
            lblResults.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 471);
            Controls.Add(lblResults);
            Controls.Add(dgvSongs);
            Controls.Add(btnClear);
            Controls.Add(btnSearch);
            Controls.Add(cmbSearchType);
            Controls.Add(txtSearch);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Music Library Manager";
            ((System.ComponentModel.ISupportInitialize)dgvSongs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtSearch;
        private ComboBox cmbSearchType;
        private Button btnSearch;
        private Button btnClear;
        private DataGridView dgvSongs;
        private Label lblResults;
    }
}
