namespace HWnumber9.Classes
{
    internal class Rectangle : Point
    {
        string rectangle { get; set; }

        double a = 5;
        double b = 10;

        /// <summary>
        /// Метод для вычисления площади прямоугольника
        /// </summary>
        public void CountArea()
        {
            double area = a * b;
        }
    }
}
