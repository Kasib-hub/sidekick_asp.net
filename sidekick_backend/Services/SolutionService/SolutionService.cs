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
    public async Task<List<Solution>> CreateSolution(Solution newSolution)
    {
      // add the solution to the list
      solutions.Add(newSolution);
      // return the solution
      return solutions;
    }

    public async Task<List<Solution>> GetAllSolutions()
    {
      return solutions;
    }

    public async Task<Solution> GetSolutionById(int Id)
    {
      // account for the case where the solution is not found and is null
      var solution = solutions.FirstOrDefault(solution => solution.Id == Id);
      if (solution is not null)
      {
        return solution;
      }
      throw new Exception("Solution not found");
    }
  }
}