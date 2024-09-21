using Apitesting.Model;
using Microsoft.EntityFrameworkCore;

namespace Apitesting.Data

{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<FormData> FormDatas { get; set; }
        public object FormData { get; internal set; }
    }
}
