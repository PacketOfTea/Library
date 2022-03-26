using Library;
using System.Data;
using System.Data.SqlClient;


namespace LibraryForm
{
	public partial class LibraryForm : Form
	{
		private SqlConnection sqlConnection;
		private FirstForm? login;
		private Reader CurrentReader;
		public Book SelectedBook = new Book();
		Bitmap b;

		public LibraryForm(Reader reader)
		{
			InitializeComponent();
#pragma warning disable CS8602 // ������������� ��������� ������ ������.
			string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
#pragma warning restore CS8602 // ������������� ��������� ������ ������.
			sqlConnection = new SqlConnection($"Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = {path}\\LibraryDB.mdf; Integrated Security = True");
			if (sqlConnection.State != ConnectionState.Open)
			{
				sqlConnection.Open();
			}
			CurrentReader = reader;
			//HeadPanel.BackColor = ColorTranslator.FromHtml("#6b7fc8");
			//LibraryCardPanel.BackColor = ColorTranslator.FromHtml("#cbcfda");
		}

		private void LibraryForm_Load(object sender, EventArgs e)
		{
			showReader();
			showDB_BOOKS(fillDatatableBooks());
#pragma warning disable CS8601 // ��������, ����������-������, ����������� �������� NULL.
			login = this.Owner as FirstForm;
#pragma warning restore CS8601 // ��������, ����������-������, ����������� �������� NULL.
			showPinnedBook();
		}

		SearchForm search_form;
		private void SearchBookBtn_Click(object sender, EventArgs e)
		{
			if (search_form == null || search_form.IsDisposed)
			{
				search_form = new SearchForm(sqlConnection);
				search_form.Owner = this;
				search_form.Show();
			}
			else
			{
				search_form.WindowState = FormWindowState.Normal;
			}
		}
		private void PrintCardBtn_Click(object sender, EventArgs e)
		{
			ChangeReaderBtn.Visible = false;
			EditReaderBtn.Visible = false;
			PrintCardBtn.Visible = false;
			b = new Bitmap(LibraryCardPanel.ClientRectangle.Width, LibraryCardPanel.ClientRectangle.Height);
			LibraryCardPanel.DrawToBitmap(b, LibraryCardPanel.ClientRectangle);
			ChangeReaderBtn.Visible = true;
			EditReaderBtn.Visible = true;
			PrintCardBtn.Visible = true;
			printDialog1.Document = printDocument1;
			if (printDialog1.ShowDialog() == DialogResult.OK)
			{
				printDocument1.Print();
			}
		}

		ReaderForm? reader_form;
		private void EditReaderBtn_Click(object sender, EventArgs e)
		{
			reader_form = new ReaderForm(true, CurrentReader, sqlConnection);
			reader_form.Owner = this;
			reader_form.ShowDialog();
		}

		private void ChangeReaderBtn_Click(object sender, EventArgs e)
		{
			this.Close();
#pragma warning disable CS8602 // ������������� ��������� ������ ������.
			login.ChangeTextCardNumber("");
#pragma warning restore CS8602 // ������������� ��������� ������ ������.
			login.Show();
		}

		public void UpdateReader(Reader reader)
		{
			CurrentReader = reader;
			showReader();
		}

		public void showDB_BOOKS(DataTable datatable)
		{
			dataGridView1.DataSource = datatable;
			dataGridView1.Columns[0].Width = 62;
			dataGridView1.Columns[1].Width = 358;
			dataGridView1.Columns[2].Width = 216;
			dataGridView1.Columns[3].Width = 95;
			dataGridView1.Columns[4].Width = 150;
			dataGridView1.Columns[5].Visible = false;
			dataGridView1.Columns[6].Width = 100;
			dataGridView1.ClearSelection();
		}

