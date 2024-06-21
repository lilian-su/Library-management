using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Data
{
	public class DBook
	{
		private int isbn;
		private string title;
		private string author;
		private bool isAvailable;

		public int Isbn { get => isbn; set => isbn = value; }
		public string Title { get => title; set => title = value; }
		public string Author { get => author; set => author = value; }
		public bool IsAvailable { get => isAvailable; set => isAvailable = value; }

		public DBook() { }

		public DBook(int isbn, string title, string author)
		{
			Isbn = isbn;
			Title = title;
			Author = author;
			IsAvailable = true; // By default, a new book is available when inserting.
		}
	}
}
