using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Verkefni_4.Models;

public class Teacher
{
    public int TeacherId { get; set; }
    [Column(TypeName = "varchar(256)")]
    public required string FirstName { get; set; }
    [Column(TypeName = "varchar(256)")]
    public required string LastName { get; set; }

    public List<Subject> Subjects { get; set; }
}