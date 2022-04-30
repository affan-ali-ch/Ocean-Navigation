using System;


namespace Ocean_Navigation.BL
{
    internal class Angle
    {
        private int degrees;
        private float minutes;
        private char direction;

        public Angle(int degrees, float minutes, char direction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = direction;
        }

        // GetDegrees
        public int GetDegrees()
        {
            return degrees;
        }

        // GetMinutes
        public float GetMinutes()
        {
            return minutes;
        }

        // GetDirection

        public char GetDirection()
        {
            return direction;
        }

        // SetDegrees
        public void SetDegrees(int degrees)
        {
            this.degrees = degrees;
        }

        // SetMinutes
        public void SetMinutes(float minutes)
        {
            this.minutes = minutes;
        }

        // SetDirection
        public void SetDirection(char direction)
        {
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
