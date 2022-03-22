using System.Data.SqlClient;

namespace LibraryForm
{
	public partial class BookForm : Form
	{
		LibraryForm main;
		private SqlConnection sqlConnection;
		bool ModeEdit = false;
		Book CurrentBook;

		public BookForm(bool mode, SqlConnection connect)
		{
			InitializeComponent();
			sqlConnection = connect;
			ModeEdit = mode;        
			DeleteBtn.Visible = false;
			SaveBtn.Location = new Point(421, 239);
		}

		public BookForm(bool mode, Book book, SqlConnection connect)
		{
			InitializeComponent();
			sqlConnection = connect;
			CurrentBook = book;
			ModeEdit = mode;
			this.Text = "Редактирование книги";      
		}

		private void BookForm_Load(object sender, EventArgs e)
		{
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
			main = this.Owner as LibraryForm;
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
			fillData(CurrentBook);
		}

		public void sqladd(SqlCommand command, string message)
		{
			try
			{
				command.Parameters.AddWithValue("Название_книги", TittleTxtBox.Text);
				command.Parameters.AddWithValue("Автор_книги", AuthorTxtBox.Text);
				command.Parameters.AddWithValue("Дата_издания", PublicDateTxtBox.Text);
				command.Parameters.AddWithValue("Издательство", PublisherTxtBox.Text);
				command.Parameters.AddWithValue("Обложка", PhotoPictureBox.ToString());
				command.Parameters.AddWithValue("Наличие", NumberOfBooksTxtBox.Text);

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

		public void fillData(Book SelectedBook)
		{
			if (ModeEdit)
			{
				CurrentBook = SelectedBook;
			}
			else
			{
				CurrentBook.clear();
			}
			TittleTxtBox.Text = CurrentBook.Title;
			AuthorTxtBox.Text = CurrentBook.Author;
			PublicDateTxtBox.Text = CurrentBook.PublicDate;
			PublisherTxtBox.Text = CurrentBook.Publisher;
            try
            {
				PhotoPictureBox.Load(CurrentBook.PhotoPictureBox);
			}
            catch (Exception)
            {

            }		
			NumberOfBooksTxtBox.Text = CurrentBook.NumberOfBooks;
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (TittleTxtBox.Text == "" || AuthorTxtBox.Text == "" || PublicDateTxtBox.Text == "" || PublisherTxtBox.Text == "" || NumberOfBooksTxtBox.Text == "")
			{
				MessageBox.Show("Заполните все данные");
			}
			else
			{
				SqlCommand sqlCommand;
				switch (ModeEdit)
				{
					case false:
						sqlCommand = new SqlCommand($"Insert INTO [Книги] ([Название книги], [Автор книги], [Дата издания], " +
							"[Издательство], [Обложка], [Наличие]) " +
							"VALUES (@Название_книги, @Автор_книги, @Дата_издания, @Издательство, @Обложка, @Наличие)"
										, sqlConnection);
						sqladd(sqlCommand, "Книга добавлена в БД");
						break;
					case true:
						sqlCommand = new SqlCommand($"Update [Книги] set [Название книги] = @Название_книги, [Автор книги] = @Автор_книги, [Дата издания] = @Дата_издания, [Издательство] = @Издательство, [Обложка] = @Обложка, [Наличие] = @Наличие " +
								$"Where Id={CurrentBook.id}", sqlConnection);
						sqladd(sqlCommand, "Книга изменена в БД");
						break;
				}
				main.showDB_BOOKS();
#pragma warning disable CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
                main.SelectedBook.clear();
#pragma warning restore CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
                this.Close();
			}
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommand sqlCommand = new SqlCommand($"Delete [Книги] Where Id={CurrentBook.id}", sqlConnection);
				if (sqlCommand.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Книга удалена из БД");
				}
				sqlCommand.Parameters.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			main.showDB_BOOKS();
#pragma warning disable CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
            main.SelectedBook.clear();
#pragma warning restore CS1690 // Доступ к члену в поле класса маршалинга по ссылке может вызвать исключение времени выполнения
            this.Close();
		}

		private void NumberOfBooksTxtBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
		}
	}
}
