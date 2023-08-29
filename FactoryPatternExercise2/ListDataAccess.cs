using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExercise2
{
    public class ListDataAccess : Product, IDataAccess
    {
        public static List<Product> Products = new List<Product>()
        {
            new Product(){Name = "VR Goggles", Price = 599.99},
            new Product(){Name = "Xbox", Price = 499.99},
            new Product(){Name = "PC Monitor", Price = 199.99},
            new Product(){Name = "Chromebook", Price = 299.99}
        };
        List<Product> IDataAccess.LoadData()
        {
            Console.WriteLine($"I am reading data from the List Database.");
            return Products;
        }

        void IDataAccess.SaveData()
        {
            Console.WriteLine($"I am saving data to the List Database.");
        }
    }
}
