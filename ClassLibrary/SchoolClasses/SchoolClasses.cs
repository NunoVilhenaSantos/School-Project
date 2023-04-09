using ClassLibrary.Courses;
using ClassLibrary.School;

namespace ClassLibrary.SchoolClasses;

public static class SchoolClasses
{
    #region Properties

    public static List<SchoolClass> ListSchoolClasses { get; set; } = new();

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
        ListSchoolClasses.Add(new SchoolClass
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
                Area = area,
                //StudentsCount = studentsCount,
                //CoursesList = courses
            }
        );
        SchoolDatabase.AddSchoolClass(ListSchoolClasses[^1]);

        // foreach (var course in ListSchoolClasses[^1].CoursesList)
        //     SchoolDatabase.AssignCourseToClass(
        //         course.IdCourse,
        //         ListSchoolClasses[^1].IdSchoolClass);

        ListSchoolClasses[^1].GetStudentsCount();
        ListSchoolClasses[^1].GetWorkHourLoad();
    }


    public static string DeleteSchoolClass(int id)
    {
        var schoolClass =
            ListSchoolClasses.FirstOrDefault(a => a.IdSchoolClass == id);

        if (schoolClass == null)
            return $"A turma {id} não existe!\n{GetFullName(id)}";

        ListSchoolClasses.Remove(schoolClass);
        return $"A turma {ListSchoolClasses[id].ClassName}" +
               $" com o {id} foi apagada!\n{GetFullInfo(id)}";
    }


    public static string EditSchoolClass(
        int id, string classAcronym, string className,
        DateOnly startDate, DateOnly endDate,
        TimeOnly startHour, TimeOnly endHour,
        string location, string type, string area,
        List<Course> courses
    )
    {
        if (ListSchoolClasses.Count < 1)
            return "A lista está vazia";

        var schoolClass =
            ListSchoolClasses.FirstOrDefault(
                a => a.IdSchoolClass == id);

        if (schoolClass == null)
            return "A turma não existe!";

        ListSchoolClasses.FirstOrDefault(
            a => a.IdSchoolClass == id)!.ClassAcronym = classAcronym;
        ListSchoolClasses.FirstOrDefault(
            a => a.IdSchoolClass == id)!.ClassName = className;

        ListSchoolClasses.FirstOrDefault(
            a => a.IdSchoolClass == id)!.StartDate = startDate;
        ListSchoolClasses.FirstOrDefault(
            a => a.IdSchoolClass == id)!.EndDate = endDate;
        ListSchoolClasses.FirstOrDefault(
            a => a.IdSchoolClass == id)!.StartHour = startHour;
        ListSchoolClasses.FirstOrDefault(
            a => a.IdSchoolClass == id)!.EndHour = endHour;

        ListSchoolClasses.FirstOrDefault(
            a => a.IdSchoolClass == id)!.Location = location;
        ListSchoolClasses.FirstOrDefault(
            a => a.IdSchoolClass == id)!.Type = type;
        ListSchoolClasses.FirstOrDefault(
            a => a.IdSchoolClass == id)!.Area = area;

        // ListSchoolClasses.FirstOrDefault(
        //     a => a.IdSchoolClass == id)!.CoursesList = courses;

        ListSchoolClasses[^1].GetStudentsCount();
        ListSchoolClasses[^1].GetWorkHourLoad();

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
        var schoolClasses = ListSchoolClasses;

        if (!string.IsNullOrWhiteSpace(classAcronym))
            schoolClasses = ListSchoolClasses
                .Where(a => a.ClassAcronym == classAcronym).ToList();
        if (!string.IsNullOrWhiteSpace(className))
            schoolClasses = ListSchoolClasses
                .Where(a => a.ClassName == className).ToList();

        schoolClasses = ListSchoolClasses.Where(a => a.StartDate == startDate)
            .ToList();
        if (endDate > startDate)
            schoolClasses = ListSchoolClasses.Where(a => a.EndDate == endDate)
                .ToList();
        schoolClasses = ListSchoolClasses.Where(a => a.StartHour == startHour)
            .ToList();
        if (endHour > startHour)
            schoolClasses = ListSchoolClasses.Where(a => a.EndHour == endHour)
                .ToList();

        if (!string.IsNullOrWhiteSpace(location))
            schoolClasses = ListSchoolClasses.Where(a => a.Location == location)
                .ToList();
        if (!string.IsNullOrWhiteSpace(type))
            schoolClasses =
                ListSchoolClasses.Where(a => a.Type == type).ToList();
        if (!string.IsNullOrWhiteSpace(area))
            schoolClasses =
                ListSchoolClasses.Where(a => a.Area == area).ToList();
        if (studentsCount != null && int.IsNegative((int) studentsCount))
            schoolClasses = ListSchoolClasses
                .Where(a => a.StudentsCount == studentsCount).ToList();

        // if (courses is {Count: > 0})
        //     schoolClasses = ListSchoolClasses
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
        foreach (var schoolClass in SchoolClasses.ListSchoolClasses)
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

        return ListSchoolClasses
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

        return ListSchoolClasses
            .Where(schoolClass =>
                property.GetValue(schoolClass)
                    ?.Equals(convertedValue) ==
                true)
            .ToList();
    }


    public static int GetLastIndex()
    {
        // handle the case where the collection is empty
        // return ListStudents[^1].IdStudent;
        // return GetLastIndex();
        var lastSchoolClasses = ListSchoolClasses.LastOrDefault();
        if (lastSchoolClasses != null)
            return lastSchoolClasses.IdSchoolClass;
        return -1;
    }


    public static int GetLastId()
    {
        var lastSchoolClasses = ListSchoolClasses.LastOrDefault();
        return lastSchoolClasses?.IdSchoolClass ?? GetLastIndex();
        /*
        return lastSchoolClasses != null
            ? lastSchoolClasses.IdSchoolClass
            : GetLastIndex();
        // handle the case where the collection is empty
        // return ListStudents[^1].IdStudent;
        // return GetLastIndex();
        */
    }


    public static string GetFullName(int id)
    {
        if (ListSchoolClasses.Count < 1)
            return "A lista está vazia";

        var schoolClass =
            ListSchoolClasses.FirstOrDefault(
                a => a.IdSchoolClass == id);

        if (schoolClass == null)
            return "A turma não existe!";

        return $"{schoolClass.IdSchoolClass,5} | " +
               $"{schoolClass.ClassAcronym} " +
               $"{schoolClass.ClassName}";
    }


    public static string GetFullInfo(int id)
    {
        if (ListSchoolClasses.Count < 1)
            return "A lista está vazia";

        var schoolClass =
            ListSchoolClasses.FirstOrDefault(
                a => a.IdSchoolClass == id);

        if (schoolClass == null)
            return "A turma não existe!";

        return $"{GetFullName(id)} | " +
               $"{schoolClass.Type} - {schoolClass.Area}";
    }


    public static void ToObtainValuesForCalculatedFields()
    {
        if (ListSchoolClasses.Count < 1) return;

        foreach (var schoolClass in ListSchoolClasses)
        {
            var coursesList =
                SchoolDatabase.GetCoursesForSchoolClass(
                    schoolClass.IdSchoolClass);
            if (coursesList == null || !coursesList.Any()) continue;

            var coursesCount = 0;
            var workHourLoad = 0;
            var studentsCount = 0;
            decimal classTotal = 0;
            decimal highestGrade = 0;
            var lowestGrade = decimal.MaxValue;

            foreach (var course in coursesList.Where(course => course != null))
            {
                coursesCount++;

                var studentIds =
                    Enrollments.Enrollments.ListEnrollments?
                        .Where(e => e.CourseId == course.IdCourse)
                        .Select(e => e.StudentId)
                        .Distinct();

                studentsCount = studentIds?.Count() ?? 0;

                // var uniqueStudents = new HashSet<string>();
                //
                // foreach (var enrollment in Enrollments.Enrollments.ListEnrollments)
                // {
                //     if (enrollment.Course == course)
                //     {
                //         uniqueStudents.Add(enrollment.Student);
                //     }
                // }
                //
                // studentsCount += uniqueStudents.Count;

                // studentsCount +=
                //     Enrollments.Enrollments.ListEnrollments?
                //         .Count(e => e.Course == course) ?? 0;
                // studentsCount +=
                //     Enrollments.Enrollments.ListEnrollments?
                //         .Count(e => e.Course == course);

                workHourLoad += course.WorkLoad;

                if (Enrollments.Enrollments.ListEnrollments == null ||
                    !Enrollments.Enrollments.ListEnrollments.Any())
                    continue;

                // var grades = Enrollments.Enrollments.ListEnrollments?
                //     .Where(e => e.Course == course)
                //     .Select(e => e.Grade)
                //     .ToList();

                var grades =
                    Enrollments.Enrollments.ListEnrollments?
                        .Where(e => e.CourseId == course.IdCourse)
                        .Select(e => e.Grade);


                if (grades != null && !grades.Any()) continue;

                classTotal += ((decimal) grades.Average())!;
                highestGrade = Math.Max(highestGrade,
                    (decimal) grades.Max());
                lowestGrade = Math.Min(lowestGrade,
                    (decimal) grades.Min());
            }

            schoolClass.CoursesCount = coursesCount;
            schoolClass.WorkHourLoad = workHourLoad;
            schoolClass.StudentsCount = studentsCount;
            schoolClass.ClassAverage = classTotal / coursesCount;
            schoolClass.HighestGrade = highestGrade;
            schoolClass.LowestGrade = lowestGrade;
        }
    }

    #endregion
}