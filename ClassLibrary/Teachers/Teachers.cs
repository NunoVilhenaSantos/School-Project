using ClassLibrary.Courses;
using ClassLibrary.School;
using Serilog;

namespace ClassLibrary.Teachers;

public static class Teachers
{
    public static readonly Dictionary<int, Teacher> TeachersDictionary = new();
    public static List<Teacher> TeachersList { get; set; } = new();


    public static void AddTeacher(
        int id,
        string name,
        string lastName,
        string address,
        string postalCode,
        string city,
        string phone,
        string email,
        bool active,
        string genre,
        DateOnly dateOfBirth,
        string identificationNumber,
        DateOnly expirationDateIn,
        string taxIdentificationNumber,
        string nationality,
        string birthplace,
        string photo,
        int coursesCount,
        int totalWorkHours,
        List<Course> courses
    )
    {
        var teacher = new Teacher
        {
            //TeacherId = id,
            Name = name,
            LastName = lastName,
            Address = address,
            PostalCode = postalCode,
            City = city,
            Phone = phone,
            Email = email,
            Active = active,
            Genre = genre,
            DateOfBirth = dateOfBirth,
            IdentificationNumber = identificationNumber,
            ExpirationDateIn = expirationDateIn,
            TaxIdentificationNumber = taxIdentificationNumber,
            Nationality = nationality,
            Birthplace = birthplace,
            Photo = photo,
            CoursesCount = coursesCount,
            TotalWorkHours = totalWorkHours
            //Courses = courses
        };
        TeachersList.Add(teacher);

        SchoolDatabase.AddTeacher(TeachersList[^1]);
    }


    public static string RemoveTeacher(int id)
    {
        var teacher = TeachersList.FirstOrDefault(x => x.TeacherId == id);

        if (teacher == null) return "Professor(a) não existe";

        TeachersList.Remove(teacher);
        return "Professor(a) apagado";
    }


    public static string EditTeacher(
        int id,
        string name,
        string lastName,
        string address,
        string postalCode,
        string city,
        string phone,
        string email,
        bool active,
        string genre,
        DateOnly dateOfBirth,
        string identificationNumber,
        DateOnly expirationDateIn,
        string taxIdentificationNumber,
        string nationality,
        string birthplace,
        string photo,
        int coursesCount,
        int totalWorkHours,
        List<Course> courses
    )
    {
        if (TeachersList.Count < 1) return "Lista está vazia";

        var teacher = TeachersList.FirstOrDefault(x => x.TeacherId == id);

        if (teacher == null) return "Professor(a) não existe";

        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.Name = name;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.LastName =
            lastName;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.Address = address;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.PostalCode =
            postalCode;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.City = city;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.Phone = phone;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.Email = email;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.Active = active;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.Genre = genre;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.DateOfBirth =
            dateOfBirth;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!
            .IdentificationNumber = identificationNumber;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.ExpirationDateIn =
            expirationDateIn;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!
            .TaxIdentificationNumber = taxIdentificationNumber;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.Nationality =
            nationality;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.Birthplace =
            birthplace;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.Photo = photo;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!
            .TotalWorkHours = totalWorkHours;
        TeachersList.FirstOrDefault(a => a.TeacherId == id)!.CoursesCount =
            coursesCount;

        TeachersList[id].CountCourses();
        TeachersList[id].GetTotalWorkHourLoad();

        return "Professor(a) alterado(a) com sucesso";
    }


