using CarLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example01
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Car carInstance = new Car();
            carInstance.SetName("Resnick");
            int year = int.Parse(Console.ReadLine());
            carInstance.Year = year;
            Console.WriteLine(carInstance.Year);
        }
    }
}