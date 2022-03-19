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
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
            this.BackColor = Color.White;
            MainPanel.BackColor = Color.FromArgb(220, Color.White);
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            LibraryForm forma = new LibraryForm();
            forma.Show();
        }

        private SqlConnection sqlConnection;

        private void CreateCardBtn_Click(object sender, EventArgs e)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            sqlConnection = new SqlConnection($"Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = {path}\\LibraryDB.mdf; Integrated Security = True");
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.Open();
            }
            ReaderForm reader_form = new ReaderForm(false, sqlConnection);
            reader_form.Owner = this;
            reader_form.ShowDialog();
        }
    }
}
