// See https://aka.ms/new-console-template for more information
using CSharpBook.Basics;
using CSharpBook.Opps;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

//Encapsulation example1 = new Encapsulation();
//example1.MainMethod();

//Inheritance example
//Inheritance example2 = new Inheritance();
//example2.InheritanceMethod();
DataTypes objDatatType = new DataTypes();
objDatatType.ValueType();
objDatatType.ReferenceType();
//Example with a Custom Class (Reference Type):
EmployeeDetails employee1 = new EmployeeDetails { Name = "Hema", Age = 25 };
EmployeeDetails employee2 = employee1; // Both employee1 and employee2 reference the same object
employee2.Name = "Latha";     // Modifying employee2 affects employee1

Console.WriteLine($"employee1.Name: {employee1.Name}, employee2.Name: {employee2.Name}"); // Output: employee1.Name: Latha, employee2.Name:Latha

//Example with struct (Value Type):
Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1; // A copy of the struct p1 is assigned to p2
p2.X = 99;     // Modifying p2 does not affect p1

Console.WriteLine($"p1.X: {p1.X}, p2.X: {p2.X}"); // Output: p1.X: 1, p2.X: 99