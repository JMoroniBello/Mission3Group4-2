using System;

namespace Mission3Group4_2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Welcome to tic-tac-toe!\n Player 1 is X\n Player 2 is O");
            // array to hold player choices
            char[] choices = new char[9] {'1','2','3','4','5','6','7','8', '9'};

            int i = 2;
            char[] placeHolder = new char[2] { 'X', 'O' };
            int res = 0;
            int p = 0;
            //loop to continue game untill draw or win
            supportClass.PrintBoard(choices);
            while (res ==0)
            {
                p = i % 2;
                Console.WriteLine("Player " +  (p+1) + " (" + placeHolder[p] + ") , where would you like play?");
                string Place = Console.ReadLine();
                //put placeholder in array
                choices[Int32.Parse(Place)-1] = placeHolder[p];
                //call supporting class methods to print board and any results
                supportClass.PrintBoard(choices);
                res = supportClass.Result(choices);
                i++;
            }
            if (res == -1)
                Console.WriteLine("The result of the game is a draw!");
            else
                Console.WriteLine("Player " + (p+1) + " (" + placeHolder[p] + ") Won! Good Game!");
                     
        }
    }
}
