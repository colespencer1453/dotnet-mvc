using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Case
{
    public int Id { get; set; }
    [Display(Name = "Last Name")]
    public required string LastName { get; set; }
    [Display(Name = "First Name")]
    public required string FirstName { get; set; }
    public required string Citizenship { get; set; }

    [Display(Name = "Date of Birth"), DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
}