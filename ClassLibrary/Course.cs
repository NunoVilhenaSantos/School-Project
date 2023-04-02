using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClassLibrary;

public class Course : INotifyPropertyChanged
{
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

    public event PropertyChangedEventHandler? PropertyChanged;


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


    #region PropertyChanged

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

    #endregion


    #region Attributes

    //
    // Attributes
    //
    private static int _mCounter;
    private string _name;
    private int _workLoad;
    private int _credits;
    private List<Enrollment> _enrollments = new();

    #endregion


    //
    // Properties
    //

    #region Properties

    public int IdCourse { get; }

    /// <summary>
    ///     Gets or sets the name of the course.
    /// </summary>
    public string Name
    {
        get => _name;
        set
        {
            if (value == _name) return;
            _name = value;
            OnPropertyChanged();
        }
    }

    public int WorkLoad
    {
        get => _workLoad;
        set
        {
            if (value == _workLoad) return;
            _workLoad = value;
            OnPropertyChanged();
        }
    }

    public int Credits
    {
        get => _credits;
        set
        {
            if (value == _credits) return;
            _credits = value;
            OnPropertyChanged();
        }
    }

    public List<Enrollment> Enrollments
    {
        get => _enrollments;
        set
        {
            if (Equals(value, _enrollments)) return;
            _enrollments = value;
            OnPropertyChanged();
        }
    }


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