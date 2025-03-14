using CruidPersonalInfo.Models;
using Microsoft.EntityFrameworkCore;

namespace CruidPersonalInfo
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :
            base(options)
        {

        }
        public DbSet<UsreInfo> UsreInfos { get; set; }
    }
}
