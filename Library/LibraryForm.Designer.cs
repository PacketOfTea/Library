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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibraryForm));
            this.ReadersBooksPanel = new System.Windows.Forms.Panel();
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
            this.HeadPanel = new System.Windows.Forms.Panel();
            this.ReadersCardLbl = new System.Windows.Forms.Label();
            this.PrintCardBtn = new System.Windows.Forms.Button();
            this.EditReaderBtn = new System.Windows.Forms.Button();
            this.ChangeReaderBtn = new System.Windows.Forms.Button();
            this.PatronymicLbl = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.CardNumberLbl = new System.Windows.Forms.Label();
            this.PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ReadersBooksPanel.SuspendLayout();
            this.SearchBooksPanel.SuspendLayout();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LibraryCardPanel.SuspendLayout();
            this.HeadPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PhotoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ReadersBooksPanel
            // 
            this.ReadersBooksPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ReadersBooksPanel.AutoScroll = true;
            this.ReadersBooksPanel.BackColor = System.Drawing.Color.White;
            this.ReadersBooksPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ReadersBooksPanel.Controls.Add(this.TitleReadersBooksLbl);
            this.ReadersBooksPanel.Location = new System.Drawing.Point(12, 225);
            this.ReadersBooksPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.ReadersBooksPanel.Name = "ReadersBooksPanel";
            this.ReadersBooksPanel.Size = new System.Drawing.Size(334, 517);
            this.ReadersBooksPanel.TabIndex = 1;
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
            this.SearchBooksPanel.BackColor = System.Drawing.Color.White;
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
            this.panel.BackColor = System.Drawing.Color.FloralWhite;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel.Controls.Add(this.giveBook_btn);
            this.panel.Controls.Add(this.qty_lbl);
            this.panel.Controls.Add(this.publisher_lbl);
            this.panel.Controls.Add(this.author_lbl);
            this.panel.Controls.Add(this.title_lbl);
            this.panel.Controls.Add(this.BooksPictureBox);
            this.panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel.Location = new System.Drawing.Point(0, 569);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1004, 160);
            this.panel.TabIndex = 6;
            // 
            // giveBook_btn
            // 
            this.giveBook_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.giveBook_btn.BackColor = System.Drawing.Color.LightSalmon;
            this.giveBook_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.giveBook_btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.giveBook_btn.Location = new System.Drawing.Point(822, 107);
            this.giveBook_btn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.giveBook_btn.Name = "giveBook_btn";
            this.giveBook_btn.Size = new System.Drawing.Size(166, 43);
            this.giveBook_btn.TabIndex = 7;
            this.giveBook_btn.Text = "Выдать книгу";
            this.giveBook_btn.UseVisualStyleBackColor = false;
            this.giveBook_btn.Click += new System.EventHandler(this.giveBook_btn_Click);
            // 
            // qty_lbl
            // 
            this.qty_lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qty_lbl.AutoSize = true;
            this.qty_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.qty_lbl.Location = new System.Drawing.Point(845, 11);
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
            this.publisher_lbl.Size = new System.Drawing.Size(301, 28);
            this.publisher_lbl.TabIndex = 3;
            this.publisher_lbl.Text = "Издательство/год публикации";
            // 
            // author_lbl
            // 
            this.author_lbl.AutoSize = true;
            this.author_lbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.author_lbl.ForeColor = System.Drawing.Color.DimGray;
            this.author_lbl.Location = new System.Drawing.Point(117, 46);
            this.author_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.author_lbl.Name = "author_lbl";
            this.author_lbl.Size = new System.Drawing.Size(69, 28);
            this.author_lbl.TabIndex = 2;
            this.author_lbl.Text = "Автор";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_lbl.Location = new System.Drawing.Point(116, 11);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(285, 31);
            this.title_lbl.TabIndex = 1;
            this.title_lbl.Text = "Название произведения";
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
            this.EditBookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBookBtn.BackColor = System.Drawing.Color.Moccasin;
            this.EditBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBookBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EditBookBtn.Location = new System.Drawing.Point(743, 3);
            this.EditBookBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.EditBookBtn.Name = "EditBookBtn";
            this.EditBookBtn.Size = new System.Drawing.Size(257, 44);
            this.EditBookBtn.TabIndex = 5;
            this.EditBookBtn.Text = "Редактировать книгу";
            this.EditBookBtn.UseVisualStyleBackColor = false;
            this.EditBookBtn.Click += new System.EventHandler(this.EditBookBtn_Click);
            // 
            // AddBookBtn
            // 
            this.AddBookBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddBookBtn.BackColor = System.Drawing.Color.Moccasin;
            this.AddBookBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBookBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddBookBtn.Location = new System.Drawing.Point(502, 3);
            this.AddBookBtn.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddBookBtn.Name = "AddBookBtn";
            this.AddBookBtn.Size = new System.Drawing.Size(233, 44);
            this.AddBookBtn.TabIndex = 4;
            this.AddBookBtn.Text = "Добавить книгу";
            this.AddBookBtn.UseVisualStyleBackColor = false;
            this.AddBookBtn.Click += new System.EventHandler(this.AddBookBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 35;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1006, 519);
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
            this.SearchBookBtn.Size = new System.Drawing.Size(167, 44);
            this.SearchBookBtn.TabIndex = 0;
            this.SearchBookBtn.Text = "Поиск книги";
            this.SearchBookBtn.UseVisualStyleBackColor = false;
            this.SearchBookBtn.Click += new System.EventHandler(this.SearchBookBtn_Click);
            // 
            // LibraryCardPanel
            // 
            this.LibraryCardPanel.BackColor = System.Drawing.Color.FloralWhite;
            this.LibraryCardPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LibraryCardPanel.Controls.Add(this.HeadPanel);
            this.LibraryCardPanel.Controls.Add(this.PrintCardBtn);
            this.LibraryCardPanel.Controls.Add(this.EditReaderBtn);
            this.LibraryCardPanel.Controls.Add(this.ChangeReaderBtn);
            this.LibraryCardPanel.Controls.Add(this.PatronymicLbl);
            this.LibraryCardPanel.Controls.Add(this.NameLbl);
            this.LibraryCardPanel.Controls.Add(this.SurnameLbl);
            this.LibraryCardPanel.Controls.Add(this.CardNumberLbl);
            this.LibraryCardPanel.Controls.Add(this.PhotoPictureBox);
            this.LibraryCardPanel.Location = new System.Drawing.Point(12, 11);
            this.LibraryCardPanel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.LibraryCardPanel.Name = "LibraryCardPanel";
            this.LibraryCardPanel.Size = new System.Drawing.Size(334, 207);
            this.LibraryCardPanel.TabIndex = 1;
            // 
            // HeadPanel
            // 
            this.HeadPanel.BackColor = System.Drawing.Color.Orange;
            this.HeadPanel.Controls.Add(this.ReadersCardLbl);
            this.HeadPanel.Location = new System.Drawing.Point(-1, -1);
            this.HeadPanel.Name = "HeadPanel";
            this.HeadPanel.Size = new System.Drawing.Size(334, 36);
            this.HeadPanel.TabIndex = 7;
            // 
            // ReadersCardLbl
            // 
            this.ReadersCardLbl.AutoSize = true;
            this.ReadersCardLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReadersCardLbl.Location = new System.Drawing.Point(52, 0);
            this.ReadersCardLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReadersCardLbl.Name = "ReadersCardLbl";
            this.ReadersCardLbl.Size = new System.Drawing.Size(233, 31);
            this.ReadersCardLbl.TabIndex = 1;
            this.ReadersCardLbl.Text = "Читательский билет";
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
            this.PatronymicLbl.Location = new System.Drawing.Point(148, 129);
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
            this.NameLbl.Location = new System.Drawing.Point(148, 102);
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
            this.SurnameLbl.Location = new System.Drawing.Point(148, 72);
            this.SurnameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(96, 28);
            this.SurnameLbl.TabIndex = 3;
            this.SurnameLbl.Text = "Фамилия";
            // 
            // CardNumberLbl
            // 
            this.CardNumberLbl.AutoSize = true;
            this.CardNumberLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CardNumberLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.CardNumberLbl.Location = new System.Drawing.Point(148, 42);
            this.CardNumberLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CardNumberLbl.Name = "CardNumberLbl";
            this.CardNumberLbl.Size = new System.Drawing.Size(133, 28);
            this.CardNumberLbl.TabIndex = 2;
            this.CardNumberLbl.Text = "00000000000";
            // 
            // PhotoPictureBox
            // 
            this.PhotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PhotoPictureBox.ImageLocation = "";
            this.PhotoPictureBox.Location = new System.Drawing.Point(10, 40);
            this.PhotoPictureBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.PhotoPictureBox.Name = "PhotoPictureBox";
            this.PhotoPictureBox.Size = new System.Drawing.Size(90, 120);
            this.PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PhotoPictureBox.TabIndex = 0;
            this.PhotoPictureBox.TabStop = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.AllowPrintToFile = false;
            this.printDialog1.UseEXDialog = true;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "LibraryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LibraryForm_FormClosed);
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            this.ReadersBooksPanel.ResumeLayout(false);
            this.ReadersBooksPanel.PerformLayout();
            this.SearchBooksPanel.ResumeLayout(false);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BooksPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.LibraryCardPanel.ResumeLayout(false);
            this.LibraryCardPanel.PerformLayout();
            this.HeadPanel.ResumeLayout(false);
            this.HeadPanel.PerformLayout();
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
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private Panel HeadPanel;
    }
}