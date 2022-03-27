using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_String_Array_Methods2
{
    internal class Group
    {
        public string No;
        public Student[] Students = new Student[0];
        public int StudentLimit;

        public Student[] AddStudent(Student student)
        {
            Array.Resize(ref this.Students, this.Students.Length+1);
            this.Students[this.Students.Length-1] = student;
            return this.Students;

        }

        public void GetInfo()
        {
            Console.WriteLine("-----Telebeler siyahisi-----");
            foreach (var item in this.Students)
            {
                Console.WriteLine($"Ad Soyad: {item.FullName} " +
                                  $"Qrup nomresi: {item.GroupNo} " +
                                  $"Ortalama: {item.AvgPoint}");
            }
        }

        public Student[] FilterStudents(string fullname)
        {
            int count = 0;
            foreach (var student in this.Students)
            {
                if (student.FullName == fullname)
                {
                    count++;
                }
            }
            Student[] filteredStudents = new Student[count];
            int j = 0;
            for (int i = 0; i < this.Students.Length; i++)
            {
                if (this.Students[i].FullName == fullname)
                {
                    filteredStudents[j] = this.Students[i];
                    j++;
                }
            }

            return filteredStudents;
        }
    }
}
