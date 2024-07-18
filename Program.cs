

using SmartPhone_project.Models;

// List of number what you can call
List<string> numbersToCall = ["978722121", "999992222", "988887666"];
// List of apss for install
List<string> appsForInstall = ["WhatsApp", "Instagram", "Facebook"];

bool menuChoose = true;

while (menuChoose)
{
    Console.Clear();
    Console.WriteLine("Welcome, you bought a phone. Choose your phone: \n 1 - Nokia \n 2 - Iphone \n 3 - Exit");

    string option = Console.ReadLine();

    if (option == "1")
    {
        // Create a new instance for Smartphone like Nokia
        Smartphone nokia = new Nokia(number: "971009565", iMei: "12121212", model: "Type 1", memory: 128);

        bool menuNokia = true;
        while (menuNokia)
        {
            Console.Clear();

            Console.WriteLine($"Welcome to Nokia!");
            Thread.Sleep(1500);
            Console.WriteLine("1 - Call someone.");
            Console.WriteLine("2 - Receive a call.");
            Console.WriteLine("3 - Install a app.");
            Console.WriteLine("4 - Show phone descripitons.");
            Console.WriteLine("5 - Bye bye!!");

            switch (Console.ReadLine())
            {
                case "1":
                    nokia.Call(numbersToCall);
                    break;
                case "2":
                    nokia.ReceiveCall();
                    break;
                case "3":
                    nokia.InstallApp(appsForInstall);
                    break;
                case "4":
                    nokia.ShowDescription();
                    break;
                case "5":
                    menuNokia = false;
                    Thread.Sleep(1500);
                    break;
                default:
                    Console.WriteLine(" Something is going wrong! Sorry...");
                    break;
            }
        }
    }
    else if (option == "2")
    {
        Smartphone iphone = new Iphone(number: "996544321", iMei: "32323233", model: "15 Pro Max", memory: 512);

        bool menuIphone = true;
        while (menuIphone)
        {
            Console.Clear();

            Console.WriteLine($"Welcome to Iphone!");
            Thread.Sleep(1500);
            Console.WriteLine("1 - Call someone.");
            Console.WriteLine("2 - Receive a call.");
            Console.WriteLine("3 - Install a app.");
            Console.WriteLine("4 - Show phone descripitons.");
            Console.WriteLine("5 - Bye bye!!");

            switch (Console.ReadLine())
            {
                case "1":
                    iphone.Call(numbersToCall);
                    break;
                case "2":
                    iphone.ReceiveCall();
                    break;
                case "3":
                    iphone.InstallApp(appsForInstall);
                    break;
                case "4":
                    iphone.ShowDescription();
                    break;
                case "5":
                    menuIphone = false;
                    Thread.Sleep(1500);
                    break;
                default:
                    Console.WriteLine(" Something is going wrong! Sorry...");
                    break;
            }
        }
    }
    else if (option == "3")
    {
        menuChoose = false;
    }
    else
    {
        Console.WriteLine("You choose a invalid phone!");
    }
}