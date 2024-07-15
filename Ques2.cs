using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Car
    {
        public string brand;
        public string model;
        public int yom;
        public void details()
        {
            Console.WriteLine("Enter The Car Details:");
            Console.WriteLine("Enter The Car Brand:");
            brand = Console.ReadLine();
            Console.WriteLine("Enter The Car Model:");
            model = Console.ReadLine();
            Console.WriteLine("Enter The Car Year of Manufacturing"); 
            yom = int.Parse(Console.ReadLine());

        }
        public void write(string path)
        {
            string k = brand + " " + model + " " + yom; 
            File.WriteAllText(path, k);
            //File.Write
            string g=File.ReadAllText(path);
            Console.WriteLine(g);
        }

    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            Car cs = new Car();
            cs.details();
            string path = "D:\\.net\\dotnet\\mani";
            cs.write(path);
        }
    }
}
