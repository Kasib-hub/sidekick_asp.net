using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// the service response is used to give a response to the client incase of an error or catching an exception
namespace sidekick_backend.Models
{
  public class ServiceResponse<T> // T is the type of data that will be returned
  {
    public T? Data { get; set; } // ? means that the data can be null
    public bool Success { get; set; } = true; // true is the default value
    public string Message { get; set; } = string.Empty; // empty string is the default value
  }
}