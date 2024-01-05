using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogApp.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using SQLitePCL;

namespace BlogApp.Data.Concrete.EfCore
{
    public static class SeedData
    {
        public static void FillTestData(IApplicationBuilder app)
        {
            var context = app.ApplicationServices.CreateScope().ServiceProvider.GetService<BlogContext>();
            if (context != null)
            {
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }

                if (!context.Tags.Any())
                {
                    context.Tags.AddRange(
                        new Tag { Text = "Web Programming", Url = "web-programming", Color = TagColors.warning },
                        new Tag { Text = "Backend", Url = "Backend", Color = TagColors.primary },
                        new Tag { Text = "Frontend", Url = "Frontend", Color = TagColors.success },
                        new Tag { Text = "Full Stack", Url = "FullStack", Color = TagColors.secondary },
                        new Tag { Text = "C#", Url = "C#", Color = TagColors.danger }
                    );
                    context.SaveChanges();
                }

                if (!context.Users.Any())
                {
                    context.Users.AddRange(
                        new User { UserName = "JackReacher", Name = "Jack Reacher", Email = "info@jackreacher.com", Password = "1234", Image = "p1.jpg" },
                        new User { UserName = "JackRyan", Name = "Jack Ryan", Email = "info@jackryan.com", Password = "1234", Image = "p2.jpg" }
                    );
                    context.SaveChanges(); 
                }

                if (!context.Posts.Any())
                {
                    context.Posts.AddRange(
                        new Post
                        {
                            Title = "AspNetCore",
                            Content = "AspNetCore .Net8",
                            Url = "aspnet-core",
                            IsActive = true,
                            Image = "1.jpg",
                            PublishedOn = DateTime.Now.AddDays(-10),
                            Tags = context.Tags.Take(3).ToList(),
                            UserId = 1,
                            Comments = new List<Comment> {
                            new Comment { Text = "Best of the world Course", PublishedOn = DateTime.Now.AddDays(-20), UserId = 1 },
                            new Comment { Text = "Amazing Course", PublishedOn = DateTime.Now.AddDays(-30), UserId = 2 }
                            },
                        },
                        new Post
                        {
                            Title = "Angular",
                            Content = "Angular 7",
                            Url = "angular-7",
                            IsActive = true,
                            Image = "2.jpg",
                            PublishedOn = DateTime.Now.AddDays(-20),
                            Tags = context.Tags.Take(2).ToList(),
                            UserId = 1
                        },
                        new Post
                        {
                            Title = "Dart",
                            Content = "Flutter",
                            Url = "flutter",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-30),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        },
                        new Post
                        {
                            Title = "React Courses",
                            Content = "React",
                            Url = "react-courses",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-40),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        },
                        new Post
                        {
                            Title = "Web Design",
                            Content = "Web Design Courses",
                            Url = "web-design",
                            IsActive = true,
                            Image = "3.jpg",
                            PublishedOn = DateTime.Now.AddDays(-50),
                            Tags = context.Tags.Take(4).ToList(),
                            UserId = 2
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
