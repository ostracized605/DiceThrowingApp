using System;
using System.Collections.Generic;

namespace DiceThrowing{
    class Project{
        public static Random r=new Random();
        static void Main(){
            //Define color to have every one of 16 colours.
            ConsoleColor[] color=new ConsoleColor[16];
            color=Colours.Clrs();
            Die.DieConstructor();
        }
    }
}
        