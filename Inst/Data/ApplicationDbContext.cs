using Inst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.Identity.Client;

namespace Inst.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<InstModels> Inst { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
            
        }
    }
}

