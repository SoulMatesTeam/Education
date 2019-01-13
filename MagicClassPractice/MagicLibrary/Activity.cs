using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLibrary
{
    public static class Activity
    {
        //статический класс, исп без создания экземпляра класса

        public static void Act(string activity)
        {
            switch (activity)
            {
                case "listen to music":
                    Console.WriteLine("What kind of music do you want to listen?");
                    Console.Write("Choose one: 'Dark psy', 'Chill', 'Psy rock', 'Psy juzz'");
                    string musicType = Console.ReadLine();
                    Music(musicType);
                    break;
                case "walk in the forest":
                    Console.WriteLine("Imagine you're walking in a beautiful forest, listening to sound of trees. They are talking to you... What are they saying? ");
                    break;
                case "swim in the sea":
                    Console.WriteLine("You're coming up to the sea. Waves are softly tickling your feets. And you're diving into the water, it's warm but refreshing. Taste the moment!");
                    break;
                default:
                    break;

            }
        }

        public static void Music(string musicType)
        {
            switch (musicType)
            {
                case "Dark psy":
                    Console.WriteLine("Try this: Hishiryo - What' ur Dope");
                    break;
                case "Chill":
                    Console.WriteLine("Try this: Lab's cloud - Found the way");
                    break;
                case "Psy rock":
                    Console.WriteLine("Try this: Tame impala - Let it happen");
                    break;
                case "Psy juzz":
                    Console.WriteLine("Try this: Atomic simao - Sun in everyone");
                    break;
                default:
                    break;
            }
        }
    }
}
