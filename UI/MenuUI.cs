using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocean_Navigation.UI
{
    internal class MenuUI
    {
        public static void Header()
        {
            Console.WriteLine("  ***********************************");
            Console.WriteLine("  *     Ocean Navigation System     *");
            Console.WriteLine("  ***********************************");
            Console.WriteLine();

        }
        
        public static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Header();
            Console.WriteLine();


            Console.WriteLine();

            Console.WriteLine("  1. Add Ship");
            Console.WriteLine();
            Console.WriteLine("  2. View Ship Position");
            Console.WriteLine();

            Console.WriteLine("  3. View Ship Serial Number");
            Console.WriteLine();

            Console.WriteLine("  4. Change Ship Position");
            Console.WriteLine();

            Console.WriteLine("  5. Exit");
            Console.WriteLine();

            Console.WriteLine();
            Console.Write("  Enter Your Option: ");

            int option = 0;

            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Wrong Input !!");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("  Press Any Key to Continue...");
                Console.ReadKey();
            }

            return option;
        }
        
    }
}
