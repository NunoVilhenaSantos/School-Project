namespace ClassLibrary;

public static class Enrollments
{
    #region Properties

    public static List<Enrollment> ListEnrollments { get; set; } = new();

    #endregion


    #region Methods

    /// <summary>
    ///     Adding a new enrollment
    /// </summary>
    /// <param name="studentId"></param>
    /// <param name="courseId"></param>
    public static void AddEnrollment(int studentId, int courseId)
    {
        ListEnrollments.Add(new Enrollment
        {
            Grade = null,
            StudentId = studentId,
            CourseId = courseId
        });
    }

    /// <summary>
    ///     Adding a new enrollment
    /// </summary>
    /// <param name="studentId"></param>
    /// <param name="courseId"></param>
    /// <param name="grade"></param>
    public static void AddEnrollment(decimal grade, int studentId, int courseId)
    {
        ListEnrollments.Add(new Enrollment
        {
            Grade = grade,
            StudentId = studentId,
            CourseId = courseId
        });
    }


    /// <summary>
    ///     Deleting an enrollment
    /// </summary>
    /// <param name="studentId"></param>
    /// <param name="courseId"></param>
    /// <returns>Return an text informing if the operation was valid or not</returns>
    public static string DeleteEnrollment(int studentId, int courseId)
    {
        var enrollment =
            ListEnrollments.FirstOrDefault(
                a => a.StudentId == studentId && a.CourseId == courseId);

        if (enrollment == null)
            return "A matrícula não existe";

        ListEnrollments.Remove(enrollment);
        return "A matrícula foi apagada";
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
            enrollments = enrollments.Where(a => a.StudentId == studentId)
                .ToList();

        if (courseId != -1)
            enrollments = enrollments.Where(a => a.CourseId == courseId)
                .ToList();

        if (grade.HasValue)
            enrollments = enrollments.Where(a => a.Grade == grade.Value)
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