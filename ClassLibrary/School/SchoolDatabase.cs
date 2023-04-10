using ClassLibrary.Courses;
using ClassLibrary.SchoolClasses;
using ClassLibrary.Students;
using ClassLibrary.Teachers;
using Serilog;

namespace ClassLibrary.School;

public class SchoolDatabase
{
    #region UpdatingDictionaries

    // update the dictionaries from the list of their corresponding classes
    public static void UpdateDictionaries()
    {
        // update the Courses dictionary
        foreach (
            var course in
            ClassLibrary.Courses.Courses.CoursesList ??
            Enumerable.Empty<Course>())
            Courses[course.IdCourse] = course;

        // update the SchoolClasses dictionary
        foreach (
            var schoolClass in
            ClassLibrary.SchoolClasses.SchoolClasses.SchoolClassesList ??
            Enumerable.Empty<SchoolClass>())
            SchoolClasses[schoolClass.IdSchoolClass] = schoolClass;

        // update the Students dictionary
        foreach (
            var student in
            ClassLibrary.Students.Students.StudentsList ??
            Enumerable.Empty<Student>())
            Students[student.IdStudent] = student;

        // update the Teachers dictionary
        foreach (
            var teacher in
            ClassLibrary.Teachers.Teachers.TeachersList ??
            Enumerable.Empty<Teacher>())
            Teachers[teacher.TeacherId] = teacher;
    }

    #endregion

    #region Constructor

    //
    // Região com o construtor da diversas classes
    //


    // public SchoolDatabase()
    // {
    //     Courses = new Dictionary<int, Course>();
    //     SchoolClasses = new Dictionary<int, SchoolClass>();
    //     Students = new Dictionary<int, Student>();
    //     Teachers = new Dictionary<int, Teacher>();
    //
    //     // SchoolClassCourses = new Dictionary<int, HashSet<int>>();
    //     // StudentCourses = new Dictionary<int, HashSet<int>>();
    //     // TeacherCourses = new Dictionary<int, HashSet<int>>();
    // }

    #endregion


    #region Properties

    #region DictionaryClasses

    //
    // Região com os dicionários das classes primitivas
    //
    // Dictionaries to store the objects
    public static Dictionary<int, Course> Courses = new();
    public static Dictionary<int, SchoolClass> SchoolClasses = new();
    public static Dictionary<int, Student> Students = new();
    public static Dictionary<int, Teacher> Teachers = new();

    #endregion


    #region DictionaryRelations

    // modificado por mim
    // Dictionaries to store the relationships
    public static Dictionary<int, HashSet<int>> CourseClasses = new();
    public static Dictionary<int, HashSet<int>> CourseStudents = new();
    public static Dictionary<int, HashSet<int>> StudentClass = new();
    public static Dictionary<int, HashSet<int>> CourseTeacher = new();

    #endregion

    #endregion


    #region AddingValuesToPrimaryClasses

    //
    // região para adiçionar os membros das classes primarias
    //


    public static void AddCourse(Course course)
    {
        Courses.Add(course.IdCourse, course);
        // Courses[course.IdCourse] = course;
    }


    public static void AddSchoolClass(SchoolClass schoolClass)
    {
        SchoolClasses.Add(schoolClass.IdSchoolClass, schoolClass);
        // SchoolClasses[schoolClass.IdSchoolClass] = schoolClass;
    }


    public static void AddStudent(Student student)
    {
        Students.Add(student.IdStudent, student);
        // Students[student.IdStudent] = student;
    }


    public static void AddTeacher(Teacher teacher)
    {
        Teachers.Add(teacher.TeacherId, teacher);
        // Teachers[teacher.TeacherId] = teacher;
    }

    #endregion


    #region AddingRelationsBetweenPrimaryClasses

    #region EnrollStudentInClass

