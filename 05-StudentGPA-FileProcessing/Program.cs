/*
 * Programmer: Cindy Cheng
 * Date: Fall 2021
 * Purpose: Assignment#6
 */

using static System.Console;
using System.IO;

namespace Assignment_6
{
    class Program
    {
        static void Main(string[] args)
        {
            const int NO_OF_COURSES = 5;

            Write("The text file StudentData.txt opened for reading...\n");
            Write("The binary file studentsGPA.dat opened for writing...\n");
            WriteLine();

            FileStream fsR = File.Open("StudentData.txt", FileMode.Open);
            StreamReader inTxt = new StreamReader(fsR);

            FileStream byW = File.Open("studentsGPA.dat", FileMode.Create);
            BinaryWriter outBin = new BinaryWriter(byW);

            string inStr;
            int t = 0;

            Student student = new Student(NO_OF_COURSES);

            while ((inStr = inTxt.ReadLine()) != null)
            {
                WriteLine($"Reading record {t += 1} ...");
                string[] lines = inStr.Split(' ');
                student.stuName = lines[0];
                for (int i = 0; i < lines.Length - 1; i++)
                {
                    student.stuGrade[i] = float.Parse(lines[i + 1]);
                }
                student.stuGPA = Student.GetGPA(student.stuGrade);
                outBin.Write(student.stuGPA);
                WriteLine($"Writing to the binary file ... {student.stuName} {student.stuGPA:0.##}\n");
            }
            fsR.Close();
            outBin.Close();

            WriteLine("\n\nPress a key to quit...");
            ReadKey();
        }

    }

}
