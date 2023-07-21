using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13BasicsOFc_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Task1();
                Task2();
                Task3();
                Task4();
                Task5();
                Task6();
                Task7();
                Task8();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error! "+ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
        public static void Task1()
        {
            //Task 1
            Console.WriteLine("Hello, World!");
        }
        public static void Task2()
        {
            //Task 2
            Console.WriteLine("\n*********************************");
            string name;
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}!");
        }
        public static void Task3()
        {
            //Task 3
            Console.WriteLine("\n*********************************");
            Console.WriteLine("Arithmetic Operations");
            int num1, num2,add,sub,mul,div,mod;
            Console.Write("Enter 1st Number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter 2nd Number: ");
            num2 = int.Parse(Console.ReadLine());
            add = num1 + num2;
            Console.WriteLine($"Addition: {num1} + {num2} = {add}");
            sub = num1 - num2;
            Console.WriteLine($"Subtraction: {num1} - {num2} = {sub}");
            mul = num1 * num2;
            Console.WriteLine($"Multiplication: {num1} * {num2} = {mul}");
            div = num1 / num2;
            Console.WriteLine($"Division: {num1} / {num2} = {div}");
            mod = num1 % num2;
            Console.WriteLine($"Modulus: {num1} % {num2} = {mod}");
        }
        public static void Task4()
        {
            //Task 4
            Console.WriteLine("\n*********************************");
            Console.WriteLine("Check Integer Even or Odd");
            Console.Write("ENter an Integer: ");
            int num = int.Parse(Console.ReadLine());
            if(num % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is Odd");
            }
        }
        public static void Task5()
        {
            //Task 5
            Console.WriteLine("\n*********************************");
            Console.WriteLine("Printing numbers from 1-10");
            int i = 1;
            while(i <= 10)
            {
                Console.Write(i+ " ");
                i++;
            }
        }
        public static void Task6()
        {
            //Task 6
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("Calculate Sum and average of Array");
            int [] numbers = { 2, 3, 4, 5, 6 };
            int sum = 0,count =0, average;
            Console.Write("Sum of ");
            for (int num=0; num<numbers.Length; num++)
            {
                Console.Write(numbers[num]+ " ");
                sum += numbers[num];
                count++;
            }
            Console.Write("is: "+sum);
            average = sum / count;
            Console.WriteLine("\nAverage: " + average);
        }
        public static void Task7()
        {
            //Task 7
            Console.WriteLine("\n\n*********************************");
            Console.WriteLine("Factorial Calculation");
            Console.Write("Enter a integer: ");
            int num;
            num = int.Parse(Console.ReadLine()) ;
            Console.WriteLine($"Factorial of {num} = "+CalculateFactorial(num)); 
            
        }
        public static int CalculateFactorial(int num)
        {
            if (num == 1)
                return 1;
            else
                return num * CalculateFactorial(num - 1);
        }
        public static void Task8()
        {
            //Task 8
            Console.WriteLine("\n*********************************");
            Console.WriteLine("Differentiating Person Age");
        start:
            Console.Write("Enter Age: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                if(value < 18) { Console.WriteLine("Person is Minor"); }
                else if(18 <= value && value < 65) { Console.WriteLine("Person is Adult"); }
                else { Console.WriteLine("Person is Senior"); }
            }
            else
            {
                Console.WriteLine("Not a valid Number, Try Again..");
                goto start;
            }

        }
    }
}
