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
            sqlConnection = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\User\\OneDrive - ����� �� �����\\������� ����\\������\\3 ����\\6 �������\\�������������� ��������-��������� ����������\\Library\\Library\\LibraryDB.mdf; Integrated Security = True");
            sqlConnection.Open();
        }
        


        private void SearchBookBtn_Click(object sender, EventArgs e)
        {
            FirstForm forma = new FirstForm();
            forma.Show();
            //if(LibraryCardPanel.Visible == false)
            //    MessageBox.Show("��� ������ ���� ���������� ������ ����� ������������� ������!");
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
            SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT id, [�������� �����], [����� �����], [���� �������], " +
                "[������������], [�������], [�������] FROM �����", sqlConnection);

            DataSet dataset = new DataSet();
            dataAdapter.Fill(dataset);
            dataGridView1.DataSource = dataset.Tables[0];
            //dataGridView1.Columns[0].Width = 23;
            //dataGridView1.Columns[1].Width = 100;
            //dataGridView1.Columns[2].Width = 100;
            //dataGridView1.Columns[3].Width = 107;
            //dataGridView1.Columns[4].Width = 73;
            //dataGridView1.Columns[5].Width = 130;
            //dataGridView1.Columns[6].Width = 250;
            //dataGridView1.Columns[7].Width = 90;
            //dataGridView1.Columns[8].Width = 70;
            //dataGridView1.Columns[9].Width = 171;
            //dataGridView1.Columns[10].Width = 91;
            //dataGridView1.Columns[11].Width = 463;
            //dataGridView1.Columns[12].Width = 228;
        }

        public void sqladd(SqlCommand command, string message)
        {
            try
            {
                command.Parameters.AddWithValue("��������_�����", textBox1.Text);
                command.Parameters.AddWithValue("�����_�����", textBox2.Text);
                command.Parameters.AddWithValue("����_�������", textBox3.Text);
                command.Parameters.AddWithValue("������������", textBox4.Text);
                command.Parameters.AddWithValue("�������", textBox5.Text);
                command.Parameters.AddWithValue("�������", textBox6.Text);

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


        private void button1_Click(object sender, EventArgs e)
        {
            showDB_BOOKS();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand($"Insert INTO [�����] ([�������� �����], [����� �����], [���� �������], " +
                "[������������], [�������], [�������]) " +
                "VALUES (@��������_�����, @�����_�����, @����_�������, @������������, @�������, @�������)", sqlConnection);
            sqladd(sqlCommand, "����� ��������� � ��");
            showDB_BOOKS();
        }
    }
}