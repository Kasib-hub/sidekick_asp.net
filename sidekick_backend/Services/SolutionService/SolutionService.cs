// adding iservice to service class
// SolutionService needs the methods from ISolutionService but the definition of those medthods in in the Controller
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
    public List<Solution> CreateSolution(Solution newSolution)
    {
      // add the solution to the list
      solutions.Add(newSolution);
      // return the solution
      return solutions;
    }

    public List<Solution> GetAllSolutions()
    {
      return solutions;
    }

    public Solution GetSolutionById(int Id)
    {
       return solutions.FirstOrDefault(solution => solution.Id == Id);
    }
  }
}