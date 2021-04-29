using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mapping
{
    public interface DataU
    {
        Student Get(int id);
        Student Get(string name);
        void Put(Student student);
    }
}
