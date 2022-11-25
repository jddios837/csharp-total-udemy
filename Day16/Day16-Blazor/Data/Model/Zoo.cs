using System.ComponentModel.DataAnnotations;
using Day16_Blazor.Data.Model;

namespace Day16_Blazor.Data;

public class Zoo
{
    [Key]
    public int Id { get; set; }
    public string? Ubicacion { get; set; }

    public ICollection<Animal> Animals { get; set; }
}