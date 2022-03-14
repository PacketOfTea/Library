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
            Form1 forma = new Form1();
            forma.Show();
            //if(LibraryCardPanel.Visible == false)
            //    MessageBox.Show("Для поиска книг необходимо ввести номер читательского билета!");
        }

        private void PrintCardBtn_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }
    }
}