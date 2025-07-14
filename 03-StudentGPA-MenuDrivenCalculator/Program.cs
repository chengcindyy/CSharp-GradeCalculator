/*
 * Programmer: Cindy Cheng
 * Date: Fall 2020
 * Purpose: Assignment#4
 */

using System;
using static System.Console;

namespace WeightedAverageCalc
{
    class WAC
    {
        static void Main(string[] args)
        {
            // constant weights are defined here
            const float ASSIGNMENTS_PERCENTAGE = 0.2f;
            const float MIDTERM_EXAM_PERCENTAGE = 0.3f;
            const float QUIZ_PERCENTAGE = 0.1f;
            const float FINAL_EXAM_PERCENTAGE = 0.3f;

            // variables for storing the grades of a student
            float assignments;
            float midtermExam;
            float quiz1;
            float quiz2;
            float finalExam;

            float weightedExams = 0;
            float totalWeightedAverage = 0;


            Title = "CSIS1175 - Assignment 4 - By Cindy Cheng";

            DisplayBanner("Total Weighted Average Calculator");


            if (GetUserInput("Assignments", 0, 100, out assignments))
                if (GetUserInput("Midterm Exam", 0, 100, out midtermExam))
                    if (GetUserInput("Quiz1", 0, 100, out quiz1))
                        if (GetUserInput("Quiz2", 0, 100, out quiz2))
                            if (GetUserInput("Final Exam", 0, 100, out finalExam))
                            {
                                WriteLine("\n");

                                // Total Weighted Average is sum of products of grades and their weight
                                totalWeightedAverage += WeightedGrade(assignments, ASSIGNMENTS_PERCENTAGE);
                                totalWeightedAverage += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
                                totalWeightedAverage += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
                                totalWeightedAverage += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);

                                DisplayTableRow("Assessment", "Percentage", "Your Grade");
                                DisplayTableRow("--------------", " -----------", "----------");

                                DisplayTableRow("Assignments", ASSIGNMENTS_PERCENTAGE, assignments, LetterGrade(assignments));
                                DisplayTableRow("MidTerm Exam", MIDTERM_EXAM_PERCENTAGE, midtermExam, LetterGrade(midtermExam));
                                DisplayTableRow("Quiz1", QUIZ_PERCENTAGE, quiz1, LetterGrade(quiz1));
                                DisplayTableRow("Quiz2", QUIZ_PERCENTAGE, quiz2, LetterGrade(quiz2));
                                DisplayTableRow("Final Exam", FINAL_EXAM_PERCENTAGE, finalExam, LetterGrade(finalExam));

                                WriteLine("----------------------------------------");

                                // change the following line of code such that the Floor value of totalWeightedAverage is displayed on Console
                                DisplayTableRow("Weighted Total", 1, (float)Math.Floor(totalWeightedAverage), LetterGrade(totalWeightedAverage)); //** Change only this line **//

                                WriteLine("\n");

                                weightedExams += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
                                weightedExams += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
                                weightedExams += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);
                                weightedExams /= 0.8f;

                                // change the following line of code such that the Ceiling value of weightedExams is displayed on Console
                                WriteLine("The Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0:F2} ({1})", Math.Ceiling(weightedExams), LetterGrade(weightedExams)); //** Change only this line **//

                                if (weightedExams >= 50)
                                {
                                    WriteLine("The student PASSES the course.");
                                }
                                else
                                {
                                    WriteLine("student FAILS the course.");
                                }
                            }
            Write("\nPress a key to quit...");
            ReadKey();
        }

        static bool GetUserInput(string textMessage, byte min, byte max, out float userInputValue)
        {
            string userInput;
            bool isvalid;

            Write("Enter a vaule for {0}: ", textMessage);
            userInput = ReadLine();
            isvalid = float.TryParse(userInput, out userInputValue);

            if (!isvalid)
            {
                Write("\n!!!!!\n");
                Write("The value for {0} must be a number!", textMessage);
                Write("\n!!!!!\n");
                userInputValue = 0;
                return false;
            }
            else if (min < userInputValue && userInputValue > max)
            {
                Write("\n!!!!!\n");
                Write($"The valie for {textMessage} must be a number between {min} and {max} inclusive!");
                Write("\n!!!!!\n\n");
                userInputValue = 0;
                return false;
            }
            else
            {
                userInputValue = float.Parse(userInput);
                return true;
            }
        }

        // This method displays a banner on top of the screen
        static void DisplayBanner(string textMessage)
        {
            Write("\\***************************************\\\n");
            Write("\\\t\t\t\t\t\\\n");
            Write("\\  \"{0}\"  \\\n", textMessage);
            Write("\\\t\t\t\t\t\\\n");
            Write("\\***************************************\\\n");
            WriteLine();
        }
        // this method displays a header row in a table with 3 columns
        static void DisplayTableRow(string column1, string column2, string column3)
        {
            WriteLine("{0,14}{1,13}   {2,-15}", column1, column2, column3);
        }

        // this method display a row in a table with 3 columns
        static void DisplayTableRow(string column1, float column2, float column3, string column4)
        {
            WriteLine("{0,14}{1,13:P0}   {2,-7:F2}{3}", column1, column2, column3, column4);
        }

        // this method receives grade and weight and returns product of these two parameters as weightedGrade 
        static float WeightedGrade(float grade, float weight)
        {
            return grade * weight;
        }

        static string LetterGrade(float gradeValue)
        {
            if (gradeValue >= 95)
            {
                return "A+";
            }
            else if (90 <= gradeValue && gradeValue <= 94)
            {
                return "A";
            }
            else if (85 <= gradeValue && gradeValue <= 89)
            {
                return "A-";
            }
            else if (80 <= gradeValue && gradeValue <= 84)
            {
                return "B+";
            }
            else if (75 <= gradeValue && gradeValue <= 79)
            {
                return "B";
            }
            else if (70 <= gradeValue && gradeValue <= 74)
            {
                return "B-";
            }
            else if (65 <= gradeValue && gradeValue <= 69)
            {
                return "C+";
            }
            else if (60 <= gradeValue && gradeValue <= 64)
            {
                return "C";
            }
            else if (55 <= gradeValue && gradeValue <= 59)
            {
                return "C-";
            }
            else if (50 <= gradeValue && gradeValue <= 54)
            {
                return "P";
            }
            else
            {
                return "F";
            }
        }
    }
}
