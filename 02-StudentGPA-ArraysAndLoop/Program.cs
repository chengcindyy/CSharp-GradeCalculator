/*
 * Programmer: Cindy Cheng
 * Date: Fall 2021
 * Purpose: Assignment#3
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
            const float QUIZ_PERCENTAGE = 0.2f;
            const float FINAL_EXAM_PERCENTAGE = 0.3f;

            // variables for storing the grades of a student
            float assignments;
            float midtermExam;
            float quiz1;
            float quiz2;
            float finalExam;

            float weightedExams = 0;
            float totalWeightedAverage = 0;


            Title = "CSIS1175 - Assignment 3 - By Cindy Cheng";

            DisplayBanner("Total Weighted Average Calculator");

            // The user enters the grades, the program gets them and stores them in the corresponding variable
            assignments = GetUserInput("Assignments");
            midtermExam = GetUserInput("Midterm Exam");
            quiz1 = GetUserInput("Quiz1");
            quiz2 = GetUserInput("Quiz2");
            finalExam = GetUserInput("Final Exam");

            WriteLine("\n");

            // Total Weighted Avergae is sum of products of grades and their weight
            totalWeightedAverage += WeightedGrade(assignments, ASSIGNMENTS_PERCENTAGE);
            totalWeightedAverage += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
            totalWeightedAverage += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
            totalWeightedAverage += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);

            DisplayTableRow("Assessment", "Percentage", "Your Grade");
            DisplayTableRow("--------------", " -----------", "----------");

            DisplayTableRow("Assignments", ASSIGNMENTS_PERCENTAGE, assignments);
            DisplayTableRow("MidTerm Exam", MIDTERM_EXAM_PERCENTAGE, midtermExam);
            DisplayTableRow("Quiz1", QUIZ_PERCENTAGE, quiz1);
            DisplayTableRow("Quiz2", QUIZ_PERCENTAGE, quiz2);
            DisplayTableRow("Final Exam", FINAL_EXAM_PERCENTAGE, finalExam);

            WriteLine("----------------------------------------");

            // change the following line of code such that the Floor value of totalWeightedAverage is displayed on Console
            DisplayTableRow("Weighted Total", 1, (float)Math.Floor(totalWeightedAverage)); //** Change only this line **//

            WriteLine("\n");

            weightedExams += WeightedGrade(midtermExam, MIDTERM_EXAM_PERCENTAGE);
            weightedExams += WeightedGrade((quiz1 + quiz2), QUIZ_PERCENTAGE);
            weightedExams += WeightedGrade(finalExam, FINAL_EXAM_PERCENTAGE);
            weightedExams /= 0.8f;

            // change the following line of code such that the Ceiling value of weightedExams is displayed on Console
            WriteLine("The Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0:F2}", (float)Math.Ceiling(weightedExams)); //** Change only this line **//

            WriteLine("If WAT-on-Exams is less than 50, the student fails the course.");

            ReadKey();
        }

        //  your method definitions are written here (out of Main method). A method cannot be defined inside another method
        static float GetUserInput(string examName)
        {
            string userInput1;

            Write("Enter a vaule for {0}: ", examName);
            userInput1 = ReadLine();

            return float.Parse(userInput1);
        }

        static void DisplayBanner(string describePurpose)
        {
            Write("\\***************************************\\\n");
            Write("\\\t\t\t\t\t\\\n");
            Write("\\  \"{0}\"  \\\n", describePurpose);
            Write("\\\t\t\t\t\t\\\n");
            Write("\\***************************************\\\n\n");
        }

        static void DisplayTableRow(string theTitle1, string theTitle2, string theTitle3)
        {
            WriteLine("{0,14}{1,13} {2,-15}", theTitle1, theTitle2, theTitle3);
        }

        static void DisplayTableRow(string examName, float examPercentage, float examGrade)
        {
            WriteLine("{0,14}{1,13:P0}   {2,-15:F2}", examName, examPercentage, examGrade);
        }

        static float WeightedGrade(float calculateTotal, float calculatePercentage)
        {
            return (calculateTotal * calculatePercentage);
        }
    }
}
