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
            Hashtable data = new Hashtable();


            //get the  student id
            Console.WriteLine("Enter your id number:");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter your GPA:");
            gpa = Convert.ToDouble(Console.ReadLine());

            Student student = new Student(id, name, gpa);
            Hashmap<string, Student> studentInfo1 = new Hashmap<string, Student>();
            Hashmap<int, Student> studentInfo2 = new Hashmap<int, Student>();

            Console.WriteLine("Storing your information");
            studentInfo1.Put(name, student);
            studentInfo2.Put(id, student);

            Console.WriteLine("Let's check by name if that student exist");
            name = Console.ReadLine();
            var studentInfoByName = studentInfo1.Get(name);
            Console.WriteLine("Name is: "+ studentInfoByName.name );
            Console.WriteLine( "ID is " + studentInfoByName.id);
            Console.WriteLine("GPA is " + studentInfoByName.gpa);

            Console.WriteLine("Let's check by ID if that student exist");
            name = Console.ReadLine();
            var studentInfoByID = studentInfo2.Get(id);
            Console.WriteLine("Name is: " + studentInfoByID.name);
            Console.WriteLine("ID is " + studentInfoByID.id);
            Console.WriteLine("GPA is " + studentInfoByID.gpa);





        }
    }
}
