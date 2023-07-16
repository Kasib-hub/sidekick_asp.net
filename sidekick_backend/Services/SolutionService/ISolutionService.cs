// make a service for the SolutionController
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sidekick_backend.Services.SolutionService
{
  public interface ISolutionService
  {
    Task<ServiceResponse<List<Solution>>> GetAllSolutions();
    Task<ServiceResponse<Solution>> GetSolutionById(int Id);
    Task<ServiceResponse<List<Solution>>> CreateSolution(Solution newSolution);
  }
}
