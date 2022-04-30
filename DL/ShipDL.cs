using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Ocean_Navigation.BL;

namespace Ocean_Navigation.DL
{
    internal class ShipDL
    {
        public static List<Ship> ships = new List<Ship>();

        public static void LoadDataFromTextFile(string path)
        {
            StreamReader file = new StreamReader(path);
            string line;
            while ( (line =  file.ReadLine()) != null)
            {
                string[] elements = line.Split(',');

                string SerialNumber = elements[0];
                string Latitude = elements[1];
                string Longitude = elements[2];

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

                Ship ship = new Ship(SerialNumber, Latitude_Angle, Longitude_Angle);

                ships.Add(ship);
                

            }
            file.Close();            
        }

        public static void SaveDataToTextFile(string path)
        {
            StreamWriter file = new StreamWriter(path, false);

            int counter = 0;
            foreach (Ship ship in ships)
            {
                if(counter != 0)
                {
                    file.WriteLine();
                }
                file.Write(ship.GetSerialNumber() + ",");
                file.Write(ship.GetLatitude().GetDegrees() + "°" + ship.GetLatitude().GetMinutes() + "'" + ship.GetLatitude().GetDirection() + ",");
                file.Write(ship.GetLongitude().GetDegrees() + "°" + ship.GetLongitude().GetMinutes() + "'" + ship.GetLongitude().GetDirection());
                counter++;
            }
            
            file.Flush();
            file.Close();
        }

        public static void AddShip(Ship ship)
        {
            ships.Add(ship);
        }

        public static Ship GetSerialNumber(Ship ship)
        {
            foreach (Ship s in ships)
            {
                if (s.GetLatitude().GetDegrees() == ship.GetLatitude().GetDegrees() 
                    && s.GetLatitude().GetMinutes() == ship.GetLatitude().GetMinutes() 
                    && s.GetLatitude().GetDirection() == ship.GetLatitude().GetDirection() 
                    && s.GetLongitude().GetDegrees() == ship.GetLongitude().GetDegrees() 
                    && s.GetLongitude().GetMinutes() == ship.GetLongitude().GetMinutes() 
                    && s.GetLongitude().GetDirection() == ship.GetLongitude().GetDirection())
                {
                    return s;
                }

            }
            return null;
        }

        public static Ship GetShipBySerialNumber(string SerialNumber)
        {
            foreach (Ship s in ships)
            {
                if (s.GetSerialNumber() == SerialNumber)
                {
                    return s;
                }
            }
            return null;
        }

    }
}
