using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhw2
{
    internal class Book
    {
        private string _name;
        private int _pageCount;


        public Book(string name,int pageCount)
        {
            Name = name;
            PageCount = pageCount;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                while (true)
                {
                    if (value?.Length > 3)
                    {
                        _name = value;
                        break;
                    }
                    else
                    {
                        Console.Write("kitabin adini duzgun daxil edin: ");
                        value = Console.ReadLine()??"";
                        Console.WriteLine();
                    }
                }
                
            }

        }

        public int PageCount
        {
            get { return _pageCount; }
            set
            {
                while (true)
                {
                    if (value >= 10)
                    {
                        _pageCount = value;
                        break;
                    }
                    else
                    {
                        Console.Write("Kitabin vereg sayini duzgun daxil edin: ");
                        int.TryParse(Console.ReadLine(), out value);
                        Console.WriteLine();
                    }
                }
                
            }
        }

        public void Info()
        {
            Console.Write($"Book name - {Name}\nBook pages - {PageCount}\n");
        }

        
    }
}