    // Method to add a relationship between a student and a school class
    public static void EnrollStudentInClass(int studentId, int schoolClassId)
    {
        if (!StudentClass.ContainsKey(studentId))
        {
            StudentClass.Add(studentId, new HashSet<int>());
            StudentClass[studentId] = new HashSet<int> {studentId};
        }

        StudentClass[studentId].Add(schoolClassId);
    }

    public static void EnrollStudentsInClass(
        List<Student> listStudents, int schoolClassId)
    {
        foreach (var student in listStudents)
        {
            if (!StudentClass.ContainsKey(student.IdStudent))
            {
                StudentClass.Add(student.IdStudent, new HashSet<int>());
                StudentClass[student.IdStudent] =
                    new HashSet<int> {student.IdStudent};
            }

            StudentClass[student.IdStudent].Add(schoolClassId);
        }
    }

    #endregion


    #region EnrollStudentInCourse

    public static void EnrollStudentsInCourses(
        List<Course> listOfCourses, List<Student> listOfStudents)
    {
        foreach (var course in listOfCourses)
        foreach (var student in listOfStudents)
        {
            if (!Students.ContainsKey(student.IdStudent))
            {
                Log.Error("Invalid student ID: " +
                          "{StudentId}", student.IdStudent);
                continue;
            }

            if (!Courses.ContainsKey(course.IdCourse))
            {
                Log.Error("Invalid course ID: " +
                          "{CourseId}", course.IdCourse);
                continue;
            }

            if (CourseStudents
                    .TryGetValue(student.IdStudent,
                        out var currentCourse) &&
                currentCourse.Contains(course.IdCourse))
            {
                Log.Warning("Student {StudentId} " +
                            "is already enrolled in course {CourseId}",
                    student.IdStudent,
                    course.IdCourse);
                continue;
            }

            Enrollments.Enrollments.EnrollStudent(
                student.IdStudent, course.IdCourse);

            if (!CourseStudents.ContainsKey(student.IdStudent))
                CourseStudents.Add(student.IdStudent, new HashSet<int>());

            CourseStudents[student.IdStudent].Add(course.IdCourse);
        }
    }


    public static void EnrollStudentInCourse(int studentId, int courseId)
    {
        if (!Students.ContainsKey(studentId))
        {
            Log.Error(
                "Invalid student ID: {StudentId}", studentId);
            return;
        }

        if (!Courses.ContainsKey(courseId))
        {
            Log.Error(
                "Invalid course ID: {CourseId}", courseId);
            return;
        }

        if (CourseStudents.TryGetValue(studentId, out var courses) &&
            courses.Contains(courseId))
        {
            Log.Warning(
                "Student {StudentId} " +
                "is already enrolled in course {CourseId}",
                studentId, courseId);
            return;
        }

        Enrollments.Enrollments.EnrollStudent(studentId, courseId);

        if (!CourseStudents.ContainsKey(studentId))
            CourseStudents.Add(studentId, new HashSet<int>());

        CourseStudents[studentId].Add(courseId);
    }


    public static void EnrollStudentsInCourse(
        List<Student> students, int courseId)
    {
        foreach (var student in students)
        {
            if (!Students.ContainsKey(student.IdStudent))
            {
                Log.Error("Invalid student ID: " +
                          "{StudentId}", student.IdStudent);
                continue;
            }

            if (!Courses.ContainsKey(courseId))
            {
                Log.Error("Invalid course ID: " +
                          "{CourseId}", courseId);
                continue;
            }

            if (CourseStudents.TryGetValue(student.IdStudent,
                    out var courses) && courses.Contains(courseId))
            {
                Log.Warning("Student {StudentId} " +
                            "is already enrolled in course {CourseId}",
                    student.IdStudent, courseId);
                continue;
            }

            Enrollments.Enrollments.EnrollStudent(student.IdStudent, courseId);

            if (!CourseStudents.ContainsKey(student.IdStudent))
                CourseStudents.Add(student.IdStudent, new HashSet<int>());

            CourseStudents[student.IdStudent].Add(courseId);
        }
    }

