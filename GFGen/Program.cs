using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFGen
{
    class Program
    {
        static void Main(string[] args)
        {
            string title = @"
  ██████╗ ███████╗     ██████╗ ███████╗███╗   ██╗███████╗██████╗  █████╗ ████████╗ ██████╗ ██████╗ 
 ██╔════╝ ██╔════╝    ██╔════╝ ██╔════╝████╗  ██║██╔════╝██╔══██╗██╔══██╗╚══██╔══╝██╔═══██╗██╔══██╗
 ██║  ███╗█████╗      ██║  ███╗█████╗  ██╔██╗ ██║█████╗  ██████╔╝███████║   ██║   ██║   ██║██████╔╝
 ██║   ██║██╔══╝      ██║   ██║██╔══╝  ██║╚██╗██║██╔══╝  ██╔══██╗██╔══██║   ██║   ██║   ██║██╔══██╗
 ╚██████╔╝██║         ╚██████╔╝███████╗██║ ╚████║███████╗██║  ██║██║  ██║   ██║   ╚██████╔╝██║  ██║
  ╚═════╝ ╚═╝          ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚══════╝╚═╝  ╚═╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝
";
            string[] names = { "Abigail", "Ariana ", "Alexandra", "Adriana", "Addison", "Betty", "Bella", "Bertha", "Britney", "Brianna", "Caitlin", "Carly", "Caroline", "Crystal", "Courtney", "Daisy", "Darcy", "Dixie", "Denise", "I hate black people", "Emilia", "Evie", "Elizabeth", "Ella", "Emma", "Felisha", "Franky", "Fatima", "Fiona", "Fanny", "Gabby", "Gabriela", "Gwen", "Grace", "Georgia", "Hailey", "Harmony", "Hannah", "Heather", "Holly", "Imogen", "Isabelle", "Ivy", "Isla", "Isabella", "Jennifer", "Jaquelyn", "Jasmine", "Jemima", "Josie", "Kamilla", "Kacey", "Kaitlyn", "Kylie", "Kim", "Lorena", "Libby", "Layla", "Liana", "Leah", "Maddie", "Mabel", "May", "Melissa", "Marcella", "Natalie", "Nicola", "Nora", "Nicky", "Nia", "Olivia", "Ophelia", "Opal", "October", "Olla", "Penelope", "Piper", "Phoebe", "Paige", "Poppy", "Quinn", "Riley", "Rose", "Roxy", "Rachel", "Rebecca", "Sophie", "Sarah", "Scarlett", "Summer", "Sienna", "Taylor", "Trinity (OMG TRINITY?)", "Tessa", "Tara", "Tiffany", "Violet", "Vanessa", "Victoria", "Valerie", "Willow", "Wynter", "Yasmine", "Zoey", "Zara", "tijana", "Red&White#0666", "zn5p#0802", "stars#1111", "emoo#5270", "snowy#1337" };
            Console.Title = "girlfriend genrator";
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press ENTER to start generating");
            Console.ReadLine();
            int index = 0;
            bool stop = false;
            while (!stop)
            {
                index++;
                Random rand = new Random();
                int i = rand.Next(names.Length);
                Console.ForegroundColor = ConsoleColor.Red;
                if (index > 500)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("phil [needs head]\n");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("(phil's discord is phil#4321 add him pls)");
                    Console.ReadLine();
                    System.Diagnostics.Process.Start(System.AppDomain.CurrentDomain.FriendlyName);

                    Environment.Exit(0);
                }
                else
                {

                    Console.WriteLine($"{names[i]} " + "[taken]");
                    System.Threading.Thread.Sleep(25);
                }
            }
        }
    }
}