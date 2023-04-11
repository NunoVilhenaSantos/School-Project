using ClassLibrary.Courses;
using ClassLibrary.School;

namespace ClassLibrary.SchoolClasses;

public static class SchoolClasses
{
    #region Properties

    public static List<SchoolClass> SchoolClassesList { get; set; } = new();

    #endregion


    #region Methods

    public static void AddSchoolClass(
        int id, string classAcronym, string className,
        DateOnly startDate, DateOnly endDate,
        TimeOnly startHour, TimeOnly endHour,
        string location, string type, string area, int studentsCount,
        List<Course>? courses
    )
    {
        SchoolClassesList.Add(new SchoolClass
            {
                //Id_SchoolClass = id,
                ClassAcronym = classAcronym,
                ClassName = className,
                StartDate = startDate,
                EndDate = endDate,
                StartHour = startHour,
                EndHour = endHour,
                Location = location,
                Type = type,
                Area = area
                //StudentsCount = studentsCount,
                //CoursesList = courses
            }
        );
        SchoolDatabase.AddSchoolClass(SchoolClassesList[^1]);

        // foreach (var course in SchoolClassesList[^1].CoursesList)
        //     SchoolDatabase.AssignCourseToClass(
        //         course.IdCourse,
        //         SchoolClassesList[^1].IdSchoolClass);

        SchoolClassesList[^1].GetStudentsCount();
        SchoolClassesList[^1].GetWorkHourLoad();
    }


    public static string DeleteSchoolClass(int id)
    {
        var schoolClass =
            SchoolClassesList
                .FirstOrDefault(a => a.IdSchoolClass == id);

        if (schoolClass == null) return $"A turma {id} não existe!\n";

        if (SchoolClassesList == null)
            return $"Não foi possível remover a turma " +
                   $"{id} pois a lista de turmas é nula.";

        var fullInfo = GetFullInfo(id);
        SchoolClassesList.Remove(schoolClass);
        return $"A turma {schoolClass.ClassName} com " +
               $"o {id} foi apagada!\n{fullInfo}";
    }


    public static string EditSchoolClass(
        int id, string classAcronym, string className,
        DateOnly startDate, DateOnly endDate,
        TimeOnly startHour, TimeOnly endHour,
        string location, string type, string area,
        List<Course> courses
    )
    {
        if (SchoolClassesList.Count < 1)
            return "A lista está vazia";

        var schoolClass =
            SchoolClassesList.FirstOrDefault(
                a => a.IdSchoolClass == id);

        if (schoolClass == null)
            return "A turma não existe!";

        SchoolClassesList.FirstOrDefault(
            a => a.IdSchoolClass == id)!.ClassAcronym = classAcronym;
        SchoolClassesList.FirstOrDefault(
            a => a.IdSchoolClass == id)!.ClassName = className;

        SchoolClassesList.FirstOrDefault(
            a => a.IdSchoolClass == id)!.StartDate = startDate;
        SchoolClassesList.FirstOrDefault(
            a => a.IdSchoolClass == id)!.EndDate = endDate;
        SchoolClassesList.FirstOrDefault(
            a => a.IdSchoolClass == id)!.StartHour = startHour;
        SchoolClassesList.FirstOrDefault(
            a => a.IdSchoolClass == id)!.EndHour = endHour;

        SchoolClassesList.FirstOrDefault(
            a => a.IdSchoolClass == id)!.Location = location;
        SchoolClassesList.FirstOrDefault(
            a => a.IdSchoolClass == id)!.Type = type;
        SchoolClassesList.FirstOrDefault(
            a => a.IdSchoolClass == id)!.Area = area;

        // SchoolClassesList.FirstOrDefault(
        //     a => a.IdSchoolClass == id)!.CoursesList = courses;

        SchoolClassesList[^1].GetStudentsCount();
        SchoolClassesList[^1].GetWorkHourLoad();

        return "Turma alterada com sucesso";
    }


