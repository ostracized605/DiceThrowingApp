using System;
using System.Reflection;

namespace DiceThrowing{
    class Die{
        const int height=8;
        const int width=16;
        private delegate void GeneralDieConstructCondition(int i, int j,ref string[,] array,int height=8,int width=16);
        ///probably array[,]?
        public static void DieConstructor(){
            
            string[,] die=new string[height,width];    ///i = row, j = column
            object[] dice=new object[6];
            ConstructDie(die);
        }
        
        public static void ConstructDie(string[,] die,int height=8,int width=16){
            DieConstructorConditions DCC=new DieConstructorConditions();
            ConstructLoop(DieConstructorConditions.ConstructDie_GeneralConditions,die);
            ConstructLoop_Numbers(DieConstructorConditions.ConstructDie_Conditions6,die);

            PrintDie(die);

            static void ConstructLoop(GeneralDieConstructCondition method,string[,] array,int height=8,int width=16){
                for (int i=0;i<height;i++){
                    for (int j=0;j<width;j++){
                        method(i, j,ref array);
                    }
                }
            }
            static void ConstructLoop_Numbers(GeneralDieConstructCondition method,string[,] array,int height=8,int width=16){
                for (int i=2;i<height-1;i++){
                    for (int j=3;j<width-5;j++){
                        method(i, j,ref array);
                    }
                }
            }
        }
        static void PrintDie(string[,] array,int height=8,int width=16){
            for (int i=0;i<height;i++){
                for (int j=0;j<width;j++){
                    System.Console.Write(array[i,j]);
                }
                System.Console.WriteLine();
            }
        }

    }
}
