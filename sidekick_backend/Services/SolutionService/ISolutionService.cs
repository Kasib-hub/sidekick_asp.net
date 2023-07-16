// make a service for the SolutionController
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sidekick_backend.Services.SolutionService
{
  public interface ISolutionService
  {
    Task<List<Solution>> GetAllSolutions();
    Task<Solution> GetSolutionById(int Id);
    Task<List<Solution>> CreateSolution(Solution newSolution);
  }
}
