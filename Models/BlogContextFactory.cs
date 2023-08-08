using Microsoft.EntityFrameworkCore.Design;

namespace efc6.Models;

public class BlogContextFactory : IDesignTimeDbContextFactory<BlogContext>
{
    public BlogContext CreateDbContext(string[] args)
    {
        return new BlogContext();
    }
}