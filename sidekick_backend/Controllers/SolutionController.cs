using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using sidekick_backend.Models;
using Microsoft.AspNetCore.Mvc;

// a controller can return one entry or multiple from the db as list
// base class for MVC controller
// we're adding attributes here - in brackets

namespace sidekick_backend.Controllers
{
  [ApiController]
  [Route("api/[controller]")] // comes out to solution
  public class SolutionController : ControllerBase
  {
    // instantiate a solution object
    // private static Solution solution1 = new Solution();

    // instatiate a list of solutions
    private static List<Solution> solutions = new List<Solution> {
      new Solution(),
      new Solution { Title = "new solution", Id = 1}
    };

    // this is a get request for all solutions
    [HttpGet("GetAll")]
    public ActionResult<List<Solution>> Get()
    {
      return Ok(solutions);
    }

    // needs a http attribute, can also make a query here
    // I'm going to return a single solution by id
    [HttpGet("{Id}")]
    public ActionResult<Solution> GetSingle(int Id)
    {
      // 200 status code
      return Ok(solutions.FirstOrDefault(solution => solution.Id == Id));

      // 400 status code would be BadRequest, 404 for Notfound
    }
    // That was for single object, here we can get an array of objects

  }
}