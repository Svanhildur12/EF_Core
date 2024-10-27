using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Verkefni_4.Models;

public class Student
{
    
    public int StudentId { get; set; }
    [Column(TypeName = "varchar(100)"), Required]
    public required string FirstName { get; set; }
    [Column(TypeName = "varchar(100)"),Required]
    public required string LastName { get; set; }
    public int GroupId { get; set; }

    public Group Group { get; set; } = null!;
    
}