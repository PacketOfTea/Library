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


		private SqlConnection sqlConnection;

		private void FirstForm_Load(object sender, EventArgs e)
		{
			string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
			sqlConnection = new SqlConnection($"Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = {path}\\LibraryDB.mdf; Integrated Security = True");
			if (sqlConnection.State != ConnectionState.Open)
			{
				sqlConnection.Open();
			}
		}

		public Reader SelectedReader;

		private void LoginBtn_Click(object sender, EventArgs e)
		{
			SqlDataAdapter dataAdapter = new SqlDataAdapter("Select id, Фамилия, Имя, Отчество, [Номер читательского билета], " +
				"Адрес, [Номер телефона], Фото " +
				$"FROM [Читатели] WHERE [Номер читательского билета] = '{ReaderCardTxtBox.Text}'", sqlConnection);
			DataSet dataset = new DataSet();
			dataAdapter.Fill(dataset);
			if(dataset.Tables[0].Rows.Count.ToString() == "1")
            {
				//MessageBox.Show("Вы успешно вошли");
				SelectedReader.id = Convert.ToInt32(dataset.Tables[0].Rows[0][0]);
				SelectedReader.Surname = dataset.Tables[0].Rows[0][1].ToString();
				SelectedReader.Name = dataset.Tables[0].Rows[0][2].ToString();
				SelectedReader.Patronymic = dataset.Tables[0].Rows[0][3].ToString();
				SelectedReader.Library_card_number = dataset.Tables[0].Rows[0][4].ToString();
				SelectedReader.Аddress = dataset.Tables[0].Rows[0][5].ToString();
				SelectedReader.Phone_number = dataset.Tables[0].Rows[0][6].ToString();
				SelectedReader.Photo = dataset.Tables[0].Rows[0][7].ToString();
				LibraryForm forma = new LibraryForm(SelectedReader);
				forma.Show();

			}
			else
            {
				MessageBox.Show("Читателя с данными читательским билетом не найдено");
            }

		}

		private void CreateCardBtn_Click(object sender, EventArgs e)
		{
			ReaderForm reader_form = new ReaderForm(false, sqlConnection);
			reader_form.Owner = this;
			reader_form.ShowDialog();
		}
	}
}
