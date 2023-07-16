// make a service for the SolutionController
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sidekick_backend.Services.SolutionService
{
  public interface ISolutionService
  {
    Task<ServiceResponse<List<GetSolutionResponseDto>>> GetAllSolutions();
    Task<ServiceResponse<GetSolutionResponseDto>> GetSolutionById(int Id);
    Task<ServiceResponse<List<GetSolutionResponseDto>>> CreateSolution(CreateSolutionResponseDto newSolution);
  }
}
