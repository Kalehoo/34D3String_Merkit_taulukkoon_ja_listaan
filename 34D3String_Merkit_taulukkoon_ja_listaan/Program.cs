using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34D3String_Merkit_taulukkoon_ja_listaan
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program start

            #region Main Menu:
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Please insert one lowercase word:");
            Console.ResetColor();

            //Taking and storing user input to variable input1
            string input1 = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Select piling method:");
            Console.ResetColor();
            Console.WriteLine("1) separated [####,####]");
            Console.WriteLine("2) whole word [########]");
            Console.WriteLine("\n\n0) EXIT PROGRAM");

            // Menu selection leads to different menu branches

            int menuSelect = Convert.ToInt32(Console.ReadLine());

            // While makes menu to loop

            bool mainMenuActive = true;
            #endregion

            while (mainMenuActive)
            {
                #region Separated version (+ creator notes)
                if (menuSelect == 1)
                {

                    Console.Clear();
                    /*Creating new list and array with tuple of strings inside

                         <(tuple        )>  nameOfList         <(             )> new list tuple
                          type1, type2                          type1, type2   referred variable length defined into list*/
                    List<(string, string)> charList = new List<(string, string)>(input1.Length);
                    /*List-syntax creates new instance
                     *                                new List creates new list */

                    /*Array
                    (             Tuple                 )[] variableName
                    datatype1          datatype2                         new = creating new Array
                            referred variable  referred variable             (    Tuple     )[referred variable length defined into Array]
                                                                             datatype, datatype*/
                    (string charTrap_o, string charTrap_e)[] charArray = new (string, string)[input1.Length];

                    //"Trap" variable for even chars
                    string charTrap_e = ""; //trap for evens
                                            //"Trap" variable for odd chars
                    string charTrap_o = ""; //trap for odds

                    // First loop that goes through all chars in input1
                    for (int i = 0; i < input1.Length; i++)
                    {
                        int c_count = input1[i];
                        // Counting chars for if

                        if (c_count % 2 != 0) //condition for every even-chars AND amount is NOT 0
                        {
                            char convertedChar = (char)(input1[i] - 32); // Converting evens to uppercase to list by referring -32 in their ASCII-table
                            charTrap_e += convertedChar; //Adding converted evens to charTrap_e array

                        }
                        else //else handles other cases than evens
                        {
                            charTrap_o += input1[i];
                        }
                    }

                    // Adding results to list and printing it out

                    charList.Add((charTrap_e, charTrap_o));
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("LIST:");
                    Console.ResetColor();
                    foreach ((string o, string E) in charList)
                    {
                        Console.WriteLine($"{o}, {E}");

                    }

                    // Adding results to Array and defining evens to Lowercase, odds to UpperCase

                    charArray[1] = (charTrap_e.ToLower(), charTrap_o.ToUpper());
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("ARRAY:");
                    Console.ResetColor();
                    Console.WriteLine(charArray[1]);

                    // Exit after run
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Program ran through... press any key to exit...");
                    Console.ResetColor();
                    Console.ReadKey();
                    mainMenuActive = false;
                }
                #endregion
                #region Piled
                else if (menuSelect == 2)
                {

                    //Forming lists:
                    List<string> charList = new List<string>(input1.Length);
                    string[] charArray = new string[input1.Length];

                    string piledListSentence = "";
                    string piledArraySentence = "";

                    for (int i = 0; i < input1.Length; i++)
                    {
                        int c_count = input1[i];


                        if (c_count % 2 != 0) //condition for every even-chars AND amount is NOT 0
                        {
                            char convertedChar = (char)(input1[i] - 32);
                            piledArraySentence += convertedChar; //adding evens uppercased to Array
                            piledListSentence += input1[i];

                        }
                        else //else handles other cases than evens
                        {
                            char convertedChar = (char)(input1[i] - 32); //adding odds uppercased to List
                            piledListSentence += convertedChar;
                            piledArraySentence += input1[i];

                        }

                    }

                    // Piling and printing List
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("List results:");
                    Console.ResetColor();
                    charList.Add(piledListSentence);
                    foreach (var s in charList)
                    {
                        Console.WriteLine($"{s}");
                    }
                    // Piling and printing Array
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Array results:");
                    Console.ResetColor();
                    charArray[0] = piledArraySentence;
                    foreach (var s in charArray)
                    {
                        Console.WriteLine($"{s}");
                    }


                    // Exit after run
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("Program ran through... press any key to exit...");
                    Console.ResetColor();
                    mainMenuActive = false;
                }
                #endregion
                #region Exit program
                else if (menuSelect == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Exiting program");
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Press any key...");
                    Console.ReadKey();

                    mainMenuActive = false;
                }
                #endregion
                #region False answer loop
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Please select either 1, 2 or 0 to exit...");
                    Console.ResetColor();
                }
                #endregion
            }
        }
    }
}
