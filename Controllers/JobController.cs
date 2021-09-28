using JobCalculator.Business;
using JobCalculator.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace JobCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly ICostCalculator _costCalc;
        public JobController(ICostCalculator costCalc)
        {
            _costCalc = costCalc;
        }
        // GET: api/<JobController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<JobController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // GET: api/<JobController>
        //[HttpGet]
        //public  Task<ActionResult<IEnumerable<string>>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<JobController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        //// POST api/<JobController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{


        //}

        // POST api/<JobController>
        [HttpPost]
        public ActionResult<Result> CreateJob([FromBody] JobDTO jobDTO)
        {
           // try
            {
                if (jobDTO == null)
                {

                }

                //DI
                //other method accessibility issue
                var result = _costCalc.CalculateJobCost(jobDTO);
                return result;

            }
            //catch
            //{

            //}



        }

        // PUT api/<JobController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE api/<JobController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
