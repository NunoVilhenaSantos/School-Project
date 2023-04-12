using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClassLibrary.Enrollments;

public class Enrollment : INotifyPropertyChanged
{
    #region Constructor

    //
    // https://itecnote.com/tecnote/c-incrementing-a-unique-id-number-in-the-constructor/
    //
    // Constructor for the class and incrementation of the ID
    //
    public Enrollment()
    {
        // Generate a unique course ID by incrementing
        // the counter using the Interlocked.Increment method.
        IdEnrollment = Interlocked.Increment(ref _mCounter);
    }

    #endregion

    //
    // Attributes
    //

    #region Attributes

    private static int _mCounter;
    private decimal? _grade;

    private int _studentId;

    //private Student? _student;
    private int _courseId;
    //private Course? _course;

    #endregion


    #region Properties

    public int IdEnrollment { get; }

    public decimal? Grade
    {
        get => _grade;
        set
        {
            if (value == _grade) return;
            _grade = value;
            OnPropertyChanged();
        }
    }

    public int StudentId
    {
        get => _studentId;
        set
        {
            if (value == _studentId) return;
            _studentId = value;
            OnPropertyChanged();
        }
    }

    public int CourseId
    {
        get => _courseId;
        set
        {
            if (value == _courseId) return;
            _courseId = value;
            OnPropertyChanged();
        }
    }

    #endregion


    #region PropertyChanged

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
    /// Occurs when a property value has changed.
    /// </summary>
    public event PropertyChangedEventHandler? PropertyChanged;


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
}