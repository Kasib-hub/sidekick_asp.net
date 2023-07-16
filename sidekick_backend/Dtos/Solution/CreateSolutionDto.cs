using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sidekick_backend.Dtos.Solution
{
  public class CreateSolutionResponseDto // should reflect Solution Model, remove the ID
  {
    public string Title { get; set; } = "My Solution";
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime ModifiedAt { get; set; } = DateTime.Now;
    public string Instructions { get; set; } = string.Empty!;
    public int UserId { get; set; }
    public string Units { get; set; } = string.Empty!;
    public decimal SourceConc { get; set; }
    public decimal SourceVol { get; set; }
    public decimal TargetConc { get; set; }
    public decimal TargetVol { get; set; }
  }
}