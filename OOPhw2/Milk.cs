using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPhw2
{
    internal class Milk:Product
    {
        public double Volume;
        public double FatRate;


        public Milk(string name,double price,int count,double volume,double fatrate) : base(name, price, count)
        {
            Volume = volume;
            FatRate = fatrate;
        }

        public void Info()
        {
            base.Info();
            Console.WriteLine($"\nVolume- {Volume}\nFatrate - {FatRate}\n");
        }
    }
}
