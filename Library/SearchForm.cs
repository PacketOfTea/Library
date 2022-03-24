using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LibraryForm
{
    public partial class SearchForm : Form
    {
        LibraryForm main;
        private SqlConnection sqlConnection;
        private DataTable datatable;
        public SearchForm(SqlConnection connect)
        {
            InitializeComponent();
            sqlConnection = connect;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            main = this.Owner as LibraryForm;
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            datatable = main.fillDatatableBooks();
            this.Location = new System.Drawing.Point(main.Location.X + 6, main.Location.Y + 47);
        }

        private void AuthorTxtBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter($"SELECT id, [Название книги], [Автор книги], [Дата издания], " +
                    $"[Издательство], [Обложка], [Наличие] FROM Книги " +
                    $"WHERE[Название книги] LIKE N'%{NameTxtBox.Text}%' and [Автор книги] LIKE N'%{AuthorTxtBox.Text}%' " +
                    $"and [Дата издания] LIKE N'%{PublicDateTxtBox.Text}%' and [Издательство] LIKE N'%{PublisherTxtBox.Text}%'", sqlConnection);
                DataSet dataset = new DataSet();
                dataAdapter.Fill(dataset);
                main.showDB_BOOKS(dataset.Tables[0]);
            }
            catch (Exception)
            {
            }
        }
        public void Check_Is_Digit(object sender, KeyPressEventArgs e)
        {
            if (!Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]|[a-zA-Z]").Success && e.KeyChar != 8 && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
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
