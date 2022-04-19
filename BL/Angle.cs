using System;


namespace Ocean_Navigation.BL
{
    internal class Angle
    {
        public int degrees;
        public float minutes;
        public char direction;

        public Angle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        public void ChangeAngle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        public void Print()
        {
            Console.WriteLine("{0}° {1}' {2}", degrees, minutes, direction);
        }
    }
}
