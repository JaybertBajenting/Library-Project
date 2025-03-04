namespace Library_Project.Models
{
    public class Book
    {

        public int BookId { get; set; }

        public string Title { get; set; } = null!;
        
        public string? Description { get; set; }
        public int AuthorId { get; set; }

        public Author Author { get; set; }  
        
        
        public ICollection<Category> Categories { get; set; } = new List<Category>();   
    }
}
