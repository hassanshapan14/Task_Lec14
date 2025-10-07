using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolving.Model
{
    internal class Student
    {
        public int StudentId { get; set; }
        public int BirthDate { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime RegisteredOn { get; set; }
        public List<Course> Course { get; set; }
        public List<Homework> Homworks { get; set; }
    }
}
