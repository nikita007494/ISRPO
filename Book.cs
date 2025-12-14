namespace PublishingApp.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public int ReleaseYear { get; set; }
        public int Pages { get; set; }
        public int Circulation { get; set; }
        public decimal Price { get; set; }
    }
}