using Microsoft.EntityFrameworkCore;

namespace ClassLibrary;

public class SchoolContext : DbContext
{
    // Constructor

    public SchoolContext()
    {
    }

    public SchoolContext(DbContextOptions<SchoolContext> options) :
        base(options)
    {
    }


    public SchoolContext(string connectionString) :
        base(GetOptions(connectionString))
    {
    }
    /*
    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Teacher> Teachers { get; set; }
    public DbSet<SchoolClass> SchoolClasses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Enrollment>()
            .HasKey(e => new {e.StudentId, e.CourseId});
        modelBuilder.Entity<Enrollment>().HasOne(e => e.Student)
            .WithMany(s => s.Enrollments).HasForeignKey(e => e.StudentId);
        modelBuilder.Entity<Enrollment>().HasOne(e => e.Course)
            .WithMany(c => c.Enrollments).HasForeignKey(e => e.CourseId);
        modelBuilder.Entity<Course>().HasMany(c => c.Teachers)
            .WithMany(t => t.Courses)
            .UsingEntity(j => j.ToTable("CourseTeacher"));
        // Configure many-to-many relationship between Course and Teacher entities
        modelBuilder.Entity<Course>().HasMany(c => c.Teachers)
            .WithMany(t => t.Courses)
            .UsingEntity(j => j.ToTable("CourseTeacher"));
    }
    */


    /*
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Student>().HasMany(s => s.Enrollments)
            .WithOne(e => e.Student);

        modelBuilder.Entity<Course>().HasMany(c => c.Enrollments)
            .WithOne(e => e.Course);

        modelBuilder.Entity<Enrollment>()
            .HasKey(e => new {e.StudentId, e.CourseId});

        modelBuilder.Entity<Enrollment>().HasOne(e => e.Student)
            .WithMany(s => s.Enrollments).HasForeignKey(e => e.StudentId);

        modelBuilder.Entity<Enrollment>().HasOne(e => e.Course)
            .WithMany(c => c.Enrollments).HasForeignKey(e => e.CourseId);
    }
    */

    public DbSet<Student> Students { get; set; }
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Course> Courses { get; set; }

    public DbSet<Teacher> Teachers { get; set; }

    //public DbSet<Department> Departments { get; set; }
    public DbSet<SchoolClass> SchoolClasses { get; set; }

    private static DbContextOptions<SchoolContext> GetOptions(
        string connectionString)
    {
        var optionsBuilder = new DbContextOptionsBuilder<SchoolContext>();
        optionsBuilder.UseSqlServer(connectionString);

        return optionsBuilder.Options;
    }


    // Methods
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure many-to-many relationship between Course and Teacher entities
        //modelBuilder.Entity<Course>().
        //    HasMany(c => c.Teachers).
        //    WithMany(t => t.Courses).
        //    UsingEntity(j => j.ToTable("CourseTeacher"));

        // Configure one-to-many relationship between Course and Enrollment entities
        modelBuilder.Entity<Course>().HasMany(c => c.Enrollments)
            .WithOne(e => e.Course);

        // Configure one-to-many relationship between Student and Enrollment entities
        modelBuilder.Entity<Student>().HasMany(s => s.Enrollments)
            .WithOne(e => e.Student);

        // Configure one-to-one relationship between Teacher and Department entities
        //modelBuilder.Entity<Teacher>().
        //    HasOne(t => t.Department).
        //    WithMany(d => d.Teachers);

        // Configure one-to-many relationship between Course and Department entities
        //modelBuilder.Entity<Course>().
        //    HasOne(c => c.Department).
        //    WithMany(d => d.Courses);

        // Configure many-to-many relationship between Student and SchoolClass entities
        //modelBuilder.Entity<SchoolClass>().
        //    HasMany(sc => sc.CoursesList).
        //    WithMany(c => c.SchoolClassesList).
        //    UsingEntity(j => j.ToTable("SchoolClassCourse"));
    }
}