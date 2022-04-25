using System;
using System.Collections.Generic;
using System.Text;

namespace P324_Polymorphism_Abstract
{
    class Group
    {
        public string No;
        public byte Limit;
        private Student[] Students;

        public Group(string no, byte limit)
        {
            No = no;
            Limit = limit;
            Students = new Student[0];
        }

        public void AddStudent(Student stu)
        {
            if(Students.Length < Limit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = stu;
                //Console.WriteLine($"{stu.Name} adli telebe qrupa elave olundu");
                Console.WriteLine(stu);
            }
            else
            {
                Console.WriteLine("Bu qrupda yer yoxdur");
            }
        }

        public void GetStudents()
        {
            foreach (Student student in Students)
            {
                Console.WriteLine($"{student.Name} {student.Surname}");
            }
        }

    }
}
