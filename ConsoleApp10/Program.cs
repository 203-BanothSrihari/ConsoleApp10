using System;

namespace ConsoleApp10
{
    public interface Product1
    {
        void pro();
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product1 p;
            p = new ProductName();
            p.pro();
            p = new ProductPrice();
            p.pro();

        }
    }
}
