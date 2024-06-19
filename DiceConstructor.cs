using System;

namespace DiceThrowing{
    class Die{
    const int height=8;
    const int width=16;
        ///probably array[,]?
        public static void DieConstructor(){
            
            string[,] die=new string[height,width];    ///i = row, j = column
            object[] dice=new object[6];
            ConstructDie(die);
        }
        static void PrintDie(string[,] array,int height=8,int width=16){
            for (int i=0;i<height;i++){
                for (int j=0;j<width;j++){
                    System.Console.Write(array[i,j]);
                }
                System.Console.WriteLine();
            }
        }
        public static void ConstructDie(string[,] die,int height=8,int width=16){
            for (int i=0;i<height;i++){
                for (int j=0;j<width;j++){
                    ConstructDie_Conditions(i,j,ref die);
                }
            }
            PrintDie(die);
            
            static void ConstructDie_Conditions(int i, int j,ref string[,] array,int height=8,int width=16){
                if(j==0||j==width-1){
                    if (i==0){
                        array[i,j]=" ";
                    }
                    else{
                        array[i,j]="|";
                    }
                }
                else{                                       //everything between leftmost and rightmost
                    if (i==0||i==height-1){
                        array[i,j]="_";
                    }
                    else{
                        array[i,j]=" ";
                    }
                }
            }
        }

    }
}
