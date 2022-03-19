﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;


namespace LibraryForm
{
    public partial class ReaderForm : Form
    {
		LibraryForm main;
		private SqlConnection sqlConnection;
		bool ModeEdit = false;
		Reader CurrentReader;

		public ReaderForm(bool mode, SqlConnection connect)
		{
			InitializeComponent();
			sqlConnection = connect;
			ModeEdit = mode;
			DeleteBtn.Visible = false;
		}

		public ReaderForm(bool mode, Reader reader, SqlConnection connect)
		{
			InitializeComponent();
			sqlConnection = connect;
			CurrentReader = reader;
			ModeEdit = mode;
			this.Text = "Редактирование читателя";
		}

		private void BookForm_Load(object sender, EventArgs e)
		{
#pragma warning disable CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
			main = this.Owner as LibraryForm;
#pragma warning restore CS8601 // Возможно, назначение-ссылка, допускающее значение NULL.
			fillData(CurrentReader);
		}

		public void sqladd(SqlCommand command, string message)
		{
			try
			{
				command.Parameters.AddWithValue("Фамилия", SurnameTxtBox.Text);
				command.Parameters.AddWithValue("Имя", NameTxtBox.Text);
				command.Parameters.AddWithValue("Отчество", PatronymicTxtBox.Text);
				command.Parameters.AddWithValue("Номер_читательского_билета", CardNumberMskdTxtBox.Text);
				command.Parameters.AddWithValue("Адрес", AddressTxtBox.Text);
				command.Parameters.AddWithValue("Номер_телефона", PhoneNumberMskdTxtBox.Text);
				if (PhotoPictureBox.Image != null)
				{
					Image img = PhotoPictureBox.Image;
					byte[] arr_picture;
					ImageConverter converter = new ImageConverter();
					arr_picture = (byte[])converter.ConvertTo(img, typeof(byte[]));

					command.Parameters.AddWithValue("Фото", arr_picture);
				}		

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

		public void fillData(Reader SelectedReader)
		{
			if (ModeEdit)
			{
				CurrentReader = SelectedReader;
			}
			else
			{
				CurrentReader.clear();
			}
			SurnameTxtBox.Text = CurrentReader.Surname;
			NameTxtBox.Text = CurrentReader.Name;
			PatronymicTxtBox.Text = CurrentReader.Patronymic;
			CardNumberMskdTxtBox.Text = CurrentReader.Library_card_number;
			AddressTxtBox.Text = CurrentReader.Аddress;
			PhoneNumberMskdTxtBox.Text = CurrentReader.Phone_number;
			try
			{
				PhotoPictureBox.Load(CurrentReader.Photo);
			}
			catch (Exception)
			{

			}
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (SurnameTxtBox.Text == "" || NameTxtBox.Text == "" || PatronymicTxtBox.Text == "" || CardNumberMskdTxtBox.Text == "" || AddressTxtBox.Text == "" || PhoneNumberMskdTxtBox.Text == "")
			{
				MessageBox.Show("Заполните все данные");
			}
			else
			{
				SqlCommand sqlCommand;
				switch (ModeEdit)
				{
					case false:
						sqlCommand = new SqlCommand($"Insert INTO [Читатели] ([Фамилия], [Имя], [Отчество], " +
							"[Номер читательского билета], [Адрес], [Номер телефона], [Фото]) " +
							"VALUES (@Фамилия, @Имя, @Отчество, @Номер_читательского_билета, @Адрес, @Номер_телефона, @Фото)"
										, sqlConnection);
						sqladd(sqlCommand, "Читатель добавлен в БД");
						break;
					case true:
						sqlCommand = new SqlCommand($"Update [Читатели] set [Фамилия] = @Фамилия, [Имя] = @Имя, [Отчество] = @Отчество, [Номер читательского билета] = @Номер_читательского_билета, [Адрес] = @Адрес, [Номер_телефона] = @Номер_телефона, [Фото] = @Фото " +
								$"Where Id={CurrentReader.id}", sqlConnection);
						sqladd(sqlCommand, "Читатель изменен в БД");
						break;
				}
				//main.showDB_BOOKS();
				//main.SelectedBook.clear();
				this.Close();
			}
		}

		private void DeleteBtn_Click(object sender, EventArgs e)
		{
			try
			{
				SqlCommand sqlCommand = new SqlCommand($"Delete [Читатели] Where Id={CurrentReader.id}", sqlConnection);
				if (sqlCommand.ExecuteNonQuery() == 1)
				{
					MessageBox.Show("Читатель удален из БД");
				}
				sqlCommand.Parameters.Clear();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			//main.showDB_BOOKS();
			//main.SelectedBook.clear();
			this.Close();
		}

        private void CardNumberMskdTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
		}

        private void LoadImageBtn_Click(object sender, EventArgs e)
        {
			openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" +
				"All files (*.*)|*.*";
			openFileDialog1.Title = "Выберите фотографию";
			if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
			{
				PhotoPictureBox.Image = Image.FromFile(openFileDialog1.FileName);
			}
		}
    }
}
