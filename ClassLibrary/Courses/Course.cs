using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClassLibrary.Courses;

public class Course : INotifyPropertyChanged
{
    #region Constructor

    //
    // https://itecnote.com/tecnote/c-incrementing-a-unique-id-number-in-the-constructor/
    //
    // Constructor for the class and incrementation of the ID
    //

    /// <summary>
    /// Constructor for the Course class.
    /// </summary>
    public Course()
    {
        // Generate a unique course ID by incrementing
        // the counter using the Interlocked.Increment method.
        IdCourse = Interlocked.Increment(ref _mCounter);

        // Call the GetStudentsCount method to retrieve
        // the number of students enrolled in the course.
        GetStudentsCount();
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


    /// <summary>
    /// gives the full name of the course
    /// </summary>
    /// <returns>returns the full name of the course</returns>
    public string GetFullName()
    {
        return $"{Name} {WorkLoad}";
    }


    public string GetFullInfo()
    {
        return $"{IdCourse,5} | " +
               //$"{StudentsList[id].GetFullName()} | " +
               $"{GetFullName()} | " +
               $"{WorkLoad} - {Credits}";
    }

    /// <summary>
    ///  calculates de number of students enroll in the course
    /// </summary>
    /// <returns>return a integer of the number of students enroll</returns>
    public int GetStudentsCount()
    {
        StudentsCount = Enrollments.Enrollments.ListEnrollments?
            .Where(x => x.CourseId == IdCourse)
            .Count() ?? 0;

        return StudentsCount ?? 0;
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

    /// <summary>
    /// Occurs when a property value has changed.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;


    /// <summary>
    /// Raises the PropertyChanged event to notify
    /// subscribers that a property value has changed.
    /// </summary>
    /// <param name="propertyName">The name of the property
    /// that has changed (optional).</param>
    protected virtual void OnPropertyChanged(
        [CallerMemberName] string? propertyName = null)
    {
        // Invoke the PropertyChanged event with this
        // object as the sender and the propertyName as the argument.
        PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyName));
    }


    /// <summary>
    /// Sets the value of a field and raises the
    /// PropertyChanged event if the value has changed.
    /// </summary>
    /// <typeparam name="T">The type of the field.</typeparam>
    /// <param name="field">A reference to the field being set.</param>
    /// <param name="value">The new value to set the field to.</param>
    /// <param name="propertyName">The name of the
    /// property being set (optional).</param>
    /// <returns>True if the value has changed; false otherwise.</returns>
    protected bool SetField<T>(ref T field, T value,
        [CallerMemberName] string? propertyName = null)
    {
        // If the old and new values are equal,
        // don't set the field or raise the PropertyChanged event.
        if (EqualityComparer<T>.Default.Equals(field, value))
            return false;

        // Otherwise, set the field to the new value and raise the
        // PropertyChanged event with the propertyName as the argument.
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
    private int? _studentsCount;

    #endregion


    //
    // Properties
    //

    #region Properties

    public int IdCourse { get; }

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


    public int? StudentsCount
    {
        get => _studentsCount;
        set
        {
            if (value == _studentsCount) return;
            _studentsCount = value;
            OnPropertyChanged();
        }
    }


    /// <summary>
    ///     Sets the full name of the course,
    ///     which includes the course ID and name.
    /// </summary>
    /// <remarks>
    ///     This setter is included for consistency
    ///     with the getter and should not be used externally.
    /// </remarks>
    internal string SetFullName
    {
        set => Name = value?.Trim();
    }

    #endregion
}