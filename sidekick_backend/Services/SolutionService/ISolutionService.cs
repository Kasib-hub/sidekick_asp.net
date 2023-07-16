// make a service for the SolutionController
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sidekick_backend.Services.SolutionService
{
  public interface ISolutionService
  {
    List<Solution> GetAllSolutions();
    Solution GetSolutionById(int Id);
    List<Solution> CreateSolution(Solution newSolution);
  }
}
