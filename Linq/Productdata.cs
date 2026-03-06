using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Productdata
    {
        public static readonly List<Product> products = new List<Product>()
        {
            new Product()
            {
                Id = 1,
                Name = "Juust",
                Category = "Piimatoode",
                Price = 4,
                Amount = 10,
            },new Product()
            {
                Id = 2,
                Name = "Jogurt",
                Category = "Piimatoode",
                Price = 2,
                Amount = 35,
            },new Product()
            {
                Id = 3,
                Name = "Sink",
                Category = "Liha",
                Price = 5,
                Amount = 3,
            },new Product()
            {
                Id = 4,
                Name = "Kana",
                Category = "Liha",
                Price = 11,
                Amount = 15,
            },new Product()
            {
                Id = 5,
                Name = "Kala",
                Category = "Liha",
                Price = 15,
                Amount = 21,
            },new Product()
            {
                Id = 6,
                Name = "Mahl",
                Category = "Jook",
                Price = 120,
                Amount = 22,
            },new Product()
            {
                Id = 7,
                Name = "Õlu",
                Category = "Jook",
                Price = 11,
                Amount = 19,
            },new Product()
            {
                Id = 8,
                Name = "Sidrun",
                Category = "Puuviljad",
                Price = 1,
                Amount = 40,
            },new Product()
            {
                Id = 9,
                Name = "Nuga",
                Category = "Tööriistad",
                Price = 1000,
                Amount = 4,
            },new Product()
            {
                Id = 10,
                Name = "Komm",
                Category = "Magusad",
                Price = 1.5,
                Amount = 37,
            },
        };
        
    }
}
