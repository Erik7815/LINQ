using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Orderdata
    {
        public static readonly List<Order> orders = new List<Order>()
        {
            new Order()
            {
                id = 1,
                ClientID = 1,
                ProductID = 2,
                Amount = 1,
            },new Order()
            {
                id = 2,
                ClientID = 2,
                ProductID = 10,
                Amount = 10,
            },new Order()
            {
                id = 3,
                ClientID = 4,
                ProductID = 2,
                Amount = 5,
            },new Order()
            {
                id = 4,
                ClientID = 3,
                ProductID = 5,
                Amount = 7,
            },new Order()
            {
                id = 5,
                ClientID = 2,
                ProductID = 9,
                Amount = 2,
            },new Order()
            {
                id = 6,
                ClientID = 4,
                ProductID = 8,
                Amount = 30,
            },new Order()
            {
                id = 7,
                ClientID = 1,
                ProductID = 4,
                Amount = 10,
            },new Order()
            {
                id = 8,
                ClientID = 5,
                ProductID = 6,
                Amount = 12,
            },new Order()
            {
                id = 9,
                ClientID = 5,
                ProductID = 5,
                Amount = 3,
            },new Order()
            {
                id = 10,
                ClientID = 1,
                ProductID = 2,
                Amount = 20,
            }
        };
    }
}
