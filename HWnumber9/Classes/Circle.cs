using System;

namespace HWnumber9.Classes
{
    internal class Circle : Point
    {
        string circle { get; set; }

        /// <summary>
        /// Метод для вычсиления площади круга
        /// </summary>
        public void CountArea()
        {
            double radius = 5;
            double area = Math.PI * Math.Pow(radius, 2);
        }
    }
}
