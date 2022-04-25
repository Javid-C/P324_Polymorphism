
using System;

namespace P324_Polymorphism_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Home work
            Student student = new Student("Chingiz", "Rahimov");
            Student student1 = new Student("Fakhrin", "Aliyev");
            Student student2 = new Student("Jamal", "Samadov");

            //student.Point = 100;

            student.Age = 100;
            //Console.WriteLine(student.Age);
            //student.Password = "1111";

            //Console.WriteLine(student.Password);
            //Student student = new Student();
            Group group = new Group("P324", 3);

            group.AddStudent(student);
            group.AddStudent(student1);
            group.AddStudent(student2);


            Console.WriteLine("\n");

            group.GetStudents();
            #endregion

            #region Polymorphism
            //Animal animal = new Animal();
            //Rabbit rabbit = new Rabbit();
            //Eagle eagle = new Eagle();

            //Animal animal = new Animal();
            //Animal rabbit = new Rabbit();
            //Animal eagle = new Eagle();

            //animal.MakeSound();
            //rabbit.MakeSound();
            //eagle.MakeSound();
            #endregion
        }

    }
}
