namespace ClassLibrary;

public class Courses1
{
    public static List<Course> ListCourses { get; } = new();

    public static void AddCourse(int id, string name, int workLoad, int credits,
        List<Enrollment> enrollments)
    {
        ListCourses.Add(new Course
        {
            //IdCourse = id,
            Name = name,
            WorkLoad = workLoad,
            Credits = credits,
            Enrollments = enrollments
        });
    }

    public static bool DeleteCourse(int id)
    {
        var course = ListCourses.FirstOrDefault(c => c.IdCourse == id);
        if (course == null) return false;
        ListCourses.Remove(course);
        return true;
    }

    public static bool EditCourse(int id, string name, int workLoad,
        List<Enrollment> enrollments)
    {
        var course = ListCourses.FirstOrDefault(c => c.IdCourse == id);
        if (course == null) return false;

        course.Name = name;
        course.WorkLoad = workLoad;
        course.Enrollments = enrollments;
        return true;
    }

    public static List<Course> SearchCourses(string name = "",
        int workLoad = -1, List<Enrollment>? enrollments = null)
    {
        var courses = ListCourses;
        if (!string.IsNullOrWhiteSpace(name))
            courses = courses.Where(c => c.Name == name).ToList();
        if (workLoad >= 0)
            courses = courses.Where(c => c.WorkLoad == workLoad).ToList();
        if (enrollments != null)
            courses = courses.Where(c => c.Enrollments == enrollments).ToList();
        return courses;
    }

    public static int GetNextId()
    {
        return ListCourses.Any() ? ListCourses.Max(c => c.IdCourse) + 1 : 1;
    }
}