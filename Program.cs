using System;
using System.Collections.Generic;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {   
            LibraryManager allTheBooks = new LibraryManager("All The Books");

            Book theLastKingdom = new Book("Bernard Cornwell", "The Last Kingdom", new DateTime(2004, 01, 01), "Historical Fiction");
            Book thePaleHorsman = new Book("Bernard Cornwell", "The Pale Horseman", new DateTime(2005, 01, 01), "Historical Fiction");
            Book theLordsOfTheNorth = new Book("Bernard Cornwell", "The Lords of the North", new DateTime(2006, 01, 01), "Historical Fiction");

            Console.WriteLine($"Welcome to the {allTheBooks.Name} Library Management System!");

            allTheBooks.AddBook(theLastKingdom);
            allTheBooks.AddBook(thePaleHorsman);
            allTheBooks.AddBook(theLordsOfTheNorth);

            allTheBooks.DisplayBooks();
        }
    }
}
