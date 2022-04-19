using System;


namespace Ocean_Navigation.BL
{
    internal class Ship
    {
        public string SerialNumber;
        public Angle Latitude;
        public Angle Longitude;

        public Ship(string serialNumber, Angle latitude, Angle longitude)
        {
            SerialNumber = serialNumber;
            Latitude = latitude;
            Longitude = longitude;
        }

        public void PrintPosition()
        {
            Console.WriteLine("  Ship is at {0}° {1}' {2} and  {3}° {4}' {5}", Latitude.degrees, Latitude.minutes, Latitude.direction, Longitude.degrees, Longitude.minutes, Longitude.direction);
        }

        public void PrintSerial()
        {
            Console.WriteLine("Ship's serial number is {0}", SerialNumber);
        }
    }
}
