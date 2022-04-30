using System;
using Ocean_Navigation.BL;

namespace Ocean_Navigation.UI
{
    internal class ShipUI
    {
        public static void PrintPosition(Ship ship)
        {
            Console.WriteLine();
            Console.Write("  Ship is at {0}° {1}' {2}", ship.GetLatitude().GetDegrees(), ship.GetLatitude().GetMinutes(), ship.GetLatitude().GetDirection());
            Console.Write(" and ");
            Console.Write("{0}° {1}' {2}", ship.GetLongitude().GetDegrees(), ship.GetLongitude().GetMinutes(), ship.GetLongitude().GetDirection());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  Press Any Key to Continue...");
            Console.ReadKey();
        }

        public static void PrintSerial(Ship ship)
        {
            Console.WriteLine();
            Console.WriteLine("   Ship's serial number is {0}", ship.GetSerialNumber());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("  Press Any Key to Continue...");
            Console.ReadKey();
        }

        public static Ship AddShip()
        {
            Console.Clear();
            Console.WriteLine();
            MenuUI.Header();
            Console.WriteLine();

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
                return null;
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
                return null;
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
                return null;
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
                    return null;
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
                return null;
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
                return null;
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
                return null;
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
                    return null;
                }
            }


            Angle Latitude = new Angle(Lat_Degree, Lat_Minute, Lat_Direction);
            Angle Longitude = new Angle(Long_Degree, Long_Minute, Long_Direction);
            Ship ship = new Ship(SerialNumber, Latitude, Longitude);

            

            Console.WriteLine();
            Console.WriteLine("  Ship Added Successfully !!");
            Console.WriteLine();
            Console.Write("  Press Any Key to Continue...");
            Console.ReadKey();

            return ship;

        }

        public static Ship InputShipLogitudeAndLatitude()
        {
            Console.Clear();
            Console.WriteLine();
            MenuUI.Header();
            Console.WriteLine();

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


            Angle Latitude_Angle = new Angle(Lat_Degree_Int, Lat_Minute_Float, Lat_Direction_Char);
            Angle Longitude_Angle = new Angle(Long_Degree_Int, Long_Minute_Float, Long_Direction_Char);

            Ship ship = new Ship("", Latitude_Angle, Longitude_Angle);

            Console.WriteLine();
            return ship;
        }

        public static string InputSerialNumber()
        {
            Console.Clear();
            Console.WriteLine();
            MenuUI.Header();
            Console.WriteLine();

            Console.Write("  Enter Ship Serial Number to Find its Position: ");
            string ShipSerialNumber = Console.ReadLine();

            Console.WriteLine();

            return ShipSerialNumber;

        }
        
        public static void ShipNotFoundException()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("  Ship Not Found !!");
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("  Press Any Key to Continue...");
            Console.ReadKey();
        }

    }
}
