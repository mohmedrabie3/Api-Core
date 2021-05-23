using coreApi1._2.Models;
using coreApi1._2.Reposatry;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace coreApi1._2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        ReposatryStudent RS;
        public ValuesController(ReposatryStudent RS)
        {
            this.RS = RS;
        }
        [HttpGet]
        public ActionResult Get() 
        {
            return Ok(RS.getall());
        }
        [HttpGet("{id}")]
        public ActionResult GetByid(int id) 
        {
            Student st = RS.getbyid(id);
            return Ok(st);
        }
        [HttpPost]
        public ActionResult Add(MVStudent s) 
        {
           return Ok(RS.Add(s));
        }
        [HttpPut("{id}")]
        public ActionResult<List<Student>> Edite(int id, MVStudent s) 
        {
            return RS.Edite(id, s);
        }
    }
}
