namespace Library
{
    partial class Search
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search));
            this.PublisherTxtBox = new System.Windows.Forms.TextBox();
            this.PublicDateTxtBox = new System.Windows.Forms.TextBox();
            this.NameTxtBox = new System.Windows.Forms.TextBox();
            this.AuthorTxtBox = new System.Windows.Forms.TextBox();
            this.PublisherLbl = new System.Windows.Forms.Label();
            this.PublicDateLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.AuthorLbl = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PublisherTxtBox
            // 
            this.PublisherTxtBox.Location = new System.Drawing.Point(185, 130);
            this.PublisherTxtBox.Name = "PublisherTxtBox";
            this.PublisherTxtBox.Size = new System.Drawing.Size(221, 27);
            this.PublisherTxtBox.TabIndex = 21;
            // 
            // PublicDateTxtBox
            // 
            this.PublicDateTxtBox.Location = new System.Drawing.Point(185, 90);
            this.PublicDateTxtBox.Name = "PublicDateTxtBox";
            this.PublicDateTxtBox.Size = new System.Drawing.Size(221, 27);
            this.PublicDateTxtBox.TabIndex = 20;
            // 
            // NameTxtBox
            // 
            this.NameTxtBox.Location = new System.Drawing.Point(185, 50);
            this.NameTxtBox.Name = "NameTxtBox";
            this.NameTxtBox.Size = new System.Drawing.Size(221, 27);
            this.NameTxtBox.TabIndex = 19;
            // 
            // AuthorTxtBox
            // 
            this.AuthorTxtBox.Location = new System.Drawing.Point(185, 10);
            this.AuthorTxtBox.Name = "AuthorTxtBox";
            this.AuthorTxtBox.Size = new System.Drawing.Size(221, 27);
            this.AuthorTxtBox.TabIndex = 18;
            // 
            // PublisherLbl
            // 
            this.PublisherLbl.AutoSize = true;
            this.PublisherLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PublisherLbl.Location = new System.Drawing.Point(12, 129);
            this.PublisherLbl.Name = "PublisherLbl";
            this.PublisherLbl.Size = new System.Drawing.Size(96, 28);
            this.PublisherLbl.TabIndex = 17;
            this.PublisherLbl.Text = "Издатель";
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
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(422, 236);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.PublisherTxtBox);
            this.Controls.Add(this.PublicDateTxtBox);
            this.Controls.Add(this.NameTxtBox);
            this.Controls.Add(this.AuthorTxtBox);
            this.Controls.Add(this.PublisherLbl);
            this.Controls.Add(this.PublicDateLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.AuthorLbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox PublisherTxtBox;
        private TextBox PublicDateTxtBox;
        private TextBox NameTxtBox;
        private TextBox AuthorTxtBox;
        private Label PublisherLbl;
        private Label PublicDateLbl;
        private Label NameLbl;
        private Label AuthorLbl;
        private Button SearchBtn;
    }
}