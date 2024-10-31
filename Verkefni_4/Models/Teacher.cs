using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Verkefni_4.Models;

public class Teacher
{
    public int TeacherId { get; set; }
   [MaxLength(256)]
    public string FirstName { get; set; }
    [MaxLength(256)]
    public string LastName { get; set; }

    public List<Subject> Subjects { get; set; } = new List<Subject>();
}