using Microsoft.EntityFrameworkCore;
using Mvc_E_Commerce.Models;

namespace Mvc_E_Commerce.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    DbSet<Category> Categories { get; set; }
}
