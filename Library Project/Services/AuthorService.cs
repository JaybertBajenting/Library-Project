using Library_Project.Data;
using Library_Project.Models;
using Microsoft.EntityFrameworkCore;
namespace Library_Project.Services
{
    public class AuthorService
    {

        private readonly ILogger<AuthorService> logger;

        private readonly LibraryContext libraryContext;


        public AuthorService(ILogger<AuthorService> logger, LibraryContext libraryContext)
        {
            this.logger = logger;
            this.libraryContext = libraryContext;
        }

        
        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await libraryContext.Authors.ToListAsync();
        }
          

        // needs to be implemented
        //add author
        //get author by id
        // update authors details
        //    delete an author by its id



        // * advance
        // get authors with counts of their books
        
        
    }
}
