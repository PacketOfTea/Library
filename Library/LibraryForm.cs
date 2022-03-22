using System.Data;
using System.Data.SqlClient;


namespace LibraryForm
{
    public partial class LibraryForm : Form
    {
        private SqlConnection sqlConnection;
        private FirstForm? login;
        private Reader CurrentReader;
        public Book SelectedBook;

        public LibraryForm(Reader reader)
        {
            InitializeComponent();
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
            sqlConnection = new SqlConnection($"Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = {path}\\LibraryDB.mdf; Integrated Security = True");
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            CurrentReader = reader;
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            showReader();
            showDB_BOOKS(fillDatatableBooks());
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            login = this.Owner as FirstForm;
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
        }

        private void SearchBookBtn_Click(object sender, EventArgs e)
        {
            SearchForm search_form = new SearchForm(sqlConnection);
            search_form.Owner = this;
            search_form.Show();
        }

        private void PrintCardBtn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
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
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            login.ChangeTextCardNumber("");
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
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
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 358;
            dataGridView1.Columns[2].Width = 216;
            dataGridView1.Columns[3].Width = 104;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Visible = false;
            dataGridView1.Columns[6].Width = 103;
            dataGridView1.ClearSelection();
        }

        public DataTable fillDatatableBooks()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT id, [Название книги], [Автор книги], [Дата издания], " +
                "[Издательство], [Обложка], [Наличие] FROM Книги", sqlConnection);

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
            try
            {
                PhotoPictureBox.Image = CurrentReader.Photo;
            }
            catch (Exception)
            {

            }           
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
                MessageBox.Show("Выберите книгу для редактирования");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            try
            {
                SelectedBook.id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                SelectedBook.Title = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                SelectedBook.Author = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                SelectedBook.PublicDate = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                SelectedBook.Publisher = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                SelectedBook.PhotoPictureBox = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                SelectedBook.NumberOfBooks = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                title_lbl.Text = SelectedBook.Title;
                author_lbl.Text = SelectedBook.Author;
                publisher_lbl.Text = SelectedBook.Publisher + " " + SelectedBook.PublicDate;
                qty_lbl.Text = "В наличии: " + SelectedBook.NumberOfBooks;
                BooksPictureBox.Load(SelectedBook.PhotoPictureBox);
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
        }

        private void LibraryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
            login.Show();
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
        }
    }
}