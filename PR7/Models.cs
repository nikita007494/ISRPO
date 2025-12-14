using System;

namespace PR7  // Тот же namespace, что и в DatabaseHelper!
{
    public class Author
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string FullName => $"{Surname} {Name}";
    }

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

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int Type { get; set; } = 1;
    }

    public class Office
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public string OrderName { get; set; }
        public int BookId { get; set; }
        public int OfficeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime? CompletionDate { get; set; }
        public decimal Price { get; set; }

        // Для отображения
        public string BookTitle { get; set; }
        public string CustomerName { get; set; }
        public string OfficeName { get; set; }
    }
}