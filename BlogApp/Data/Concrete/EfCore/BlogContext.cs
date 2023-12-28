using BlogApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogApp.Data.Concrete.EfCore
{
    public class BlogContext : DbContext
    {

        public BlogContext(DbContextOptions<BlogContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }

    }
}
