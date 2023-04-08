using System.Globalization;
using System.Text;
using ClassLibrary.Courses;
using ClassLibrary.SchoolClasses;
using ClassLibrary.Students;
using ClassLibrary.Teachers;
using CsvHelper;
using CsvHelper.Configuration;

namespace ClassLibrary.School;

public class SchoolDatabase
{
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
            //_schoolClassCourses.Add(schoolClassId, new HashSet<int>());
            _schoolClassCourses[schoolClassId] = new HashSet<int>();

        _schoolClassCourses[schoolClassId].Add(courseId);
    }


    public static void AddStudentToCourse(int studentId, int courseId)
    {
        if (!_studentCourses.ContainsKey(studentId))
            //_studentCourses.Add(studentId, new HashSet<int>());
            _studentCourses[studentId] = new HashSet<int>();

        _studentCourses[studentId].Add(courseId);
    }


    public static void AddTeacherCourse(int teacherId, int courseId)
    {
        if (!_teacherCourses.ContainsKey(teacherId))
            //_teacherCourses.Add(teacherId, new HashSet<int>());
            _teacherCourses[teacherId] = new HashSet<int>();

        _teacherCourses[teacherId].Add(courseId);
    }

    #endregion


    #region IEnumerar

    public static IEnumerable<Course> GetCoursesForSchoolClass(
        int schoolClassId)
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


    public static IEnumerable<Course> GetCoursesForStudent(int studentId)
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


    public static IEnumerable<Course> GetCoursesForTeacher(int teacherId)
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


    #region SaveToCsv

    public static bool SaveToCsv(string filePath, out string myString)
    {
        //
        // constructor for the reading files
        // with a try and catch
        // and also returning the messages
        //

        FileStream fileStream;
        try
        {
            using (fileStream = new FileStream(
                       filePath,
                       FileMode.Create,
                       FileAccess.Write))
            {
            }
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " +
                       ex.Source + " | " + ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " +
                       e.Source + " | " + e.Message;
            return false;
        }

        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using (fileStream =
                   new FileStream(filePath, FileMode.Create, FileAccess.Write))
        using (var writer = new StreamWriter(fileStream, Encoding.UTF8))
        using (var csv = new CsvWriter(writer, csvConfig))
        {
            csv.WriteRecords(_courses.Values);
            csv.NextRecord();
            csv.WriteRecords(_schoolClasses.Values);
            csv.NextRecord();
            csv.WriteRecords(_students.Values);
            csv.NextRecord();
            csv.WriteRecords(_teachers.Values);
            csv.NextRecord();
        }

        myString = "Operação realizada com sucesso";
        return true;
    }

    public static bool LoadFromCsv(string filePath, out string myString)
    {
        //
        // constructor for the reading files
        // with a try and catch
        // and also returning the messages
        //

        FileStream fileStream;
        try
        {
            using (fileStream = new FileStream(
                       filePath,
                       FileMode.OpenOrCreate,
                       FileAccess.Read))
            {
            }
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " +
                       ex.Source + " | " + ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " +
                       e.Source + " | " + e.Message;
            return false;
        }

        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using (fileStream = new FileStream(
                   filePath, FileMode.OpenOrCreate, FileAccess.Read))
        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8))
        using (var csv = new CsvReader(streamReader, csvConfig))
        {
            _courses =
                csv.GetRecords<Course>().ToDictionary(c => c.IdCourse);

            _schoolClasses =
                csv.GetRecords<SchoolClass>()
                    .ToDictionary(
                        sc => sc.IdSchoolClass);

            _students =
                csv.GetRecords<Student>()
                    .ToDictionary(s => s.IdStudent);

            _teachers =
                csv.GetRecords<Teacher>()
                    .ToDictionary(t => t.TeacherId);
        }

        myString = "Operação realizada com sucesso";
        return true;
    }

    public static bool SaveToCsvExtenso(string filePath, out string myString)
    {
        //
        // constructor for the reading files
        // with a try and catch
        // and also returning the messages
        //

        FileStream fileStream;
        try
        {
            using (fileStream = new FileStream(
                       filePath,
                       FileMode.Create,
                       FileAccess.Write))
            {
            }
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " +
                       ex.Source + " | " + ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " +
                       e.Source + " | " + e.Message;
            return false;
        }

        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using (fileStream =
                   new FileStream(filePath, FileMode.Create, FileAccess.Write))
        using (var writer = new StreamWriter(fileStream, Encoding.UTF8))
        using (var csv = new CsvWriter(writer, csvConfig))
        {
            // Write the courses to the CSV file
            csv.WriteRecords(_courses.Values);

            // Write the school classes to the CSV file
            csv.WriteRecords(_schoolClasses.Values);

            // Write the students to the CSV file
            csv.WriteRecords(_students.Values);

            // Write the teachers to the CSV file
            csv.WriteRecords(_teachers.Values);

            // Write the school class courses to the CSV file
            foreach (var kvp in _schoolClassCourses)
            foreach (var courseId in kvp.Value)
            {
                csv.WriteRecord(new
                {
                    SchoolClassId = kvp.Key,
                    CourseId = courseId
                });
                csv.NextRecord();
            }

            // Write the student courses to the CSV file
            foreach (var kvp in _studentCourses)
            foreach (var courseId in kvp.Value)
            {
                csv.WriteRecord(new
                {
                    StudentId = kvp.Key,
                    CourseId = courseId
                });
                csv.NextRecord();
            }

            // Write the teacher courses to the CSV file
            foreach (var kvp in _teacherCourses)
            foreach (var courseId in kvp.Value)
            {
                csv.WriteRecord(new
                {
                    TeacherId = kvp.Key,
                    CourseId = courseId
                });
                csv.NextRecord();
            }
        }

        myString = "Operação realizada com sucesso";
        return true;
    }

    #endregion
}