using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLibrary
{
    public class Humanoid
    {
        //поля
        protected string _name;
        

        //свойства
        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        //автоматические свойства
        protected string Gender { get; set; }
        protected int Age { get; set; }

        //методы
        public void Greeting()
        {
            Console.WriteLine($"Hi, {Name}!");
        }
       
    }
}
