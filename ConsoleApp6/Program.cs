using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string whoseTurn = "";
            string[] stringss = { "n", "n", "n", "n", "n", "n", "n", "n", "n" };
            //Checking whose turn it is
            for (int k = 0; k < 10; k++)
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine("X your turn: ");
                }
                else
                {
                    Console.WriteLine("Y your turn: ");
                }
                //Print the field of play
                for (int i = 0; i < 9; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine("");
                    }
                    Console.Write($" {stringss[i]} ");
                }
                Console.WriteLine();
                //Checking if X or Y wins or a draw
                if (
                    stringss[0] == "X" && stringss[1] == "X" && stringss[2] == "X" ||
                    stringss[3] == "X" && stringss[4] == "X" && stringss[5] == "X" ||
                    stringss[6] == "X" && stringss[7] == "X" && stringss[8] == "X" ||
                    stringss[0] == "X" && stringss[3] == "X" && stringss[6] == "X" ||
                    stringss[1] == "X" && stringss[4] == "X" && stringss[7] == "X" ||
                    stringss[2] == "X" && stringss[5] == "X" && stringss[8] == "X" ||
                    stringss[0] == "X" && stringss[4] == "X" && stringss[8] == "X" ||
                    stringss[6] == "X" && stringss[4] == "X" && stringss[2] == "X")
                {
                    Console.WriteLine("Win X");
                    break;
                }
                else if (
                    stringss[0] == "Y" && stringss[1] == "Y" && stringss[2] == "Y" ||
                    stringss[3] == "Y" && stringss[4] == "Y" && stringss[5] == "Y" ||
                    stringss[6] == "Y" && stringss[7] == "Y" && stringss[8] == "Y" ||
                    stringss[0] == "Y" && stringss[3] == "Y" && stringss[6] == "Y" ||
                    stringss[1] == "Y" && stringss[4] == "Y" && stringss[7] == "Y" ||
                    stringss[2] == "Y" && stringss[5] == "Y" && stringss[8] == "Y" ||
                    stringss[0] == "Y" && stringss[4] == "Y" && stringss[8] == "Y" ||
                    stringss[6] == "Y" && stringss[4] == "Y" && stringss[2] == "Y")
                {
                    Console.WriteLine("Win Y");
                    break;
                }
                if (k == 9)
                {
                    Console.WriteLine("Draw");
                    break;
                }
                //Change sign when it's another's turn
                if (k % 2 == 0)
                {
                    whoseTurn = "X";
                }
                else
                {
                    whoseTurn = "Y";
                }
                //Checking what the user has entered
                int inputx = Convert.ToInt32(Console.ReadLine());
                switch (inputx)
                {
                    case 1:
                        {
                            if (stringss[0] == "X" || stringss[0] == "Y")
                            {
                                Console.WriteLine("Sorry");
                                k--;
                            }
                            else
                            {
                                Console.WriteLine(stringss[0] = whoseTurn);
                            }
                            break;
                        }
                    case 2:
                        {
                            if (stringss[1] == "X" || stringss[1] == "Y")
                            {
                                Console.WriteLine("Sorry");
                                k--;
                            }
                            else
                            {
                                Console.WriteLine(stringss[1] = whoseTurn);
                            }
                            break;
                        }
                    case 3:
                        {
                            if (stringss[2] == "X" || stringss[2] == "Y")
                            {
                                Console.WriteLine("Sorry");
                                k--;
                            }
                            else
                            {
                                Console.WriteLine(stringss[2] = whoseTurn);
                            }
                            break;
                        }
                    case 4:
                        {
                            if (stringss[3] == "X" || stringss[3] == "Y")
                            {
                                Console.WriteLine("Sorry");
                                k--;
                            }
                            else
                            {
                                Console.WriteLine(stringss[3] = whoseTurn);
                            }
                            break;
                        }
                    case 5:
                        {
                            if (stringss[4] == "X" || stringss[4] == "Y")
                            {
                                Console.WriteLine("Sorry");
                                k--;
                            }
                            else
                            {
                                Console.WriteLine(stringss[4] = whoseTurn);
                            }
                            break;
                        }
                    case 6:
                        {
                            if (stringss[5] == "X" || stringss[5] == "Y")
                            {
                                Console.WriteLine("Sorry");
                                k--;
                            }
                            else
                            {
                                Console.WriteLine(stringss[5] = whoseTurn);
                            }
                            break;
                        }
                    case 7:
                        {
                            if (stringss[6] == "X" || stringss[6] == "Y")
                            {
                                Console.WriteLine("Sorry");
                                k--;
                            }
                            else
                            {
                                Console.WriteLine(stringss[6] = whoseTurn);
                            }
                            break;
                        }
                    case 8:
                        {
                            if (stringss[7] == "X" || stringss[7] == "Y")
                            {
                                Console.WriteLine("Sorry");
                                k--;
                            }
                            else
                            {
                                Console.WriteLine(stringss[7] = whoseTurn);
                            }
                            break;
                        }
                    case 9:
                        {
                            if (stringss[8] == "X" || stringss[8] == "Y")
                            {
                                Console.WriteLine("Sorry");
                                k--;
                            }
                            else
                            {
                                Console.WriteLine(stringss[8] = whoseTurn);
                            }
                            break;
                        }

                }
            }
        }
    }
}