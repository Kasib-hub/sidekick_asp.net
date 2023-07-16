// adding iservice to service class
// SolutionService needs the methods from ISolutionService but the definition of those medthods in in the Controller
// advantageous to make these requests async as they make changes/query to the database
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace sidekick_backend.Services.SolutionService
{

  public class SolutionService : ISolutionService
  {
  
  // instatiate a list of solutions
  private static List<Solution> solutions = new List<Solution> {
    new Solution(),
    new Solution { Title = "new solution", Id = 1}
  };
    // using the service response class to return the data
    public async Task<ServiceResponse<List<Solution>>> CreateSolution(Solution newSolution)
    {
      
      var serviceResponse = new ServiceResponse<List<Solution>>(); // instantiate a new service response
      solutions.Add(newSolution);
      serviceResponse.Data = solutions; // set the data to the list of solutions
      // return the solution
      return serviceResponse;
    }

    public async Task<ServiceResponse<List<Solution>>> GetAllSolutions()
    {
      var serviceResponse = new ServiceResponse<List<Solution>>();
      serviceResponse.Data = solutions;
      return serviceResponse;
    }

    public async Task<ServiceResponse<Solution>> GetSolutionById(int Id)
    {
      // account for the case where the solution is not found and is null
      var serviceResponse = new ServiceResponse<Solution>();
      var solution = solutions.FirstOrDefault(s => s.Id == Id);
      serviceResponse.Data = solution;
      return serviceResponse;
    }
  }
}