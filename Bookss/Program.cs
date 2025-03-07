namespace Bookss
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Books[] books = new Books[]
			{
				new Books("AlmaEcet", "Evelin", 300, 2015),
				new Books("FenyoFa", "Evelin", 300, 2015),
				new Books("KokuszGolyo", "Kis Ernő", 300, 2015),
				new Books("Az Éjszaka", "Trap Pista", 300, 2015),
				new Books("Locked In", "Ádám Nagy", 300, 2015)
			};

			Books b1 = books[0];
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
