using System;

namespace DiceThrowing{
    internal class DieConstructorConditions{

        internal static void ConstructDie_GeneralConditions(int i, int j,ref string[,] array,int height=8,int width=16){
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

        internal static void ConstructDie_Conditions1(int i, int j,ref string[,] array,int height=8,int width=16){
            if (i==2||i==4||i==5){
                if(j>=7&&j<=8){
                    array[i,j]="0";
                }
            }
            if(i==3){
                if(j>=5&&j<=8){
                    array[i,j]="0";
                }
            }
            if(i==6){
                if(j>=5&&j<=10){
                    array[i,j]="0";
                }
            }
        }
        
        internal static void ConstructDie_Conditions2(int i, int j,ref string[,] array,int height=8,int width=16){

            switch(i){
                case 2:
                    if(j>=6&&j<=9){
                    array[i,j]="0";
                }
                break;
                case 3:
                    if (j==5||j==6||j==9||j==10){
                    array[i,j]="0";
                }
                break;
                case 4:
                    if(j==8||j==9){
                    array[i,j]="0";
                }
                break;
                case 5:
                    if(j==7||j==8){
                    array[i,j]="0";
                }
                break;
                case 6:
                    if(j>=5&&j<=10){
                    array[i,j]="0";
                }
                break;
            }
        }

        internal static void ConstructDie_Conditions3(int i, int j,ref string[,] array,int height=8,int width=16){
            if(i==2||i==6){
                if(j>=6&&j<=9){
                    array[i,j]="0";
                }
            }
            else if(i==3||i==5){
                if(j==5||j==6||j==9||j==10){
                    array[i,j]="0";
                }
            }
            else if(i==4){
                if(j>=8&&j<=10){
                    array[i,j]="0";
                }
            }
        }
        internal static void ConstructDie_Conditions4(int i, int j,ref string[,] array,int height=8,int width=16){
            if(i==2||i==3){
                if(j==5||j==6||j==9||j==10){
                    array[i,j]="0";
                }
            }else if(i==4){
                if(j>=5&&j<=10){
                    array[i,j]="0";
                }
            }
            else if(i==5||i==6){
                if (j==9||j==10){
                    array[i,j]="0";
                }
            }
        }
        internal static void ConstructDie_Conditions5(int i, int j,ref string[,] array,int height=8,int width=16){
            if(i==2||i==4||i==6){
                if(j>=5&&j<=10){
                    array[i,j]="0";
                }
            }
            else if(i==3){
                if(j==5||j==6){
                    array[i,j]="0";
                }
            }
            else if(i==5){
                if(j==10){
                    array[i,j]="0";
                }
            }
        }
        internal static void ConstructDie_Conditions6(int i, int j,ref string[,] array,int height=8,int width=16){
            if(i==2){
                if(j==7||j==8){
                    array[i,j]="0";
                }
            }
            if(i==3){
                if(j==6||j==7){
                    array[i,j]="0";
                }
            }
            if(i==4||i==6){
                if(j>=5&&j<=9){
                    array[i,j]="0";
                }
            }
            if(i==5){
                if(j==4||j==5||j==10){
                    array[i,j]="0";
                }
            }
        }
    }
}