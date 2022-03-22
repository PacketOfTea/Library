﻿namespace LibraryForm
{
    partial class LibraryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.ReadersBooksPanel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TitleReadersBooksLbl = new System.Windows.Forms.Label();
            this.SearchBooksPanel = new System.Windows.Forms.Panel();
            this.EditBookBtn = new System.Windows.Forms.Button();
            this.AddBookBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBookBtn = new System.Windows.Forms.Button();
            this.LibraryCardPanel = new System.Windows.Forms.Panel();
            this.PrintCardBtn = new System.Windows.Forms.Button();
            this.EditReaderBtn = new System.Windows.Forms.Button();
            this.ChangeReaderBtn = new System.Windows.Forms.Button();
            this.PatronymicLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.CardNumberLbl = new System.Windows.Forms.Label();
            this.ReadersCardLbl = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.ReadersBooksPanel.SuspendLayout();
            this.SearchBooksPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LibraryCardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadersBooksPanel
            // 
            this.ReadersBooksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ReadersBooksPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.ReadersBooksPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReadersBooksPanel.Controls.Add(this.textBox1);
            this.ReadersBooksPanel.Controls.Add(this.TitleReadersBooksLbl);
            this.ReadersBooksPanel.Location = new System.Drawing.Point(12, 224);
            this.ReadersBooksPanel.Name = "ReadersBooksPanel";
            this.ReadersBooksPanel.Size = new System.Drawing.Size(335, 520);
            this.ReadersBooksPanel.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(326, 27);
            this.textBox1.TabIndex = 1;
            // 
            // TitleReadersBooksLbl
            // 
            this.TitleReadersBooksLbl.AutoSize = true;
            this.TitleReadersBooksLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleReadersBooksLbl.Location = new System.Drawing.Point(75, 0);
            this.TitleReadersBooksLbl.Name = "TitleReadersBooksLbl";
            this.TitleReadersBooksLbl.Size = new System.Drawing.Size(167, 28);
            this.TitleReadersBooksLbl.TabIndex = 0;
            this.TitleReadersBooksLbl.Text = "Книги \"на руках\"";
            // 
            // SearchBooksPanel
            // 
            this.SearchBooksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBooksPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.SearchBooksPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBooksPanel.Controls.Add(this.EditBookBtn);
            this.SearchBooksPanel.Controls.Add(this.AddBookBtn);
            this.SearchBooksPanel.Controls.Add(this.dataGridView1);
            this.SearchBooksPanel.Controls.Add(this.SearchBookBtn);
            this.SearchBooksPanel.Location = new System.Drawing.Point(353, 12);
            this.SearchBooksPanel.Name = "SearchBooksPanel";
            this.SearchBooksPanel.Size = new System.Drawing.Size(1007, 732);
            this.SearchBooksPanel.TabIndex = 2;
            // 
            // EditBookBtn
            // 
            this.EditBookBtn.BackColor = System.Drawing.Color.Moccasin;
            this.EditBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBookBtn.Location = new System.Drawing.Point(490, 4);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.Size = new System.Drawing.Size(184, 33);
            this.EditBookBtn.TabIndex = 5;
            this.EditBookBtn.Text = "Редактировать книгу";
            this.EditBookBtn.UseVisualStyleBackColor = false;
            this.EditBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.BackColor = System.Drawing.Color.Moccasin;
            this.AddBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBookBtn.Location = new System.Drawing.Point(332, 3);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(152, 33);
            this.AddBookBtn.TabIndex = 4;
            this.AddBookBtn.Text = "Добавить книгу";
            this.AddBookBtn.UseVisualStyleBackColor = false;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 52);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1007, 679);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SearchBookBtn
            // 
            this.SearchBookBtn.BackColor = System.Drawing.Color.Moccasin;
            this.SearchBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBookBtn.Location = new System.Drawing.Point(7, 7);
            this.SearchBookBtn.Name = "SearchBookBtn";
            this.SearchBookBtn.Size = new System.Drawing.Size(121, 33);
            this.SearchBookBtn.TabIndex = 0;
            this.SearchBookBtn.Text = "Поиск книги";
            this.SearchBookBtn.UseVisualStyleBackColor = false;
            this.SearchBookBtn.Click += new System.EventHandler(this.SearchBookBtn_Click);
            // 
            // LibraryCardPanel
            // 
            this.LibraryCardPanel.BackColor = System.Drawing.Color.White;
            this.LibraryCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LibraryCardPanel.Controls.Add(this.PrintCardBtn);
            this.LibraryCardPanel.Controls.Add(this.EditReaderBtn);
            this.LibraryCardPanel.Controls.Add(this.ChangeReaderBtn);
            this.LibraryCardPanel.Controls.Add(this.PatronymicLbl);
            this.LibraryCardPanel.Controls.Add(this.NameLbl);
            this.LibraryCardPanel.Controls.Add(this.SurnameLbl);
            this.LibraryCardPanel.Controls.Add(this.CardNumberLbl);
            this.LibraryCardPanel.Controls.Add(this.ReadersCardLbl);
            this.LibraryCardPanel.Controls.Add(this.PhotoPictureBox);
            this.LibraryCardPanel.Location = new System.Drawing.Point(12, 12);
            this.LibraryCardPanel.Name = "LibraryCardPanel";
            this.LibraryCardPanel.Size = new System.Drawing.Size(335, 206);
            this.LibraryCardPanel.TabIndex = 1;
            // 
            // PrintCardBtn
            // 
            this.PrintCardBtn.AccessibleDescription = "Печать читательского билета";
            this.PrintCardBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrintCardBtn.BackgroundImage")));
            this.PrintCardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PrintCardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintCardBtn.Location = new System.Drawing.Point(75, 171);
            this.PrintCardBtn.Name = "PrintCardBtn";
            this.PrintCardBtn.Size = new System.Drawing.Size(30, 30);
            this.PrintCardBtn.TabIndex = 10;
            this.PrintCardBtn.UseVisualStyleBackColor = true;
            this.PrintCardBtn.Click += new System.EventHandler(this.PrintCardBtn_Click);
            // 
            // EditReaderBtn
            // 
            this.EditReaderBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditReaderBtn.BackgroundImage")));
            this.EditReaderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EditReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditReaderBtn.Location = new System.Drawing.Point(39, 171);
            this.EditReaderBtn.Name = "EditReaderBtn";
            this.EditReaderBtn.Size = new System.Drawing.Size(30, 30);
            this.EditReaderBtn.TabIndex = 9;
            this.EditReaderBtn.UseVisualStyleBackColor = true;
            this.EditReaderBtn.Click += new System.EventHandler(this.EditReaderBtn_Click);
            // 
            // ChangeReaderBtn
            // 
            this.ChangeReaderBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeReaderBtn.BackgroundImage")));
            this.ChangeReaderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeReaderBtn.Location = new System.Drawing.Point(3, 171);
            this.ChangeReaderBtn.Name = "ChangeReaderBtn";
            this.ChangeReaderBtn.Size = new System.Drawing.Size(30, 30);
            this.ChangeReaderBtn.TabIndex = 6;
            this.ChangeReaderBtn.UseVisualStyleBackColor = true;
            this.ChangeReaderBtn.Click += new System.EventHandler(this.ChangeReaderBtn_Click);
            // 
            // PatronymicLbl
            // 
            this.PatronymicLbl.AutoSize = true;
            this.PatronymicLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatronymicLbl.Location = new System.Drawing.Point(147, 123);
            this.PatronymicLbl.Name = "PatronymicLbl";
            this.PatronymicLbl.Size = new System.Drawing.Size(96, 28);
            this.PatronymicLbl.TabIndex = 5;
            this.PatronymicLbl.Text = "Отчество";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.Location = new System.Drawing.Point(147, 95);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(51, 28);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Имя";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SurnameLbl.Location = new System.Drawing.Point(147, 64);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(96, 28);
            this.SurnameLbl.TabIndex = 3;
            this.SurnameLbl.Text = "Фамилия";
            // 
            // CardNumberLbl
            // 
            this.CardNumberLbl.AutoSize = true;
            this.CardNumberLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardNumberLbl.Location = new System.Drawing.Point(147, 36);
            this.CardNumberLbl.Name = "CardNumberLbl";
            this.CardNumberLbl.Size = new System.Drawing.Size(133, 28);
            this.CardNumberLbl.TabIndex = 2;
            this.CardNumberLbl.Text = "23214124124";
            // 
            // ReadersCardLbl
            // 
            this.ReadersCardLbl.AutoSize = true;
            this.ReadersCardLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReadersCardLbl.Location = new System.Drawing.Point(97, 5);
            this.ReadersCardLbl.Name = "ReadersCardLbl";
            this.ReadersCardLbl.Size = new System.Drawing.Size(233, 31);
            this.ReadersCardLbl.TabIndex = 1;
            this.ReadersCardLbl.Text = "Читательский билет";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoPictureBox.ImageLocation = "";
            this.PhotoPictureBox.Location = new System.Drawing.Point(3, 3);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(90, 120);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1372, 756);
            this.Controls.Add(this.LibraryCardPanel);
            this.Controls.Add(this.SearchBooksPanel);
            this.Controls.Add(this.ReadersBooksPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LibraryForm_FormClosed);
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.ReadersBooksPanel.ResumeLayout(false);
            this.ReadersBooksPanel.PerformLayout();
            this.SearchBooksPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.LibraryCardPanel.ResumeLayout(false);
            this.LibraryCardPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel ReadersBooksPanel;
        private Panel SearchBooksPanel;
        private Label TitleReadersBooksLbl;
        private Panel LibraryCardPanel;
        private Label PatronymicLbl;
        private Label NameLbl;
        private Label SurnameLbl;
        private Label CardNumberLbl;
        private Label ReadersCardLbl;
        private PictureBox PhotoPictureBox;
        private Button PrintCardBtn;
        private Button EditReaderBtn;
        private Button ChangeReaderBtn;
        private Button SearchBookBtn;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button EditBookBtn;
        private Button AddBookBtn;
    }
}