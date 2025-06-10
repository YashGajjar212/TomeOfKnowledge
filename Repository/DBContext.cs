using Books.ModelDTOs;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace Repository
{
    public class TOKDBContext : DbContext
    {
        public TOKDBContext(DbContextOptions<TOKDBContext> options) : base(options)
        {
        }

        DbSet<Book> Book { get; set; }
    }
}