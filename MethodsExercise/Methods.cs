﻿using System;
namespace MethodsExercise
{
	public class Methods
	{
        public static int Add(int num1, int num2, int age)
        {
            Console.WriteLine(num1 + num2 + age);

            return num1 + num2 + age;
        }

        public static int Subtract(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);

            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);

            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            Console.WriteLine(num1 / num2);

            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            Console.WriteLine(num1 % num2);

            return num1 % num2;
           
        }
	}
}

