using System;
using System.Collections.Generic;

#nullable disable

namespace coreApi1._2.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int Deptid { get; set; }

        public virtual Department Dept { get; set; }
    }
}
