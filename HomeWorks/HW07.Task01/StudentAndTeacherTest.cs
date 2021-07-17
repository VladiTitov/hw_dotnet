using System;

namespace HW07.Task01
{
    class StudentAndTeacherTest
    {
        static void Main()
        {
            Person person = new Person();
            person.SayHello();

            Student student = new Student(age:21);
            student.SayHello();
            student.ShowAge();

            Teacher teacher = new Teacher(age:30);
            teacher.SayHello();
            teacher.Explain();

            Console.ReadLine();
        }
    }
}
