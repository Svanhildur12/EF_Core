using System.ComponentModel.DataAnnotations.Schema;

namespace Verkefni_4.Models;

public class Mark
{

    public int MarkId { get; set; }
    public int StudentId { get; set; }
    public int SubjectId { get; set; }
    public DateTime Date { get; set; } = DateTime.Now;
    public int Marks { get; set; }
    
    public Student Student { get; set; } = new Student();
    public Subject Subject { get; set; } = new Subject();
}