using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLSProject
{
    public class Player
    {
        // member variables (What does the class HAVE? The class HAS...)
        public string name;
        public string gesture;
        public int score;

        //constructor (unique methods/functions) - declaring a variable scoped to the constructor. Set up any default values (if they make sense)
        public Player(string name, string gesture, int score) //
        {
            this.name = name;
            this.gesture = gesture;
            this.score = score;
        }

        //member methods - actions that can be performed with the object (What CAN the object do? The object CAN...)
        public string ChooseGesture();
        {
                Console.WriteLine("You chose " + "" + gesture ".");
        }
    }
}
