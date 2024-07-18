using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartPhone_project.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string number, string model, string iMei, int memory)
        {
            Number = number;
            Model = model;
            IMei = iMei;
            Memory = memory;
        }

        public string Number { get; set; }
        protected string Model { get; set; }
        protected string IMei { get; set; }
        protected int Memory { get; set; }

        public void Call(List<string> numbers) // Criar uma lista de numeros fakes para ligar
        {
            Console.Clear();

            Console.WriteLine("What number do you want to call?");

            for (var i = 0; i < numbers.Capacity; i++)
            {
                Console.Write($"{i + 1} - {numbers[i]} | ");
            }
            Console.Write("\n");

            string option = Console.ReadLine();
            Console.WriteLine("Calling to " + numbers[Convert.ToInt32(option) - 1]);
            Thread.Sleep(3000);

        }

        public void ReceiveCall()
        {
            Console.Clear();

            Console.WriteLine($"Receiving a call from 998607532 \n");
            Thread.Sleep(3000);
        }

        public abstract void InstallApp(List<string> apps);

        public void ShowDescription()
        {
            Console.Clear();

            Console.WriteLine($"Number: {Number} | Model: {Model} | IMei: {IMei} | Memory: {Memory}");
            Console.WriteLine($"Press enter to return...");
            Console.ReadKey();
        }
    }
}