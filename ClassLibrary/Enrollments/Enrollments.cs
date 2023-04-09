using ClassLibrary.Courses;
using ClassLibrary.School;
using ClassLibrary.Students;
using Serilog;

namespace ClassLibrary.Enrollments;

public static class Enrollments
{
    #region Properties

    public static List<Enrollment> ListEnrollments = new();
    public static Dictionary<int, Student> StudentsDictionary = new();
    public static Dictionary<int, Course> CoursesDictionary = new();

    #endregion


    #region Methods

    // update the dictionaries from the list of their corresponding classes
    public static void UpdateDictionaries()
    {
        // update the students dictionary
        foreach (var student in Students.Students.ListStudents)
            StudentsDictionary[student.IdStudent] = student;

        // update the courses dictionary
        foreach (var course in Courses.Courses.ListCourses)
            CoursesDictionary[course.IdCourse] = course;
    }


    public static void EnrollStudent(
        int studentId, int courseId, decimal? grade = null)
    {
        // Check if the student ID is valid
        if (!StudentsDictionary.ContainsKey(studentId))
        {
            Log.Error("Invalid student ID: " +
                      "{StudentId}", studentId);
            return;
        }

        // Check if the course ID is valid
        if (!CoursesDictionary.ContainsKey(courseId))
        {
            Log.Error("Invalid course ID: " +
                      "{CourseId}", courseId);
            return;
        }

        // Check if the student is already enrolled in the course
        if (ListEnrollments
            .Any(e =>
                e.StudentId == studentId &&
                e.CourseId == courseId))
        {
            Log.Error("Student {StudentId} " +
                      "is already enrolled in course {CourseId}",
                studentId, courseId);
            return;
        }

        // Create a new enrollment and add it to the list
        var newEnrollment = new Enrollment
        {
            Grade = grade,
            StudentId = studentId,
            CourseId = courseId
        };
        ListEnrollments.Add(newEnrollment);

        // Update the school database
        SchoolDatabase.EnrollStudentInCourse(studentId, courseId);
    }


    public static void RemoveEnrollment(int studentId, int courseId)
    {
        var enrollment = ListEnrollments
            .FirstOrDefault(
                e =>
                    e.StudentId == studentId &&
                    e.CourseId == courseId);

        if (enrollment == null)
        {
            throw new ArgumentException("This enrollment does not exist");
            throw new ArgumentException("A matrícula não existe");
        }

        ListEnrollments.Remove(enrollment);
    }

    public static List<Enrollment> ConsultEnrollment(
        int courseId = -1, int studentId = -1)
    {
        var enrollments = ListEnrollments;

        if (courseId != -1)
            if (CoursesDictionary.TryGetValue(courseId, out var course))
            {
                enrollments = enrollments
                    .Where(e =>
                        e.CourseId == course.IdCourse)
                    .ToList();
            }

        if (studentId == -1) return enrollments;
        {
            if (StudentsDictionary.TryGetValue(studentId, out var student))
            {
                enrollments = enrollments
                    .Where(e =>
                        e.StudentId == student.IdStudent)?
                    .ToList();
            }
        }

        return enrollments;
    }

    /// <summary>
    ///     Searching an enrollment
    /// </summary>
    /// <param name="studentId"></param>
    /// <param name="courseId"></param>
    /// <param name="grade"></param>
    /// <returns>Returns a list of enrollments by student or course or grade</returns>
    public static List<Enrollment> ConsultEnrollment(
        int studentId, int courseId, decimal? grade)
    {
        var enrollments = ListEnrollments;

        if (studentId != -1)
            enrollments = enrollments
                .Where(a => a.StudentId == studentId)
                .ToList();

        if (courseId != -1)
            enrollments = enrollments
                .Where(a => a.CourseId == courseId)
                .ToList();

        if (grade.HasValue)
            enrollments = enrollments
                .Where(a => a.Grade == grade.Value)
                .ToList();

        return enrollments;
    }


    /// <summary>
    ///     Searching an enrollment
    /// </summary>
    /// <param name="id"></param>
    /// <param name="grade"></param>
    /// <param name="studentId"></param>
    /// <param name="courseId"></param>
    /// <returns>Returns a list of enrollments by student or course or grade</returns>
    public static List<Enrollment> ConsultEnrollment(
        int id, decimal? grade,
        int studentId, int courseId)
    {
        var enrollments = ListEnrollments;

        if (id >= 0)
            enrollments =
                enrollments.Where(e => e.IdEnrollment == id).ToList();

        if (grade.HasValue)
            enrollments =
                enrollments.Where(e => e.Grade == grade).ToList();

        if (studentId >= 0)
            enrollments =
                enrollments.Where(e => e.StudentId == studentId).ToList();

        if (courseId >= 0)
            enrollments =
                enrollments.Where(e => e.CourseId == courseId).ToList();

        return enrollments;
    }

    #endregion
}