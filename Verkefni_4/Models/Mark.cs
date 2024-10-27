using System.ComponentModel.DataAnnotations.Schema;

namespace Verkefni_4.Models;

public class Mark
{

    public int MarkId { get; set; }
    public int StudentId { get; set; }
    public int SubjectId { get; set; }
    public DateTime Date { get; set; }
    public int Marks { get; set; }
    
    public Student Student { get; set; } = null!;
    public Subject Subject { get; set; } = null!;
}