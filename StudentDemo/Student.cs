using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDemo
{
    class Student
    {
        readonly int id;
        string name;
        static string batch;
        int score;
        public const string Institue="ABC Institue";


        public static void Batch()
        {
           
            
            Console.WriteLine("Batch Code is " +batch);
        }

        // Static Con > Can be only 1 within a class
        // It shoud be parameterless , cannot have any access specefier
        static Student()
        {
            batch = "B001";
        }
        // Def Cons  > COULD BE ONLY ONE
        public Student() { }

        //Para Cons
        public Student(int id)
        {
            this.id = id;
            Console.WriteLine("ENter Name");
            name = Console.ReadLine();
            //Console.WriteLine("Enter Batch");
            //batch = Console.ReadLine();
            Console.WriteLine("ENter Score");
            score = byte.Parse(Console.ReadLine());

        }
        //Para Cons

        public Student(int id, string name)
        {
            this.id = id;
             
            this.name = name;
            //Console.WriteLine("Enter Batch");
            //batch = Console.ReadLine();
            Console.WriteLine("ENter Score");
            score = byte.Parse(Console.ReadLine());

        }

        //Fully Para Cons

        public Student(int id, string name, int score)
        {
            this.id = id;

            this.name = name;
           
            this.score = score;

        }

        // Copy Cons
        public Student(Student student)
        {
            Console.WriteLine("Enter ID");
            id = Byte.Parse(Console.ReadLine());

            this.name = student.name;
            //this.batch = student.batch;
            this.score = student.score;
        }

        public void GetDetails()
        {
            //Console.WriteLine("Enter ID");
            //id = Byte.Parse(Console.ReadLine());
            Console.WriteLine("ENter Name");
            name = Console.ReadLine();
            //Console.WriteLine("Enter Batch");
            //batch = Console.ReadLine();
            Console.WriteLine("ENter Score");
            score = byte.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine($"Rollo is {id}");
            Console.WriteLine($"Name is {name}");
            //Console.WriteLine($"Batch is {batch}");
            Console.WriteLine($"Score is {score}");

        }
    }
}
