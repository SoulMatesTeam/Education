using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicLibrary
{
    public class Pet: Alien
    {
        //fields
        private string _nickName;

        //properties
        public string NickName
        {
            get { return _nickName; }

            set { _nickName = value; }
        }

        //constructor
        public Pet() { }
        public Pet(string nickName)
        {
            NickName = nickName;
        }

        


    }
}
