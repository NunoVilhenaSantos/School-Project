using ClassLibrary.Courses;
using ClassLibrary.School;
using ClassLibrary.Students;

namespace ClassLibrary.Enrollments;

public static class Enrollments
{
    #region Properties

    public static List<Enrollment> ListEnrollments { get; set; } = new();

    public static Dictionary<int, Student> StudentsDictionary { get; set; } =
        new();

    public static Dictionary<int, Course> CoursesDictionary { get; set; } =
        new();

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
        int studentId, int courseId,
        decimal? grade = null,
        Student student = null, Course course = null)
    {
        // this is done before adding the Enrollments to improve performance
        UpdateDictionaries();

        if (!StudentsDictionary.ContainsKey(studentId))
            throw new ArgumentException("Invalid student ID");

        if (!CoursesDictionary.ContainsKey(courseId))
            throw new ArgumentException("Invalid course ID");

        if (ListEnrollments.Any(e =>
                e.StudentId == studentId && e.CourseId == courseId))
            throw new ArgumentException(
                "This student is already enrolled in this course");

        ListEnrollments.Add(new Enrollment
        {
            Grade = grade,
            StudentId = studentId,
            Student = student ?? StudentsDictionary[studentId],
            CourseId = courseId,
            Course = course ?? CoursesDictionary[courseId]
        });
        SchoolDatabase.AddStudentToCourse(studentId, courseId);
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
            if (CoursesDictionary.ContainsKey(courseId))
            {
                var course = CoursesDictionary[courseId];
                enrollments = enrollments
                    .Where(e =>
                        e.CourseId == course.IdCourse)
                    .ToList();
            }

        if (studentId != -1)
            if (StudentsDictionary.ContainsKey(studentId))
            {
                var student = StudentsDictionary[studentId];
                enrollments = enrollments
                    .Where(e =>
                        e.StudentId == student.IdStudent)
                    .ToList();
            }

        return enrollments;
    }

    // public static List<Enrollment> ConsultEnrollment(int idStudent)
    // {
    //     var enrollments = ListEnrollments;
    //
    //     if (idStudent >= 0)
    //         enrollments =
    //             enrollments.Where(e => e.StudentId == idStudent).ToList();
    //
    //     return enrollments;
    // }
    //
    // public static List<Enrollment> ConsultEnrollment(int idCourse)
    // {
    //     var enrollments = ListEnrollments;
    //
    //     if (idCourse >= 0)
    //         enrollments =
    //             enrollments.Where(e => e.CourseId == idCourse).ToList();
    //
    //     return enrollments;
    // }


    //
    // public static List<Enrollment> ConsultEnrollment(
    //     int courseId = -1, int studentId = -1)
    // {
    //     var enrollments = ListEnrollments;
    //
    //     foreach (var filterParam in filterParams)
    //     {
    //         switch (filterParam.Key.ToLower())
    //         {
    //             case "studentid":
    //                 if (StudentsDictionary.ContainsKey(filterParam.Value))
    //                 {
    //                     var student = StudentsDictionary[filterParam.Value];
    //                     enrollments = enrollments
    //                         .Where(e => e.StudentId == student.IdStudent)
    //                         .ToList();
    //                 }
    //
    //                 break;
    //             case "courseid":
    //                 if (CoursesDictionary.ContainsKey(filterParam.Value))
    //                 {
    //                     var course = CoursesDictionary[filterParam.Value];
    //                     enrollments = enrollments
    //                         .Where(e => e.CourseId == course.IdCourse).ToList();
    //                 }
    //
    //                 break;
    //             default:
    //                 // handle unsupported filter parameters if necessary
    //                 break;
    //         }
    //     }
    //
    //     return enrollments;
    // }


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