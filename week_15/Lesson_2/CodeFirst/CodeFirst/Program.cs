using CodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CodeFirst
{
    
   

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddCategory("Womens2");
            //GetAllCategores();
            //UpdateCategory("Womens", "Men");
            //RemoveCategory("Womens2");

        }


        static void AddCategory(string categoryName)
        {
            using (var db  = new ParfumCnotex())
            {
                if (string.IsNullOrEmpty(categoryName))
                {
                    Console.WriteLine("Not Name Added");
                    return;
                }
                var c = new Category() { Name = categoryName };
                db.Categories.Add(c);
                db.SaveChanges();
                Console.WriteLine("Category Added");
            }
        }

        static void GetAllCategores()
        {
            using (var db = new ParfumCnotex())
            {

                var categores = db.Categories.Select(dr=>dr.Name).ToList();

                foreach (var item in categores)
                {
                    Console.WriteLine($"Category: {item}");
                }
            }
        }


        static void RemoveCategory(string categoryName)
        {
            if (string.IsNullOrEmpty(categoryName))
            {
                Console.WriteLine("Not Name Added");
                return;
            }

            using (var db = new ParfumCnotex())
            {
                var c = db.Categories.FirstOrDefault(dr => dr.Name == categoryName);
                if (c != null)
                {
                    db.Categories.Remove(c);
                    db.SaveChanges();
                }
                Console.WriteLine("Category Removed");
            }
        }

        static void UpdateCategory(string categoryName , string newcategoryName)
        {
            if (string.IsNullOrEmpty(categoryName) || string.IsNullOrEmpty(newcategoryName))
            {
                Console.WriteLine("Not Name Added");
                return;
            }

            using (var db = new ParfumCnotex())
            {
                Category c = db.Categories.FirstOrDefault(dr => dr.Name == categoryName);
                if (c != null)
                {
                    c.Name = newcategoryName;
                    db.SaveChanges();
                }
                Console.WriteLine("Category Updated");
            }
        }
    }
}
