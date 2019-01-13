using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLibrary
{
    public class Soulmate : Humanoid
    {
        //поля
        private string _nickName;
        public string[] _kotiki = {"MDMA", "Bublik", "LSD", "Shrooms", "Weed"};

        //конструктор, перегрузка конструктора
        public Soulmate() { }

        public Soulmate(string name)
        {
            _name = name;
        }

        public Soulmate(string name, string nickName)
        {
            _name = name;
            _nickName = nickName;
        }

        //методы
        public void ImagineHouse()
        {
            Console.WriteLine(" Let's imagine perfect house to live in.");
            
        }

        public void GettingHigh()
        {
            Console.Write("Which drug do you want to take? ");
            for (int i = 0; i < _kotiki.Length; i++)
            {
                Console.Write($"'{_kotiki[i]}' ");
            }
            string kotik = Console.ReadLine();
            switch (kotik)
            {
                case "MDMA":
                    Console.WriteLine("All colors and lights become brighter. You feel pleasand shiver all over the body. And...");
                    break;
                case "Bublik":
                    Console.WriteLine("Whatever... you are definitely streamlet. And.. ");
                    break;
                case "LSD":
                    Console.WriteLine("Wait... The wall is so beautiful, all the things surrounds you are so interesting. Hm.. There are so many little element. And..");
                    break;
                case "Shrooms":
                    Console.WriteLine("What a wonderful view!!! It's the best place in the world! And...");
                    break;
                case "Weed":
                    Console.WriteLine("You're sitting in a cosy armchair on the balcony with joint and totaly relaxing. And...");
                    break;
                default:
                    break;

            }
        }

        public void Hugs()
        {
            Console.Write("And now... You are definitely need HUGS)))). Who do you want have near? ");
            string personToHug = Console.ReadLine();
            Console.WriteLine($"Yeeahh! Heart to heart hugs with {personToHug}. Now it's time to be happy!");
        }

        public void ReturnToReality()
        {
            Console.WriteLine("Whatever.. Everything is classes.)");
        }











    }
}
