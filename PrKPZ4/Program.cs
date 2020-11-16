using System;
using ClassLibrary;
namespace PrKPZ4



{
    class Program
    {


        static void Main(string[] args)
        {
            Teacher teacher = new Teacher();
            Library_user library_User = new Library_user();
            Applicant applicant = new Applicant();
            Student student = new Student();
            Human human = new Human();
            Console.WriteLine("людина");
            human.Init_Human();
            human.Show_Info();
            Console.WriteLine("студент");
            student.Init_Student();
            student.Show_Info();
            Console.WriteLine("абітуріент");
            applicant.Init_Aplicant();
            applicant.Show_Info();
            Console.WriteLine("вчитель");
            teacher.Init_Teacher();
            teacher.Show_Info();
            Console.WriteLine("користувач");
            library_User.Init_Library_user();
            library_User.Show_Info();

        }
    }
}
