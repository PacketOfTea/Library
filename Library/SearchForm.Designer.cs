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
            this.AuthorTxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.PublicDateTxtBox = new System.Windows.Forms.TextBox();
            this.PublisherTxtBox = new System.Windows.Forms.TextBox();
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
            // AuthorTxtBox
            // 
            this.AuthorTxtBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthorTxtBox.Location = new System.Drawing.Point(149, 12);
            this.AuthorTxtBox.Name = "AuthorTxtBox";
            this.AuthorTxtBox.Size = new System.Drawing.Size(181, 30);
            this.AuthorTxtBox.TabIndex = 27;
            this.AuthorTxtBox.TextChanged += new System.EventHandler(this.AuthorTxtBox_TextChanged);
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTxtBox.Location = new System.Drawing.Point(149, 51);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(181, 30);
            this.NameTxtBox.TabIndex = 28;
            this.NameTxtBox.TextChanged += new System.EventHandler(this.AuthorTxtBox_TextChanged);
            // 
            // PublicDateTxtBox
            // 
            this.PublicDateTxtBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PublicDateTxtBox.Location = new System.Drawing.Point(149, 91);
            this.PublicDateTxtBox.Name = "PublicDateTxtBox";
            this.PublicDateTxtBox.Size = new System.Drawing.Size(181, 30);
            this.PublicDateTxtBox.TabIndex = 29;
            this.PublicDateTxtBox.TextChanged += new System.EventHandler(this.AuthorTxtBox_TextChanged);
            // 
            // PublisherTxtBox
            // 
            this.PublisherTxtBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PublisherTxtBox.Location = new System.Drawing.Point(149, 131);
            this.PublisherTxtBox.Name = "PublisherTxtBox";
            this.PublisherTxtBox.Size = new System.Drawing.Size(181, 30);
            this.PublisherTxtBox.TabIndex = 30;
            this.PublisherTxtBox.TextChanged += new System.EventHandler(this.AuthorTxtBox_TextChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(341, 176);
            this.Controls.Add(this.PublisherTxtBox);
            this.Controls.Add(this.PublicDateTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.AuthorTxtBox);
            this.Controls.Add(this.PublisherLbl);
            this.Controls.Add(this.PublicDateLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.AuthorLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(587, 163);
            this.MaximizeBox = false;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private TextBox AuthorTxtBox;
        private TextBox NameTxtBox;
        private TextBox PublicDateTxtBox;
        private TextBox PublisherTxtBox;
    }
}