using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    class StudentData : DataU
    {
        //List of Student information
        Hashtable students = new Hashtable();

        //StudentData class constructor
        public StudentData()
        {

        }

        public Student Get(int id)
        {
            return id;
        }
        public Student Get(string name)
        {
            return name;
        }
        public void Put(Student pack)
        {
            students.Add(pack);
        }

    }
}
