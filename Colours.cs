using System;

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
    } 
}
