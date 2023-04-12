using ClassLibrary.School;
using Serilog;

namespace ClassLibrary.Enrollments;

public static class Enrollments
{
    #region Properties

    public static readonly List<Enrollment> ListEnrollments = new();

    #endregion


    #region Methods

    // update the dictionaries from the list of their corresponding classes
    public static void UpdateDictionaries()
    {
        // update the students dictionary
        foreach (var student in Students.Students.StudentsList)
            Students.Students.StudentsDictionary[student.IdStudent] = student;

        // update the courses dictionary
        foreach (var course in Courses.Courses.CoursesList)
            Courses.Courses.CoursesDictionary[course.IdCourse] = course;
    }

    public static void AddEnrollmentsToSchoolDatabase()
    {
        // update the students dictionary
        foreach (var e in ListEnrollments)
            SchoolDatabase.EnrollStudentInCourse(e.StudentId, e.CourseId);
    }


    public static void EnrollStudent(
        int studentId, int courseId, decimal? grade = null)
    {
        // Check if the student ID is valid
        if (!Students.Students.StudentsDictionary.ContainsKey(studentId))
        {
            Log.Error("Invalid student ID: " +
                      "{StudentId}", studentId);
            return;
        }

        // Check if the course ID is valid
        if (!Courses.Courses.CoursesDictionary.ContainsKey(courseId))
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


    public static void UnenrollStudent(int idStudent, int idCourse)
    {
        var enrollment =
            ListEnrollments
                .FirstOrDefault(
                    e =>
                        e.StudentId == idStudent &&
                        e.CourseId == idCourse);

        if (enrollment == null)
        {
            Log.Warning(
                "Attempted to unenroll student {StudentId} " +
                "from course {CourseId}," +
                " but no such enrollment exists",
                idStudent, idCourse);
            return;
        }

        ListEnrollments.Remove(enrollment);
        Log.Information(
            "Student {StudentId} " +
            "has been unenrolled from course {CourseId}",
            idStudent, idCourse);
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
            Log.Warning(
                "Attempted to unenroll student {StudentId} " +
                "from course {CourseId}," +
                " but no such enrollment exists",
                studentId, courseId);
            return;
        }

        ListEnrollments.Remove(enrollment);
    }

    public static List<Enrollment> ConsultEnrollment(
        int courseId = -1, int studentId = -1)
    {
        var enrollments = ListEnrollments;

        if (courseId != -1)
            if (Courses.Courses.CoursesDictionary
                .TryGetValue(courseId, out var course))
                enrollments = enrollments
                    .Where(e =>
                        e.CourseId == course.IdCourse)
                    .ToList();

        if (studentId == -1) return enrollments;
        {
            if (Students.Students.StudentsDictionary
                .TryGetValue(studentId, out var student))
                enrollments = enrollments
                    .Where(e =>
                        e.StudentId == student.IdStudent)?
                    .ToList();
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