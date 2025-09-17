using Crud_System.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Crud_System.Data
{
    public class ApplicationDpContext : DbContext
    {
        //public ApplicationDpContext(DbContextOptions<ApplicationDpContext> options) :base(options)
        //{

        //}
        public ApplicationDpContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<student> students { get; set; }    
    }

}
