using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacePracticeHFCSpg360
{

    class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            Console.WriteLine($"My name is {Name} and I'm {Height} inches tall.");          
        }//end TAY()

        public void Honk()
        {
            Console.WriteLine($"Honk! Honk!");
        }//end Honk()

        public string FunnyThingIHave
        {
            get { return "Oversized Pants"; }
        }

    }//end calss

    class Program
    {
        static void Main(string[] args)
        {
            TallGuy tallGuy = new TallGuy() { Height = 76, Name = "Jimmy" };
            tallGuy.TalkAboutYourself();
            Console.WriteLine($"The tall guy has {tallGuy.FunnyThingIHave}");
            tallGuy.Honk();
        }//end main
    }//end class
}//end namespace
