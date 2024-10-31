using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Verkefni_4.Models;

public class Student
{
    
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int GroupId { get; set; }

    public Group Group { get; set; } = new Group();

}