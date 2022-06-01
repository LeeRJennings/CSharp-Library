using System;

namespace Library
{
    public class Book
    {
        public string Author {get; set;}
        public string Title {get; set;}
        public DateTime PublishDate {get; set;}
        public string Genre {get; set;}

        public Book(string author, string title, DateTime publishDate, string genre)
        {
            Author = author;
            Title = title;
            PublishDate = publishDate;
            Genre = genre;
        }
    }
}