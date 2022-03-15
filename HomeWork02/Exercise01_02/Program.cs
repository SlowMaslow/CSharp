using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string FullName = "Иванов Иван Иванович";
            byte Age = 25;
            string Email = "test@test.ru";
            double ProgrammingResult = 70.5;
            double MathResult = 55;
            double PhysicsResult = 80;
            double Sum;
            double Average;

            string Result = "Ф.И.О.: {0}\nВозраст: {1}\nEmail: {2}\nБаллы по программированию: {3}\nБаллы по математике: {4}\nБаллы по физике: {5}";

            Console.WriteLine("Задание 1\n");

            Console.WriteLine(Result,
                              FullName,
                              Age,
                              Email,
                              ProgrammingResult,
                              MathResult,
                              PhysicsResult);
            Console.ReadLine();

            Console.WriteLine("Задание 2\n");

            Sum = ProgrammingResult + MathResult + PhysicsResult;
            Average = Sum / 3;
            Console.WriteLine($"Средний балл по предметам: {Average}");
            Console.ReadLine();
        }
    }
}
