using System;
using System.Reflection;

namespace DiceThrowing{
    class Die{
        public const int height=8;
        public const int width=16;
        internal static object[] dice=new object[6];

        private delegate void GeneralDieConstructCondition(int i, int j,ref string[,] array,int height=8,int width=16);
        private delegate void DieConstructCondition(int i, int j,int x, string[,] array,int height=8,int width=16);
        public static void DieConstructor(ref object[] dice){
            string[,] die=new string[height,width];    ///i = row, j = column

            ConstructDie(die,dice);
        }
        
        static void ConstructDie(string[,] die,object[] dice,int height=8,int width=16){
            ConstructLoop(DieConstructorConditions.ConstructDie_GeneralConditions,die);
            
            for (int i=0;i<6;i++){
                    string[,] array=(string[,])die.Clone();
                    dice[i]=ConstructLoop_Numbers(DieConstructorConditions.ConstructDie_Conditions,array,i+1);
                }
        }


        static void ConstructLoop(GeneralDieConstructCondition method,string[,] array,int height=8,int width=16){
            for (int i=0;i<height;i++){
                for (int j=0;j<width;j++){
                    method(i, j,ref array);
                }
            }
        }
        static object ConstructLoop_Numbers(DieConstructCondition method,string[,] array,int x,int height=8,int width=16){
            for (int i=2;i<height-1;i++){
                for (int j=3;j<width-5;j++){
                    method(i, j,x, array);
                }
            }
            return array;
        }
        static void PrintDie(string[,] array,int height=8,int width=16){
            for (int i=0;i<height;i++){
                for (int j=0;j<width;j++){
                    System.Console.Write(array[i,j]);
                }
                System.Console.WriteLine();
            }
        }

        static void PrintDie1(string[,] array,int numberOfDice,int height=8,int width=16){
            for (int i=0;i<height;i++){                 //rows
                for (int j=0;j<numberOfDice;j++){        //n=2
                    for(int k=0;k<width;k++){            //columns
                    System.Console.Write(array[i,j]);
                    }
                    Console.Write("   ");
                }
                System.Console.WriteLine();
            }
        }

        internal static void PrintDice(object[] array,int height=8,int width=16){
            for(int i=0;i<6;i++){
                System.Console.WriteLine();
                string[,] die=(string[,])array[i];
                PrintDie(die);
            } 
        }
    }
}
