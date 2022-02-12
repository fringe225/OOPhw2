using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhw2
{
    internal class Product
    {
        private string _name;
        public double Price;
        public int Count;
        public double TotalIncome=0;


        public Product(string name)
        {
            Name = name;
        }
        public Product(string name,double price, int count):this(name)
        {
            Name = name;
            Price = price;
            Count = count;
        }


        public string Name
        {
            get { return _name; }
            set {
                while (true)
                {
                    if (value.Length == 0)
                    {
                        Console.Write("Please Enter Product name : ");
                        value = Console.ReadLine() ?? "";
                    }
                    else
                    {
                        _name = value;
                        break;
                    }
                }
                
            }
        }

        public void Sell()
        {
            if (Count > 0)
            {
                TotalIncome += Price;
                Count--;
                Console.WriteLine($"You sold 1 {Name}");
            }
            else
            {
                Console.WriteLine("Product Out of Stock. Come Later!");
            }
        }

        public void Info()
        {
            Console.WriteLine();
            Console.Write($"Product name - {Name}\nPrice - {Price}\nInStock - {Count}\nTotalIncome from Product - {TotalIncome} ");
        }
    }
}
