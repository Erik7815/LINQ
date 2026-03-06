using System.Linq.Expressions;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Filtreerimine");
            Console.WriteLine("2. Sorteerimine");
            Console.WriteLine("3. Andmete Projitseerimine");
            Console.WriteLine("4. Andmete Vahelejätmine");
            Console.WriteLine("5. Võtmine tingimuse alusel");
            Console.WriteLine("6. Üksiku elemendi leidmine");
            Console.WriteLine("7. Statistika");
            Console.WriteLine("8. Tingimuslik Kontroll");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Filtreerimine();
                    break;

                    case 2:
                    Sorteerimine();
                    break;

                    case 3:
                    Projitseerimine();
                    break;

                    case 4:
                    Vahele();
                    break;

                    case 5:
                    votmine();
                    break;

                    case 6:
                    first();
                    break;

                    case 7:
                    statistika();
                    break;

                    case 8:
                    kontroll();
                    break;
            }

        }
        public static void Filtreerimine()
        {
            var toode = Productdata.products.Where(x => x.Price > 50);
            Console.WriteLine("Tooted, mille hind on üle 50");
            foreach (var x in toode)
            {
                Console.WriteLine(x.Name + ":" + x.Price);
            }
        }
        public static void Sorteerimine()
        {
            var sort = Clientdata.clients.OrderBy(x => x.City).ThenBy(x => x.Name);
            foreach (var x in sort)
            {
                Console.WriteLine(x.City + "," + x.Name);
            }
        }
        public static void Projitseerimine()
        {
            var proj = Productdata.products.Select(x => new
            Product
            { Name = x.Name });
            foreach (var x in proj)
            {
                Console.WriteLine(x.Name);
            }
        }
        public static void Vahele()
        {
            var skip = Productdata.products.Skip(3);
            foreach (var item in skip)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void votmine()
        {
            var take = Productdata.products.TakeWhile(x => x.Price < 100);
            foreach (var item in take)
            {
                Console.WriteLine(item.Name);
            }
        }
        public static void first()
        {
            Console.WriteLine("Kategooria: lihatooted");
            var first = Productdata.products.FirstOrDefault(x => x.Category == "Liha").Name;
            Console.WriteLine(first);
        }
        public static void statistika()
        {
            var avg = Productdata.products.Average(x => x.Price);
            var ex = Productdata.products.Max(x => x.Price);
            var mitu = Productdata.products.Count(x => x.Category == "Liha");
            Console.WriteLine("Keskmine hind on " + avg);
            Console.WriteLine("Kallim toode on" + ex);
            Console.WriteLine("Tooteid kategoorias: " + mitu);
        }
        public static void kontroll()
        {
            Console.WriteLine("Kas on toode mis maksab üle 500");
            bool kont = Productdata.products.Any(x => x.Price < 500);
            Console.WriteLine(kont);
            
        }
         
    }
}
