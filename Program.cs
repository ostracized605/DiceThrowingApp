using System;
using System.Collections.Generic;

namespace DiceThrowing{
    class Project{
        public static Random r=new Random();
        static void Main(){
            //Define color to have every one of 16 colours.
            ConsoleColor[] color=new ConsoleColor[16];
            color=Colours.Clrs();
            //check if it works
            foreach(ConsoleColor item in color){
                System.Console.WriteLine(item);
            }
            Die.ConstructDie();
        }
        class Die{
            ///probably array[,]?
            static int height=8, width=16;
            public static void ConstructDie(){
                
                string[,] die=new string[height,width];    ///i = row, j = column
                object[] dice=new object[6];
                for (int i=0;i<height;i++){
                    System.Console.WriteLine();
                    for (int j=0;j<width;j++){
                        if(i==0){
                            if(j==0){
                                System.Console.Write(" ");
                            }
                            else if (j==width-1){                      
                            }
                            else{
                            System.Console.Write("_");
                            }
                        }
                        else if(j==0||j==width-1){
                            System.Console.Write("|");
                            
                        }
                        else if(i==height-1){
                                System.Console.Write("_");
                        }
                        else{
                            System.Console.Write(" ");
                        }

                    }
                    
                }
            }
        }
    }
}