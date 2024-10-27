using Microsoft.EntityFrameworkCore;

namespace Verkefni_4.Models;

public class SchoolContext : DbContext
{
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<Subject> Subjects { get; set; }
    public DbSet<Mark> Marks { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Group> Groups { get; set; }
    
    public string DbPath { get; }

    public SchoolContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "school.db");
        Console.WriteLine(DbPath);
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}