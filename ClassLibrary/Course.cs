namespace ClassLibrary;

public class Course
{
    #region Attributes

    //
    // Attributes
    //
    private static int _mCounter;

    #endregion

    #region Constructor

    //
    // https://itecnote.com/tecnote/c-incrementing-a-unique-id-number-in-the-constructor/
    //
    // Constructor for the class and incrementation of the ID
    //
    public Course()
    {
        IdCourse = Interlocked.Increment(ref _mCounter);
    }

    #endregion


    #region Methods

    //
    // Methods
    //
    public override string ToString()
    {
        //return $"{Id_Course,5:G} - {Name,50} - {WorkLoad} horas";
        return $"{IdCourse,5:G} - {Name} - {WorkLoad} horas";
    }

    #endregion


    //
    // Properties
    //

    #region Properties

    public int IdCourse { get; }

    /// <summary>
    ///     Gets or sets the name of the course.
    /// </summary>
    public string Name { get; set; }

    public int WorkLoad { get; set; }
    public int Credits { get; set; }

    public List<Enrollment> Enrollments { get; set; } = new();


    /// <summary>
    ///     Gets the full name of the course, which includes the course ID and name.
    /// </summary>
    public string FullName => $"{IdCourse,3} | {Name}";


    /// <summary>
    ///     Sets the full name of the course, which includes the course ID and name.
    /// </summary>
    /// <remarks>
    ///     This setter is included for consistency with the getter and should not be used externally.
    /// </remarks>
    internal string SetFullName
    {
        set => Name = value?.Trim();
    }

    // Example usage:
    // var course = new Course { IdCourse = 1, SetFullName = "  Introduction to Programming " };
    // Console.WriteLine(course.FullName); // Outputs "  1 | Introduction to Programming"


    //
    // para avaliar se vão ser precisos
    //
    //public int TeacherId { get; set; }
    //public Teacher Teachers { get; set; }

    //public int DepartmentId { get; set; }
    //public Department Departments { get; set; }
    //public List<Teacher> TeacherList { get; set; }= new();
    //public List<SchoolClass> SchoolClassesList { get; set; } = new();

    #endregion
}