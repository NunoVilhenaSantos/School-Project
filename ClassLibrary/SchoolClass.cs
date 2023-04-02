using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClassLibrary;

public class SchoolClass : INotifyPropertyChanged
{
    //
    // https://itecnote.com/tecnote/c-incrementing-a-unique-id-number-in-the-constructor/
    //
    // Constructor for the class and incrementation of the ID
    //

    #region Constructor

    public SchoolClass()
    {
        IdSchoolClass = Interlocked.Increment(ref _mCounter);
        GetStudentsCount();
        GetWorkHourLoad();
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


    private void NotifyPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyName));
    }

    #endregion

    //
    // Attributes
    //

    #region Attributes

    private static int _mCounter;

    private string _classAcronym;
    private string _className;
    private DateOnly _startDate;
    private DateOnly _endDate;
    private TimeOnly _startHour;
    private TimeOnly _endHour;
    private string _location;
    private string _type;
    private string _area;
    private int? _coursesCount;
    private int? _workHourLoad;
    private int? _studentsCount;
    private decimal? _classAverage;
    private decimal? _highestGrade;
    private decimal? _lowestGrade;
    private List<Course> _coursesList = new();

    #endregion


    //
    // Properties
    //

    #region Properties

    public int IdSchoolClass { get; }

    public string ClassAcronym
    {
        get => _classAcronym;
        set => SetField(ref _classAcronym, value);
    }

    public string ClassName
    {
        get => _className;
        set => SetField(ref _className, value);
    }

    public DateOnly StartDate
    {
        get => _startDate;
        set => SetField(ref _startDate, value);
    }

    public DateOnly EndDate
    {
        get => _endDate;
        set => SetField(ref _endDate, value);
    }

    public TimeOnly StartHour
    {
        get => _startHour;
        set => SetField(ref _startHour, value);
    }

    public TimeOnly EndHour
    {
        get => _endHour;
        set => SetField(ref _endHour, value);
    }

    public string Location
    {
        get => _location;
        set => SetField(ref _location, value);
    }

    public string Type
    {
        get => _type;
        set => SetField(ref _type, value);
    }

    public string Area
    {
        get => _area;
        set => SetField(ref _area, value);
    }

    public int? CoursesCount
    {
        get => _coursesCount;
        set => SetField(ref _coursesCount, value);
    }

    public int? WorkHourLoad
    {
        get => _workHourLoad;
        set => SetField(ref _workHourLoad, value);
    }

    public int? StudentsCount
    {
        get => _studentsCount;
        set => SetField(ref _studentsCount, value);
    }

    public decimal? ClassAverage
    {
        get => _classAverage;
        set => SetField(ref _classAverage, value);
    }

    public decimal? HighestGrade
    {
        get => _highestGrade;
        set => SetField(ref _highestGrade, value);
    }

    public decimal? LowestGrade
    {
        get => _lowestGrade;
        set => SetField(ref _lowestGrade, value);
    }

    public List<Course>? CoursesList
    {
        get => _coursesList;
        set => SetField(ref _coursesList, value);
    }

    //
    // para avaliar se são precisos
    //
    //public List<Student>? StudentsList { get; set; } = new();
    //public List<Enrollment> Enrollments { get; set; } = new();

    #endregion


    //
    // Methods
    //

    #region Methods

    public override string ToString()
    {
        // return base.ToString();
        return $"{IdSchoolClass,5} | {ClassAcronym} - {ClassName}";
    }


    public int GetCoursesCount()
    {
        return CoursesList?.Count ?? 0;
        /*
        return CoursesList == null
            ? 0
            : CoursesList.Sum(course => course.Enrollments.Count);
        
        if (CoursesList == null) return 0;
        return CoursesList.Sum(course => course.Enrollments.Count);
        */
    }


    public int GetStudentsCount()
    {
        return CoursesList?.Sum(course => course.Enrollments.Count) ?? 0;
        /*
        return CoursesList == null
            ? 0
            : CoursesList.Sum(course => course.Enrollments.Count);
        
        if (CoursesList == null) return 0;
        return CoursesList.Sum(course => course.Enrollments.Count);
        */
    }


    public int GetWorkHourLoad()
    {
        return CoursesList?.Sum(course => course.WorkLoad) ?? 0;
        /*
        return CoursesList == null
            ? 0
            : CoursesList.Sum(course => course.WorkLoad);
        
        if (CoursesList == null) return 0;
        return CoursesList.Sum(course => course.WorkLoad);
        */
    }


    //public void ToObtainValuesForCalculatedFields()
    //{
    //    //return CoursesList?.Count ?? 0;
    //    /*
    //    return CoursesList == null
    //        ? 0
    //        : CoursesList.Sum(course => course.Enrollments.Count);

    //    if (CoursesList == null) return 0;
    //    return CoursesList.Sum(course => course.Enrollments.Count);
    //    */

    //    CoursesCount = CoursesList?.Sum(course => course.Enrollments.Count) ?? 0;
    //    WorkHourLoad= CoursesList?.Sum(course => course.WorkLoad) ?? 0;
    //    StudentsCount= CoursesList?.Count ?? 0;

    //    ClassAverage = CoursesList?.Where(course => course.IdCourse == IdCourse)
    //                               .SelectMany(course => course.Enrollments)
    //                               .Average(enrollment => enrollment.Enrollments)
    //                               ?? 0;
    //    HighestGrade = 0;
    //    LowestGrade = 0;


    //}

    #endregion
}