
using System;

namespace LibraryCatalogSystem
{
    public class Library
    {
        public required string Name { get; set; }
        public required string Address { get; set; }
        private List<Book> Books { get; set; } = new List<Book>();
        private List<MediaItem> MediaItems { get; set; } = new List<MediaItem>();

        public Library() { }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RemoveBook(Book book)
        {
            Books.Remove(book);
        }

        public void AddMediaItem(MediaItem item)
        {
            MediaItems.Add(item);
        }

        public void RemoveMediaItem(MediaItem item)
        {
            MediaItems.Remove(item);
        }

        public void PrintCatalog()
        {
            foreach (var book in Books)
            {
                Console.WriteLine($"{{Book}} Title - {book.Title} | Author - {book.Author}");
            }

            foreach (var mediaItem in MediaItems)
            {
                Console.WriteLine($"{{Media}} Title - {mediaItem.Title} | Duration - {mediaItem.Duration}");
            }
        }
    }
}