using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskSolving.Model
{
    public enum ResourseType
    {
        Video,
        Presentation,
        Document,
        Other
    }
    internal class Resource
    {
       
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Url  { get; set; }
        public ResourseType Resourse { get; set; }
        public int CourseId { get; set; }
    }
}
