using GraphQl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Services
{
    public interface IStudent
    {
        List<Student> GetAll();
        Student Get(int id);
    }

    public class StudentService : IStudent
    {
        public Student Get(int id)
        {
            List<Student> students = new();
            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student { id = i, name = $"st{i}", age = i });
            }

            return students.FirstOrDefault(x => x.id == id);
        }

        public List<Student> GetAll()
        {
            List<Student> students = new();
            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student { id = i, name = $"st{i}", age = i });
            }

            return students;
        }
    }
}
