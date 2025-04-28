using System;
using System.Threading.Tasks;
namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentDetails()
            );
            Console.ReadLine();
        }

        private static void PrintTeacherDetails()
        {
            //Singleton fromTeacher = Singleton.GetInstance();
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintStudentDetails()
        {
            //Singleton fromStudent = Singleton.GetInstance();
            Singleton fromStudent = Singleton.GetInstance; 
            fromStudent.PrintDetails("From Student");
        }
    }
}