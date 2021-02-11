using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student()
           {
               Name = "Mayardes",
               Register = 123,
           };
            student.ToStudy();
            student.ToSleep();


            Staff staff = new Staff();
            staff.Name = "Erich";
            staff.Department = "Development";
            staff.ToWork();
            staff.ToSleep();
        }
    }
}
