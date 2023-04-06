using System.ComponentModel;
using System.Runtime.CompilerServices;
using ClassLibrary.Courses;
using ClassLibrary.Teachers;

namespace ClassLibrary.SchoolClasses;

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
    private List<Course>? _coursesList = new();

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
    //public List<Teacher>? TeachersList { get; set; } = new();
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


    public void GetStudentsCount()
    {
        if (Enrollments.Enrollments.ListEnrollments != null)
            StudentsCount = CoursesList?.Join(
                    Enrollments.Enrollments.ListEnrollments,
                    c => c.IdCourse,
                    e => e.CourseId,
                    (c, e) => e)
                .Count() ?? 0;

        /*
        return CoursesList == null
            ? 0
            : CoursesList.Sum(course => course.Enrollments.Count);
        
        if (CoursesList == null) return 0;
        return CoursesList.Sum(course => course.Enrollments.Count);
        */
    }


    public void GetWorkHourLoad()
    {
        WorkHourLoad = CoursesList?.Sum(course => course.WorkLoad) ?? 0;
        /*
        return CoursesList == null
            ? 0
            : CoursesList.Sum(course => course.WorkLoad);
        
        if (CoursesList == null) return 0;
        return CoursesList.Sum(course => course.WorkLoad);
        */
    }


    public void ToObtainValuesForCalculatedFields()
    {
        // int? CoursesCount
        // int? WorkHourLoad
        // int? StudentsCount
        // decimal? ClassAverage
        // decimal? HighestGrade
        // decimal? LowestGrade

        CoursesCount = CoursesList?.Count ?? 0;
        CoursesCount = CoursesList == null
            ? 0
            : CoursesList.Count;
        var enrollments = Enrollments.Enrollments.ListEnrollments;
        var courses = CoursesList;

        var query = from enrollment in enrollments
            join course in courses on enrollment.CourseId equals course.IdCourse
            select new
            {
                enrollment,
                course
            };

        var totalWorkHourLoad = courses.Sum(course => course?.WorkLoad) ?? 0;
        var studentsCount = enrollments?.Count ?? 0;
        var classAverage = query.Average(ec => ec.enrollment.Grade) ?? 0;
        var highestGrade = query.Max(ec => ec.enrollment.Grade) ?? 0;
        var lowestGrade = query.Min(ec => ec.enrollment.Grade) ?? 0;

        var studentAverages =
            query
                .GroupBy(ec => ec.enrollment.StudentId)
                .Select(g => new
                {
                    StudentId = g.Key,
                    AverageGrade = g.Average(ec => ec.enrollment.Grade)
                });

        var studentCountAverage =
            studentAverages.Average(sa => sa.AverageGrade) ?? 0;
        var studentCount = studentAverages.Count();
    }

    #endregion
}