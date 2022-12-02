using System.ComponentModel.DataAnnotations;

namespace Day19_LINQ_SQL.Data.DTOs;

public class UniversityDto
{
    [Required]
    [StringLength(50, ErrorMessage = "Name is too long")]
    public string Name { get; set; }
}