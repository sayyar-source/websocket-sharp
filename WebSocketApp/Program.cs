using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace WebSocketApp
{
    class Program
    {
        public static int Port =6001;
        public static P2PServer server = null;
        public static P2PClient client = new P2PClient();
        public static string name = "Muhammed";
        static void Main(string[] args)
        {
            server = new P2PServer();
            server.start();
            Console.WriteLine($"Current user is {name}");
            Console.WriteLine("=========================");
            Console.WriteLine("1. Connect to a server");
           
           
            Console.WriteLine("2. Exit");
            Console.WriteLine("=========================");
            int selection = 0;
            while(selection!=2)
            {
                switch (selection)
                {
                    case 1:
                        Console.WriteLine("Please enter the server URL");
                        string serverURL = Console.ReadLine();
                        client.Connect($"{serverURL}/service");
                        break;
                }
                Console.WriteLine("Please select an action");
                string action = Console.ReadLine();
                selection = int.Parse(action);
            }
           

           
        }
    }
}
