using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Verkefni_4.Models;

public class Subject
{
    public int SubjectId { get; set; }
    public string Title { get; set; }

    public List<Teacher> Teachers { get; set; } = new List<Teacher>();


}