using MagicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicClassPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The following is happenning, when you're thinking about classes too much...:)");

            Soulmate Soulmate = new Soulmate();
            Console.Write("Please enter your name: ");
            Soulmate.Name = Console.ReadLine();
            Console.WriteLine();

            Soulmate.Greeting();
            Soulmate.ImagineHouse();

            House SoulmatesHouse = new House();
            SoulmatesHouse.AskFloorQuantity();
            SoulmatesHouse.Floors = int.Parse(Console.ReadLine());
            SoulmatesHouse.AskRoomsQuantity();
            SoulmatesHouse.Rooms = int.Parse(Console.ReadLine());
            SoulmatesHouse.AskLocation();
            SoulmatesHouse.Location = Console.ReadLine();
            SoulmatesHouse.IfToHavePetAlien();
            SoulmatesHouse.HouseDescription();
            SoulmatesHouse.EnterOwnersRoom();
            Soulmate.GettingHigh();
            Soulmate.Hugs();
            Console.WriteLine();
            Console.Write("What else you can do here, in this dream? Let's choose the option: 'listen to music', 'walk in the forest', 'swim in the sea' ");
            string activity = Console.ReadLine();
            Activity.Act(activity);
            Console.WriteLine();
            Soulmate.ReturnToReality();

            Console.ReadLine();
        }
    }
}
