using System;
using System.Reflection;

namespace DiceThrowing{
    class Die{
        const int height=8;
        const int width=16;
        private delegate void GeneralDieConstructCondition(int i, int j,ref string[,] array,int height=8,int width=16);
        private delegate void DieConstructCondition(int i, int j,int x, string[,] array,int height=8,int width=16);
        ///probably array[,]?
        public static void DieConstructor(){
            
            string[,] die=new string[height,width];    ///i = row, j = column
            object[] dice=new object[6];
            
            ConstructDie(die,dice);
        }
        
        public static void ConstructDie(string[,] die,object[] dice,int height=8,int width=16){
            ConstructLoop(DieConstructorConditions.ConstructDie_GeneralConditions,die);
            
            for (int i=0;i<6;i++){
                    string[,] array=(string[,])die.Clone();
                    dice[i]=ConstructLoop_Numbers(DieConstructorConditions.ConstructDie_Conditions,array,i+1);
                }
            PrintDice(dice);
        }


        static void ConstructLoop(GeneralDieConstructCondition method,string[,] array,int height=8,int width=16){
            for (int i=0;i<height;i++){
                for (int j=0;j<width;j++){
                    method(i, j,ref array);
                }
            }
        }
        static object ConstructLoop_Numbers(DieConstructCondition method,string[,] array,int x,int height=8,int width=16){
            //string[,] array1=array;
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
        static void PrintDice(object[] array,int height=8,int width=16){
            for(int i=0;i<6;i++){
                System.Console.WriteLine();
                string[,] die=(string[,])array[i];
                PrintDie(die);
            } 
        }
    }
}
