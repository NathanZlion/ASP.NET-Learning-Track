
namespace LibraryCatalogSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Book Book1 = new Book()
            {
                Title = "Inspired",
                Author = "Martin Cagan",
                ISBN = " 0-9767736-6-X or 978-0-9767736-6-5",
                PublicationYear = 2018,
            };

            Book Book2 = new Book()
            {
                Title = "Clean Architecture",
                Author = "Uncle Bob",
                ISBN = " 0-9767736-6-X or 978-0-9767736-6-7",
                PublicationYear = 1990,
            };

            MediaItem mediaItem1 = new MediaItem() { Duration = 160, MediaType = "DVD", Title = "Gugut Podcast" };
            MediaItem mediaItem2 = new MediaItem() { Duration = 90, MediaType = "CD", Title = "Movie: The man who knew Infinity" };

            Library library = new Library() {Name = "Abrehot", Address = "4 Kilo akababi"};
            library.AddBook(Book1); 
            library.AddBook(Book2); 
            
            library.AddMediaItem(mediaItem1); 
            library.AddMediaItem(mediaItem2); 

            library.PrintCatalog();
        }
    }
}


