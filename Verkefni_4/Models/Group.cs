using System.ComponentModel.DataAnnotations.Schema;

namespace Verkefni_4.Models;

public class Group
{
    public int GroupId { get; set; }
    
    public required string Name { get; set; }

    public required ICollection<Student> Students { get; set; } = null!;
}