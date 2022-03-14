namespace LibraryForm
{
    public partial class LibraryForm : Form
    {
        public LibraryForm()
        {
            InitializeComponent();
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
    }
}