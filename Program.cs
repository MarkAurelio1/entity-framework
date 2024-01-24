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
            using (var context = new BlogDataContext())
            {    //create
                // var tag = new Tag { Name = "test1", Slug = "NewTest2" };
                // context.Tags.Add(tag); // Salve o usuário apenas na memória
                // context.SaveChanges(); // salva tudo que tem na memória e passa para o banco
                //update
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 7);
                // tag.Name = "test2";
                // tag.Slug = "test3";

                // context.Update(tag);
                // context.SaveChanges();

                //delete
                // var tag = context.Tags.FirstOrDefault(x => x.Id == 1);
                // context.Remove(tag);
                // context.SaveChanges();

                // var tags = context.Tags.AsNoTracking().ToList(); // .ToList inclui fitros dinamicos sempre no final da query
                // foreach (var tag in tags)
                // {
                //     Console.WriteLine(tag.Name);
                // }

                // var tag = context.Tags.AsNoTracking().FirstOrDefault(x => x.Id == 8);
                // Console.WriteLine(tag?.Name);
            }
        }
    }
}
