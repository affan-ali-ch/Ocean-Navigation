using System;


namespace Ocean_Navigation.BL
{
    internal class Ship
    {
        private string SerialNumber;
        private Angle Latitude;
        private Angle Longitude;

        public Ship(string SerialNumber, Angle Latitude, Angle Longitude)
        {
            this.SerialNumber = SerialNumber;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
        }

        // getSerialNumber
        public string GetSerialNumber()
        {
            return SerialNumber;
        }

        // getLatitude
        public Angle GetLatitude()
        {
            return Latitude;
        }

        // getLongitude
        public Angle GetLongitude()
        {
            return Longitude;
        }

        // setSerialNumber
        public void SetSerialNumber(string SerialNumber)
        {
            this.SerialNumber = SerialNumber;
        }

        // setLatitude
        public void SetLatitude(Angle Latitude)
        {
            this.Latitude = Latitude;
        }

        // setLongitude
        public void SetLongitude(Angle Longitude)
        {
            this.Longitude = Longitude;
        }

        
    }
}
