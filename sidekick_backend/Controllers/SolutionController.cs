using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    // the actionResult is a generic class that represents the result of an action method where the action method returns a single object, Action methods are a part of the ASP.NET MVC framework. Define the behaviour of HTTP requests to a controller's action method.
    private static List<Solution> solutions = new List<Solution> {
      new Solution(),
      new Solution { Title = "new solution", Id = 1}
    };

    // private readonly is a field modifier that means that this field can only be assigned in the constructor of this class
    private readonly ISolutionService _solutionService;

    // making a constructor for the service, having the service injected into the controller removes the need to instanatiate objects in the controller
    public SolutionController(ISolutionService solutionService)
    {
      _solutionService = solutionService;
    }

    // this is a get request for all solutions
    [HttpGet("GetAll")]
    public async Task<ActionResult<ServiceResponse<List<Solution>>>> Get()
    {
      return Ok(await _solutionService.GetAllSolutions());
    }

    // needs a http attribute, can also make a query here
    // I'm going to return a single solution by id
    [HttpGet("{Id}")]
    public async Task<ActionResult<ServiceResponse<Solution>>> GetSingle(int Id)
    {
      // 200 status code
      return Ok(await _solutionService.GetSolutionById(Id));

      // 400 status code would be BadRequest, 404 for Notfound
    }
    
    // this is a post request to create a new solution
    [HttpPost]
    public async Task<ActionResult<ServiceResponse<Solution>>> CreateSolution(Solution solution)
    {
      return Ok(await _solutionService.CreateSolution(solution));
    }

  }
}