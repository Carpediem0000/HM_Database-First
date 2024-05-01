using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HM_Database_First
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ShopEntities()) { 
                foreach (var item in db.Products)
                {
                    Console.WriteLine(item);
                }
                db.Products.Add(new Product { Name = "test"});
                db.SaveChanges();
                Console.WriteLine("--------------After Add-------------");
                foreach (var item in db.Products)
                {
                    Console.WriteLine(item);
                }
                db.Products.Remove(db.Products.First(i => i.Id == 4));
                db.SaveChanges();
                Console.WriteLine("------------After Remove------------");
                foreach (var item in db.Products)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
