using System.Data;
using System.Data.SqlClient;

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
    }
}
