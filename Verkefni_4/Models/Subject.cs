using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Verkefni_4.Models;

public class Subject
{
    public int SubjectId { get; set; }
    [Column(TypeName = "varchar(100)"), Required]
    public required string Title { get; set; }

    public required List<Teacher>? Teachers { get; set; } 


}