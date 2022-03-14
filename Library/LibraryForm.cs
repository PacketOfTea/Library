namespace Library
{
    public partial class Library : Form
    {
        public Library()
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
            Reader reader_form = new Reader();
            reader_form.Owner = this;
            reader_form.ShowDialog();
        }
    }
}