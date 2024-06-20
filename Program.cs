using System;
using System.Collections.Generic;

namespace DiceThrowing{
    class Project{
        
        static void Main(){
            //Define color to have every one of 16 colours.
            ConsoleColor[] color=new ConsoleColor[16];
            color=Colours.Clrs();
            //Create 6 dice
            Die die=new Die();
            Die.DieConstructor(ref Die.dice);
            Game gm = new Game();
            //Enter the number of dice
            System.Console.WriteLine("How many dice do you want to throw? Max number is 3.");
            gm.DiceChosen=gm.Choosing();
            //Output result
            int[] array=gm.Throwing(gm.DiceChosen);
<<<<<<< HEAD
            Console.ReadLine();
=======
>>>>>>> 8fbfaf2b78fa8e8a8cd55ee107e7a934b29e1e8e
        }
    }
}
        