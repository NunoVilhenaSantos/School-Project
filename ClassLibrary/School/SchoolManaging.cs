using System.ComponentModel;
using System.Runtime.CompilerServices;
using ClassLibrary.Courses;
using ClassLibrary.Enrollments;
using ClassLibrary.SchoolClasses;
using ClassLibrary.Students;
using ClassLibrary.Teachers;

namespace ClassLibrary.School;

public class SchoolManaging : INotifyPropertyChanged
{
    public static List<Teacher> TeachersList { get; set; } = new();
    public static List<SchoolClass> ListSchoolClasses { get; set; } = new();
    public static List<Course> ListCourses { get; set; } = new();
    public static List<Student> ListStudents { get; set; } = new();
    public static List<Enrollment> Enrollments { get; set; } = new();


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