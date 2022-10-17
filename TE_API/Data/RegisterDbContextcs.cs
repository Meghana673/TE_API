using Microsoft.EntityFrameworkCore;
using TE_API.Models;

namespace TE_API.Data
{
    public class RegisterDbContextcs : DbContext
    {
        public RegisterDbContextcs(DbContextOptions<RegisterDbContextcs> options) : base(options)
        {

        }
            public DbSet<Register> Registers { get; set; }
        
    }
}
