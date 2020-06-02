using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace E_Book_Library
{
    class Profile
    {
        private string name;
        public gender Gender;
        public string NumberOfBooksOwned(int Number)
        {
            if (Number == 0)
                return "There are No Books in The Library";
            else
                return ("You ,"+name+" have " + Number + " Number Of Books");
        }
        public Profile()
        {
           
        }
         public gender Sex(gender mySex)
        {
            if (mySex == gender.Male)
                Gender = gender.Male;
            else if (mySex == gender.Female)
                Gender = gender.Female;
            else
                Gender = gender.DontKnow;
            return mySex;
        }
        public string UserName(string Name)
        {
                return name = Name;
        }
    }
    enum gender
    {
        Male,
        Female,
        DontKnow
    }
}