    public static void UnenrollStudentFromCourses(
        List<Course> coursesToRemove, int idStudent)
    {
        foreach (var course in coursesToRemove)
        {
            if (!Students.ContainsKey(idStudent))
            {
                Log.Error(
                    "Invalid student ID: {StudentId}",
                    idStudent);
                continue;
            }

            if (!Courses.ContainsKey(course.IdCourse))
            {
                Log.Error(
                    "Invalid course ID: {CourseId}",
                    course.IdCourse);
                continue;
            }

            if (!CourseStudents.TryGetValue(idStudent, out var courses) ||
                !courses.Contains(course.IdCourse))
            {
                Log.Warning(
                    "Student {StudentId} " +
                    "is not enrolled in course {CourseId}",
                    idStudent, course.IdCourse);
                continue;
            }

            Enrollments.Enrollments.UnenrollStudent(idStudent, course.IdCourse);

            CourseStudents[idStudent].Remove(course.IdCourse);

            if (CourseStudents[idStudent].Count == 0)
            {
                CourseStudents.Remove(idStudent);
            }
        }
    }


    public static void EnrollStudentInCourses(
        List<Course> listOfCourses, int idStudent)
    {
        foreach (var course in listOfCourses)
        {
            if (!Students.ContainsKey(idStudent))
            {
                Log.Error("Invalid student ID: " +
                          "{StudentId}", idStudent);
                continue;
            }

            if (!Courses.ContainsKey(course.IdCourse))
            {
                Log.Error("Invalid course ID: " +
                          "{CourseId}", course.IdCourse);
                continue;
            }

            if (
                CourseStudents.TryGetValue(idStudent,
                    out var courses) &&
                courses.Contains(course.IdCourse))
            {
                Log.Warning("Student {StudentId} " +
                            "is already enrolled in course {CourseId}",
                    idStudent, course.IdCourse);
                continue;
            }

            Enrollments.Enrollments.EnrollStudent(idStudent, course.IdCourse);

            if (!CourseStudents.ContainsKey(idStudent))
                CourseStudents.Add(idStudent, new HashSet<int>());

            CourseStudents[idStudent].Add(course.IdCourse);
        }
    }


    public static void EnrollStudentInCourses(HashSet<int> listOfCourses,
        int idStudent)
    {
        foreach (var course in listOfCourses)
        {
            if (!Students.ContainsKey(idStudent))
            {
                Log.Error("Invalid student ID: " +
                          "{StudentId}", idStudent);
                continue;
            }

            if (!Courses.ContainsKey(course))
            {
                Log.Error("Invalid course ID: " +
                          "{CourseId}", course);
                continue;
            }

            if (
                CourseStudents.TryGetValue(idStudent,
                    out var courses) &&
                courses.Contains(course))
            {
                Log.Warning("Student {StudentId} " +
                            "is already enrolled in course {CourseId}",
                    idStudent, course);
                continue;
            }

            Enrollments.Enrollments.EnrollStudent(idStudent, course);

            if (!CourseStudents.ContainsKey(idStudent))
                CourseStudents.Add(idStudent, new HashSet<int>());

            CourseStudents[idStudent].Add(course);
        }
    }

    #endregion

    public static void AssignCourseToClass(int courseId, int schoolClassId)
    {
        if (Courses.TryGetValue(courseId, out var course) &&
            SchoolClasses.TryGetValue(schoolClassId, out var schoolClass))
        {
            if (!CourseClasses
                    .TryGetValue(courseId, out var classes))
            {
                classes = new HashSet<int>();
                CourseClasses.Add(courseId, classes);
            }

            classes.Add(schoolClassId);

            Log.Information(
                "Assigned course {CourseId} to class {ClassId}.",
                courseId, schoolClassId);
        }
        else
        {
            Log.Warning(
                "Failed to assign course " +
                "{CourseId} to class {ClassId}." +
                " Course or school class does not exist.",
                courseId, schoolClassId);
        }
    }


