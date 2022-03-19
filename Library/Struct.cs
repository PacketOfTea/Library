
namespace LibraryForm
{
	public struct Book
	{
		public int id;
		public string? Title;
		public string? Author;
		public string? PublicDate;
		public string? Publisher;
		public string? PhotoPictureBox;
		public string? NumberOfBooks;

		public void clear()
		{
			id = 0;
			Title = null;
			Author = null;
			PublicDate = null;
			Publisher = null;
			PhotoPictureBox = null;
			NumberOfBooks = null;
		}
	}

	public struct Reader
	{
		public int id;
		public string? Surname;
		public string? Name;
		public string? Patronymic;
		public string? Library_card_number;
		public string? Аddress;
		public string? Phone_number;
		public string? Photo;

		public void clear()
		{
			id = 0;
			Surname = null;
			Name = null;
			Patronymic = null;
			Library_card_number = null;
			Аddress = null;
			Phone_number = null;
			Photo = null;
		}
	}
}
