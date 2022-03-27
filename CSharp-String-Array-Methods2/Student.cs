using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_String_Array_Methods2
{
    internal class Student:Group
    {

        public Student(string fullname)
        {
            this.FullName = fullname;
        }

        public string FullName;
        public string GroupNo;
        public int AvgPoint;
    }
}
