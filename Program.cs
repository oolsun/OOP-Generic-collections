﻿using GenericsDemo2;
using System.Collections.Generic;

namespace OOP_Generic_collections
{
    // Olov Olsson Sundqvist .NET23
    internal class Program
    {
        static void Main(string[] args)
        {
            // Adds 5 objects from Employee class.
            Employee E1 = new Employee()
            {
                ID = 110,
                Name = "Olov",
                Gender = "Male",
                Salary = 17000
            };

            Employee E2 = new Employee()
            {
                ID = 111,
                Name = "Johanna",
                Gender = "Female",
                Salary = 38500
            };

            Employee E3 = new Employee()
            {
                ID = 112,
                Name = "Elliot",
                Gender = "Male",
                Salary = 1325
            };

            Employee E4 = new Employee()
            {
                ID = 113,
                Name = "Henri",
                Gender = "Male",
                Salary = 1325
            };

            Employee E5 = new Employee()
            {
                ID = 114,
                Name = "Maja",
                Gender = "Female",
                Salary = 47000
            };

            // Part 1 of assignment. Stack.
            Console.WriteLine("********************************");
            Console.WriteLine("          Part 1 STACK");
            Console.WriteLine("********************************\n");

            // Create stack.
            Stack<Employee> employeeStack = new Stack<Employee>();

            // Add objects to stack using Push.
            employeeStack.Push(E1);
            employeeStack.Push(E2);
            employeeStack.Push(E3);
            employeeStack.Push(E4);
            employeeStack.Push(E5);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Print all objects in stack");
            Console.WriteLine("--------------------------------");

            // Print all objects in stack.
            foreach (Employee employee in employeeStack)
            {
                Console.WriteLine("ID: " + employee.ID + "\nNamn: " + employee.Name + "\nKön: " + employee.Gender + "\nLön: " + employee.Salary);
                Console.WriteLine("Objekt kvar i stacken: " + employeeStack.Count());
                Console.WriteLine("********************************");
            }

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Retrieve using Pop Method");
            Console.WriteLine("--------------------------------");

            // Print and delete objects from stack using Pop.
            Employee poppedEmployee1 = employeeStack.Pop();      
            Console.WriteLine("ID: " + poppedEmployee1.ID + "\nNamn: " + poppedEmployee1.Name + "\nKön: " + poppedEmployee1.Gender + "\nLön: " + poppedEmployee1.Salary);
            Console.WriteLine("Objekt kvar i stacken: " + employeeStack.Count);
            Console.WriteLine("********************************");
            Employee poppedEmployee2 = employeeStack.Pop();
            Console.WriteLine("ID: " + poppedEmployee2.ID + "\nNamn: " + poppedEmployee2.Name + "\nKön: " + poppedEmployee2.Gender + "\nLön: " + poppedEmployee2.Salary);
            Console.WriteLine("Objekt kvar i stacken: " + employeeStack.Count);
            Console.WriteLine("********************************");
            Employee poppedEmployee3 = employeeStack.Pop();
            Console.WriteLine("ID: " + poppedEmployee3.ID + "\nNamn: " + poppedEmployee3.Name + "\nKön: " + poppedEmployee3.Gender + "\nLön: " + poppedEmployee3.Salary);
            Console.WriteLine("Objekt kvar i stacken: " + employeeStack.Count);
            Console.WriteLine("********************************");
            Employee poppedEmployee4 = employeeStack.Pop();
            Console.WriteLine("ID: " + poppedEmployee4.ID + "\nNamn: " + poppedEmployee4.Name + "\nKön: " + poppedEmployee4.Gender + "\nLön: " + poppedEmployee4.Salary);
            Console.WriteLine("Objekt kvar i stacken: " + employeeStack.Count);
            Console.WriteLine("********************************");
            Employee poppedEmployee5 = employeeStack.Pop();
            Console.WriteLine("ID: " + poppedEmployee5.ID + "\nNamn: " + poppedEmployee5.Name + "\nKön: " + poppedEmployee5.Gender + "\nLön: " + poppedEmployee5.Salary);
            Console.WriteLine("Objekt kvar i stacken: " + employeeStack.Count);
            Console.WriteLine("********************************");

            // Add objects to stack again.
            employeeStack.Push(E1);
            employeeStack.Push(E2);
            employeeStack.Push(E3);
            employeeStack.Push(E4);
            employeeStack.Push(E5);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Retrieve using Peek Method");
            Console.WriteLine("--------------------------------");

            // Peek and print two objects in stack (peek only shows the top object in the stack without removing so output will be the same on both).
            Employee peekE2 = employeeStack.Peek();
            Console.WriteLine("ID: " + peekE2.ID + "\nNamn: " + peekE2.Name + "\nKön: " + peekE2.Gender + "\nLön: " + peekE2.Salary);
            Console.WriteLine("Objekt kvar i stacken: " + employeeStack.Count);
            Console.WriteLine("********************************");
            Employee peekE4 = employeeStack.Peek();
            Console.WriteLine("ID: " + peekE4.ID + "\nNamn: " + peekE4.Name + "\nKön: " + peekE4.Gender + "\nLön: " + peekE4.Salary);
            Console.WriteLine("Objekt kvar i stacken: " + employeeStack.Count);
            Console.WriteLine("********************************");

            Console.WriteLine("--------------------------------");
            Console.WriteLine("See if Employee E3 is in stack");
            Console.WriteLine("--------------------------------");

            // See if stack contains object E3. If it does, print "Stack contains E3". Else print "Stack does not contains E3".
            if (employeeStack.Contains(E3))
            {
                Console.WriteLine("Stacken innehåller E3");
            }
            else
            {
                Console.WriteLine("Stacken innehåller inte E3");
            }

            // Part 2 of assignment. List.
            Console.WriteLine("\n********************************");
            Console.WriteLine("          Part 2  LIST");
            Console.WriteLine("********************************\n");

            // Create a new list.
            var employeeList = new List<Employee>();

            // Add object to list.
            employeeList.Add(E1);
            employeeList.Add(E2);
            employeeList.Add(E3);
            employeeList.Add(E4);
            employeeList.Add(E5);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("See if Employee E1 is in list");
            Console.WriteLine("--------------------------------");

            // See if object E1 is in list. If it does, print "E1 is in list" else print "E1 is not in list".
            if (employeeList.Contains(E1))
            {
                Console.WriteLine("E1 finns i listan");
            }
            else
            {
                Console.WriteLine("E1 finns inte i listan");
            }

            // Find method to find the first Male in list.
            var firstMale = employeeList.Find(x => x.Gender == "Male");

            // Print the first male in list.
            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("First male in list");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("ID: " + firstMale.ID + "\nNamn: " + firstMale.Name + "\nKön: " + firstMale.Gender + "\nLön: " + firstMale.Salary);

            // FindAll to find all males in list.
            var allMales = employeeList.FindAll(x => x.Gender == "Male");

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("All males in list");
            Console.WriteLine("--------------------------------");

            // Print all males in list.
            foreach (var male in allMales)
            {
                Console.WriteLine("ID: " + male.ID + "\nNamn: " + male.Name + "\nKön: " + male.Gender + "\nLön: " + male.Salary);
                Console.WriteLine("********************************");
            }
        }
    }
}