using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Clientdata
    {
        public static readonly List<Client> clients = new List<Client>()
        {
            new Client()
            {
                Id = 1,
                    Name = "Joonas",
                    City = "Tallinn"
            },
            new Client()
            {
                Id = 2,
                    Name = "Mari",
                    City = "Narva"
            },
            new Client()
            {
                Id = 3,
                    Name = "Juss",
                    City = "Rakvere"
            },
            new Client()
            {
                Id = 4,
                    Name = "Ingvar",
                    City = "Tallinn"
            },
            new Client()
            {
                Id = 5,
                    Name = "Ron",
                    City = "Tartu"
            },
        };
    }
}
