
namespace LibraryCatalogSystem
{
    public class Book
    {
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string ISBN { get; set; }
        public required int PublicationYear { get; set; }

        public Book() { }
    }
}