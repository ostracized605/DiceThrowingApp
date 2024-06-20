using System;

namespace DiceThrowing{
    class Game{
        public static Random r=new Random();
        int numberOfDice;
        public int NumberOfDice{
            get{return numberOfDice;}
            set{
                if (value<=0){
                    numberOfDice=1;
                }
                else if (value>Constants.maxDice){
                numberOfDice=Constants.maxDice;    
                }
                else{
                numberOfDice=value;
                }
            }
        }
        public int Choosing(){
            while(true){
                try
                {
                    NumberOfDice=Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch(FormatException){
                    System.Console.WriteLine("Please only enter integer numbers!");
                }
                catch (System.Exception e)
                {
                    System.Console.WriteLine(e.Message);
                }
            }
            return NumberOfDice;
        }

        public int[] Throwing(int numberOfDice){
            AssignDieValue(numberOfDice,out int[] diceValues);
            PrintDice(r,Die.dice,numberOfDice,diceValues,Constants.height,Constants.width);
            CountDice(numberOfDice,diceValues,out int total);
            PrintResult(diceValues,total);
            return diceValues;
        }
        public void CountDice(int numberOfDice,int[] diceValues,out int total){
            total=0;
            for (int i=0;i<numberOfDice;i++){
                total+=diceValues[i]+1;
            }
            
        }

        void PrintResult(int[] diceValues,int total){
            if(numberOfDice<=1){
                Console.Write($"Your die is: {total+1}");
            }
            else{
                Console.Write("Your dice are: ");
                for (int i=0;i<numberOfDice;i++){
                    System.Console.Write(diceValues[i]+1+ " ");
                }
                System.Console.Write($"\nYour total is: {total}");
            }
        }        

        public void AssignDieValue(int numberOfDice,out int[] diceValues){
            diceValues=new int[numberOfDice];
            for (int i=0;i<numberOfDice;i++){
                diceValues[i]=r.Next(6);
            }
        }

        public void PointAtDieNumber(int[] diceValues,object[]dice,int i, int k,int j,int num,int count=0){
            
            string[,] die=(string[,])dice[diceValues[j+num]];
            Console.Write(die[i,k]);
        }

        public void PrintDice(Random r,object[] dice,int numberOfDice,int[] diceValues,int height,int width,int num=0){
            //PrintDiceLoop(r,dice,numberOfDice,diceValues,num,height,width);
            
            while(numberOfDice>5){
                
                num=numberOfDice-5;
                numberOfDice=5;
                PrintDice(r,dice,num,diceValues,height,width);
                //PrintDiceLoop(r,dice,numberOfDice,diceValues,num,height,width);
            }
            PrintDiceLoop(r,dice,numberOfDice,diceValues,num,height,width);
        }

        public void PrintDiceLoop(Random r,object[] dice,int numberOfDice,int[] diceValues,int num,int height,int width){
            
            for (int i=0;i<height;i++){                                                 
                for (int j=0;j<numberOfDice;j++){                                       
                    for (int k=0;k<width;k++){                                      
                        PointAtDieNumber(diceValues,dice,i,k,j,num);          
                    }
                    Console.Write("   ");
                }
                System.Console.WriteLine();
            }
        }
    }
}