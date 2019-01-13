using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLibrary
{
    public class House
    {
        //fields
        private int _roomsQuantity;
        private int _floor;
        private string _location;
        private int _peopleLivingQuantity;
        private string[] _coolFeatures;
        public int NumberOfPets { get; set; }
        public Pet MyPetAlien;
        private string[] _locationOptions = { "in the forest", "near the sea", "in forest near the sea", "in the mountains" };

        //properties

        public string Location
        {
            get { return _location; }

            set { _location = value; }
        }

        public int Rooms
        {
            get { return _roomsQuantity; }

            set { _roomsQuantity = value; }
        }

        public int Floors
        {
            get { return _floor; }

            set { _floor = value; }
        }

        public int PeopleLiving
        {
            get { return _peopleLivingQuantity; }

            set {
                if (_peopleLivingQuantity > _roomsQuantity)
                {
                    Console.WriteLine("Your house doesn't have enough room for so many people.");
                }
                _peopleLivingQuantity = value; }
        }

        //constructors, constructors chain
        public House() { }
        public House(int floor, int roomsQuantity)
            : this(floor, roomsQuantity, "", 1) { }
        public House(int floors, int roomsQuantity, string location, int peopleLivingIn)
        {
            Floors = floors;
            Rooms = roomsQuantity;
            Location = location;
            PeopleLiving = peopleLivingIn;
        }

        //methods
        public void AskFloorQuantity()
        {
            Console.Write("How many floors has it? ");
        }

        public void AskRoomsQuantity()
        {
            Console.Write("How many rooms has it? ");
        }

        public void AskLocation()
        {
            Console.WriteLine("Choose location of the house: ");
            for (int i = 0; i < _locationOptions.Length; i++)
            {
                Console.Write($"'{_locationOptions[i]}' ");
            }
            Console.WriteLine();
            Console.Write("Enter location: ");

        }

        public void HouseDescription()
        {
            Console.WriteLine($"Great! Now, you are standing near the beautiful house {Location}, with {Floors} floors and {Rooms} rooms. Let's enter!");
        }

        public void EnterOwnersRoom()
        {
            Console.WriteLine($"You are entering your room. It's very cosy. There is soft sofa, balcony vith vonderfull view, all necessary things.");
            Console.WriteLine("Relaxing music is playing. And you're opening cupboard and find something interesting there...;) Hm... What about getting high... Why not? ");
        }

        public void IfToHavePetAlien()
        {
            Console.WriteLine("Do you want to have pet alien in your house? 'Yes'/'No' ");
            string toHavePet = Console.ReadLine();
            switch (toHavePet)
            {
                case "No":
                    break;
                case "Yes":
                    Console.Write("Enter name for your pet alien: ");
                    string petAlienName = Console.ReadLine();
                    MyPetAlien = new Pet(petAlienName);
                    Console.WriteLine();
                    Console.WriteLine($"Now {MyPetAlien.NickName} lives with you))");
                    break;
                default:
                    break;
            }
            
        }

        


    }
}
