using System;

namespace Bookss
{
	internal class Books
	{
		string title;
		string author;
		int pageCount;
		int releseYear;

		public Books(string title, string author, int pageCount, int releseYear)
		{
			this.title = title;
			this.author = author;
			this.pageCount = pageCount;
			this.releseYear = releseYear;
		}

		public string Title { get => title; }
		public string Author { get => author; }
		public int PageCount { get => pageCount; }
		public int ReleseYear { get => releseYear; }

		public static Books GetBookByTitle(Books[] books, string title)
		{
			bool meglette = false;
			foreach (var book in books)
			{
				if (book.Title == title)
				{
					Console.WriteLine($" A Cim amit keresel " + "" + title + " ");
					Console.WriteLine("Van ilyen : ");
                    Console.WriteLine();
                    return book;
				}
			}
			Console.WriteLine($" A Cim amit keresel " + "" + title + " ");
			Console.WriteLine("Nincs Ilyen");
			return null;
		}

		public void EditBookData()
		{
			this.title = "ZombikEditelve";
		}

		public override string? ToString()
		{
			return $" Cím :{title}  Írta : {Author} {pageCount}  Oldal {releseYear} Jött ki";
		}
	}
}