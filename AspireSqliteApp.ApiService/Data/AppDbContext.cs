using Microsoft.EntityFrameworkCore;
using AspireSqliteApp.ApiService.Models;

namespace AspireSqliteApp.ApiService.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    public DbSet<Item> Items => Set<Item>();
}