    public static List<Teacher> ConsultTeacher(
        int id,
        string name,
        string lastName,
        string address,
        string postalCode,
        string city,
        string phone,
        string email,
        bool active,
        string genre,
        DateOnly dateOfBirth,
        string identificationNumber,
        DateOnly expirationDateIn,
        string taxIdentificationNumber,
        string nationality,
        string birthplace,
        string photo,
        int totalWorkHours,
        List<Course> courses
    )
    {
        var teachers = TeachersList;


        if (!string.IsNullOrWhiteSpace(name))
            teachers = TeachersList.Where(a => a.Name == name).ToList();
        if (!string.IsNullOrWhiteSpace(lastName))
            teachers = TeachersList.Where(a => a.LastName == lastName).ToList();
        if (!string.IsNullOrWhiteSpace(address))
            teachers = TeachersList.Where(a => a.Address == address).ToList();
        if (!string.IsNullOrWhiteSpace(postalCode))
            teachers = TeachersList.Where(a => a.PostalCode == postalCode)
                .ToList();
        if (!string.IsNullOrWhiteSpace(city))
            teachers = TeachersList.Where(a => a.City == city).ToList();
        if (!string.IsNullOrWhiteSpace(phone))
            teachers = TeachersList.Where(a => a.Phone == phone).ToList();
        if (!string.IsNullOrWhiteSpace(email))
            teachers = TeachersList.Where(a => a.Email == email).ToList();
        teachers = TeachersList.Where(a => a.Active == active).ToList();
        if (!string.IsNullOrWhiteSpace(genre))
            teachers = TeachersList.Where(a => a.Genre == genre).ToList();
        if (dateOfBirth != default)
            teachers = TeachersList.Where(a => a.DateOfBirth == dateOfBirth)
                .ToList();
        if (!string.IsNullOrWhiteSpace(identificationNumber))
            teachers = TeachersList
                .Where(a => a.IdentificationNumber == identificationNumber)
                .ToList();
        if (expirationDateIn != default)
            teachers = TeachersList
                .Where(a => a.ExpirationDateIn == expirationDateIn).ToList();
        if (!string.IsNullOrWhiteSpace(taxIdentificationNumber))
            teachers = TeachersList.Where(a =>
                a.TaxIdentificationNumber == taxIdentificationNumber).ToList();
        if (!string.IsNullOrWhiteSpace(nationality))
            teachers = TeachersList.Where(a => a.Nationality == nationality)
                .ToList();
        if (!string.IsNullOrWhiteSpace(birthplace))
            teachers = TeachersList.Where(a => a.Birthplace == photo).ToList();
        if (!string.IsNullOrWhiteSpace(photo))
            teachers = TeachersList.Where(a => a.Photo == photo).ToList();
        if (!int.IsNegative(totalWorkHours))
            teachers = TeachersList
                .Where(a => a.TotalWorkHours == totalWorkHours).ToList();

        return teachers;
    }


    public static List<Teacher> ConsultTeachers(
        string selectedProperty, object selectedValue)
    {
        var property = typeof(Teacher).GetProperty(selectedProperty);
        if (property == null) return new List<Teacher>();

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
            return new List<Teacher>();
        }
        catch (FormatException ex)
        {
            // Handle format exception
            Console.WriteLine($"Invalid format: {ex.Message}");
            return new List<Teacher>();
        }

        return TeachersList
            .Where(t => property.GetValue(t)?.Equals(convertedValue) == true)
            .ToList();
    }


    public static int GetLastIndex()
    {
        var lastTeachers = TeachersList.LastOrDefault();
        if (lastTeachers != null)
            return lastTeachers.TeacherId;
        return -1;
    }


    public static int GetLastId()
    {
        var lastTeachers = TeachersList.LastOrDefault();
        return lastTeachers?.TeacherId ?? GetLastIndex();
        /*
        return lastTeachers != null
            ? lastTeachers.TeacherId
            : GetLastIndex();
        // handle the case where the collection is empty
        // return StudentsList[^1].IdStudent;
        // return GetLastIndex();
        */
    }


    public static void CalculateTeacherMetrics()
    {
        if (TeachersList.Count < 1)
            Log.Warning("No teachers found in the directory");

        foreach (var teacher in TeachersList)
        {
            teacher.CalculateTotalWorkHours();
            teacher.CountCourses();
            //teacher.CalculateWorkloadPerCourse();

            Log.Information(
                $"Metrics for {teacher.Name}: " +
                $"Total work hours = {teacher.TotalWorkHours}, " +
                $"Course count = {teacher.CoursesCount}, ");
            // $"Workload per course = {teacher.workloadPerCourse}.");
        }

        Log.Information("Teacher metrics calculation completed");
    }
}