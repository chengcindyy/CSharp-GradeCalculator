/*
 * Programmer: Cindy Cheng
 * Date: Fall 2020
 * Purpose: Assignment#5
 */

using static System.Console;



namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            const string str = "EHLNTXZ";
            string userString;
            int dimension;

            userString = GetUserString(str);
            dimension = GetUserInput("Enter an odd integer number greater than 2 for the dimension of the shape: ");


            for (int c = 0; c < userString.Length; c++)
            {
                switch (userString[c])
                {
                    case 'E':
                        DrawE(dimension);
                        break;
                    case 'H':
                        DrawH(dimension);
                        break;
                    case 'L':
                        DrawL(dimension);
                        break;
                    case 'N':
                        DrawN(dimension);
                        break;
                    case 'T':
                        DrawT(dimension);
                        break;
                    case 'X':
                        DrawX(dimension);
                        break;
                    case 'Z':
                        DrawZ(dimension);
                        break;
                }

            }
            Write("Press a key to quit...");
            ReadKey();
        }

        static string GetUserString(string acceptStr)
        {
            string userInput, invalidChr;


            do
            {
                invalidChr = "";
                Write($"Enter a string, including only the follwing characters ( {acceptStr} ) : ");
                userInput = ReadLine();

                for (int c = 0; c < userInput.Length; c++)
                {
                    if (acceptStr.IndexOf(userInput.ToUpper()[c]) == -1)
                    {
                        invalidChr = userInput;
                        Write($"{invalidChr} is(are) not accepted, only {acceptStr} characters are accepted! Re-enter your characters.\n");
                        break;
                    }
                }

            } while (invalidChr != "");
            return userInput.ToUpper();
        }

        static int GetUserInput(string textMessage)
        {
            string userInput;
            int userNumber;

            do
            {
                Write($"{textMessage}");

                userInput = ReadLine();
                int.TryParse(userInput, out userNumber);
                if (userNumber % 2 == 0)
                {
                    Write($"{userNumber} is not odd!");
                    WriteLine();
                }
                else if (userNumber == 1)
                {
                    Write("Must be greater than 3!\n");
                }

            } while (userNumber % 2 == 0 || userNumber == 1);
            return userNumber;
        }

        private static void DrawE(int dimension)
        {

            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row == 1 || row == dimension || col == 1 || (dimension + 1) / 2 == row)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }

                }
                WriteLine();
            }

            WriteLine();
        }

        private static void DrawH(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (col == 1 || (dimension + 1) / 2 == row || col == dimension)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        private static void DrawL(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row == dimension || col == 1)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        private static void DrawN(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (col == 1 || row == col || col == dimension)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        private static void DrawT(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row == 1 || (dimension + 1) / 2 == col)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        private static void DrawX(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (col == row || row + col - 1 == dimension)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }

        private static void DrawZ(int dimension)
        {
            WriteLine();
            for (int row = 1; row <= dimension; row++)
            {
                for (int col = 1; col <= dimension; col++)
                {
                    if (row + col - 1 == dimension || row == 1 || row == dimension)
                    {
                        Write("*");
                    }
                    else
                    {
                        Write(" ");
                    }
                }
                WriteLine();
            }
            WriteLine();
        }
    }
}
