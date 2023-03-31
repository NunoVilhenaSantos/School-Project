using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClassLibrary;

public class Student : INotifyPropertyChanged
{
    //
    // Constructor for the class and incrementation of the ID
    //

    #region Constructor

    //
    // https://itecnote.com/tecnote/c-incrementing-a-unique-id-number-in-the-constructor/
    //
    // Constructor for the class and incrementation of the ID
    //
    public Student()
    {
        IdStudent = Interlocked.Increment(ref _mCounter);
    }

    #endregion

    #region Attributes

    //
    // attributes
    //
    private static int _mCounter;

    private static readonly List<string> Genreslist = new()
        {"Male", "Female", "Non Binary", "Prefer not to say"};

    private string? _identificationNumber;
    private string? _taxIdentificationNumber;
    private int? _coursesCount;
    private const int IdNumberlength = 12;
    private const int TidNumberlength = 6;

    #endregion


    //
    // Properties
    //

    #region Properties

    public int IdStudent { get; set; }
    public string? Name { get; set; }
    public string? LastName { get; set; }

    public string? Address { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public bool Active { get; set; } = true;

    public static readonly List<string> Genres = Genreslist;

    public string? Genre { get; set; }

    public DateOnly DateOfBirth { get; set; }

    public string? IdentificationNumber
    {
        get => _identificationNumber;
        set
        {
            if (string.IsNullOrEmpty(value) ||
                string.IsNullOrWhiteSpace(value) ||
                value.Length > IdNumberlength)
            {
                //return "The field may only have " + IDNumberlength + " characters";
            }

            _identificationNumber = value;
        }
    }

    public DateOnly ExpirationDateIn { get; set; }

    public string? TaxIdentificationNumber
    {
        get => _taxIdentificationNumber;
        set
        {
            if (string.IsNullOrEmpty(value) ||
                string.IsNullOrWhiteSpace(value) ||
                value.Length > TidNumberlength)
            {
                //return "The field may only have " + IDNumberlength + " characters";
            }

            _taxIdentificationNumber = value;
        }
    }

    public string? Nationality { get; set; }
    public string? Birthplace { get; set; }

    public string? Photo { get; set; }
    //public Image Photo { get; set; }


    public int? CoursesCount
    {
        get => _coursesCount;
        set => SetField(ref _coursesCount, value);
    }

    public int TotalWorkHoursLoad { get; internal set; }


    //
    // Section of enrolments 
    //
    //public List<Course>? CoursesList { get; set; } = new();
    public DateOnly EnrollmentDate { get; set; }

    public List<Enrollment> Enrollments { get; set; } = new();
    //public List<StudentGrades> StudentCoursesGradesList { get; set; } = new();


    public string FullName => $"{IdStudent,5} | {Name} {LastName}";

    #endregion


    //
    // Methods
    //

    #region Methods

    public override string ToString()
    {
        // return base.ToString();
        //return $"{IdStudent,5} | {FullName()} | {Phone} - {Address}";
        return $"{IdStudent,3} | {Name} {LastName} | {Phone} - {Address}";
    }


    public int GetWorkHourLoad(Course course)
    {
        var enrollment = Enrollments?.FirstOrDefault(e =>
            e.Student.IdStudent == IdStudent && e.Course == course);

        return enrollment == null ? 0 : enrollment.Course.WorkLoad;
    }

    public int GetTotalWorkHourLoad()
    {
        var enrollment = Enrollments?.Where(e =>
            e.Student.IdStudent == IdStudent).ToList();

        return Enrollments?.Sum(enrollment => enrollment.Course.WorkLoad) ?? 0;
        /*
        return Enrollments == null
            ? 0
            : Enrollments.Sum(enrollment => enrollment.Course.WorkLoad);
        */
    }


    public int GetCoursesCount()
    {
        var enrollment = Enrollments?.Where(
            e => e.Student.IdStudent == IdStudent).Count();

        return enrollment ?? 0;
        /*
        return CoursesList == null
            ? 0
            : CoursesList.Sum(course => course.Enrollments.Count);
        
        if (CoursesList == null) return 0;
        return CoursesList.Sum(course => course.Enrollments.Count);
        */
    }

    #endregion


    #region PropertyChanged

    public event PropertyChangedEventHandler? PropertyChanged;


    protected virtual void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value,
        [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }


    protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        PropertyChanged?.Invoke(this, e);
    }

    private void NotifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyName));
    }

    #endregion
}