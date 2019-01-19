using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFinal
{
    class Program
    {
        public static Category category { get; private set; }

        static void Main(string[] args)
        {
            using (var db = new CategoryContext())
            {
                Console.Write("Enter a name for a new Error category:");
                var name = Console.ReadLine();

                var  category = new Category { Name = name };
                db.Categories.Add(category);
                db.SaveChanges();

                var query = from c in db.Categories
                            orderby c.Name
                            select c;

                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
    public class Category
    {
        public int? CategoryId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public virtual List<Error> Errors { get; set; }
    }

    public class Error
    {
        public int? ErrorId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int? CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
    public class User
    {
        [Key]
        public string Username { get; set; }
        public string DisplayName { get; set; }
    }

    public class CategoryContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .Property(u => u.DisplayName)
                .HasColumnName("display_area");

        }
    }
}
