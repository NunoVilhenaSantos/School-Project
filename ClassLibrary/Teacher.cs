namespace ClassLibrary;

public class Teacher
{
    #region Attributes

    //
    // Attributes
    //
    private static int _mCounter;

    #endregion

    //
    // Constructor for the class and incrementation of the ID
    //

    #region Constructor

    //
    // https://itecnote.com/tecnote/c-incrementing-a-unique-id-number-in-the-constructor/
    //
    // Constructor for the class and incrementation of the ID
    //
    public Teacher()
    {
        TeacherId = Interlocked.Increment(ref _mCounter);
    }

    #endregion


    public int TeacherId { get; }
    public string? Name { get; set; }
    public string? LastName { get; set; }
    public string? Address { get; set; }
    public string? PostalCode { get; set; }
    public string? City { get; set; }
    public string? Mobile { get; set; }
    public string? Email { get; set; }

    public List<Course> Courses { get; set; } = new();

    //
    // para avaliar se é preciso
    //
    //public int DepartmentId { get; set; }
    //public Department Department { get; set; }
    //public List<SchoolClass> SchoolClasses { get; set; } = new();
}