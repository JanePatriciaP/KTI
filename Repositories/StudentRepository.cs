using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using MyWebApp.Models;

namespace MyWebApp.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private static List<Student> _students = new List<Student>
        {
            new Student{ StudentId = 1, Name = "John Doe", Email = "john@gmail.com", BirthDate = new DateOnly(2000, 2, 20) },
            new Student{ StudentId = 2, Name = "Jane Doe", Email = "john@gmail.com", BirthDate = new DateOnly(2001, 2, 20) },
            new Student{ StudentId = 3, Name = "Jill Doe", Email = "john@gmail.com", BirthDate = new DateOnly(2002, 2, 20) },
            new Student{ StudentId = 4, Name = "James Doe", Email = "john@gmail.com", BirthDate = new DateOnly(2003, 2, 20) },
        };

        public IEnumerable<Student> GetAll()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.First(s => s.StudentId == id);
        }
    }
}