namespace ClassLibrary;

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
        List<Course> courses
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
            CoursesList = courses
        }
        );

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
        return $"A turma {id} foi apagada!\n{GetFullInfo(id)}";
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

        ListSchoolClasses.FirstOrDefault(
            a => a.IdSchoolClass == id)!.CoursesList = courses;

        ListSchoolClasses[^1].GetStudentsCount();
        ListSchoolClasses[^1].GetWorkHourLoad();

        return "Turma alterada com sucesso";
    }


    public static List<SchoolClass> ConsultSchoolClasses(
        int id, string classAcronym, string className,
        DateOnly startDate, DateOnly endDate,
        TimeOnly startHour, TimeOnly endHour,
        string location, string type, string area,
        int studentsCount,
        //List<Student>? studentsList
        List<Course> courses
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
        if (!int.IsNegative(studentsCount))
            schoolClasses = ListSchoolClasses
                .Where(a => a.StudentsCount == studentsCount).ToList();

        if (courses is { Count: > 0 })
            schoolClasses = ListSchoolClasses
                .Where(a => a.CoursesList == courses).ToList();

        return schoolClasses;
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


    public static string ToObtainValuesForCalculatedFields()
    {
        if (ListSchoolClasses.Count < 1)
            return "A lista está vazia";

        foreach (var school in ListSchoolClasses)
        {
            var cList = school.CoursesList;
            if (cList != null && cList.Any())
            {
                var coursesCount = 0;
                var workHourLoad = 0;
                var studentsCount = 0;
                decimal classTotal = 0;
                decimal highestGrade = 0;
                var lowestGrade = decimal.MaxValue;

                foreach (var course in cList)
                    if (course != null)
                    {
                        coursesCount++;
                        studentsCount += course.Enrollments?.Count ?? 0;
                        workHourLoad += course.WorkLoad;

                        if (course.Enrollments != null &&
                            course.Enrollments.Any())
                        {
                            var grades = course.Enrollments.Select(e => e.Grade)
                                .ToList();
                            classTotal += (decimal)grades.Average();
                            highestGrade = Math.Max(highestGrade,
                                (decimal)grades.Max());
                            lowestGrade = Math.Min(lowestGrade,
                                (decimal)grades.Min());
                        }
                    }

                school.CoursesCount = coursesCount;
                school.WorkHourLoad = workHourLoad;
                school.StudentsCount = studentsCount;
                school.ClassAverage = classTotal / coursesCount;
                school.HighestGrade = highestGrade;
                school.LowestGrade = lowestGrade;
            }
        }
        /*
        if (ListSchoolClasses.Count < 1)
            return "A lista está vazia";

        foreach (var school in ListSchoolClasses)
        {
            var cList= school.CoursesList;
            if (cList != null)
            {

                school.CoursesCount = cList?.Sum(course => course.Enrollments.Count) ?? 0;

                school.WorkHourLoad = cList?.Sum(course => course.WorkLoad) ?? 0;
                school.StudentsCount = cList?.Count ?? 0;

                school.ClassAverage = cList?.SelectMany(course => course.Enrollments)
                                             .Average(enrollment => enrollment.Grade)
                                             ?? 0;

                school.HighestGrade = cList?.SelectMany(course => course.Enrollments)
                                             .Average(enrollment => enrollment.Grade)
                                             ?? 0;

                school.LowestGrade = cList?.SelectMany(course => course.Enrollments)
                                             .Average(enrollment => enrollment.Grade)
                                             ?? 0;
            }
        }
        */

        return "Cálculos executados.";

        //return CoursesList?.Count ?? 0;
        /*
        return CoursesList == null
            ? 0
            : CoursesList.Sum(course => course.Enrollments.Count);
        
        if (CoursesList == null) return 0;
        return CoursesList.Sum(course => course.Enrollments.Count);
        */
    }

    #endregion
}