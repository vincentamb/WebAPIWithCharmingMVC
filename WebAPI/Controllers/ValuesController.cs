using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<StudentModel> Get()
        {
            List<StudentModel> list = new List<StudentModel>();
            for (int i = 0; i < 10; i++)
            {
                StudentModel stu = new StudentModel();
                stu.StudentId = i;
                stu.StuName = "stu" + i;
                list.Add(stu);
            }
            return list;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
