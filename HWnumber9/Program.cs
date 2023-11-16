using HWnumber9.Classes;
using System;

namespace HWnumber9
{
    internal class Program
    {
        static void Lab_UPR_10_1()
        {
            ACipher cipher = new ACipher();

            string encoded = cipher.Encode("DungeonMaster");
            Console.WriteLine(encoded);
            string decoded = cipher.Decode(encoded);
            Console.WriteLine(decoded);
        }

        static void Lab_DZ_10_1()
        {
            Circle damnCircle = new Circle();
            Rectangle damnRectangle = new Rectangle();
        }
        static void Main(string[] args)
        {
            Lab_UPR_10_1();
            Lab_DZ_10_1();

            Console.ReadKey();
        }
    }
}
