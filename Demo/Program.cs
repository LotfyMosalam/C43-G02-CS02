using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Comments
            // single line comment
            // multiple line comment
            /*
             * 
             * 
             * 
             */
            #endregion

            #region Variable Decleration
            //int number = 10;
            //Console.WriteLine($"The number is : {number}");
            #endregion

            #region Value Type
            //int x = 5;
            //int y = 10;
            //Console.WriteLine($"{x} , {y}");
            //y = x;
            //Console.WriteLine($"{x} , {y}");
            //x = 3;
            //Console.WriteLine($"{x} , {y}");

            #endregion

            #region Reference Type
            //Point p1 = new Point();
            //p1.x = 1;
            //p1.y = 2;  
            //Point p2 = new Point();
            //p2.x = 3; 
            //p2.y = 4;
            //Console.WriteLine($"{p1.x} , {p1.y} , {p2.x} , {p2.y} ");
            //p1 = p2;
            //Console.WriteLine($"{p1.x} , {p1.y} , {p2.x} , {p2.y} ");
            //p1.x = 150;
            //p2.y = 300;
            //Console.WriteLine($"{p1.x} , {p1.y} , {p2.x} , {p2.y} ");
            #endregion

            #region Object
            //object o = new object();
            //o = new string("Lotfy");
            //o = "Ahmed";
            //o = 10;
            //o = 5.5;
            //o = true;
            //o = new DateTime();
            //o = new DateOnly();
            //o = new TimeOnly(); 
            #endregion

            #region Fractions and Discard
            //Fractions
            //float x = 10F;
            //double y = 10.5;
            //decimal z = 10.5M;
            //Discard
            //long number = 1000_000_000;
            //Console.WriteLine(number);
            #endregion

            #region Implicit casting and Explicit casting
            //Implicit casting
            //int x = 10;
            //long y = X;
            //Console.WriteLine(y);
            //Explicit casting
            //long x = 10;
            //int y = (int)x;
            //Console.WriteLine(y);
            #endregion

            #region Convert and Parse and TryParse
            //Convert
            //string numberStr = "123";
            //int number = Convert.ToInt32(numberStr);  
            //Console.WriteLine(number);
            //Parse
            //string numberStr = "456";
            //int number = int.Parse(numberStr);
            //Console.WriteLine(number);
            //TryParse
            //string numberStr = "789";
            //bool success = int.TryParse(numberStr, out int number);
            //if (success)
            //{
            //    Console.WriteLine($"Conversion succeeded: {number}");
            //}
            //else
            //{
            //    Console.WriteLine("Conversion failed.");
            //}

            #endregion

            #region Operators
            //Arithmetic Operators
            //int a = 10;
            //int b = 5;
            //Console.WriteLine(a + b);  
            //Console.WriteLine(a - b);  
            //Console.WriteLine(a * b);  
            //Console.WriteLine(a / b);  
            //Console.WriteLine(a % b);  
            //Comparison Operators
            //int a = 10;
            //int b = 5;
            //Console.WriteLine(a == b); 
            //Console.WriteLine(a != b);  
            //Console.WriteLine(a > b);  
            //Console.WriteLine(a < b);   
            //Console.WriteLine(a >= b); 
            //Console.WriteLine(a <= b);
            //Logical Operators
            //bool a = true;
            //bool b = false;
            //Console.WriteLine(a && b);  
            //Console.WriteLine(a || b);  
            //Console.WriteLine(!a);
            //Assignment Operators
            //int a = 10;
            //a += 5;  
            //Console.WriteLine(a);  

            //a -= 3;  
            //Console.WriteLine(a);  

            //a *= 2;  
            //Console.WriteLine(a);  

            //a /= 4;   
            //Console.WriteLine(a); 

            //a %= 4;  
            //Console.WriteLine(a);  

            //Bitwise Operators
            //int a = 5;   
            //int b = 3;  
            //Console.WriteLine(a & b);  
            //Console.WriteLine(a | b);  
            //Console.WriteLine(a ^ b);  
            //Console.WriteLine(~a);      
            //Console.WriteLine(a << 1); 
            //Console.WriteLine(a >> 1); 
            //Ternary Operator
            //int a = 10;
            //int b = 5;
            //string result = a > b ? "a is greater" : "b is greater";
            //Console.WriteLine(result);  
            // Unary Operators
            //int a = 5;
            //Console.WriteLine(++a); 
            //Console.WriteLine(a--);  
            //Console.WriteLine(a);   
            #endregion

            #region String Formatting
            //Interpolation
            //int age = 25;
            //string message = $"I am {age} years old.";
            //Console.WriteLine(message);  
            //String.Format
            //int age = 25;
            //string message = string.Format("I am {0} years old.", age);
            //Console.WriteLine(message);
            #endregion
        }
    }
}
