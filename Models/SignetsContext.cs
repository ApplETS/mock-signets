using Microsoft.EntityFrameworkCore;
using Models.Entities;

public class SignetsContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<EvaluationCours> EvaluationCours { get; set; }

    public string DbPath { get; }

    public SignetsContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = System.IO.Path.Join(path, "signets-mock.db");
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}