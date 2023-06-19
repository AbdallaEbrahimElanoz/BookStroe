
namespace BookStore.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string title { get; set; }   
        public string Description { get; set; } 
        public Author Author { get; set; }
    }
}
