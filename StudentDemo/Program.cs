using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Student.batch = "DotNet";
            Console.WriteLine("Institue Name is " + Student.Institue);
            //Student.Institue = "aaaaa";
            Student.Batch();
            // Will call Def Cons
            Student student1 = new Student();
            student1.GetDetails();
            student1.DisplayDetails();


            // Will call Para Cons
            Student student2 = new Student(10);
            student2.DisplayDetails();


            // Will call Para Cons
            Student student3 = new Student(11, "Mahesh");
            student2.DisplayDetails();

            // Will call Para Cons
            Student student4 = new Student(12, "Deepak", 90);
            student4.DisplayDetails();
            
            // Will call Copy Cons
            Student student5 = new Student(student4);
            student5.DisplayDetails();

        }
    }
}