    public static void AssignCoursesToClass(
        List<Course> listOfCourses, int schoolClassId)
    {
        if (!SchoolClasses.TryGetValue(schoolClassId, out var schoolClass))
        {
            Log.Warning(
                "Failed to assign courses to class {ClassId}." +
                " School class does not exist.",
                schoolClassId);
            return;
        }

        foreach (var course in listOfCourses)
            if (Courses.TryGetValue(course.IdCourse, out var c))
            {
                if (!CourseClasses.TryGetValue(course.IdCourse,
                        out var classes))
                {
                    classes = new HashSet<int>();
                    CourseClasses.Add(course.IdCourse, classes);
                }

                classes.Add(schoolClassId);

                Log.Information(
                    "Assigned course {CourseId} " +
                    "to class {ClassId}.",
                    course.IdCourse, schoolClassId);
            }
            else
            {
                Log.Warning(
                    "Failed to assign course {CourseId} " +
                    "to class {ClassId}. Course does not exist.",
                    course.IdCourse, schoolClassId);
            }
    }


    public static void AssignCoursesToClass(HashSet<int> listOfCourses,
        int schoolClassId)
    {
        if (!SchoolClasses.TryGetValue(schoolClassId, out var schoolClass))
        {
            Log.Warning(
                "Failed to assign courses to class {ClassId}." +
                " School class does not exist.",
                schoolClassId);
            return;
        }

        foreach (var course in listOfCourses)
            if (Courses.TryGetValue(course, out var c))
            {
                if (!CourseClasses.TryGetValue(course,
                        out var classes))
                {
                    classes = new HashSet<int>();
                    CourseClasses.Add(course, classes);
                }

                classes.Add(schoolClassId);

                Log.Information(
                    "Assigned course {CourseId} " +
                    "to class {ClassId}.",
                    course, schoolClassId);
            }
            else
            {
                Log.Warning(
                    "Failed to assign course {CourseId} " +
                    "to class {ClassId}. Course does not exist.",
                    course, schoolClassId);
            }
    }


    #region MyRegion

    public static void AssignTeacherToCourse(int teacherId, int courseId)
    {
        if (!CourseTeacher.ContainsKey(teacherId))
        {
            CourseTeacher.Add(teacherId, new HashSet<int>());
            CourseTeacher[teacherId] = new HashSet<int>();
        }

        CourseTeacher[teacherId].Add(courseId);
    }


    public static void AssignTeacherToCourses(
        int teacherId, List<Course> courses)
    {
        foreach (var course in courses)
        {
            if (!CourseTeacher.ContainsKey(teacherId))
            {
                CourseTeacher.Add(teacherId, new HashSet<int>());
                CourseTeacher[teacherId] = new HashSet<int>();
            }

            CourseTeacher[teacherId].Add(course.IdCourse);
        }
    }


    public static void AssignTeacherToCourses(
        HashSet<int> hashSetCourses, int teacherId)
    {
        foreach (var course in hashSetCourses)
        {
            if (!CourseTeacher.ContainsKey(teacherId))
            {
                CourseTeacher.Add(teacherId, new HashSet<int>());
                CourseTeacher[teacherId] = new HashSet<int>();
            }

            CourseTeacher[teacherId].Add(course);
        }
    }

    #endregion

    #endregion


    #region IEnumerar

    public static List<Course> GetCoursesForSchoolClass(
        int schoolClassId)
    {
        if (!CourseClasses.ContainsKey(schoolClassId))
            return new List<Course>();

        return CourseClasses[schoolClassId]
            .Select(x => Courses[x])
            .ToList();
    }


