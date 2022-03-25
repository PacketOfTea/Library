
namespace LibraryForm
{
	public class Book
	{
		public int id;
		public string? Title;
		public string? Author;
		public string? PublicDate;
		public string? Publisher;
		public Image? PhotoPictureBox;
		public string? NumberOfBooks;

		public Book() {	}
		public virtual void clear()
		{
			id = 0;
			Title = null;
			Author = null;
			PublicDate = null;
			Publisher = null;
			PhotoPictureBox = Library.Properties.Resources.NoPicture;
			NumberOfBooks = null;
		}
	}

	public class PinnedBook : Book
	{
		public DateTime? DateOfIssue;
		public DateTime? DateIssuedBefore;
		public DateTime? DateReturn;

		public PinnedBook(Book book) 
		{
			id = book.id;
			Title = book.Title;
			Author = book.Author;
			PublicDate = book.PublicDate;
			Publisher = book.Publisher;
			PhotoPictureBox = book.PhotoPictureBox;
			NumberOfBooks = book.NumberOfBooks;
		}
		public override void clear()
        {
			id = 0;
			Title = null;
			Author = null;
			PublicDate = null;
			Publisher = null;
			PhotoPictureBox = null;
			NumberOfBooks = null;
			DateOfIssue = null;
			DateIssuedBefore = null;
			DateReturn = null;
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
		public Image? Photo;

		public void clear()
		{
			id = 0;
			Surname = null;
			Name = null;
			Patronymic = null;
			Library_card_number = null;
			Аddress = null;
			Phone_number = null;
			Photo = Library.Properties.Resources.NoPhoto;
		}
	}

}
