using GraphQl.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQl.Models
{
    public class Query
    {
        private IStudent _student;
        public Query(IStudent student)
        {
            _student = student;
        }

        public List<Student> GetAllStudents => _student.GetAll();

        public Student GetStudent(int id) => _student.Get(id);
    }
}
