using System;
using Ocean_Navigation.BL;
using System.Collections.Generic;
using System.Linq;

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
                if (option == 2)
                {
                    ViewShipPosition();
                }
                if (option == 3)
                {
                    ViewSerialNumber();
                }
                if (option == 4)
                {
                    ChangeShipPositionMenu();
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
            Console.WriteLine();

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

            foreach (Ship s in ships)
            {
                if (s.SerialNumber == ShipSerialNumber)
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

            Console.Write("  Enter The Ship Latitude: ");
            string Latitude = Console.ReadLine();

            Console.WriteLine();

            Console.Write("  Enter The Ship Longitude: ");
            string Longitude = Console.ReadLine();

            Console.WriteLine();


            // extract the degree from Latitude
            string Lat_Degree = Latitude.Substring(0, Latitude.IndexOf('°'));
            // extract the minutes from Latitude
            string Lat_Minute = Latitude.Substring(Latitude.IndexOf('°') + 1, Latitude.IndexOf('\'') - Latitude.IndexOf('°') - 1);
            // extract the direction from latitude
            string Lat_Direction = Latitude.Substring(Latitude.IndexOf('\'') + 1, 1);

            // extract the degree from Longitude
            string Long_Degree = Longitude.Substring(0, Longitude.IndexOf('°'));
            // extract the minutes from Longitude
            string Long_Minute = Longitude.Substring(Longitude.IndexOf('°') + 1, Longitude.IndexOf('\'') - Longitude.IndexOf('°') - 1);
            // extract the direction from Longitude
            string Long_Direction = Longitude.Substring(Longitude.IndexOf('\'') + 1, 1);

            // convert the degree to int
            int Lat_Degree_Int = int.Parse(Lat_Degree);
            // convert the minutes to float
            float Lat_Minute_Float = float.Parse(Lat_Minute);
            // convert the direction to char
            char Lat_Direction_Char = char.Parse(Lat_Direction);

            // convert the degree to int
            int Long_Degree_Int = int.Parse(Long_Degree);
            // convert the minutes to float
            float Long_Minute_Float = float.Parse(Long_Minute);
            // convert the direction to char
            char Long_Direction_Char = char.Parse(Long_Direction);


            // print all values
            //Console.WriteLine("  Latitude: " + Lat_Degree_Int + "°" + Lat_Minute_Float + "'" + Lat_Direction_Char);
            //Console.WriteLine("  Longitude: " + Long_Degree_Int + "°" + Long_Minute_Float + "'" + Long_Direction_Char);

            Angle Latitude_Angle = new Angle(Lat_Degree_Int, Lat_Minute_Float, Lat_Direction_Char);
            Angle Longitude_Angle = new Angle(Long_Degree_Int, Long_Minute_Float, Long_Direction_Char);

            foreach (Ship s in ships)
            {
                if (s.Latitude.degrees == Latitude_Angle.degrees && s.Latitude.minutes == Latitude_Angle.minutes && s.Latitude.direction == Latitude_Angle.direction && s.Longitude.degrees == Longitude_Angle.degrees && s.Longitude.minutes == Longitude_Angle.minutes && s.Longitude.direction == Longitude_Angle.direction)
                {
                    Console.WriteLine();
                    Console.WriteLine("  Ship Serial Number: " + s.SerialNumber);
                    Console.WriteLine();
                }

            }

            Console.WriteLine();

            Console.WriteLine();
            Console.Write("  Press Any Key to Continue...");
            Console.ReadKey();
        }

        // change ship position
        static void ChangeShipPositionMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Header();
            Console.WriteLine();

            Console.WriteLine("  Main Menu > Change Ship Position > ");
            Console.WriteLine("  -------------------------------------");

            Console.WriteLine();

            Console.Write("  Enter Ship Serial Number to Change its Position: ");
            string ShipSerialNumber = Console.ReadLine();

            Console.WriteLine();

            var s = from ship in ships
                        where ship.SerialNumber == ShipSerialNumber
                        select ship;
            
            if (s.Count() == 0)
            {
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("  Ship Not Found !!");
                Console.ResetColor();
                Console.WriteLine();
                Console.Write("  Press Any Key to Continue...");
                Console.ReadKey();
                return;
            }

            // take latitude inputs
            Console.WriteLine("  Enter Ship Latitude  \x2193  ");
            Console.Write("  Enter Latitude Degree: ");
            string Lat_Degree = Console.ReadLine();
            Console.Write("  Enter Latitude Minutes: ");
            string Lat_Minute = Console.ReadLine();
            Console.Write("  Enter Latitude Direction: ");
            string Lat_Direction = Console.ReadLine();

            // take longitude input
            Console.WriteLine("  Enter Ship Longitude  \x2193  ");
            Console.Write("  Enter Longitude Degree: ");
            string Long_Degree = Console.ReadLine();
            Console.Write("  Enter Longitude Minutes: ");
            string Long_Minute = Console.ReadLine();
            Console.Write("  Enter Longitude Direction: ");
            string Long_Direction = Console.ReadLine();

            // convert the degree to int
            int Lat_Degree_Int = int.Parse(Lat_Degree);
            // convert the minutes to float
            float Lat_Minute_Float = float.Parse(Lat_Minute);
            // convert the direction to char
            char Lat_Direction_Char = char.Parse(Lat_Direction);

            // convert the degree to int
            int Long_Degree_Int = int.Parse(Long_Degree);
            // convert the minutes to float
            float Long_Minute_Float = float.Parse(Long_Minute);
            // convert the direction to char
            char Long_Direction_Char = char.Parse(Long_Direction);

            // create new angle
            Angle Latitude_Angle = new Angle(Lat_Degree_Int, Lat_Minute_Float, Lat_Direction_Char);
            Angle Longitude_Angle = new Angle(Long_Degree_Int, Long_Minute_Float, Long_Direction_Char);

            // change the ship position
            s.First().Latitude = Latitude_Angle;
            s.First().Longitude = Longitude_Angle;
            
            


            Console.WriteLine();

            Console.WriteLine();
            Console.Write("  Press Any Key to Continue...");
            Console.ReadKey();

        }


        


    }

    
    
}