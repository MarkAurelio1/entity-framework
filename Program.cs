using System;
using Blog.Data;
using Blog.Models;
using Microsoft.EntityFrameworkCore;

namespace Blog
{
    class Program
    {
        static void Main(string[] args)
        {
            using var context = new BlogDataContext();

            // var user = new User
            // {
            //     Name = "John Doe",
            //     Email = "john@doe.com",
            //     Slug = "johndoe",
            //     Bio = "1x Then Top",
            //     Image = "https://balta.io",
            //     PasswordHash = "12345678"
            // };

            // var category = new Category
            // {
            //     Name = "Professor",
            //     Slug = "History"
            // };

            // var post = new Post
            // {
            //     Author = user,
            //     Category = category,
            //     Body = "<p>Hello World<p>",
            //     Slug = "history-school",
            //     Summary = "Vamos aprender sobre história",
            //     Title = "Aprendendo História da Escola",
            //     CreateDate = DateTime.Now,
            //     LastUpdateDate = DateTime.Now,
            // };

            // context.Posts.Add(post);
            // context.SaveChanges();

            // var posts = context
            //    .Posts
            //    .AsNoTracking()
            //    .Include(x => x.Author)
            //    .OrderByDescending(x => x.LastUpdateDate)
            //    .ToList();

            // foreach (var post in posts)
            //     Console.WriteLine($"{post.Title} escrito por {post.Author?.Name}");

            // var post = context
            //   .Posts
            //   //.AsNoTracking()
            //   .Include(x => x.Author)
            //   .Include(x => x.Category)
            //   .OrderByDescending(x => x.LastUpdateDate)
            //   .FirstOrDefault();

            // post.Author.Name = "Teste";

            // context.Posts.Update(post);
            // context.SaveChanges();

        }
    }
}
