using System;

namespace CSharp_String_Array_Methods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qrup yaratmaq ucun qrupun nomresini daxil edin: ");
            string groupNo = Console.ReadLine();

            //while ()
            //{
            //    Console.WriteLine("Qrupun nomresi 5 simvoldan ibaret olmalidir: ");
            //    groupNo = Console.ReadLine();
            //}
                            
            while (groupNo.Length != 5 || !char.IsUpper(groupNo[0]) || !char.IsUpper(groupNo[1]) || !char.IsDigit(groupNo[2]) || !char.IsDigit(groupNo[3]) || !char.IsDigit(groupNo[4]))
            {
                Console.WriteLine("Qrupun nomresi 2 boyuk herfden ve 3 reqemden ibaret olmalidir: ");
                groupNo = Console.ReadLine();
            }






            int studentLimit = 0;
            do
            {
                Console.WriteLine("Max telebe sayini daxil edin: ");
                studentLimit = Convert.ToInt32(Console.ReadLine());
            } while (studentLimit<0 || studentLimit>20);

            Group group = new Group();
            group.No = groupNo;
            group.StudentLimit = studentLimit;

            string chosen = "";
            do
            {
                Console.WriteLine("1. Telebe elave et\n" +
                                  "2. Butun telebelere bax\n" +
                                  "3. Telebeler uzre axtaris et\n" +
                                  "0. Proqrami bitir");
                chosen = Console.ReadLine();
                if (chosen=="1")
                {
                    if (group.Students.Length+1 <= studentLimit)
                    {

                        Console.WriteLine("Telebenin ad ve soyadini daxil edin: ");
                        string fullname = Console.ReadLine();
                        Console.WriteLine("Telebenin qrup nomresini daxil edin: ");
                        string no = Console.ReadLine();
                        while (no.Length != 5 || !char.IsUpper(no[0]) || !char.IsUpper(no[1]) || !char.IsDigit(no[2]) || !char.IsDigit(no[3]) || !char.IsDigit(no[4]))
                        {
                            Console.WriteLine("Qrupun nomresi 2 boyuk herfden ve 3 reqemden ibaret olmalidir: ");
                            no = Console.ReadLine();
                        }
                        Console.WriteLine("Telebenin ortalama qiymetini daxil edin: ");
                        int avgPoint = Convert.ToInt32(Console.ReadLine());

                        Student student = new Student(fullname);
                        student.GroupNo = no;
                        student.AvgPoint = avgPoint;

                        group.AddStudent(student);

                    }
                    else
                    {
                        Console.WriteLine("Telebe limitini kecdiniz..");    
                    }

                }
                else if (chosen == "2")
                {
                    group.GetInfo();
                }
                else if (chosen == "3")
                {
                    Console.WriteLine("Axtarmaq istediyiniz telebenin ad ve soyadini yazin: ");
                    string filterName = Console.ReadLine();
                    foreach (var item in group.FilterStudents(filterName))
                    {
                        Console.WriteLine($"Ad Soyad: {item.FullName} " +
                                          $"Qrup nomresi: {item.GroupNo} " +
                                          $"Ortalama: {item.AvgPoint}");
                    }
                }

            } while (chosen!="0");
        }
    }
}
