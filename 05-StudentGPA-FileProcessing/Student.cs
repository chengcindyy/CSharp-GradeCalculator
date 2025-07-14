
namespace Assignment_6
{
    class Student
    {
        public string stuName;
        public float[] stuGrade = new float[5];
        public float stuGPA;
        public int courseNum;
               
      
        public Student(int num)
        {
            courseNum = num;
        }

        public static float GetGPA(float[] stuGrade)
        {
            float sum = 0;            

            sum = 0;
            foreach (float g in stuGrade)
            {
                sum += g;
            }
            return sum / stuGrade.Length;
            
        }
    }        
}
