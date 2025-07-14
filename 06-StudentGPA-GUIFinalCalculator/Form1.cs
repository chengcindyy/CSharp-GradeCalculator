using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbQuizesWei.Text = (0.2).ToString();
            tbAssignWei.Text = (0.15).ToString();
            tbMidWei.Text = (0.3).ToString();
            tbFinalWei.Text = (0.35).ToString();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            // When the user clicks on button, it must calculate total percentage (normally this total must be 100) and it must calculate the final grade.

            // define a two-dimensional array of size 4 x 2 and of type float.
            // the values of weights in the first column and the values of the grades in the second column
            float[,] arrayVals = new float[4, 2];
            // Use TryParse to convert from string to float

            // if it has a non-numeric value, must show an error message
            // error message: the values must be between 0 and 1 inclusive.


            if (float.TryParse(tbQuizesWei.Text, out arrayVals[0, 0]) && 0 <= arrayVals[0, 0] && arrayVals[0, 0] <= 1)
            {
                if (float.TryParse(tbAssignWei.Text, out arrayVals[1, 0]) && 0 <= arrayVals[1, 0] && arrayVals[1, 0] <= 1)
                {
                    if (float.TryParse(tbMidWei.Text, out arrayVals[2, 0]) && 0 <= arrayVals[2, 0] && arrayVals[2, 0] <= 1)
                    {
                        if (float.TryParse(tbFinalWei.Text, out arrayVals[3, 0]) && 0 <= arrayVals[3, 0] && arrayVals[3, 0] <= 1)
                        {
                            if (float.TryParse(tbQuizGrade.Text, out arrayVals[0, 1]) && 0 <= arrayVals[0, 0] && arrayVals[0, 0] <= 100)
                            {
                                if (float.TryParse(tbAssignGrade.Text, out arrayVals[1, 1]) && 0 <= arrayVals[1, 1] && arrayVals[1, 1] <= 100)
                                {
                                    if (float.TryParse(tbMidGrade.Text, out arrayVals[2, 1]) && 0 <= arrayVals[2, 1] && arrayVals[2, 1] <= 100)
                                    {
                                        if (float.TryParse(tbFinalGrade.Text, out arrayVals[3, 1]) && 0 <= arrayVals[3, 1] && arrayVals[3, 1] <= 100)
                                        {
                                            // using a for-loop we must calculate the sum of all weights
                                            float i = 0;

                                            for (int row = 0; row < arrayVals.GetLength(0); row++)
                                            {
                                                for (int col = 0; col < arrayVals.GetLength(0);)
                                                {
                                                    i += arrayVals[row, 0];
                                                    break;
                                                }
                                                // convert to string and assign it to the label 
                                            }
                                            tbTotalWei.Text = (i * 100).ToString();

                                            // using a for-loop, calculate the weighted average of the grades
                                            float g = 0;

                                            for (int row = 0; row < arrayVals.GetLength(0); row++)
                                            {
                                                for (int col = 0; col < arrayVals.GetLength(0); col++)
                                                {
                                                    g += arrayVals[row, col] * arrayVals[row, col + 1];
                                                    break;
                                                }
                                                // assign the result to the label 
                                            }
                                            tbTotalGrade.Text = (g).ToString();
                                        }
                                        else
                                        {
                                            MessageBox.Show("Enter a number between 0 and 100 for Final Exam Grade");
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Enter a number between 0 and 100 for Midtrem Exam Grade");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Enter a number between 0 and 100 for Assignments Grade");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Enter a number between 0 and 100 for Quizzes Grade");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Enter a number between 0 and 1 for Final Exam Weight");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter a number between 0 and 1 for Midtrem Exam Weight");
                    }
                }
                else
                {
                    MessageBox.Show("Enter a number between 0 and 1 for Assignments Weight");
                }
            }
            else
            {
                MessageBox.Show("Enter a number between 0 and 1 for Quizzes Weight");
            }
            
        }
    }
}
