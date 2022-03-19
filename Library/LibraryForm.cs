using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace LibraryForm
{
    public partial class LibraryForm : Form
    {
        private SqlConnection sqlConnection;

        public LibraryForm()
        {
            InitializeComponent();
            sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Data\\Projects\\6 Семестр\\Library\\Library\\LibraryDB.mdf; Integrated Security = True");
            sqlConnection.Open();
        }
        

        private void SearchBookBtn_Click(object sender, EventArgs e)
        {
            FirstForm forma = new FirstForm();
            forma.Show();
            //if(LibraryCardPanel.Visible == false)
            //    MessageBox.Show("Для поиска книг необходимо ввести номер читательского билета!");
        }

        private void PrintCardBtn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void EditReaderBtn_Click(object sender, EventArgs e)
        {

        }

        private void ChangeReaderBtn_Click(object sender, EventArgs e)
        {
            ReaderForm reader_form = new ReaderForm();
            reader_form.Owner = this;
            reader_form.ShowDialog();
        }

        public void showDB_BOOKS()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT id, [Название книги], [Автор книги], [Дата издания], " +
                "[Издательство], [Обложка], [Наличие] FROM Книги", sqlConnection);

            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 290;
            dataGridView1.Columns[2].Width = 188;
            dataGridView1.Columns[3].Width = 75;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 87;
            dataGridView1.Columns[6].Width = 93;
            dataGridView1.ClearSelection();
        }

        BookForm bookform;
        public Book SelectedBook;
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
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
        }

        private void LibraryForm_Load(object sender, EventArgs e)
        {
            showDB_BOOKS();        
        }
    }
}