    // Get all courses a student is enrolled in
    public static List<Course> GetCoursesForStudent(int studentId)
    {
        if (CourseStudents
            .TryGetValue(studentId, out var studentCourses))
            return studentCourses
                .Select(x => Courses[x])
                .ToList();

        Log.Information(
            "Invalid student id {studentId}.",
            studentId);

        return new List<Course>();
    }


    public static List<Course> GetCoursesForTeacher(int teacherId)
    {
        if (!CourseTeacher.ContainsKey(teacherId)) return new List<Course>();

        return CourseTeacher[teacherId]
            .Select(x => Courses[x])
            .ToList();
    }


    // Get all students enrolled in a course
    public List<Student> GetStudentsInCourse(int courseId)
    {
        if (!Courses.ContainsKey(courseId))
            throw new ArgumentException("Invalid course id");

        return CourseStudents[courseId]
            .Select(x => Students[x])
            .ToList();
    }


    // public static Dictionary<int, HashSet<Student>>
    //     GetEnrolledStudentsByCourseForClass(int schoolClassId)
    // {
    //     var enrolledStudentsByCourse = new Dictionary<int, HashSet<Student>>();
    //
    //     var courseIds = CourseClasses.ContainsKey(schoolClassId)
    //         ? CourseClasses[schoolClassId]
    //         : new HashSet<int>();
    //
    //     foreach (var courseId in courseIds)
    //     {
    //         var studentIds = CourseStudents.ContainsKey(courseId)
    //             ? CourseStudents[courseId]
    //             : new HashSet<int>();
    //
    //         var students = studentIds
    //             .Where(studentId => StudentClass.ContainsKey(studentId) &&
    //                                 StudentClass[studentId]
    //                                     .Contains(schoolClassId))
    //             .Select(studentId => Students.ContainsKey(studentId)
    //                 ? Students[studentId]
    //                 : null)
    //             .Where(student => student != null)
    //             .ToHashSet();
    //
    //         enrolledStudentsByCourse.Add(courseId, students);
    //     }
    //
    //     // log error and rethrow exception
    //     var errorMessage =
    //         $"Error retrieving students enrolled in courses for school class with ID {schoolClassId}.";
    //     var errorDetails =
    //         $"The following key was not found in the dictionary: {ex.Message}.";
    //     Log.Error($"{errorMessage} {errorDetails}");
    //
    //     // log success
    //     Log.Information(
    //         $"Retrieved {studentIds.Count}" +
    //         $" students enrolled in courses for " +
    //         $"school class with ID {schoolClassId}.");
    //
    //     return enrolledStudentsByCourse;
    // }


    public static Dictionary<int, HashSet<Student>>
        GetEnrolledStudentsByCourseForClass(int schoolClassId)
    {
        var enrolledStudentsByCourse = new Dictionary<int, HashSet<Student>>();
        var errorMessage =
            $"Error retrieving students enrolled in " +
            $"courses for school class with ID {schoolClassId}.";

        if (!CourseClasses.ContainsKey(schoolClassId))
        {
            var errorDetails =
                $"Course classes not found for " +
                $"school class with ID {schoolClassId}.";
            Log.Error($"{errorMessage} {errorDetails}");
            return enrolledStudentsByCourse;
        }

        var courseIds = CourseClasses[schoolClassId];

        foreach (var courseId in courseIds)
        {
            if (!CourseStudents.ContainsKey(courseId))
            {
                var errorDetails =
                    $"Course students not found for course with ID {courseId}.";
                Log.Warning($"{errorMessage} {errorDetails}");
                continue;
            }

            var studentIds = CourseStudents[courseId];
            var students = new HashSet<Student>();

            foreach (var studentId in studentIds)
            {
                if (!StudentClass.ContainsKey(studentId))
                {
                    var errorDetails =
                        $"Student classes not found for " +
                        $"student with ID {studentId}.";
                    Log.Warning($"{errorMessage} {errorDetails}");
                    continue;
                }

                if (StudentClass[studentId].Contains(schoolClassId) &&
                    Students.TryGetValue(studentId, out var student))
                {
                    students.Add(student);
                }
            }

            enrolledStudentsByCourse.Add(courseId, students);
        }

        var totalStudents =
            enrolledStudentsByCourse
                .Sum(c => c.Value.Count);
        Log.Information(
            $"Retrieved {totalStudents} students enrolled " +
            $"in courses for school class with ID {schoolClassId}.");
        return enrolledStudentsByCourse;
    }

