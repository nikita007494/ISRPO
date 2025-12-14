using System;

namespace PublishingApp.Models
{
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