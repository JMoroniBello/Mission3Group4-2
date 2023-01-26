using System;
using System.Collections.Generic;
using System.Text;

namespace Mission3Group4_2
{
    public class supportClass
    {


        public static void PrintBoard(char[] choices)
        {
            //Prepare game board

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  " + choices[0] + "  |  " + choices[1] + "  |  " + choices[2] + " ");

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  " + choices[3] + "  |  " + choices[4] + "  |  " + choices[5] + " ");

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  " + choices[6] + "  |  " + choices[7] + "  |  " + choices[8] + " ");

            Console.WriteLine("     |     |      ");

        }



        public static int Result(char[] choices)

        {
            //check for winner

            if (choices[0] == choices[1] && choices[2] == choices[1])

            {

                return 1;

            }

            else if (choices[3] == choices[4] && choices[5] == choices[4])

            {

                return 1;

            }

            else if (choices[6] == choices[7] && choices[8] == choices[7])

            {

                return 1;

            }

            else if (choices[0] == choices[3] && choices[6] == choices[3])

            {

                return 1;

            }

            else if (choices[1] == choices[4] && choices[7] == choices[4])

            {

                return 1;

            }

            else if (choices[2] == choices[5] && choices[8] == choices[5])

            {

                return 1;

            }

            else if (choices[0] == choices[4] && choices[8] == choices[4])

            {

                return 1;

            }

            else if (choices[2] == choices[4] && choices[6] == choices[4])

            {

                return 1;

            }

            else if ((choices[0] == 'X' | choices[0] == 'O') && (choices[1] == 'X' | choices[1] == 'O') && (choices[2] == 'X' | choices[2] == 'O') && (choices[3] == 'X' | choices[3] == 'O') && (choices[4] == 'X' | choices[4] == 'O') && (choices[5] == 'X' | choices[5] == 'O') && (choices[6] == 'X' | choices[6] == 'O') && (choices[7] == 'X' | choices[7] == 'O') && (choices[8] == 'X' | choices[8] == 'O'))

            {

                return -1;

            }

            else

            {

                return 0;

            }
        }
    }
}
