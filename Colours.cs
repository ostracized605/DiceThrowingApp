using System;
using System.Threading;

namespace DiceThrowing{
    public static class Colours{

        private static Type enumType=typeof(ConsoleColor);
        private static ConsoleColor[] colours=new ConsoleColor[16];
        public static ConsoleColor[] Clrs(){
            if (enumType.IsEnum){
                AssignColour(colours);
            }
            return colours;
        }
        
        static void AssignColour(ConsoleColor[] array){
            for (int i=0;i<array.Length;i++){
                ConsoleColor color=(ConsoleColor)Enum.ToObject(typeof(ConsoleColor),i);     ///(ConsoleColor)i works as well
                array[i]=color;
            }
        }

        public static void ChangeColour(ConsoleColor[] array){
            int counter=0;
            int test=0;
            while(true){
                Console.ForegroundColor=array[counter];
                System.Console.Write("FFFFFF");
                test++;
                if(counter==15){
                    counter=0;
                }else{
                counter++;
                }
                Thread.Sleep(150);
                Console.Clear();
                if (test==100){
                    break;
                }
            }
        }

        public static void ChangeColourFG(ConsoleColor[] array,ref int counter){
            if (counter>=15){
                counter=0;
            }
            Console.ForegroundColor=array[counter];
        }
        public static void ChangeColourFGRandom(ConsoleColor[] array, int counter){
            if (counter>=15){
                counter=0;
            }
            Console.ForegroundColor=array[counter];
        }

        public static void ChangeColourBG(ConsoleColor[] array,int counter){
            if (counter>=15){
                counter=0;
            }
            Console.BackgroundColor=array[counter];
        }

        public static void TestDoTheThing(int height,int width,int numberOfDice){
            for (int i=0;i<height;i++){
                for (int j=0;j<numberOfDice;j++){
                    for (int k=0;k<width;k++){

                    }
                }
            }
        }
    } 
}
