using FirstRestSharp.Models;
using Microsoft.EntityFrameworkCore;

namespace FirstRestSharp.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
                
        }
      public DbSet<Person>Persons { get; set; }



    }
}
