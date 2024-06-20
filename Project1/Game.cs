using System;

namespace DiceThrowing{
    class Game{
        public static Random r=new Random();
        int diceChosen;
        public int DiceChosen{
            get{return diceChosen;}
            set{
                if (value<=0){
                    diceChosen=1;
                }
                else if (value>3){
                diceChosen=3;    
                }
                else{
                diceChosen=value;
                }
            }
        }
        public int Choosing(){
            while(true){
                try
                {
                    DiceChosen=Convert.ToInt32(Console.ReadLine());
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
            return DiceChosen;
        }

        public int[] Throwing(int diceChosen){
            
            int dieCount=0;
            int[] dieCountArr=new int[diceChosen];
            int total=0;
            switch(diceChosen){
                case 1:
                    PrintDice(r,Die.dice,Constants.height,Constants.width,out dieCount);
                    dieCountArr[0]=dieCount+1;
                    total+=dieCountArr[0];
                    PrintResult(dieCountArr,total);
                    break;
                case 2:
                    for (int i=0;i<=1;i++){
                        PrintDice(r,Die.dice,Constants.height,Constants.width,out dieCount);
                        dieCountArr[i]=dieCount+1;
                        total+=dieCountArr[i];
                    }
                    PrintResult(dieCountArr,total);
                    break;
                case 3:
                    
                    for (int i=0;i<=2;i++){
                        PrintDice(r,Die.dice,Constants.height,Constants.width,out dieCount);
                        dieCountArr[i]=dieCount+1;
                        total+=dieCountArr[i];
                    }
                    PrintResult(dieCountArr,total);
                    break;
            }
            return dieCountArr;
        }

        void PrintResult(int[] dieCountArr,int total){
            if(diceChosen<=1){
                Console.Write($"Your die is: {total}");
            }
            else{
                Console.Write("Your dice are: ");
                for (int i=0;i<diceChosen;i++){
                    System.Console.Write(dieCountArr[i]+ " ");
                }
                System.Console.Write($"\nYour total is: {total}");
            }
        }

        public void PrintDice(Random r,object[] array,int height,int width,out int dieCount){
            dieCount=r.Next(6);
            string[,] die=(string[,])array[dieCount];
            for (int i=0;i<height;i++){
                for (int j=0;j<width;j++){
                    System.Console.Write(die[i,j]);
                }
                System.Console.WriteLine();
            }
        }
    }
}