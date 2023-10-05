using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Basics
{
    internal class DataTypes
    {
        //Example with int(Value Type):
        struct Point
        {
            public int X;
            public int Y;
        }
        public void ValueType()
        {
            try
            {
                int x = 10;
                int y = x; // A copy of the value in x is assigned to y
                y = 20;    // Modifying y does not affect x

                Console.WriteLine($"x: {x}, y: {y}"); // Output: x: 10, y: 20
            }
            catch(Exception ex)
            {
                Console.WriteLine($"{ex.ToString()}");
            }
        }
        public void ReferenceType()
        {
            try
            {
                string str1 = "Hema";
                string str2 = str1; // Both str1 and str2 reference the same string object
                str2 = "Latha";     // Modifying str2 does not affect str1

                Console.WriteLine($"str1: {str1}, str2: {str2}"); // Output: str1: Hema, str2: Latha

            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.ToString()}");
            }
        }
    }
    class EmployeeDetails
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
