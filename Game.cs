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
                    if(i%5==0){
                        System.Console.WriteLine();
                    }
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

        public void PointAtDieNumber(int[] diceValues,object[]dice,int i, int k,int j,int count=0){ 
            
            string[,] die=(string[,])dice[diceValues[j+count*5]];
            Console.Write(die[i,k]);
        }

        public void PrintDice(Random r,object[] dice,int numberOfDice,int[] diceValues,int height,int width, 
        int count=0,int temp=0 ){
            while (numberOfDice>5){
                count++;
                numberOfDice-=5;
            }
            int tempCount=0;
            if (count>0&&numberOfDice<5){
                tempCount=count;
                temp=numberOfDice;
                numberOfDice=5;
                count--;
            }
            int copyCount=count;
            count=0;
                
            while(count<=copyCount){
                PrintDiceLoop(r,dice,numberOfDice,diceValues,height,width,count);
                count++;
            }
            if(temp>0){
                PrintDiceLoop(r,dice,temp,diceValues,height,width,tempCount);
                temp=0;
            }
        }

        public void PrintDiceLoop(Random r,object[] dice,int numberOfDice,int[] diceValues,int height,int width,int count=0){    
            int counter=0;
            ConsoleColor[] colr=new ConsoleColor[16];
            colr=Colours.Clrs();
            for (int i=0;i<height;i++){                                                 
                for (int j=0;j<numberOfDice;j++){                                       
                    for (int k=0;k<width;k++){      
                        counter++;
                        //Colours.ChangeColourFG(colr,ref counter);
                        Colours.ChangeColourFGRandom(colr,r.Next(16));
                        PointAtDieNumber(diceValues,dice,i,k,j,count);          
                    }
                    Console.Write("   ");
                }
                System.Console.WriteLine();
            }
            Console.ResetColor();
        }
    }
}