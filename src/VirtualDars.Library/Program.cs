namespace LibraryManagement
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Library library = new();
			library.RegisterUser("Ahmad");
			library.AddBook("The Barakah Culture: More with Less");
			library.TakeBook("Ahmad", "The Barakah Culture: More with Less");
			library.ReturnBook("Ahmad", "The Barakah Culture: More with Less");
		}
	}

	public class Library
	{
		private List<string> _books = new();
		private List<string> _users = new();

		public void AddBook(string book)
		{
			_books.Add(book);
			Console.WriteLine($"Book '{book}' added to the library.");
		}

		public void RegisterUser(string user)
		{
			_users.Add(user);
			Console.WriteLine($"User '{user}' registered.");
		}

		public void TakeBook(string user, string book)
		{
			if (_users.Contains(user) && _books.Contains(book))
			{
				_books.Remove(book);
				Console.WriteLine($"User '{user}' borrowed book '{book}'.");
			}
			else
			{
				Console.WriteLine($"Borrowing failed: either user '{user}' or book '{book}' does not exist.");
			}
		}

		public void ReturnBook(string user, string book)
		{
			_books.Add(book);
			Console.WriteLine($"User '{user}' returned book '{book}'.");
		}
	}

	
}
