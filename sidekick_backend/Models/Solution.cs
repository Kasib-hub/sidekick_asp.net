
namespace sidekick_backend.Models;

  public class Solution
  {
    // I'm creating a solution model
    // the get and set methods are used to get and set the values of the properties
    public int Id { get; set; }
    public string Title { get; set; } = "My Solution";
    // property for datetime field at creation
    public DateTime CreatedAt { get; set; } = DateTime.Now;
    public DateTime ModifiedAt { get; set; } = DateTime.Now;
    public string Instructions { get; set; } = string.Empty!;

    // property for the solution author that is one to many with the user model
    // looks like it links to the user id without reference to the user model like in django
    public int UserId { get; set; }
    public string Units { get; set; } = string.Empty!;




  }