    #endregion


    #region GetList

    public static int GetCoursesCountForSchoolClass(int schoolClassId)
    {
        var coursesCount =
            GetCoursesForSchoolClass(schoolClassId)?.Count ?? 0;

        if (coursesCount == 0)
            Log.Warning("No courses found for " +
                        "the specified school class.");

        return coursesCount;
    }

    public static int GetWorkHourLoadForSchoolClass(int schoolClassId)
    {
        var listCoursesForSchoolClass =
            GetCoursesForSchoolClass(schoolClassId);
        var workHourLoad =
            listCoursesForSchoolClass?.Sum(c => c.WorkLoad) ?? 0;

        return workHourLoad;
    }

    public static int GetStudentsCountForSchoolClass(int schoolClassId)
    {
        var listCoursesForSchoolClass =
            GetCoursesForSchoolClass(schoolClassId);
        var studentsCount =
            listCoursesForSchoolClass?
                .Join(Enrollments.Enrollments.ListEnrollments,
                    c => c.IdCourse,
                    e => e.CourseId,
                    (c, e) => e).Count() ?? 0;

        return studentsCount;
    }

    public static (decimal, decimal, decimal) GetClassGradesForSchoolClass(
        int schoolClassId)
    {
        var enrollments = Enrollments.Enrollments.ListEnrollments;
        var courses = GetCoursesForSchoolClass(schoolClassId);

        var query =
            from enrollment in enrollments
            join course in courses on enrollment.CourseId equals course.IdCourse
            select new
            {
                enrollment,
                course
            };

        var classAverage =
            query.Average(ec => ec.enrollment.Grade) ?? 0;
        var highestGrade =
            query.Max(ec => ec.enrollment.Grade) ?? 0;
        var lowestGrade =
            query.Min(ec => ec.enrollment.Grade) ?? 0;

        return (classAverage, highestGrade, lowestGrade);
    }

    public static decimal GetStudentAveragesForSchoolClass(int schoolClassId)
    {
        var enrollments = Enrollments.Enrollments.ListEnrollments;
        var courses = GetCoursesForSchoolClass(schoolClassId);

        var query =
            from enrollment in enrollments
            join course in courses on enrollment.CourseId equals course.IdCourse
            select new
            {
                enrollment,
                course
            };

        var studentAverages =
            query
                .GroupBy(ec => ec.enrollment.StudentId)
                .Select(g => new
                {
                    StudentId = g.Key,
                    AverageGrade = g.Average(ec => ec.enrollment.Grade)
                });

        var studentCountAverage =
            studentAverages
                .Average(sa => sa.AverageGrade) ?? 0;

        return studentCountAverage;
    }

    public static int GetStudentCountForSchoolClass(int schoolClassId)
    {
        var enrollments = Enrollments.Enrollments.ListEnrollments;
        var courses = GetCoursesForSchoolClass(schoolClassId);

        var query = from enrollment in enrollments
            join course in courses on enrollment.CourseId equals course.IdCourse
            select new
            {
                enrollment,
                course
            };

        var studentAverages =
            query
                .GroupBy(ec => ec.enrollment.StudentId)
                .Select(g => new
                {
                    StudentId = g.Key,
                    AverageGrade = g.Average(ec => ec.enrollment.Grade)
                });

        var studentCount = studentAverages.Count();

        return studentCount;
    }

    #endregion
}