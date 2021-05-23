using coreApi1._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreApi1._2.Reposatry
{
   public interface Ireposatry
    {
        List<Student> getall();
        Student getbyid(int id);
        string Add(MVStudent s);
        List<Student> Edite(int id, MVStudent s);
    }
}
