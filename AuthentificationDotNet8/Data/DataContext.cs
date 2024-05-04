using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AuthentificationDotNet8.Data
{
    public class DataContext : IdentityDbContext
    {
        public DataContext (DbContextOptions<DataContext> options) : base(options) 
        {
            
        }
    }
}
