using Microsoft.EntityFrameworkCore;

namespace Crud_System.Data
{
    public class ApplicationDpContext : DbContext
    {
        public ApplicationDpContext(DbContextOptions<ApplicationDpContext> options) :base(options)
        {
            
        }
    }
}