		public DataTable fillDatatableBooks()
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT id, [�������� �����], [����� �����], [���� �������], " +
				"[������������], [�������], [�������] FROM �����", sqlConnection);
			DataSet dataset = new DataSet();
			dataAdapter.Fill(dataset);
			return dataset.Tables[0];
		}

		public void showReader()
		{
			CardNumberLbl.Text = CurrentReader.Library_card_number;
			SurnameLbl.Text = CurrentReader.Surname;
			NameLbl.Text = CurrentReader.Name;
			PatronymicLbl.Text = CurrentReader.Patronymic;
			try { PhotoPictureBox.Image = CurrentReader.Photo; } catch (Exception) { }
		}

		BookForm? bookform;
		private void AddBookBtn_Click(object sender, EventArgs e)
		{
			bookform = new BookForm(false, sqlConnection);
			bookform.Owner = this;
			bookform.ShowDialog();
		}

		private void EditBookBtn_Click(object sender, EventArgs e)
		{
			if (SelectedBook.id != 0)
			{
				bookform = new BookForm(true, SelectedBook, sqlConnection);
				bookform.Owner = this;
				bookform.ShowDialog();
			}
			else
			{
				MessageBox.Show("�������� ����� ��� ��������������");
			}
		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
#pragma warning disable CS8601 // ��������, ����������-������, ����������� �������� NULL.
			try
			{
				SelectedBook.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
				SelectedBook.Title = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
				SelectedBook.Author = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
				SelectedBook.PublicDate = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
				SelectedBook.Publisher = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

				try
				{
					byte[] imgData = (byte[])dataGridView1.SelectedRows[0].Cells[5].Value;
					MemoryStream ms = new MemoryStream(imgData);
					SelectedBook.PhotoPictureBox = Image.FromStream(ms);
				}
				catch (Exception ex) { MessageBox.Show(ex.ToString()); }

				SelectedBook.NumberOfBooks = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

				title_lbl.Text = SelectedBook.Title;
				author_lbl.Text = SelectedBook.Author;
				publisher_lbl.Text = SelectedBook.Publisher + " " + SelectedBook.PublicDate;
				qty_lbl.Text = "� �������: " + SelectedBook.NumberOfBooks;
				BooksPictureBox.Image = SelectedBook.PhotoPictureBox;

				periodLbl.Visible = false;
				takeBook_btn.Visible = false;
				giveBook_btn.Visible = true;
				qty_lbl.Visible = true;

			}
			catch (Exception) {	}
#pragma warning restore CS8601 // ��������, ����������-������, ����������� �������� NULL.
		}

		private void LibraryForm_FormClosed(object sender, FormClosedEventArgs e)
		{
#pragma warning disable CS8602 // ������������� ��������� ������ ������.
			login.Show();
#pragma warning restore CS8602 // ������������� ��������� ������ ������.
		}

		public void panel_MouseMove(Panel panel)
		{ 
			panel.BackColor = Color.Moccasin;
		}

		public void panel_MouseLeave(Panel panel)
		{
			panel.BackColor = Color.White;
		}

		PinnedBook takedBook;
		BookPanel panelTakedBook;
		private void giveBook_btn_Click(object sender, EventArgs e)
		{
			SqlCommand sqlCommand;
			takedBook = new PinnedBook(SelectedBook);
			takedBook.DateOfIssue = DateTime.Today;
			takedBook.DateIssuedBefore = DateTime.Today.AddDays(14);
			takedBook.DateReturn = null;

			if (Convert.ToInt32(takedBook.NumberOfBooks) > 0)
			{
				takedBook.NumberOfBooks = (Convert.ToInt32(takedBook.NumberOfBooks) - 1).ToString();
				qty_lbl.Text = "� �������: " + takedBook.NumberOfBooks;
				sqlCommand = new SqlCommand($"Update [�����] set [�������] = @������� Where Id={takedBook.id}", sqlConnection);
				sqladd_BOOK(sqlCommand);

				sqlCommand = new SqlCommand($"Insert INTO [�������� �����] ([��������], [�����], [���� ������], " +
								"[������ ��], [���� ��������]) " +
								"VALUES (@��������, @�����, @����_������, @������_��, @����_��������)", sqlConnection);
				sqladd_PinnedBook(sqlCommand, "����� ������");

				panelTakedBook = new BookPanel(ReadersBooksPanel, ReadersBooksPanel.Controls.Count, takedBook, this);

				showDB_BOOKS(fillDatatableBooks());
				resetPanelCurrentBook();
			}
			else
			{
				MessageBox.Show("��������� ����� ��� � �������");
			}
		}

		private void resetPanelCurrentBook()
        {
			BooksPictureBox.Image = Library.Properties.Resources.NoPicture;
			title_lbl.Text = "�������� ������������";
			author_lbl.Text = "�����";
			publisher_lbl.Text = "������������/��� ����������";
			periodLbl.Visible = false;
			takeBook_btn.Visible = false;
			giveBook_btn.Visible = false;
			qty_lbl.Visible = false;
		}

		private void takeBook_btn_Click(object sender, EventArgs e)
		{
			takedBook.DateReturn = DateTime.Today;
			SqlCommand sqlCommand = new SqlCommand("Update [�������� �����] set [��������] = @��������, " +
				"[�����] = @�����, [���� ������] = @����_������, [������ ��] = @������_��, " +
				$"[���� ��������] = @����_�������� Where �������� = {CurrentReader.id} and ����� = {takedBook.id}",
				sqlConnection);
			sqladd_PinnedBook(sqlCommand, "����� ������� �������");
			ReadersBooksPanel.Controls.Clear();
			showPinnedBook();

			takedBook.NumberOfBooks = (Convert.ToInt32(takedBook.NumberOfBooks) + 1).ToString();
			sqlCommand = new SqlCommand($"Update [�����] set [�������] = @������� Where Id={takedBook.id}",
				sqlConnection);
			sqladd_BOOK(sqlCommand);

			showDB_BOOKS(fillDatatableBooks());
		}

		private void showPinnedBook()
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT id, [��������], [�����], [���� ������], " +
				$"[������ ��], [���� ��������] FROM [�������� �����] WHERE [��������] = {CurrentReader.id}" +
				$" and [���� ��������] IS NULL", sqlConnection);
			DataSet dataset = new DataSet();
			dataAdapter.Fill(dataset);
			DataTable dt1 = dataset.Tables[0];

			if (dt1.Rows.Count > 0)
			{
				string books = dt1.Rows[0][2].ToString();

				for (int i = 1; i < dt1.Rows.Count; i++)
				{
					books += "," + dt1.Rows[i][2].ToString();
				}

				SqlDataAdapter dataAdapter1 = new SqlDataAdapter("SELECT id, [�������� �����], [����� �����], [���� �������], " +
					$"[������������], [�������] FROM ����� WHERE id IN ({books})", sqlConnection);
				DataSet dataset1 = new DataSet();
				dataAdapter1.Fill(dataset1);
				DataTable dtBook = dataset1.Tables[0];

				for (int i = 0; i < dtBook.Rows.Count; i++)
				{
					PinnedBook takedBook = new PinnedBook(new Book());
					takedBook.id = Convert.ToInt32(dtBook.Rows[i][0]);
					takedBook.Title = dtBook.Rows[i][1].ToString();
					takedBook.Author = dtBook.Rows[i][2].ToString();
					takedBook.PublicDate = dtBook.Rows[i][3].ToString();
					takedBook.Publisher = dtBook.Rows[i][4].ToString();

					try
					{
						byte[] imgData = (byte[])dtBook.Rows[i][5];
						MemoryStream ms = new MemoryStream(imgData);
						takedBook.PhotoPictureBox = Image.FromStream(ms);
					}
					catch (Exception ex) { MessageBox.Show(ex.ToString()); }

					takedBook.DateOfIssue = Convert.ToDateTime(dt1.Rows[i][3]);
					takedBook.DateIssuedBefore = Convert.ToDateTime(dt1.Rows[i][4]);
					takedBook.DateReturn = null;

					panelTakedBook = new BookPanel(ReadersBooksPanel, ReadersBooksPanel.Controls.Count, takedBook, this);
				}
			}
		}

		public void sqladd_BOOK(SqlCommand command)
		{
			try
			{
				command.Parameters.AddWithValue("�������", takedBook.NumberOfBooks);

				if (command.ExecuteNonQuery() == 1)
				{
					//MessageBox.Show(message);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		public void sqladd_PinnedBook(SqlCommand command, string message)
		{
			try
			{
				command.Parameters.AddWithValue("��������", CurrentReader.id);
				command.Parameters.AddWithValue("�����", takedBook.id);
				command.Parameters.AddWithValue("����_������", takedBook.DateOfIssue);
				command.Parameters.AddWithValue("������_��", takedBook.DateIssuedBefore);
				if (takedBook.DateReturn == null)
				{
					command.Parameters.AddWithValue("����_��������", DBNull.Value);
				}
				else
				{
					command.Parameters.AddWithValue("����_��������", takedBook.DateReturn);
				}

				if (command.ExecuteNonQuery() == 1)
				{
					MessageBox.Show(message);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
		{
			e.Graphics.DrawImageUnscaled(b, 0, 0);
			e.Graphics.PageUnit = GraphicsUnit.Inch;
		}

		private void LibraryForm_MaximumSizeChanged(object sender, EventArgs e)
		{
			dataGridView1.Columns[0].Width = 62;
			dataGridView1.Columns[1].Width = 358;
			dataGridView1.Columns[2].Width = 216;
			dataGridView1.Columns[3].Width = 95;
			dataGridView1.Columns[4].Width = 150;
			dataGridView1.Columns[6].Width = 100;
		}

		private void LibraryForm_SizeChanged(object sender, EventArgs e)
		{
			dataGridView1.Width = SearchBooksPanel.Width;
			dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView1.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
		}
		
		public void ChangePanelBook(PinnedBook currentBook)
		{
			periodLbl.Visible = true;
			takeBook_btn.Visible = true;
			giveBook_btn.Visible = false;
			qty_lbl.Visible = false;

			takedBook = currentBook;

			title_lbl.Text = currentBook.Title;
			author_lbl.Text = currentBook.Author;
			publisher_lbl.Text = currentBook.Publisher;
			BooksPictureBox.Image = currentBook.PhotoPictureBox;
			periodLbl.Text = "���� ������: " + currentBook.DateOfIssue.Value.ToShortDateString() 
				+ "\n������� ��:   " + currentBook.DateIssuedBefore.Value.ToShortDateString();
		}

	}
}
