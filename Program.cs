using System;
using Ocean_Navigation.BL;
using System.Collections.Generic;

namespace Ocean_Navigation
{
    internal class Program
    {
        public static List<Ship> ships = new List<Ship>();
        
        static void Main()
        {
            while (true)
            {
                int option = MainMenu();

                if (option == 1)
                {
                    AddShip();
                }
                if(option == 2)
                {
                    ViewShipPosition();
                }
                if(option == 3)
                {
                    ViewSerialNumber();
                }
                if (option == 5)
                {
                    break;
                }
            }
        }


        static void Header()
        {
            Console.WriteLine("  ***********************************");
            Console.WriteLine("  *     Ocean Navigation System     *");
            Console.WriteLine("  ***********************************");

        }
        static int MainMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Header();
            Console.WriteLine();

            Console.WriteLine("  Main Menu > ");
            Console.WriteLine("  --------------");

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

        static void AddShip()
        {
            Console.Clear();
            Console.WriteLine();
            Header();
            Console.WriteLine();

            Console.WriteLine("  Main Menu > Add Ship > ");
            Console.WriteLine("  ------------------------");

            Console.WriteLine();

            Console.Write("  Enter Ship Serial Number: ");
            string SerialNumber = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("  Enter Ship Latitude  \x2193  ");

            Console.WriteLine();
            Console.Write("  Enter Latitude's Degree: ");
            int Lat_Degree;
            try
            {
                Lat_Degree = int.Parse(Console.ReadLine());
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
                return;
            }


            float Lat_Minute;
            
            Console.Write("  Enter Latitude's Minutes: ");
            try
            {
                Lat_Minute = float.Parse(Console.ReadLine());
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
                return;
            }
            
            Console.Write("  Enter Latitude's Direction: ");
            char Lat_Direction;
            try
            {
                Lat_Direction = char.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Wrong Input !!");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("  Press Any Key to Continue...");
                Console.ReadKey();
                return;
            }

            if (Lat_Direction != 'W' && Lat_Direction != 'E' && Lat_Direction != 'S' && Lat_Direction != 'N')
            {
                if (Lat_Direction != 'w' && Lat_Direction != 'e' && Lat_Direction != 's' && Lat_Direction != 'n')
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Wrong Input !!");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("  Press Any Key to Continue...");
                    Console.ReadKey();
                    return;
                }
            }


            Console.WriteLine("\n");

            Console.WriteLine("  Enter Ship Longitude  \x2193 ");
            Console.WriteLine();

            Console.Write("  Enter Longitude's Degree: ");
            int Long_Degree;
            try
            {
                Long_Degree = int.Parse(Console.ReadLine());
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
                return;
            }


            Console.Write("  Enter Longitude's Minutes: ");
            float Long_Minute;
            try
            {
                Long_Minute = float.Parse(Console.ReadLine());
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
                return;
            }


            Console.Write("  Enter Longitude's Direction: ");

            char Long_Direction;
            try
            {
                Long_Direction = char.Parse(Console.ReadLine());
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
                return;
            }

            if (Long_Direction != 'W' && Long_Direction != 'E' && Long_Direction != 'S' && Long_Direction != 'N')
            {
                if (Long_Direction != 'w' && Long_Direction != 'e' && Long_Direction != 's' && Long_Direction != 'n')
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Wrong Input !!");
                    Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("  Press Any Key to Continue...");
                    Console.ReadKey();
                    return;
                }
            }


            Angle Latitude = new Angle(Lat_Degree, Lat_Minute, Lat_Direction);
            Angle Longitude = new Angle(Long_Degree, Long_Minute, Long_Direction);
            Ship ship = new Ship(SerialNumber, Latitude, Longitude);

            ships.Add(ship);
            
            Console.WriteLine();
            Console.WriteLine("  Ship Added Successfully !!");
            Console.WriteLine();
            Console.Write("  Press Any Key to Continue...");
            Console.ReadKey();

        }


        static void ViewShipPosition()
        {
            Console.Clear();
            Console.WriteLine();
            Header();
            Console.WriteLine();

            Console.WriteLine("  Main Menu > View Ship > ");
            Console.WriteLine("  ------------------------");

            Console.WriteLine();

            Console.Write("  Enter Ship Serial Number to Find its Position: ");
            string ShipSerialNumber = Console.ReadLine();

            Console.WriteLine();

            foreach(Ship s in ships)
            {
                if(s.SerialNumber == ShipSerialNumber)
                {
                    s.PrintPosition();
                }
            }
            Console.WriteLine();
            

            Console.WriteLine();
            Console.Write("  Press Any Key to Continue...");
            Console.ReadKey();

        }

        
        static void ViewSerialNumber()
        {
            Console.Clear();
            Console.WriteLine();
            Header();
            Console.WriteLine();

            Console.WriteLine("  Main Menu > View Serial Number > ");
            Console.WriteLine("  ----------------------------------");

            Console.WriteLine();

            Console.WriteLine("  Enter The Ship Latitude: ");
            string Latitude = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("  Enter The Ship Longitude: ");
            string Longitude = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine(Latitude.IndexOf('°'));


            Console.WriteLine();
            Console.Write("  Press Any Key to Continue...");
            Console.ReadKey();
        }
    }
}
