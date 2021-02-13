using System;

using System.Threading;


namespace TicTacToeidrisulu

{

    class Program

        
    {





        static char[] array1 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' }; //making array  

        static int player = 1; // x=player1 O=player2  

        static int choice; //holds the choice at which position user want to mark   



        // if the value is 0, the game continues , if the value is 1, all the fields are full
        static int flag = 0;
        static string mainmenu;
        static string enternumber;
        static string exitsure;



        static void Main(string[] args)

        {
        idris:
            Console.WriteLine("[Press Enter to Main Menu...]");

            mainmenu = Console.ReadLine();
        don:
            if (mainmenu == "")
            {

                Console.WriteLine("1.New Game");
                Console.WriteLine("2.About the Author");
                Console.WriteLine("3.Exit");

            }
            enternumber = Console.ReadLine();
            if (enternumber == "1")
            {
                Console.Clear();
                flag = 0;
                player = 1;
                array1[1] = '1';
                array1[2] = '2';
                array1[3] = '3';
                array1[4] = '4';
                array1[5] = '5';
                array1[6] = '6';
                array1[7] = '7';
                array1[8] = '8';
                array1[9] = '9';
                goto etiket;
            }
            if (enternumber == "2")
            {
                Console.WriteLine("Created by İdris Ulu.");
                mainmenu = "";
                goto idris;
            }
            if (enternumber == "3")
            {
                Console.WriteLine("Are you sure you want to quit.[y/n]");
                exitsure = Console.ReadLine();
                if (exitsure == "y")
                {
                    Environment.Exit(0);
                }
                if (exitsure == "n")
                {
                    mainmenu = "";
                    goto don;

                }
            }





        etiket:
            Console.WriteLine("Welcome To Tic-Tac-Toe Game!");


            do

            {



                Console.WriteLine("\n");
                idrisBoard();
                Console.WriteLine("\n");

                if (player % 2 == 0)// O's turn.  

                {

                    Console.Write("O's Move =>");

                }

                else // X's turn.

                {

                    Console.Write("X's Move =>");

                }





                choice = int.Parse(Console.ReadLine());// reading users's entered value   





                if (array1[choice] != 'X' && array1[choice] != 'O')

                {

                    if (player % 2 == 0) // if the O's turn - write it O  where the 'choice' value is entered.

                    {

                        array1[choice] = 'O';

                        player++;

                    }

                    else //if the X's turn - write it X  where the 'choice' value is entered.

                    {

                        array1[choice] = 'X';

                        player++;

                    }

                }

                else //If the field you tried to mark is full, show the message 

                {

                    Console.WriteLine("Illegal Move. Try Again.");



                }

                flag = fullboard();


            } while (flag != 1 && flag != -1); // The game  continues  

            idrisBoard();

            if (flag == 1)// if flag value is 1 then some one has win or means who played marked last time which has win  

            {

                Console.WriteLine("Player {0} has won", (player % 2) + 1);

                Console.WriteLine("[Press Enter to return to Main Menu...]");

                mainmenu = Console.ReadLine();
                //don:
                if (mainmenu == "")
                {

                    Console.WriteLine("1.New Game");
                    Console.WriteLine("2.About the Author");
                    Console.WriteLine("3.Exit");

                }
                enternumber = Console.ReadLine();
                if (enternumber == "1")
                {
                    Console.Clear();   // clear console
                    flag = 0;
                    player = 1;
                    array1[1] = '1';
                    array1[2] = '2';
                    array1[3] = '3';
                    array1[4] = '4';
                    array1[5] = '5';
                    array1[6] = '6';
                    array1[7] = '7';
                    array1[8] = '8';
                    array1[9] = '9';
                    goto etiket;
                }
                if (enternumber == "2")
                {
                    Console.WriteLine("Created by İdris Ulu.");
                    mainmenu = "";
                    goto idris;
                }
                if (enternumber == "3")
                {
                    Console.WriteLine("Are you sure you want to quit.[y/n]");
                    exitsure = Console.ReadLine();
                    if (exitsure == "y")
                    {
                        Environment.Exit(0);
                    }
                    if (exitsure == "n")
                    {
                        mainmenu = "";
                        goto don;

                    }
                }

            }

            else// if flag value is -1 the match will be draw and no one is winner  

            {

                Console.WriteLine("Draw");
                Console.WriteLine("[Press Enter to return to Main Menu...]");

                mainmenu = Console.ReadLine();
                //don:
                if (mainmenu == "")
                {

                    Console.WriteLine("1.New Game");
                    Console.WriteLine("2.About the Author");
                    Console.WriteLine("3.Exit");

                }
                enternumber = Console.ReadLine();
                if (enternumber == "1")
                {
                    Console.Clear();
                    flag = 0;
                    player = 1;
                    array1[1] = '1';
                    array1[2] = '2';
                    array1[3] = '3';
                    array1[4] = '4';
                    array1[5] = '5';
                    array1[6] = '6';
                    array1[7] = '7';
                    array1[8] = '8';
                    array1[9] = '9';
                    goto etiket;
                }
                if (enternumber == "2")
                {
                    Console.WriteLine("Created by İdris Ulu.");
                    mainmenu = "";
                    goto idris;
                }
                if (enternumber == "3")
                {
                    Console.WriteLine("Are you sure you want to quit.[y/n]");
                    exitsure = Console.ReadLine();
                    if (exitsure == "y")
                    {
                        Environment.Exit(0);
                    }
                    if (exitsure == "n")
                    {
                        mainmenu = "";
                        goto don;

                    }
                }

            }

            Console.ReadLine();

        }



        private static void idrisBoard() // this is a gameboard function.

        {

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array1[1], array1[2], array1[3]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array1[4], array1[5], array1[6]);

            Console.WriteLine("_____|_____|_____ ");

            Console.WriteLine("     |     |      ");

            Console.WriteLine("  {0}  |  {1}  |  {2}", array1[7], array1[8], array1[9]);

            Console.WriteLine("     |     |      ");

        }


        //Checking that any player has won or not  

        private static int fullboard()

        {

            #region Horzontal Winning Condtion

            //Winning Condition For First Row   

            if (array1[1] == array1[2] && array1[2] == array1[3])

            {

                return 1;

            }

            //Winning Condition For Second Row   

            else if (array1[4] == array1[5] && array1[5] == array1[6])

            {

                return 1;

            }

            //Winning Condition For Third Row   

            else if (array1[6] == array1[7] && array1[7] == array1[8])

            {

                return 1;

            }

            #endregion



            #region vertical Winning Condtion

            //Winning Condition For First Column       

            else if (array1[1] == array1[4] && array1[4] == array1[7])

            {

                return 1;

            }

            //Winning Condition For Second Column  

            else if (array1[2] == array1[5] && array1[5] == array1[8])

            {

                return 1;

            }

            //Winning Condition For Third Column  

            else if (array1[3] == array1[6] && array1[6] == array1[9])

            {

                return 1;

            }

            #endregion



            #region Diagonal Winning Condition

            else if (array1[1] == array1[5] && array1[5] == array1[9])

            {

                return 1;

            }

            else if (array1[3] == array1[5] && array1[5] == array1[7])

            {

                return 1;

            }

            #endregion



            #region Checking For Draw

            // If all the cells or values filled with X or O then any player has won the match  

            else if (array1[1] != '1' && array1[2] != '2' && array1[3] != '3' && array1[4] != '4' && array1[5] != '5' && array1[6] != '6' && array1[7] != '7' && array1[8] != '8' && array1[9] != '9')

            {

                return -1;

            }

            #endregion



            else

            {

                return 0;

            }

        }






    }

}
