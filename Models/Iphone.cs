using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone_project.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string number, string model, string iMei, int memory) :
        base(number, model, iMei, memory)
        { }

        public override void InstallApp(List<string> apps)
        {
            Console.Clear();

            Console.WriteLine("Installing apps from AppleStore: ");
            for (var i = 0; i < apps.Capacity; i++)
            {
                Console.Write($"{i + 1} - {apps[i]} | ");
            }
            Console.Write("\n");

            string option = Console.ReadLine();
            Console.WriteLine("\n Installing --> " + apps[Convert.ToInt32(option) - 1]);
            Thread.Sleep(2000);

            Console.WriteLine($"{apps[Convert.ToInt32(option) - 1]} has been installed.");
            Thread.Sleep(2000);
        }
    }
}