using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._7Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Ivanov Ivan Ivanovich";
            int age = 25;
            string email = "ivanovivan@gmail.com";
            double pointsProgramming = 4.5;
            double pointsMath = 4.7;
            double pointsPhysics = 3.9;
            string pattern = "Full name: {0} \nAge: {1} \nEmail: {2} \nPoints in Programmins: {3} \nPoints in Math: {4} \nPoints in Physics: {5}";
            Console.WriteLine(pattern,
                              fullName,
                              age,
                              email,
                              pointsProgramming,
                              pointsMath,
                              pointsPhysics);
            Console.ReadKey();
            double pointsSum = pointsProgramming + pointsMath + pointsPhysics;
            Console.WriteLine(pointsSum);
            Console.ReadKey();
            double pointsArithmeticMeans = pointsSum / 3;
            Console.WriteLine(pointsArithmeticMeans);
            Console.ReadKey();


        }
    }
}
