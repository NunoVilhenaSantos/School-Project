using ClassLibrary.Courses;
using ClassLibrary.Students;

namespace ClassLibrary.Enrollments;

public class Enrollments1
{
    private readonly IDictionary<int, Student> _students;
    private readonly IDictionary<int, Course> _courses;
    private readonly ISet<Enrollment> _enrollments;

    public Enrollments1(
        IDictionary<int, Student> students,
        IDictionary<int, Course> courses)
    {
        _students = students;
        _courses = courses;
        _enrollments = new HashSet<Enrollment>();
    }

    public void AddEnrollment(
        int studentId, int courseId,
        decimal? grade = null)
    {
        if (!_students.TryGetValue(studentId, out var student))
        {
            throw new KeyNotFoundException(
                $"Student with ID {studentId} not found.");
        }

        if (!_courses.TryGetValue(courseId, out var course))
        {
            throw new KeyNotFoundException(
                $"Course with ID {courseId} not found.");
        }

        var enrollment = new Enrollment
        {
            Student = student,
            Course = course,
            Grade = grade
        };

        if (!_enrollments.Add(enrollment))
        {
            throw new ArgumentException("Enrollment already exists.");
        }
    }

    public bool DeleteEnrollment(int studentId, int courseId)
    {
        var enrollment = _enrollments
            .FirstOrDefault(
                e =>
                    e.Student.IdStudent == studentId &&
                    e.Course.IdCourse == courseId);

        return enrollment != null && _enrollments.Remove(enrollment);
    }

    public IEnumerable<Enrollment> SearchEnrollments(
        int? studentId = null,
        int? courseId = null,
        decimal? grade = null)
    {
        return _enrollments
            .Where(e =>
                (!studentId.HasValue || e.Student.IdStudent == studentId.Value)
                &&
                (!courseId.HasValue || e.Course.IdCourse == courseId.Value)
                &&
                (!grade.HasValue || e.Grade == grade.Value));
    }
}