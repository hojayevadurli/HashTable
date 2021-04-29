using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
   public class Student
    {
        public int id;
        public string name;
        public double gpa;

       
        //constuctor
        public Student(int ID, string Name, double GPA)
        {

            this.id = ID;
            this.name = Name;
            this.gpa = GPA;

        }
    }
}
