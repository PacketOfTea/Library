namespace LibraryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.ReadersBooksPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accept_Book_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.publisher_lbl1 = new System.Windows.Forms.Label();
            this.author_lbl1 = new System.Windows.Forms.Label();
            this.title_lbl1 = new System.Windows.Forms.Label();
            this.TitleReadersBooksLbl = new System.Windows.Forms.Label();
            this.SearchBooksPanel = new System.Windows.Forms.Panel();
            this.panel = new System.Windows.Forms.Panel();
            this.giveBook_btn = new System.Windows.Forms.Button();
            this.qty_lbl = new System.Windows.Forms.Label();
            this.publisher_lbl = new System.Windows.Forms.Label();
            this.author_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.BooksPictureBox = new System.Windows.Forms.PictureBox();
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
            this.panel1.SuspendLayout();
            this.SearchBooksPanel.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksPictureBox)).BeginInit();
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
            this.ReadersBooksPanel.Controls.Add(this.panel1);
            this.ReadersBooksPanel.Controls.Add(this.TitleReadersBooksLbl);
            this.ReadersBooksPanel.Location = new System.Drawing.Point(12, 225);
            this.ReadersBooksPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ReadersBooksPanel.Name = "ReadersBooksPanel";
            this.ReadersBooksPanel.Size = new System.Drawing.Size(334, 520);
            this.ReadersBooksPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.accept_Book_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.publisher_lbl1);
            this.panel1.Controls.Add(this.author_lbl1);
            this.panel1.Controls.Add(this.title_lbl1);
            this.panel1.Location = new System.Drawing.Point(4, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 126);
            this.panel1.TabIndex = 7;
            // 
            // accept_Book_btn
            // 
            this.accept_Book_btn.BackColor = System.Drawing.Color.Moccasin;
            this.accept_Book_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept_Book_btn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.accept_Book_btn.Location = new System.Drawing.Point(175, 92);
            this.accept_Book_btn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.accept_Book_btn.Name = "accept_Book_btn";
            this.accept_Book_btn.Size = new System.Drawing.Size(143, 30);
            this.accept_Book_btn.TabIndex = 7;
            this.accept_Book_btn.Text = "Принять книгу";
            this.accept_Book_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(849, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "В наличии: ";
            // 
            // publisher_lbl1
            // 
            this.publisher_lbl1.AutoSize = true;
            this.publisher_lbl1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.publisher_lbl1.ForeColor = System.Drawing.Color.DimGray;
            this.publisher_lbl1.Location = new System.Drawing.Point(4, 61);
            this.publisher_lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publisher_lbl1.Name = "publisher_lbl1";
            this.publisher_lbl1.Size = new System.Drawing.Size(121, 25);
            this.publisher_lbl1.TabIndex = 3;
            this.publisher_lbl1.Text = "ЭКСМО 2013";
            // 
            // author_lbl1
            // 
            this.author_lbl1.AutoSize = true;
            this.author_lbl1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.author_lbl1.ForeColor = System.Drawing.Color.DimGray;
            this.author_lbl1.Location = new System.Drawing.Point(4, 36);
            this.author_lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.author_lbl1.Name = "author_lbl1";
            this.author_lbl1.Size = new System.Drawing.Size(167, 25);
            this.author_lbl1.TabIndex = 2;
            this.author_lbl1.Text = "Михаил Булгаков";
            // 
            // title_lbl1
            // 
            this.title_lbl1.AutoSize = true;
            this.title_lbl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_lbl1.Location = new System.Drawing.Point(4, 8);
            this.title_lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_lbl1.Name = "title_lbl1";
            this.title_lbl1.Size = new System.Drawing.Size(215, 28);
            this.title_lbl1.TabIndex = 1;
            this.title_lbl1.Text = "Мастер и Маргарита";
            // 
            // TitleReadersBooksLbl
            // 
            this.TitleReadersBooksLbl.AutoSize = true;
            this.TitleReadersBooksLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleReadersBooksLbl.Location = new System.Drawing.Point(76, 0);
            this.TitleReadersBooksLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TitleReadersBooksLbl.Name = "TitleReadersBooksLbl";
            this.TitleReadersBooksLbl.Size = new System.Drawing.Size(167, 28);
            this.TitleReadersBooksLbl.TabIndex = 0;
            this.TitleReadersBooksLbl.Text = "Книги \"на руках\"";
            // 
            // SearchBooksPanel
            // 
            this.SearchBooksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBooksPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.SearchBooksPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBooksPanel.Controls.Add(this.panel);
            this.SearchBooksPanel.Controls.Add(this.EditBookBtn);
            this.SearchBooksPanel.Controls.Add(this.AddBookBtn);
            this.SearchBooksPanel.Controls.Add(this.dataGridView1);
            this.SearchBooksPanel.Controls.Add(this.SearchBookBtn);
            this.SearchBooksPanel.Location = new System.Drawing.Point(353, 11);
            this.SearchBooksPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SearchBooksPanel.Name = "SearchBooksPanel";
            this.SearchBooksPanel.Size = new System.Drawing.Size(1006, 731);
            this.SearchBooksPanel.TabIndex = 2;
            // 
            // panel
            // 
            this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.giveBook_btn);
            this.panel.Controls.Add(this.qty_lbl);
            this.panel.Controls.Add(this.publisher_lbl);
            this.panel.Controls.Add(this.author_lbl);
            this.panel.Controls.Add(this.title_lbl);
            this.panel.Controls.Add(this.BooksPictureBox);
            this.panel.Location = new System.Drawing.Point(3, 566);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(998, 160);
            this.panel.TabIndex = 6;
            // 
            // giveBook_btn
            // 
            this.giveBook_btn.BackColor = System.Drawing.Color.Moccasin;
            this.giveBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giveBook_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.giveBook_btn.Location = new System.Drawing.Point(822, 107);
            this.giveBook_btn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.giveBook_btn.Name = "giveBook_btn";
            this.giveBook_btn.Size = new System.Drawing.Size(166, 43);
            this.giveBook_btn.TabIndex = 7;
            this.giveBook_btn.Text = "Выдать книгу";
            this.giveBook_btn.UseVisualStyleBackColor = false;
            // 
            // qty_lbl
            // 
            this.qty_lbl.AutoSize = true;
            this.qty_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qty_lbl.Location = new System.Drawing.Point(849, 11);
            this.qty_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.qty_lbl.Name = "qty_lbl";
            this.qty_lbl.Size = new System.Drawing.Size(122, 28);
            this.qty_lbl.TabIndex = 4;
            this.qty_lbl.Text = "В наличии: ";
            // 
            // publisher_lbl
            // 
            this.publisher_lbl.AutoSize = true;
            this.publisher_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.publisher_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.publisher_lbl.Location = new System.Drawing.Point(118, 80);
            this.publisher_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.publisher_lbl.Name = "publisher_lbl";
            this.publisher_lbl.Size = new System.Drawing.Size(127, 28);
            this.publisher_lbl.TabIndex = 3;
            this.publisher_lbl.Text = "ЭКСМО 2013";
            // 
            // author_lbl
            // 
            this.author_lbl.AutoSize = true;
            this.author_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.author_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.author_lbl.Location = new System.Drawing.Point(117, 46);
            this.author_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.author_lbl.Name = "author_lbl";
            this.author_lbl.Size = new System.Drawing.Size(174, 28);
            this.author_lbl.TabIndex = 2;
            this.author_lbl.Text = "Михаил Булгаков";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_lbl.Location = new System.Drawing.Point(116, 11);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(239, 31);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Мастер и Маргарита";
            // 
            // BooksPictureBox
            // 
            this.BooksPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BooksPictureBox.Location = new System.Drawing.Point(12, 11);
            this.BooksPictureBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.BooksPictureBox.Name = "BooksPictureBox";
            this.BooksPictureBox.Size = new System.Drawing.Size(94, 128);
            this.BooksPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BooksPictureBox.TabIndex = 0;
            this.BooksPictureBox.TabStop = false;
            // 
            // EditBookBtn
            // 
            this.EditBookBtn.BackColor = System.Drawing.Color.Moccasin;
            this.EditBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBookBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditBookBtn.Location = new System.Drawing.Point(731, 3);
            this.EditBookBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.Size = new System.Drawing.Size(270, 44);
            this.EditBookBtn.TabIndex = 5;
            this.EditBookBtn.Text = "Редактировать книгу";
            this.EditBookBtn.UseVisualStyleBackColor = false;
            this.EditBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.BackColor = System.Drawing.Color.Moccasin;
            this.AddBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBookBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBookBtn.Location = new System.Drawing.Point(502, 3);
            this.AddBookBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(224, 44);
            this.AddBookBtn.TabIndex = 4;
            this.AddBookBtn.Text = "Добавить книгу";
            this.AddBookBtn.UseVisualStyleBackColor = false;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 513);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // SearchBookBtn
            // 
            this.SearchBookBtn.BackColor = System.Drawing.Color.Moccasin;
            this.SearchBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBookBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchBookBtn.Location = new System.Drawing.Point(4, 3);
            this.SearchBookBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.SearchBookBtn.Name = "SearchBookBtn";
            this.SearchBookBtn.Size = new System.Drawing.Size(172, 44);
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
            this.LibraryCardPanel.Location = new System.Drawing.Point(12, 11);
            this.LibraryCardPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LibraryCardPanel.Name = "LibraryCardPanel";
            this.LibraryCardPanel.Size = new System.Drawing.Size(334, 207);
            this.LibraryCardPanel.TabIndex = 1;
            // 
            // PrintCardBtn
            // 
            this.PrintCardBtn.AccessibleDescription = "Печать читательского билета";
            this.PrintCardBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PrintCardBtn.BackgroundImage")));
            this.PrintCardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PrintCardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintCardBtn.Location = new System.Drawing.Point(76, 171);
            this.PrintCardBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PrintCardBtn.Name = "PrintCardBtn";
            this.PrintCardBtn.Size = new System.Drawing.Size(30, 31);
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
            this.EditReaderBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.EditReaderBtn.Name = "EditReaderBtn";
            this.EditReaderBtn.Size = new System.Drawing.Size(30, 31);
            this.EditReaderBtn.TabIndex = 9;
            this.EditReaderBtn.UseVisualStyleBackColor = true;
            this.EditReaderBtn.Click += new System.EventHandler(this.EditReaderBtn_Click);
            // 
            // ChangeReaderBtn
            // 
            this.ChangeReaderBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChangeReaderBtn.BackgroundImage")));
            this.ChangeReaderBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ChangeReaderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeReaderBtn.Location = new System.Drawing.Point(4, 171);
            this.ChangeReaderBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ChangeReaderBtn.Name = "ChangeReaderBtn";
            this.ChangeReaderBtn.Size = new System.Drawing.Size(30, 31);
            this.ChangeReaderBtn.TabIndex = 6;
            this.ChangeReaderBtn.UseVisualStyleBackColor = true;
            this.ChangeReaderBtn.Click += new System.EventHandler(this.ChangeReaderBtn_Click);
            // 
            // PatronymicLbl
            // 
            this.PatronymicLbl.AutoSize = true;
            this.PatronymicLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PatronymicLbl.Location = new System.Drawing.Point(148, 122);
            this.PatronymicLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PatronymicLbl.Name = "PatronymicLbl";
            this.PatronymicLbl.Size = new System.Drawing.Size(96, 28);
            this.PatronymicLbl.TabIndex = 5;
            this.PatronymicLbl.Text = "Отчество";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.Location = new System.Drawing.Point(148, 95);
            this.NameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(51, 28);
            this.NameLbl.TabIndex = 4;
            this.NameLbl.Text = "Имя";
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.AutoSize = true;
            this.SurnameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SurnameLbl.Location = new System.Drawing.Point(148, 65);
            this.SurnameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(96, 28);
            this.SurnameLbl.TabIndex = 3;
            this.SurnameLbl.Text = "Фамилия";
            // 
            // CardNumberLbl
            // 
            this.CardNumberLbl.AutoSize = true;
            this.CardNumberLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CardNumberLbl.Location = new System.Drawing.Point(148, 35);
            this.CardNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.ReadersCardLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.PhotoPictureBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
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
            this.ClientSize = new System.Drawing.Size(1372, 754);
            this.Controls.Add(this.LibraryCardPanel);
            this.Controls.Add(this.SearchBooksPanel);
            this.Controls.Add(this.ReadersBooksPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "LibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LibraryForm_FormClosed);
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.ReadersBooksPanel.ResumeLayout(false);
            this.ReadersBooksPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.SearchBooksPanel.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksPictureBox)).EndInit();
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
        private Button EditBookBtn;
        private Button AddBookBtn;
        private Panel panel;
        private PictureBox BooksPictureBox;
        private Label title_lbl;
        private Label author_lbl;
        private Label publisher_lbl;
        private Button giveBook_btn;
        private Label qty_lbl;
        private Panel panel1;
        private Button accept_Book_btn;
        private Label label1;
        private Label publisher_lbl1;
        private Label author_lbl1;
        private Label title_lbl1;
    }
}