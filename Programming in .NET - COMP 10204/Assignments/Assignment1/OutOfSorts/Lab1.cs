﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

//Author: Thomas Coons
//Student ID: 000317961
//Date: Sept 15th 2024
//Purpose: Employee Sorting Application

//I, Thomas Coons, 000317961 certify that this material is my original work.
//No other person's work has been used without due acknowledgement.
namespace OutOfSorts
{
    internal class Lab1
    {
        static public Employee[] employees = Read();

        /// <summary>
        /// Main method of the application
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string choice = "";

            while (!choice.Equals("6"))
            {
                Console.WriteLine("1. Sort by Employee Name");
                Console.WriteLine("2. Sort by Employee Number");
                Console.WriteLine("3. Sort by Employee Pay Rate");
                Console.WriteLine("4. Sort by Employee Hours");
                Console.WriteLine("5. Sort by Employee Gross Pay");
                Console.WriteLine("6. Exit");
                Console.WriteLine("");
                Console.Write("Enter Choice: ");
                choice = Console.ReadLine();
                try
                {
                    Console.Clear();
                    int numChoice = int.Parse(choice);
                    Console.WriteLine($"{"NAME",-20} {"NUMBER",-10} {"RATE",-10} {"HOURS",-10}");
                    foreach (Employee employee in employees) { Console.WriteLine(employee); }
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                Console.WriteLine("");
            }
        }

        /// <summary>
        /// Reads in text from employees.txt and returns an array of Employee Objects
        /// </summary>
        /// <returns>An array of Employee Objects</returns>
        /// <exception cref="Exception"></exception>
        public static Employee[] Read()
        {
            StreamReader data = new StreamReader("employees.txt");
            Employee employee = null;

            // Checking if file is empty using .Peek() Method. Source: 
            if (data.Peek() == -1)
            {
                throw new Exception("File is empty.");
            }

            string[] dataList = data.ReadToEnd().Trim().Split('\n');

            // Checking if file size will produce an array larger than 100 employees. 
            if (dataList.Length > 100)
            {
                throw new Exception("File size too large.");
            }
            else
            {
                Employee[] employees = new Employee[dataList.Length];
                string[] employeeList = new string[100];
                int empInfoTracker = 0;

                for (int i = 0; i < dataList.Length; i++)
                {
                    employeeList[i] = (dataList[i]);
                }

                for (int i = 0; i < dataList.Length; i++)
                {
                    while (empInfoTracker < 1)
                    {
                        string name = employeeList[i].Split(',')[0].Trim();
                        int number = int.Parse(employeeList[i].Split(',')[1].Trim());
                        decimal rate = decimal.Parse(employeeList[i].Split(',')[2].Trim());
                        double hours = double.Parse(employeeList[i].Split(',')[3].Trim());

                        employee = new Employee(name, number, rate, hours);
                        employees[i] = employee;
                        empInfoTracker++;
                    }
                    empInfoTracker = 0;
                }
                return employees;
            }
        }

        public static void Sort()
        {

        }
    }
}
