using System.Web.Http;

namespace codingTask.Controllers
{
    public class HelloController : ApiController
    {
        // GET: api/Hello
        public IHttpActionResult Get()
        {
            return Ok("Hello World");
        }

        //// GET: api/Hello/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Hello
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Hello/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Hello/5
        //public void Delete(int id)
        //{
        //}
    }
}
