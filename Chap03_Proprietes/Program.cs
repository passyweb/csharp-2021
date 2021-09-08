using System;

namespace Chap03_Proprietes
{
    class Program
    {
        static void Main(string[] args)
        {
            Product item = new Product();
            var item2 = new Product();
            Product item3 = new();

            item.Name = " Stylo";
            var s = item.Name;
        }
    }
}
