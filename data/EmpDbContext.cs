using Microsoft.EntityFrameworkCore;
using pract02.models;

namespace pract02.data;

public class EmpDbContext : DbContext
{
    // public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options) { }
    public EmpDbContext(DbContextOptions<EmpDbContext> options) : base(options)
    {
    }
    public DbSet<Employee> ETbl { get; set; }
}


