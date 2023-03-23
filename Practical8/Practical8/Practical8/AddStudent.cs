﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    public class AddStudent : IAddStudent
    {
        public void AddNewStudent(IManageStudentList studentList)
        {
            try
            {
                IStudent student = FactoryClass.GetStudent();
                List<IStudent> stdList = studentList.Students;
                Console.WriteLine("---- Add New Student ----");
                Console.WriteLine();

                Console.WriteLine("Enter ID of student");
                student.Id = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter first name of student : ");
                student.FirstName = Console.ReadLine();

                Console.WriteLine("Enter last name of student : ");
                student.LastName = Console.ReadLine();

                Console.WriteLine("Enter email address of student : ");
                student.Email = Console.ReadLine();

                Console.WriteLine("Enter Age of student");
                student.Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Contact No. of student");
                student.PhoneNumber = Convert.ToInt64(Console.ReadLine());

                stdList.Add(student);
                studentList.Students = stdList;
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
