using System;

/*
Programmer: Cindy Cheng
Date:Fall 2021
Propose:Assignment2
*/


namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)

        {
            const float ASSIGNMENTS_PERCENTAGE = 0.2f;
            const float QUIZZES_PERCENTAGE = 0.2f;
            const float MIDTERM_EXAM_PERCENTAGE = 0.3f;
            const float FINAL_EXAM_PERCENTAGE = 0.3f;
            
            float assignmentGrade, minternExamGrade, finalExamGrade, quizzGrade1, quizzGrade2;

            assignmentGrade = 100;
            minternExamGrade = 55;
            quizzGrade1 = 45.5f;
            quizzGrade2 = 100;
            finalExamGrade = 65.8f;

            const float weightedTotal = ASSIGNMENTS_PERCENTAGE + QUIZZES_PERCENTAGE + MIDTERM_EXAM_PERCENTAGE + FINAL_EXAM_PERCENTAGE;
            const float weightedExams = QUIZZES_PERCENTAGE + MIDTERM_EXAM_PERCENTAGE + FINAL_EXAM_PERCENTAGE;

            /*
            assignmentGrade = 90;
            minternExamGrade = 65;
            quizzGrade1 = 60;
            quizzGrade2 = 75;
            finalExamGrade = 50;

            assignmentGrade = 95;
            minternExamGrade = 65;
            quizzGrade1 = 80;
            quizzGrade2 = 95;
            finalExamGrade = 60;

            assignmentGrade = 80;
            minternExamGrade = 86;
            quizzGrade1 = 90;
            quizzGrade2 = 95;
            finalExamGrade = 78;

            assignmentGrade = 100;
            minternExamGrade = 0;
            quizzGrade1 = 45.5f;
            quizzGrade2 = 100;
            finalExamGrade = 65.8f;

            assignmentGrade = 100;
            minternExamGrade = 55;
            quizzGrade1 = 45.5f;
            quizzGrade2 = 100;
            finalExamGrade = 65.8f;
            */

            double weightedAverage = ((assignmentGrade * ASSIGNMENTS_PERCENTAGE + minternExamGrade * MIDTERM_EXAM_PERCENTAGE + finalExamGrade * FINAL_EXAM_PERCENTAGE + quizzGrade1 * (QUIZZES_PERCENTAGE / 2) + quizzGrade2 * (QUIZZES_PERCENTAGE / 2)) / weightedTotal);
            double weightedExamsAverage = (minternExamGrade * MIDTERM_EXAM_PERCENTAGE + (quizzGrade1 + quizzGrade2) * QUIZZES_PERCENTAGE / 2 + finalExamGrade * FINAL_EXAM_PERCENTAGE) / weightedExams;

            Console.Write("\\***************************************\\\n");
            Console.Write("\\\t\t\t\t\t\\\n");
            Console.Write("\\  \"Total Weighted Average Calculator\"  \\\n");
            Console.Write("\\\t\t\t\t\t\\\n");
            Console.Write("\\***************************************\\\n\n");

            Console.WriteLine("{0,14}{1,13}   {2,-15}", "Assessment", "Precentage", "Your Grade");
            Console.WriteLine("{0,14}{1,13}   {2,-15}", "--------------", "-----------", "-----------");
            Console.WriteLine("{0,14}{1,13:0%}   {2,-15}", "Assessments", ASSIGNMENTS_PERCENTAGE, assignmentGrade);
            Console.WriteLine("{0,14}{1,13:0%}   {2,-15}", "MidTerm Exam", MIDTERM_EXAM_PERCENTAGE, minternExamGrade);
            Console.WriteLine("{0,14}{1,13:0%}   {2,-15}", "Quiz1", QUIZZES_PERCENTAGE / 2, quizzGrade1);
            Console.WriteLine("{0,14}{1,13:0%}   {2,-15}", "Quiz2", QUIZZES_PERCENTAGE / 2, quizzGrade2);
            Console.WriteLine("{0,14}{1,13:0%}   {2,-15}", "Final Exam", FINAL_EXAM_PERCENTAGE, finalExamGrade);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("{0,14}{1,13:P0}   {2,-15:N2}", "Weighted Total", weightedTotal, weightedAverage);

            Console.WriteLine("\n\nThe Weighted Average Total on Exams (Midterm, Quizzes, Final exam) is {0:f2}", weightedExamsAverage);
            Console.WriteLine("If WAT-on-Exam is less than 50, the student fails the course.");

            Console.ReadKey();


        }
    }
}
