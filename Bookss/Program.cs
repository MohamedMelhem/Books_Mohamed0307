namespace Bookss
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Random rnd = new Random();
			Books[] books = new Books[]
			{
				new Books("AlmaEcet", "Evelin", 300, 2015),
				new Books("FenyoFa", "Evelin", 300, 2015),
				new Books("KokuszGolyo", "Kis Ernő", 300, 2015),
				new Books("Az Éjszaka", "Trap Pista", 300, 2015),
				new Books("Locked In", "Ádám Nagy", 300, 2015),
				new Books("The Catcher in the Rye", "J.D. Salinger", 214, 1951),
				new Books("The Hobbit", "J.R.R. Tolkien", 310, 1937),
				new Books("Fahrenheit 451", "Ray Bradbury", 194, 1953),
				new Books("Moby-Dick", "Herman Melville", 635, 1851),
				new Books("Pride and Prejudice", "Jane Austen", 279, 1813),
				new Books("War and Peace", "Leo Tolstoy", 1225, 1869),
				new Books("The Odyssey", "Homer", 541, -800),
				new Books("Crime and Punishment", "Fyodor Dostoevsky", 671, 1866),
				new Books("The Brothers Karamazov", "Fyodor Dostoevsky", 824, 1880),
				new Books("Brave New World", "Aldous Huxley", 311, 1932),
				new Books("The Lord of the Rings", "J.R.R. Tolkien", 1178, 1954)

			};

			Books b1 = books[rnd.Next(1,books.Length)];
			Console.WriteLine(b1);

            Console.WriteLine($"A {b1} Modositva lett");
            b1.EditBookData();
			Console.WriteLine($"");
			Console.WriteLine(b1);

			Books foundBook = Books.GetBookByTitle(books, "Locked In");
			if (foundBook != null)
			{
				Console.WriteLine($"Megtalált Könyv : {foundBook}");
			}
			else
			{
				Console.WriteLine("A Könyv Sajnos nincs meg");

			}
		}
	}
}
