namespace ClassLibrary;

public class SchoolManaging
{
    public static List<Teacher> TeachersList = new();
    public static List<SchoolClass> ListSchoolClasses { get; set; } = new();
    public static List<Course> ListCourses { get; set; } = new();
    public static List<Student> ListStudents { get; set; } = new();
    public static List<Enrollment> Enrollments { get; set; } = new();
}