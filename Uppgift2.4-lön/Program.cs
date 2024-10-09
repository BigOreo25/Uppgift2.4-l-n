using System;
namespace hoppa
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Nu får du chansen att få veta medellönen på dina anställda! Säg Bänkts lön.");
            int blön = int.Parse(Console.ReadLine());
            Console.WriteLine("bra, ge mig Svens lön nu");
            int slön = int.Parse(Console.ReadLine());
            Console.WriteLine("Finfint. Nu vill jag ha Gunnars (fina) lön");
            int glön = int.Parse(Console.ReadLine());
            int summami = (blön + slön + glön) / 3;
            Console.WriteLine("här är medellönen: " + summami + "kr");

        }

    }

}