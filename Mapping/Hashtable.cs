using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    public class Hashtable:DataU
    {
        Hashmap<string, Student> ByName = new Hashmap<string, Student>();
        Hashmap<int, Student> ByID = new Hashmap<int, Student>();

       
        //get the student ID and return the as Student ID
        public Student Get(int ID)
        {
            
            return ByID.Get(ID);
        }

        //get the student name and return the as Student name
        public Student Get(string name)
        {
            return ByName.Get(name);
        }

        //put student information
        public void Put(Student student)
        {

           
            //Add student to by name 
           ByName.Put(student.name, student);

            //Add student to By Id
            ByID.Put(student.id, student);


        }



    }
}
