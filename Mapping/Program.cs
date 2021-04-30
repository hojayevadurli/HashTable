using System;

namespace Mapping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");            
            int id;
            string name;
            double gpa;
            //generic type key to get the key from the user
           // K key;
           /// StudentData data = new StudentData();


            //get the  student id
            Console.WriteLine("Enter your id number:");
            id = Convert.ToInt32(Console.ReadLine());
            name = Console.ReadLine();
            gpa= Convert.ToDouble(Console.ReadLine());

            Student student = new Student(id, name, gpa);

            //data.Put(student);


            
        }
    }
}
