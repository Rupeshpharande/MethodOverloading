using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class EmployeeConstOverload
    {
        string name;
        int id;

        //Constructor with no parameter
        public EmployeeConstOverload() 
        {
            this.id = 0;
            this.name = "Unknown";
        }

        //Constructor With one parameter
        public EmployeeConstOverload(string name)
        {
            this.name = name;
        }

        //Constructor with two parameter
        public EmployeeConstOverload(int id,string name)
        {
            this.id = id;
            this.name = name;
        }

        public string Print()
        {
            return $"{id},{name}";
        }

    }
}
