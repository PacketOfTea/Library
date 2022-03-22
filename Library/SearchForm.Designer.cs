namespace LibraryForm
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.PublisherLbl = new System.Windows.Forms.Label();
            this.PublicDateLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AuthorLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.AuthorСmbBox = new System.Windows.Forms.ComboBox();
            this.NameCmbBox = new System.Windows.Forms.ComboBox();
            this.PublicDateCmbBox = new System.Windows.Forms.ComboBox();
            this.PublisherCmbBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // PublisherLbl
            // 
            this.PublisherLbl.AutoSize = true;
            this.PublisherLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PublisherLbl.Location = new System.Drawing.Point(12, 129);
            this.PublisherLbl.Name = "PublisherLbl";
            this.PublisherLbl.Size = new System.Drawing.Size(136, 28);
            this.PublisherLbl.TabIndex = 17;
            this.PublisherLbl.Text = "Издательство";
            // 
            // PublicDateLbl
            // 
            this.PublicDateLbl.AutoSize = true;
            this.PublicDateLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PublicDateLbl.Location = new System.Drawing.Point(12, 89);
            this.PublicDateLbl.Name = "PublicDateLbl";
            this.PublicDateLbl.Size = new System.Drawing.Size(125, 28);
            this.PublicDateLbl.TabIndex = 16;
            this.PublicDateLbl.Text = "Год издания";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.Location = new System.Drawing.Point(12, 49);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(100, 28);
            this.NameLbl.TabIndex = 15;
            this.NameLbl.Text = "Название";
            // 
            // AuthorLbl
            // 
            this.AuthorLbl.AutoSize = true;
            this.AuthorLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorLbl.Location = new System.Drawing.Point(12, 9);
            this.AuthorLbl.Name = "AuthorLbl";
            this.AuthorLbl.Size = new System.Drawing.Size(68, 28);
            this.AuthorLbl.TabIndex = 14;
            this.AuthorLbl.Text = "Автор";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Bisque;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.Location = new System.Drawing.Point(150, 180);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(120, 40);
            this.SearchBtn.TabIndex = 22;
            this.SearchBtn.Text = "Поиск";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // AuthorСmbBox
            // 
            this.AuthorСmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.AuthorСmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.AuthorСmbBox.FormattingEnabled = true;
            this.AuthorСmbBox.Location = new System.Drawing.Point(185, 13);
            this.AuthorСmbBox.Name = "AuthorСmbBox";
            this.AuthorСmbBox.Size = new System.Drawing.Size(221, 28);
            this.AuthorСmbBox.TabIndex = 23;
            // 
            // NameCmbBox
            // 
            this.NameCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.NameCmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.NameCmbBox.FormattingEnabled = true;
            this.NameCmbBox.Location = new System.Drawing.Point(185, 49);
            this.NameCmbBox.Name = "NameCmbBox";
            this.NameCmbBox.Size = new System.Drawing.Size(221, 28);
            this.NameCmbBox.TabIndex = 24;
            // 
            // PublicDateCmbBox
            // 
            this.PublicDateCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PublicDateCmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PublicDateCmbBox.FormattingEnabled = true;
            this.PublicDateCmbBox.Location = new System.Drawing.Point(185, 89);
            this.PublicDateCmbBox.Name = "PublicDateCmbBox";
            this.PublicDateCmbBox.Size = new System.Drawing.Size(221, 28);
            this.PublicDateCmbBox.TabIndex = 25;
            // 
            // PublisherCmbBox
            // 
            this.PublisherCmbBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.PublisherCmbBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.PublisherCmbBox.FormattingEnabled = true;
            this.PublisherCmbBox.Location = new System.Drawing.Point(185, 129);
            this.PublisherCmbBox.Name = "PublisherCmbBox";
            this.PublisherCmbBox.Size = new System.Drawing.Size(221, 28);
            this.PublisherCmbBox.TabIndex = 26;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 236);
            this.Controls.Add(this.PublisherCmbBox);
            this.Controls.Add(this.PublicDateCmbBox);
            this.Controls.Add(this.NameCmbBox);
            this.Controls.Add(this.AuthorСmbBox);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.PublisherLbl);
            this.Controls.Add(this.PublicDateLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.AuthorLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label PublisherLbl;
        private Label PublicDateLbl;
        private Label NameLbl;
        private Label AuthorLbl;
        private Button SearchBtn;
        private ComboBox AuthorСmbBox;
        private ComboBox NameCmbBox;
        private ComboBox PublicDateCmbBox;
        private ComboBox PublisherCmbBox;
    }
}