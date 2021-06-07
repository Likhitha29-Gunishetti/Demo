using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Average
{
   class student
    {
        public  int studentId { get; set; }
        public String studentName { get; set;}
        public DateTime doj { get; set; }
        public int Lang1Mark { get; set; }
        public int Lang2Mark { get; set; }
        public int mathsMark { get; set; }
        public int ScienceMark { get; set; }
        public int SocialMark { get; set; }
        public long TotalMark { get; set; }
        public decimal percentage { get; set; }
        public student(DateTime date1)
        {
            doj = date1;
        }
        public static void totalmarks(student[] students)
        {
            for(int cnt = 0; cnt < students.Length; cnt++)
            {
                int mark1 = students[cnt].Lang1Mark;
                int mark2 = students[cnt].Lang2Mark;
                int mark3 = students[cnt].mathsMark;
                int mark4 = students[cnt].ScienceMark;
                int mark5 = students[cnt].SocialMark;
                students[cnt].TotalMark = mark1 + mark2 + mark3 + mark4 + mark5;
                Console.WriteLine("Total Marks:" + students[cnt].TotalMark);
                Console.ReadLine();
            }
        }
        public static decimal calculatepercentage(long Totalmark)
        {
            decimal percentage = Totalmark / 5;
            Console.WriteLine("percentage is:" + percentage);
            Console.ReadLine();
            return percentage;
        }
    }
}
    