﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace LibraryForm
{
	public partial class ReaderForm : Form
	{
		LibraryForm? main;
		FirstForm? login;
		private SqlConnection sqlConnection;
		bool ModeEdit = false;
		Reader CurrentReader;

		public ReaderForm(bool mode, SqlConnection connect)
		{
			InitializeComponent();
			sqlConnection = connect;
			ModeEdit = mode;
			DeleteBtn.Visible = false;
			SaveBtn.Location = new Point(421, 259);
		}

		public ReaderForm(bool mode, Reader reader, SqlConnection connect)
		{
			InitializeComponent();
			sqlConnection = connect;
			CurrentReader = reader;
			ModeEdit = mode;
			this.Text = "Редактирование читателя";
		}

		private void ReaderForm_Load(object sender, EventArgs e)
		{
			if(this.Owner is LibraryForm)
			{
				main = (LibraryForm)this.Owner;
			}
			else
			{
				login = (FirstForm)this.Owner;
			}
			fillData(CurrentReader);
		}

		private void UpdateReaderFromTxtBox()
		{
			//CurrentReader.id = Convert.ToInt32(dataset.Tables[0].Rows[0][0]);
			CurrentReader.Surname = SurnameTxtBox.Text;
			CurrentReader.Name = NameTxtBox.Text;
			CurrentReader.Patronymic = PatronymicTxtBox.Text;
			CurrentReader.Library_card_number = CardNumberMskdTxtBox.Text;
			CurrentReader.Аddress = AddressTxtBox.Text;
			CurrentReader.Phone_number = PhoneNumberMskdTxtBox.Text;
			CurrentReader.Photo = PhotoPictureBox.Image;
		}

		public bool sqladd(SqlCommand command, string message)
		{
			try
			{
				command.Parameters.AddWithValue("Фамилия", CurrentReader.Surname);
				command.Parameters.AddWithValue("Имя", CurrentReader.Name);
				command.Parameters.AddWithValue("Отчество", CurrentReader.Patronymic);
				command.Parameters.AddWithValue("Номер_читательского_билета", CurrentReader.Library_card_number);
				command.Parameters.AddWithValue("Адрес", CurrentReader.Аddress);
				command.Parameters.AddWithValue("Номер_телефона", CurrentReader.Phone_number);
				if (CurrentReader.Photo != null)
				{			
					byte[] arr_picture;
					ImageConverter converter = new ImageConverter();
#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                    arr_picture = (byte[])converter.ConvertTo(CurrentReader.Photo, typeof(byte[]));
#pragma warning restore CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.
                    command.Parameters.AddWithValue("Фото", arr_picture);
				}
				if (command.ExecuteNonQuery() == 1)
				{
					MessageBox.Show(message);
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
#pragma warning disable CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
					if (!ModeEdit)
					{
						login.ChangeTextCardNumber(CurrentReader.Library_card_number);
					}
#pragma warning restore CS8604 // Возможно, аргумент-ссылка, допускающий значение NULL.
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
					return true;
				}
				else { return false; }
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				return false;
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
				PhotoPictureBox.Image = CurrentReader.Photo;
			}
			catch (Exception) {	}
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (SurnameTxtBox.Text == "" || NameTxtBox.Text == "" || PatronymicTxtBox.Text == "" || CardNumberMskdTxtBox.Text == "" || AddressTxtBox.Text == "" || PhoneNumberMskdTxtBox.Text == "+7 (   )    -")
			{
				MessageBox.Show("Заполните все данные");
			}
			else
			{
				SqlCommand sqlCommand;
				UpdateReaderFromTxtBox(); // Обновление Reader из TextBox
				switch (ModeEdit)
				{
					case false:
						sqlCommand = new SqlCommand($"Insert INTO [Читатели] ([Фамилия], [Имя], [Отчество], " +
							"[Номер читательского билета], [Адрес], [Номер телефона], [Фото]) " +
							"VALUES (@Фамилия, @Имя, @Отчество, @Номер_читательского_билета, @Адрес, @Номер_телефона, " +
                            "@Фото)", sqlConnection);
						if (sqladd(sqlCommand, "Читатель добавлен в БД"))
						{
							this.Close();
						}
                        break;
					case true:
						sqlCommand = new SqlCommand($"Update [Читатели] set [Фамилия] = @Фамилия, [Имя] = @Имя, " +
                            "[Отчество] = @Отчество, [Номер читательского билета] = @Номер_читательского_билета, " +
                            "[Адрес] = @Адрес, [Номер телефона] = @Номер_телефона, [Фото] = @Фото " +
							$"Where Id={CurrentReader.id}", sqlConnection);
						if (sqladd(sqlCommand, "Читатель изменен в БД"))
                        {
#pragma warning disable CS8602 // Разыменование вероятной пустой ссылки.
							main.UpdateReader(CurrentReader);
#pragma warning restore CS8602 // Разыменование вероятной пустой ссылки.
							this.Close();
						}
                        break;
				}
				
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

			this.Close();
			main.Close();
		}

		private void CardNumberMskdTxtBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
			{
				e.Handled = true;
			}
		}
		public void Check_Is_Digit(object sender, KeyPressEventArgs e)
		{
			if (!Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]").Success && e.KeyChar != 8 && e.KeyChar != '-')
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

        private void AddressTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
			if (!Regex.Match(e.KeyChar.ToString(), @"[а-яА-Я]").Success && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != ',' && e.KeyChar != '.' && !Char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}
    }
}
