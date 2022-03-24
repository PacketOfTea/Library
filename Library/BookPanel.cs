namespace LibraryForm
{
	public class BookPanel
	{
		public PinnedBook takedBook;

		public Panel panel = new Panel();
		public Label title_lbl = new Label();
		public Label author_lbl = new Label();
		public Label period = new Label();

		public LibraryForm library;

		public BookPanel() { }
		public BookPanel(Panel ReadersBooksPanel, int k, PinnedBook currentBook, LibraryForm library_form)
		{
			library = library_form;
			takedBook = currentBook;
			// 
			// panel
			// 
			this.panel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
			| System.Windows.Forms.AnchorStyles.Right)));
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel.Controls.Add(this.period);
			this.panel.Controls.Add(this.author_lbl);
			this.panel.Controls.Add(this.title_lbl);
			this.panel.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panel.Location = new System.Drawing.Point(4, k * 109);
			this.panel.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(294, 105);
			this.panel.TabIndex = 8;
			this.panel.BackColor = Color.White;
			this.panel.Dock = DockStyle.Top;
			// 
			// period
			// 
			this.period.AutoSize = true;
			this.period.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.period.ForeColor = System.Drawing.Color.DimGray;
			this.period.Location = new System.Drawing.Point(4, 61);
			this.period.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.period.Name = "period";
			this.period.Size = new System.Drawing.Size(217, 25);
			this.period.TabIndex = 3;
			this.period.Text = $"Вернуть до: {takedBook.DateIssuedBefore.Value.ToShortDateString()}";
			// 
			// author_lbl
			// 
			this.author_lbl.AutoSize = true;
			this.author_lbl.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.author_lbl.ForeColor = System.Drawing.Color.DimGray;
			this.author_lbl.Location = new System.Drawing.Point(4, 36);
			this.author_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.author_lbl.Name = "author_lbl";
			this.author_lbl.Size = new System.Drawing.Size(189, 25);
			this.author_lbl.TabIndex = 2;
			this.author_lbl.Text = takedBook.Author;
			// 
			// title_lbl
			// 
			this.title_lbl.AutoSize = true;
			this.title_lbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.title_lbl.Location = new System.Drawing.Point(4, 8);
			this.title_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.title_lbl.Name = "title_lbl";
			this.title_lbl.Size = new System.Drawing.Size(278, 28);
			this.title_lbl.TabIndex = 1;
			this.title_lbl.Text = takedBook.Title;
			
			title_lbl.Click += new System.EventHandler(panel_Click);
			title_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(panel_MouseMove);
			title_lbl.MouseLeave += new System.EventHandler(panel_MouseLeave);

			author_lbl.Click += new System.EventHandler(panel_Click);
			author_lbl.MouseMove += new System.Windows.Forms.MouseEventHandler(panel_MouseMove);
			author_lbl.MouseLeave += new System.EventHandler(panel_MouseLeave);

			period.Click += new System.EventHandler(panel_Click);
			period.MouseMove += new System.Windows.Forms.MouseEventHandler(panel_MouseMove);
			period.MouseLeave += new System.EventHandler(panel_MouseLeave);


			panel.Click += new System.EventHandler(panel_Click);
			panel.MouseMove += new System.Windows.Forms.MouseEventHandler(panel_MouseMove);
			panel.MouseLeave += new System.EventHandler(panel_MouseLeave);


			ReadersBooksPanel.Controls.Add(panel);
		}
		private void panel_Click(object sender, EventArgs e)
        {
			library.ChangePanelBook(takedBook);
		}
		private void panel_MouseMove(object sender, MouseEventArgs e)
		{
			library.panel_MouseMove(panel);
		}
		private void panel_MouseLeave(object sender, EventArgs e)
		{
			library.panel_MouseLeave(panel);
		}
	}
}