using System;

namespace Array_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            RunApplication();
        }

        public static void RunApplication()
        {
            string[] class3A, class3B;
            class3A = new string[10] { "Rahul", "Sheela", "Mukesh", "Afzal", "Ramesh", "Geeta", "Jason", "Robert", "Gopal", "Meera" };
            class3B = new string[10] { "Pinky", "Rakesh", "Rafi", "Mumtaz", "Derek", "Sukhwinder", "Gopi", "Tulsi", "Chandrika", "Ann" };

            string[] courseNames = new string[6];
            courseNames[0] = "Physics";
            courseNames[1] = "Chemistry";
            courseNames[2] = "Biology";
            courseNames[3] = "Calculus";
            courseNames[4] = "Computer Science";
            courseNames[5] = "Algebra";

            int[] studentMarks = new int[6];
            studentMarks[0] = 67;
            studentMarks[1] = 90;
            studentMarks[2] = 80;
            studentMarks[3] = 55;
            studentMarks[4] = 71;
            studentMarks[5] = 92;

            Console.WriteLine("Students in Class 3A:");
            foreach (string student in class3A)
            {
                Console.Write(student + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Students in Class 3B:");
            foreach (string student in class3B)
            {
                Console.Write(student + " ");
            }
            Console.WriteLine("");

            Console.WriteLine("Marks for a Student:");
            int totalScore = 0;
            for (int i = 0; i < 6; i++)
            {
                totalScore += studentMarks[i];
                Console.WriteLine(courseNames[i] + " = " + studentMarks[i]);
            }

            Console.WriteLine("TOTAL = " + totalScore + "/600 = " + (totalScore * 100 / 600) + " percent");
        }
    }
}
