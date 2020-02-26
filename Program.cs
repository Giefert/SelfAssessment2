using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod2_SelfAssessnentLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // repeat the output for each row
            for (int row = 0; row < 8; row++)
            {
                string cross = "X";
                string circle = "O";

                // output alternating Xs and Os 4 times
                for (int pairXO = 0; pairXO < 4; pairXO++)
                {
                    if (row % 2 == 0) // check if row is even numbered
                    {
                        Console.Write($"{cross}{circle}");
                    }
                    else // odd numbered row
                        Console.Write($"{circle}{cross}");
                }
                Console.WriteLine(); // newline
            }    
        }
    }
}
