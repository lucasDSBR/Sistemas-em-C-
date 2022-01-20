using System;
using extencions.Extencions;
namespace extencions
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 11, 16, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());
        }
    }
}
