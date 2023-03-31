namespace ClassLibrary;

public class Enrollment
{
    //
    // Attributes
    //

    #region Attributes

    private static int _mCounter;

    #endregion

    #region Constructor

    //
    // https://itecnote.com/tecnote/c-incrementing-a-unique-id-number-in-the-constructor/
    //
    // Constructor for the class and incrementation of the ID
    //
    public Enrollment()
    {
        IdEnrollment = Interlocked.Increment(ref _mCounter);
    }

    #endregion

    public int IdEnrollment { get; }
    public decimal? Grade { get; set; }

    public int StudentId { get; set; }
    public Student Student { get; set; }

    public int CourseId { get; set; }
    public Course Course { get; set; }
}