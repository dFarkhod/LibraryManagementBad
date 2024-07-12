namespace LibraryManagement
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Library library = new Library();
			library.RegisterUser("Ahmad");
			library.AddBook("The Barakah Culture");
			library.BorrowBook("Ahmad", "The Barakah Culture");
			library.ReturnBook("Ahmad", "The Barakah Culture");
		}
	}

	public class Library
	{
		private List<string> books = new();
		private List<string> users = new();

		public void AddBook(string book)
		{
			books.Add(book);
			Console.WriteLine($"Book '{book}' added to the library.");
		}

		public void RegisterUser(string user)
		{
			users.Add(user);
			Console.WriteLine($"User '{user}' registered.");
		}

		public void BorrowBook(string user, string book)
		{
			if (users.Contains(user) && books.Contains(book))
			{
				books.Remove(book);
				Console.WriteLine($"User '{user}' borrowed book '{book}'.");
			}
			else
			{
				Console.WriteLine($"Borrowing failed: either user '{user}' or book '{book}' does not exist.");
			}
		}

		public void ReturnBook(string user, string book)
		{
			books.Add(book);
			Console.WriteLine($"User '{user}' returned book '{book}'.");
		}
	}

	
}
