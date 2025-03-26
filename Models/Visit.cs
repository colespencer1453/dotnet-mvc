using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class Visit
{
    public int Id { get; set; }
    public required int CaseId { get; set; }
    public required Case Case { get; set; }
    public string? VisitNotes { get; set; }
    [Display(Name = "Visit Date"), DataType(DataType.Date)]
    public DateTime VisitDate { get; set; }
}