    public static List<SchoolClass> ConsultSchoolClasses(
        int? id, string classAcronym, string className,
        DateOnly? startDate, DateOnly? endDate,
        TimeOnly? startHour, TimeOnly? endHour,
        string location, string type, string area,
        int? studentsCount,
        //List<Student>? studentsList
        List<Course>? courses
    )
    {
        var schoolClasses = SchoolClassesList;

        if (!string.IsNullOrWhiteSpace(classAcronym))
            schoolClasses = SchoolClassesList
                .Where(a => a.ClassAcronym == classAcronym).ToList();
        if (!string.IsNullOrWhiteSpace(className))
            schoolClasses = SchoolClassesList
                .Where(a => a.ClassName == className).ToList();

        schoolClasses = SchoolClassesList.Where(a => a.StartDate == startDate)
            .ToList();
        if (endDate > startDate)
            schoolClasses = SchoolClassesList.Where(a => a.EndDate == endDate)
                .ToList();
        schoolClasses = SchoolClassesList.Where(a => a.StartHour == startHour)
            .ToList();
        if (endHour > startHour)
            schoolClasses = SchoolClassesList.Where(a => a.EndHour == endHour)
                .ToList();

        if (!string.IsNullOrWhiteSpace(location))
            schoolClasses = SchoolClassesList.Where(a => a.Location == location)
                .ToList();
        if (!string.IsNullOrWhiteSpace(type))
            schoolClasses =
                SchoolClassesList.Where(a => a.Type == type).ToList();
        if (!string.IsNullOrWhiteSpace(area))
            schoolClasses =
                SchoolClassesList.Where(a => a.Area == area).ToList();
        if (studentsCount != null && int.IsNegative((int) studentsCount))
            schoolClasses = SchoolClassesList
                .Where(a => a.StudentsCount == studentsCount).ToList();

        // if (courses is {Count: > 0})
        //     schoolClasses = SchoolClassesList
        //         .Where(a => a.CoursesList == courses).ToList();

        return schoolClasses;
    }


    /*
    public static List<SchoolClass> ConsultSchoolClasses(
        string selectedProperty, object selectedValue)
    {
        
        //
        // 1.º teste
        //

        // Create a new list to store the filtered results
        List<SchoolClass> filteredSchoolClass = new();

        var property = typeof(SchoolClass).GetProperty(selectedProperty);
        foreach (var schoolClass in SchoolClasses.SchoolClassesList)
        {
            if (property == null ||
                property.GetValue(schoolClass).ToString() == ""
               )
                continue;

            filteredSchoolClass.Add(schoolClass);
        }


        var property = typeof(SchoolClass).GetProperty(selectedProperty);
        if (property == null) return new List<SchoolClass>();

        var propertyType = property.PropertyType;
        var convertedValue =
            Convert.ChangeType(selectedValue, propertyType);

        return SchoolClassesList
            .Where(schoolClass =>
                property.GetValue(schoolClass)
                    ?.Equals(convertedValue) ==
                true)
            .ToList();
    }
    */

    public static List<SchoolClass> ConsultSchoolClasses(
        string selectedProperty, object selectedValue)
    {
        var property = typeof(SchoolClass).GetProperty(selectedProperty);
        if (property == null) return new List<SchoolClass>();

        var propertyType = property.PropertyType;
        object convertedValue;
        try
        {
            convertedValue = Convert.ChangeType(selectedValue, propertyType);
        }
        catch (InvalidCastException ex)
        {
            // Handle invalid cast exception
            Console.WriteLine($"Invalid cast: {ex.Message}");
            return new List<SchoolClass>();
        }
        catch (FormatException ex)
        {
            // Handle format exception
            Console.WriteLine($"Invalid format: {ex.Message}");
            return new List<SchoolClass>();
        }

        return SchoolClassesList
            .Where(schoolClass =>
                property.GetValue(schoolClass)
                    ?.Equals(convertedValue) ==
                true)
            .ToList();
    }


    public static int GetLastIndex()
    {
        // handle the case where the collection is empty
        // return StudentsList[^1].IdStudent;
        // return GetLastIndex();
        var lastSchoolClasses = SchoolClassesList.LastOrDefault();
        if (lastSchoolClasses != null)
            return lastSchoolClasses.IdSchoolClass;
        return -1;
    }


    public static int GetLastId()
    {
        var lastSchoolClasses = SchoolClassesList.LastOrDefault();
        return lastSchoolClasses?.IdSchoolClass ?? GetLastIndex();
        /*
        return lastSchoolClasses != null
            ? lastSchoolClasses.IdSchoolClass
            : GetLastIndex();
        // handle the case where the collection is empty
        // return StudentsList[^1].IdStudent;
        // return GetLastIndex();
        */
    }


    public static string GetFullName(int id)
    {
        if (SchoolClassesList.Count < 1)
            return "A lista está vazia";

        var schoolClass =
            SchoolClassesList.FirstOrDefault(
                a => a.IdSchoolClass == id);

        if (schoolClass == null)
            return "A turma não existe!";

        return $"{schoolClass.IdSchoolClass,5} | " +
               $"{schoolClass.ClassAcronym} " +
               $"{schoolClass.ClassName}";
    }


    public static string GetFullInfo(int id)
    {
        if (SchoolClassesList.Count < 1)
            return "A lista está vazia";

        var schoolClass =
            SchoolClassesList.FirstOrDefault(
                a => a.IdSchoolClass == id);

        if (schoolClass == null)
            return "A turma não existe!";

        return $"{GetFullName(id)} | " +
               $"{schoolClass.Type} - {schoolClass.Area}";
    }


