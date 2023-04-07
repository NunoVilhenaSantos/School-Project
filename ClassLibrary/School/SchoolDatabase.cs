using ClassLibrary.Courses;
using ClassLibrary.SchoolClasses;
using ClassLibrary.Students;
using ClassLibrary.Teachers;

namespace ClassLibrary.School;

public class SchoolDatabase
{
    #region DictionaryClasses

    //
    // Região com os dicionários das classes primitivas
    //
    private static Dictionary<int, Course> _courses;
    private static Dictionary<int, SchoolClass> _schoolClasses;
    private static Dictionary<int, Student> _students;
    private static Dictionary<int, Teacher> _teachers;

    #endregion


    #region DictionaryRelations

    //
    // Região com os dicionários das classes das relações
    //
    private static Dictionary<int, HashSet<int>> _schoolClassCourses;
    private static Dictionary<int, HashSet<int>> _studentCourses;
    private static Dictionary<int, HashSet<int>> _teacherCourses;

    #endregion


    #region Constructor

    //
    // Região com o construtor da diversas classes
    //


    public SchoolDatabase()
    {
        _courses = new Dictionary<int, Course>();
        _schoolClasses = new Dictionary<int, SchoolClass>();
        _students = new Dictionary<int, Student>();
        _teachers = new Dictionary<int, Teacher>();

        _schoolClassCourses = new Dictionary<int, HashSet<int>>();
        _studentCourses = new Dictionary<int, HashSet<int>>();
        _teacherCourses = new Dictionary<int, HashSet<int>>();
    }

    #endregion


    #region AddingValuesToPrimaryClasses

    //
    // região da adição dos membros das classes primarias
    //


    public static void AddCourse(Course course)
    {
        //_courses.Add(course.IdCourse, course);
        _courses[course.IdCourse] = course;
    }


    public static void AddSchoolClass(SchoolClass schoolClass)
    {
        _schoolClasses.Add(schoolClass.IdSchoolClass, schoolClass);
        _schoolClasses[schoolClass.IdSchoolClass] = schoolClass;
    }


    public static void AddStudent(Student student)
    {
        //_students.Add(student.IdStudent, student);
        _students[student.IdStudent] = student;
    }


    public static void AddTeacher(Teacher teacher)
    {
        //_teachers.Add(teacher.TeacherId, teacher);
        _teachers[teacher.TeacherId] = teacher;
    }

    #endregion


    #region AddingRelationsBetweenPrimaryClassesAndCoursID

    public static void AddSchoolClassCourses(int schoolClassId, int courseId)
    {
        if (!_schoolClassCourses.ContainsKey(schoolClassId))
        {
            //_schoolClassCourses.Add(schoolClassId, new HashSet<int>());
            _schoolClassCourses[schoolClassId] = new HashSet<int>();
        }

        _schoolClassCourses[schoolClassId].Add(courseId);
    }


    public static void AddStudentToCourse(int studentId, int courseId)
    {
        if (!_studentCourses.ContainsKey(studentId))
        {
            //_studentCourses.Add(studentId, new HashSet<int>());
            _studentCourses[studentId] = new HashSet<int>();
        }

        _studentCourses[studentId].Add(courseId);
    }


    public static void AddTeacherCourse(int teacherId, int courseId)
    {
        if (!_teacherCourses.ContainsKey(teacherId))
        {
            //_teacherCourses.Add(teacherId, new HashSet<int>());
            _teacherCourses[teacherId] = new HashSet<int>();
        }

        _teacherCourses[teacherId].Add(courseId);
    }

    #endregion


    #region IEnumerar

    public IEnumerable<Course> GetCoursesForSchoolClass(int schoolClassId)
    {
        // if (!_schoolClassCourses.ContainsKey(schoolClassId))
        // {
        //     return Enumerable.Empty<Course>();
        // }
        //var courseIds = _schoolClassCourses[schoolClassId];
        //return _courses.Values.Where(c => courseIds.Contains(c.IdCourse));
        return !_schoolClassCourses
            .TryGetValue(schoolClassId, out var courseIds)
            ? Enumerable.Empty<Course>()
            : courseIds.Select(courseId => _courses[courseId]);
    }


    public IEnumerable<Course> GetCoursesForStudent(int studentId)
    {
        // if (!_studentCourses.ContainsKey(studentId))
        // {
        //     return Enumerable.Empty<Course>();
        // }
        //
        // var courseIds = _studentCourses[studentId];
        // return _courses.Values.Where(c => courseIds.Contains(c.IdCourse));
        return !_studentCourses
            .TryGetValue(studentId, out var courseIds)
            ? Enumerable.Empty<Course>()
            : courseIds.Select(courseId => _courses[courseId]);
    }


    public IEnumerable<Course> GetCoursesForTeacher(int teacherId)
    {
        // if (!_teacherCourses.ContainsKey(teacherId))
        // {
        //     return Enumerable.Empty<Course>();
        // }
        //
        // var courseIds = _teacherCourses[teacherId];
        // return _courses.Values.Where(c => courseIds.Contains(c.IdCourse));
        return !_teacherCourses
            .TryGetValue(teacherId, out var courseIds)
            ? Enumerable.Empty<Course>()
            : courseIds.Select(courseId => _courses[courseId]);
    }

    #endregion
}