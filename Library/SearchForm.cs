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

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            if (AuthorСmbBox.Text == "" && NameCmbBox.Text == "" && PublicDateCmbBox.Text == "" && PublisherCmbBox.Text == "")
                MessageBox.Show("Вы не ввели ни одного условия для поиска!");
            else
            {
                for(int row = 0; row < datatable.Rows.Count; row++)
                {
                    int[] check_for_search = { 0, 0, 0, 0 };

                    // Обозначения:
                    // 0 - текстовое поле не заполнено
                    // 1 - текстовое поле заполнено и совпадений нет (или еще не найдено)
                    // 2 - текстовое поле заполнено и найдено совпадение 
                    if (AuthorСmbBox.Text != "")
                    {
                        check_for_search[0] = 1;
                        if (datatable.Rows[row][2] == AuthorСmbBox.Text)
                            check_for_search[0] = 2;
                    }
                    if (NameCmbBox.Text != "")
                    {
                        check_for_search[1] = 1;
                        if (datatable.Rows[row][1] == NameCmbBox.Text)
                            check_for_search[1] = 2;
                    }
                    if (PublicDateCmbBox.Text != "")
                    {
                        check_for_search[2] = 1;
                        if (datatable.Rows[row][3] == PublicDateCmbBox.Text)
                            check_for_search[2] = 2;
                    }
                    if (PublisherCmbBox.Text != "")
                    {
                        check_for_search[3] = 1;
                        if (datatable.Rows[row][4] == PublisherCmbBox.Text)
                            check_for_search[3] = 2;
                    }

                }

                //foreach (var day in dates)
                //    for (int i = 0; i < day.Count(); ++i)
                //    {
                //        int[] check_for_search = { 0, 0, 0, 0, 0 };

                //        // Обозначения:
                //        // 0 - текстовое поле не заполнено
                //        // 1 - текстовое поле заполнено и совпадений нет (или еще не найдено)
                //        // 2 - текстовое поле заполнено и найдено совпадение 

                        
                //        int flag = 0;
                //        for (int j = 0; j < 5; j++)
                //        {
                //            if (check_for_search[j] == 1)
                //            {
                //                flag = 1;
                //                break;
                //            }
                //            if (check_for_search[j] == 2)
                //                flag = 2;
                //        }
                //        if (flag == 2)
                //            meet_panel = new MeetingPanel(organizerPanel, day[i], organizerPanel.Controls.Count - 1);
                //    }
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            main = this.Owner as LibraryForm;
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
            datatable = main.fillDatatableBooks() ;
        }
    }
}
