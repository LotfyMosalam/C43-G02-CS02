using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    class Program
    {
        static void Main()
        {
            #region 1-	Write a program that allows the user to enter a number then print it.

            ///Console.Write($"Enter a number : ");
            ///int x = int.Parse(Console.ReadLine());       
            ///Console.WriteLine("The Number is : " + x );

            #endregion


            #region 2-	Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen 
            /// First Solution
            ///string MyDate = "I Was born in 1998";
            ///if (int.TryParse(MyDate , out int Statement))
            ///{
            ///    Console.WriteLine("My Date is : " + Statement);
            ///}
            ///else
            ///{
            ///    Console.WriteLine("This operation is invalid because it contains non-numeric characters.");
            ///}
            #endregion


            #region 3-	Write C# program that Perform a simple arithmetic operation with floating-point numbers And mention what will happen
            ///decimal Number1 = 1.35M;
            ///decimal Number2 = 2.46M;
            ///decimal Result = Number1 + Number2;
            ///Console.WriteLine("The result is : " + Result);
            #endregion


            #region 4-	Write C# program that Extract a substring from a given string.
            ///string MyFullName = "Lotfy abdalla lotfy mosalam";
            ///string MyFatherName = MyFullName.Substring(6);
            ///string MyGrandFatherName = MyFullName.Substring(14, 5);
            ///string MyFamilyName = MyFullName.Substring(20, 7);
            ///
            ///Console.WriteLine(MyFullName);
            ///Console.WriteLine(MyFatherName);
            ///Console.WriteLine(MyGrandFatherName);
            ///Console.WriteLine(MyFamilyName);
            #endregion


            #region 5-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen .
            ///int x = 5;
            ///int y = 10;
            ///Console.WriteLine( $"{x} , {y}" );
            ///y = x;
            ///Console.WriteLine($"modification1 : {x} , {y}");
            ///x = 15;
            ///Console.WriteLine($"modification2 : {x} , {y}");
            #endregion


            #region 6-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen.
            ///Car car1 = new Car();
            ///car1.Model = "Toyota";
            ///Car car2 = new Car();
            ///car2.Model = "Ford";
            ///Console.WriteLine($"The Models is => car1 model : {car1.Model}, car2 model : {car2.Model}");
            ///car2 = car1;
            ///Console.WriteLine($"modification1 => car1 model : {car1.Model}, car2 model : {car2.Model}");
            ///car1.Model = "Mercedes-Benz";
            ///Console.WriteLine($"modification2 => car1 model : {car1.Model}, car2 model : {car2.Model}");
            #endregion


            #region 7-	Write C# program that take two string variables and print them as one variable. 
            ///string MyFirstName = "Lotfy";
            ///string MyLastName = "Mosalam";
            ///string MyFullName = MyFirstName + " " + MyLastName;
            ///Console.WriteLine(MyFullName);
            #endregion


            #region 8-	Write a program that calculates the simple interest given the principal amount, rate of interest, and time. The formula for simple interest is Interest = (principal * rate * time) / 100.

            ///decimal principal, rate, time, Interest;
            ///Console.Write("Enter the principal : ");
            ///principal =Convert.ToDecimal(Console.ReadLine());
            ///Console.Write("Enter the rate : ");
            ///rate = Convert.ToDecimal(Console.ReadLine());
            ///Console.Write("Enter the time : ");
            ///time = Convert.ToDecimal(Console.ReadLine());
            ///
            ///Interest = (principal * rate * time) / 100;
            ///Console.WriteLine("The Interest is : " + Interest);

            #endregion


            #region 9-	Write a program that calculates the Body Mass Index (BMI) given a person's weight in kilograms and height in meters. The formula for BMI is BMI = (Weight) / (Height * Height).

            ///decimal Weight, Height, BMI;
            ///Console.Write("Enter your Weight : ");
            ///Weight = Convert.ToDecimal(Console.ReadLine());
            ///Console.Write("Enter your Height : ");
            ///Height = Convert.ToDecimal(Console.ReadLine());
            ///
            ///BMI = (Weight) / (Height * Height) ;
            ///Console.WriteLine("The BMI is : " + BMI);

            #endregion


            #region 10-	Write a program that uses the ternary operator to check if the temperature is too hot, too cold, or just good. Assign the result in a variable then display the result. Assume that below 10 degrees is "Just Cold", above 30 degrees is "Just Hot", and anything else is "Just Good".

            ///Console.Write("Enter the temperature : ");
            ///double temperature = Convert.ToDouble(Console.ReadLine());
            ///string result = (temperature < 10) ? "Just Cold" : 
            ///                (temperature > 30) ? "Just Hot"  : "Just Good";
            ///         
            ///Console.WriteLine($"The temperature : {result}");

            #endregion


            #region 11-	Write a program that takes the date from the user and displays it in various formats using string interpolation.
                       // Ex:
            //Today’s date : 20 , 11 , 2001
            //Today's date : 20 / 11 / 2001
            //Today's date : 20 – 11 – 2001

            ///Console.Write("Enter The day : ");
            ///int day =Convert.ToInt32(Console.ReadLine());
            ///Console.Write("Enter The month : ");
            ///int month = Convert.ToInt32(Console.ReadLine());
            ///Console.Write("Enter The year : ");
            ///int year = Convert.ToInt32(Console.ReadLine());
            ///
            ///Console.WriteLine($"Today’s date : {day} , {month} , {year} ");
            ///Console.WriteLine($"Today’s date : {day} / {month} / {year} ");
            ///Console.WriteLine($"Today’s date : {day} - {month} - {year}");

            #endregion


            #region 12-    DateTime date = new DateTime(2024, 6, 14); Console.WriteLine($"The event is on {date:MM/dd/yyyy}"); .
            /// The answer is :
            /// c - The event is on 06/14/2024
            #endregion


            #region 13-	Which of the following statements is correct about the C#.NET code snippet given below?
            /// The answer is :
            /// f)	A value 1 will be assigned to d.
            #endregion


            #region 14-	Which of the following is the correct output for the C# code given below?
            /// The answer is :
            /// d)	6 1
            #endregion


            #region 15-     What will be the output of the C# code given below?
            /// The answer is :
            /// d)	7 7
            #endregion

        }
    }
}
