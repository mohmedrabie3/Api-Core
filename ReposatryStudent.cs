using coreApi1._2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreApi1._2.Reposatry
{
    public class ReposatryStudent :Ireposatry
    {
        learnhouseContext db;
        public ReposatryStudent(learnhouseContext db)
        {
            this.db = db;
        }
        public List<Student> getall() 
        {
            return db.Students.ToList();
        }
        public Student getbyid(int id) 
        {
            Student s = db.Students.Find(id);
            return s;
        }
        public string Add(MVStudent s) 
        {
            Student ss = new Student();
            ss.Id = s.Id;
            ss.Name = s.Name;
            ss.Age = s.Age;
            ss.Deptid = s.Deptid;
            db.Students.Add(ss);
            db.SaveChangesAsync();
            return "ok";
        }
        public List<Student> Edite(int id, MVStudent s) 
        {
            Student ss = db.Students.Where(n => n.Id == id).FirstOrDefault();
            ss.Name = s.Name;
            ss.Age = s.Age;
            ss.Deptid = s.Deptid;
            db.SaveChanges();
            return db.Students.ToList();
        }
    }
}
