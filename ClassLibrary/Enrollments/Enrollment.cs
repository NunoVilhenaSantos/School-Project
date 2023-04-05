using System.ComponentModel;
using System.Runtime.CompilerServices;
using ClassLibrary.Courses;
using ClassLibrary.Students;

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
    private Student? _student;
    private int _courseId;
    private Course? _course;

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

    public Student? Student
    {
        get => _student;
        set
        {
            if (Equals(value, _student)) return;
            _student = value;
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

    public Course? Course
    {
        get => _course;
        set
        {
            if (Equals(value, _course)) return;
            _course = value;
            OnPropertyChanged();
        }
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

    #endregion
}