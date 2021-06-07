using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter no of Student you want to validatte");

            int noofTimes = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter no. of subjects");
            //int noofsubjects = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("no. of marks to be obtained");
            //int maxmarks = Convert.ToInt32(Console.ReadLine());

            student[] students = new student[noofTimes];
            // student[] student = new student[noofsubjects];
            // student[] stud = new student[maxmarks];

            for (int cnt = 0; cnt < noofTimes; cnt++)

            {

                Console.WriteLine(" =======================================");

                Console.WriteLine("Enter Student id");

                //students[cnt] = new student();

                students[cnt].studentId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Name");

                students[cnt].studentName = Console.ReadLine();
                Console.WriteLine("enter doj");
                students[cnt] = new student(DateTime.Now);

                Console.WriteLine("Enter Student Lang1 Marks");

                students[cnt].Lang1Mark = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Lang2 Marks");

                students[cnt].Lang2Mark = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Maths Marks");

                students[cnt].mathsMark = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Science Marks");

                students[cnt].ScienceMark = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Student Social Marks");

                students[cnt].SocialMark = Convert.ToInt32(Console.ReadLine());
            }
            student.totalmarks(students);

            for (int cnt = 0; cnt < students.Length; cnt++)
            {
                student.calculatepercentage(students[cnt].TotalMark);

            }
            DateTime date = DateTime.UtcNow;
            student obj = new student(date);
            Console.WriteLine("The joining date is", obj.doj);
            Console.ReadLine();
        }
    }
}


            //int total = (students[cnt].Lang1Mark + students[cnt].Lang2Mark + students[cnt].mathsMark + students[cnt].ScienceMark + students[cnt].SocialMark);
            // float avg = total / noofsubjects;
            // Console.WriteLine("average is:" + avg);
            // int percentage = (total / maxmarks) * 100;
            // Console.WriteLine("percentage is:" + percentage);
            // Console.ReadLine();
 
