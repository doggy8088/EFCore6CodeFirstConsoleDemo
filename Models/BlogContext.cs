
using Microsoft.EntityFrameworkCore;

namespace efc6.Models;

public class BlogContext : DbContext
{
    public BlogContext() { }
    public BlogContext(DbContextOptions<BlogContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=BlogDB;Integrated Security=True");
        // optionsBuilder.UseSqlServer("Server=localhost;Initial Catalog=BlogDB;User Id=sa;Password=VeryC0mplexPW");
    }

    public DbSet<Blog> Blogs { get; set; } = null!;
    public DbSet<Post> Posts { get; set; } = null!;
}