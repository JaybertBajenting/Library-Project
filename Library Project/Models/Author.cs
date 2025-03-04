using System.ComponentModel.DataAnnotations.Schema;

namespace Library_Project.Models
    
{

    [Table("tbl_author")]
    public class Author
    {
        
       public int AuthorId { get; set; }

        public string AuthorName { get; set; } = null!;

        public string? Bio { get; set; }


       
        public ICollection<Book> Books { get; set; }

        
    }
}