    // public static void ToObtainValuesForCalculatedFields()
    // {
    //     if (SchoolClassesList.Count < 1) return;
    //
    //     foreach (var schoolClass in SchoolClassesList)
    //     {
    //         var coursesList =
    //             SchoolDatabase.GetCoursesForSchoolClass(
    //                 schoolClass.IdSchoolClass);
    //
    //         if (coursesList == null || !coursesList.Any()) continue;
    //
    //         var coursesCount = 0;
    //         var workHourLoad = 0;
    //         var studentsCount = 0;
    //         decimal classTotal = 0;
    //         decimal highestGrade = 0;
    //         var lowestGrade = decimal.MaxValue;
    //
    //         foreach (var course in coursesList.Where(course => course != null))
    //         {
    //             coursesCount++;
    //
    //             var studentIds =
    //                 Enrollments.Enrollments.ListEnrollments?
    //                     .Where(e => e.CourseId == course.IdCourse)
    //                     .Select(e => e.StudentId)
    //                     .Distinct();
    //
    //             if (studentIds != null && studentIds.Any())
    //             {
    //                 studentsCount += studentIds.Count();
    //             }
    //
    //             workHourLoad += course.WorkLoad;
    //
    //             if (Enrollments.Enrollments.ListEnrollments == null ||
    //                 !Enrollments.Enrollments.ListEnrollments.Any())
    //                 continue;
    //
    //             var grades =
    //                 Enrollments.Enrollments.ListEnrollments?
    //                     .Where(e => e.CourseId == course.IdCourse)
    //                     .Select(e => e.Grade);
    //
    //             if (grades == null || !grades.Any()) continue;
    //
    //             classTotal += grades.Average() ?? 0;
    //             highestGrade = Math.Max(highestGrade, grades.Max() ?? 0);
    //             lowestGrade = Math.Min(lowestGrade,
    //                 grades.Min() ?? decimal.MaxValue);
    //         }
    //
    //         schoolClass.CoursesCount = coursesCount;
    //         schoolClass.WorkHourLoad = workHourLoad;
    //         schoolClass.StudentsCount =
    //             coursesCount > 0 ? studentsCount / coursesCount : 0;
    //         schoolClass.ClassAverage =
    //             coursesCount > 0 ? classTotal / coursesCount : 0;
    //         schoolClass.HighestGrade = highestGrade;
    //         schoolClass.LowestGrade = lowestGrade;
    //     }
    // }


    public static void ToObtainValuesForCalculatedFields()
    {
        if (SchoolClassesList.Count < 1) return;

        foreach (var schoolClass in SchoolClassesList)
        {
            var coursesList =
                SchoolDatabase
                    .GetCoursesForSchoolClass(schoolClass.IdSchoolClass);

            if (coursesList == null || !coursesList.Any()) continue;

            // use a set to ensure uniqueness of student IDs
            var students = new HashSet<string>();
            var coursesCount = 0;
            var workHourLoad = 0;
            decimal classTotal = 0;
            decimal highestGrade = 0;
            var lowestGrade = decimal.MaxValue;

            foreach (var course in coursesList.Where(course => course != null))
            {
                coursesCount++;
                workHourLoad += course.WorkLoad;

                var courseEnrollments =
                    Enrollments.Enrollments.ListEnrollments?
                        .Where(e => e.CourseId == course.IdCourse)
                        .ToList();

                if (courseEnrollments == null || !courseEnrollments.Any())
                    continue;

                var courseGrades = courseEnrollments
                    .Where(e => e.Grade.HasValue)
                    .Select(e => e.Grade.Value)
                    .ToList();

                if (courseGrades.Any())
                {
                    classTotal += courseGrades.Average();
                    highestGrade =
                        Math.Max(highestGrade, courseGrades.Max());
                    lowestGrade =
                        Math.Min(lowestGrade, courseGrades.Min());
                }

                // students.UnionWith(courseEnrollments
                //     .Select(e => e.StudentId));
                students.UnionWith(courseEnrollments
                    .Select(e => e.StudentId.ToString()));
            }

            schoolClass.CoursesCount = coursesCount;
            schoolClass.WorkHourLoad = workHourLoad;
            schoolClass.StudentsCount = students.Count;
            schoolClass.ClassAverage =
                coursesCount > 0 ? classTotal / coursesCount : 0;
            schoolClass.HighestGrade = highestGrade;
            schoolClass.LowestGrade = lowestGrade;
        }
    }

    #endregion
}