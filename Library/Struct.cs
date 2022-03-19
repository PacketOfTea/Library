
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
}
