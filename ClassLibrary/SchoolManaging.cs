using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ClassLibrary;

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