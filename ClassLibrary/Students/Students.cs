using ClassLibrary.School;

namespace ClassLibrary.Students;

public class Students
{
    #region Properties

    public static List<Student?> StudentsList { get; set; } = new();

    #endregion


    #region Attributes

    #endregion


    #region Methods

    public static void AddStudent(
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
        int courseCount,
        int totalWorkHours,
        DateOnly enrollmentDate
    )
    {
        StudentsList.Add(new Student
            {
                //IdStudent = id,
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
                CoursesCount = courseCount,
                TotalWorkHoursLoad = totalWorkHours,
                EnrollmentDate = enrollmentDate
            }
        );
        SchoolDatabase.AddStudent(StudentsList[^1]);
        Console.WriteLine("Debugging");
    }


    public static string DeleteStudent(int id)
    {
        var student =
            StudentsList.FirstOrDefault(a => a.IdStudent == id);

        if (student == null)
            return "O estudante não existe!";

        StudentsList.Remove(student);
        return "O estudante foi apagado!";
    }


    public static string EditStudent(
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
        int courseCount,
        int totalWorkHours,
        DateOnly enrollmentDate
    )
    {
        if (StudentsList.Count < 1)
            return "A lista está vazia";

        var student =
            StudentsList.FirstOrDefault(
                a => a != null && a.IdStudent == id);

        if (student == null)
            return "O estudante não existe!";

        StudentsList.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Name = name;
        StudentsList.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.LastName = lastName;
        StudentsList.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Address = address;
        StudentsList.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.PostalCode = postalCode;
        StudentsList.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.City = city;
        StudentsList.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Phone = phone;
        StudentsList.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Email = email;
        StudentsList.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Active = active;
        StudentsList.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Genre = genre;
        StudentsList.FirstOrDefault(
                a => a != null && a.IdStudent == id)!.DateOfBirth =
            dateOfBirth;
        StudentsList.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .IdentificationNumber = identificationNumber;
        StudentsList.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .ExpirationDateIn = expirationDateIn;
        StudentsList.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .TaxIdentificationNumber = taxIdentificationNumber;
        StudentsList.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .Nationality = nationality;
        StudentsList.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .Birthplace = birthplace;

        StudentsList.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Photo = photo;
        StudentsList.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .TotalWorkHoursLoad = totalWorkHours;
        StudentsList.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .EnrollmentDate = enrollmentDate;


        StudentsList[id].GetTotalWorkHourLoad();

        return "Estudante alterado com sucesso";
    }


    public static List<Student?> ConsultStudent(
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
        DateOnly enrollmentDate
    )
    {
        var students = StudentsList;

        if (!string.IsNullOrWhiteSpace(name))
            students = StudentsList
                .Where(a => a?.Name == name).ToList();
        if (!string.IsNullOrWhiteSpace(lastName))
            students = StudentsList
                .Where(a => a?.LastName == lastName)
                .ToList();
        if (!string.IsNullOrWhiteSpace(address))
            students = StudentsList
                .Where(a => a?.Address == address)
                .ToList();
        if (!string.IsNullOrWhiteSpace(postalCode))
            students = StudentsList
                .Where(a => a?.PostalCode == postalCode)
                .ToList();
        if (!string.IsNullOrWhiteSpace(city))
            students = StudentsList
                .Where(a => a?.City == city).ToList();
        if (!string.IsNullOrWhiteSpace(phone))
            students = StudentsList
                .Where(a => a?.Phone == phone).ToList();
        if (!string.IsNullOrWhiteSpace(email))
            students = StudentsList
                .Where(a => a?.Email == email).ToList();
        students = StudentsList
            .Where(a => a?.Active == active).ToList();
        if (!string.IsNullOrWhiteSpace(genre))
            students = StudentsList
                .Where(a => a?.Genre == genre).ToList();

        if (dateOfBirth != default)
            students = StudentsList
                .Where(a =>
                    a?.DateOfBirth == dateOfBirth)
                .ToList();
        if (!string.IsNullOrWhiteSpace(identificationNumber))
            students = StudentsList
                .Where(a =>
                    a?.IdentificationNumber == identificationNumber)
                .ToList();

        if (expirationDateIn != default)
            students = StudentsList
                .Where(a =>
                    a?.ExpirationDateIn == expirationDateIn)
                .ToList();

        if (!string.IsNullOrWhiteSpace(taxIdentificationNumber))
            students = StudentsList
                .Where(a =>
                    a?.TaxIdentificationNumber == taxIdentificationNumber)
                .ToList();

        if (!string.IsNullOrWhiteSpace(nationality))
            students = StudentsList
                .Where(
                    a => a?.Nationality == nationality)
                .ToList();

        if (!string.IsNullOrWhiteSpace(birthplace))
            students = StudentsList
                .Where(a => a?.Birthplace == photo)
                .ToList();

        if (!string.IsNullOrWhiteSpace(photo))
            students = StudentsList
                .Where(a => a?.Photo == photo)
                .ToList();

        if (!int.IsNegative(totalWorkHours))
            students = StudentsList
                .Where(a => a?.TotalWorkHoursLoad == totalWorkHours)
                .ToList();

        if (enrollmentDate != default)
            students = StudentsList
                .Where(
                    a => a?.EnrollmentDate == enrollmentDate)
                .ToList();

        return students;
    }


    public static int GetLastIndex()
    {
        var lastStudent = StudentsList.LastOrDefault();
        return StudentsList.LastOrDefault()?.IdStudent ?? -1;
        //return lastStudent?.IdStudent ?? -1;
    }


    public static int GetLastId()
    {
        var lastStudent = StudentsList.LastOrDefault();
        return lastStudent?.IdStudent ?? GetLastIndex();
        /*
        return lastStudent != null
            ? lastStudent.IdStudent
            : GetLastIndex();
        // handle the case where the collection is empty
        // return StudentsList[^1].IdStudent;
        // return GetLastIndex();
        */
    }


    /*
    public static void GetTotalWorkHours(int id)
    {
        Console.WriteLine("Debugging");

        if (StudentsList.Count <= id ||
            StudentsList[id].StudentCoursesGradesList == null ||
            StudentsList[id].StudentCoursesGradesList.Count <= 0)
        {
            // Handle the case where the list is empty or null,
            // or the index is out of range
            // return "Lista está vazia"
            return;
            if (StudentsList.Count < 1) return;
            if (StudentsList[id].StudentCoursesGradesList.Count == 0) return;
            if (StudentsList[id].StudentCoursesGradesList == null) return;
        }

        // Access the StudentCoursesGradesList property
        // and perform necessary operations

        //
        // Resetting the variable,
        // to start from zero,
        // if not it will accumulate to the previous balance
        //
        StudentsList[id].TotalWorkHoursLoad = 0;

        foreach (var course in StudentsList[id].StudentCoursesGradesList)
        {
            var workHoursLoad = Courses.CoursesList
                .Where(a => a.IdCourse == course.IdCourse)
                .Sum(x => x.WorkLoad);
            //Courses.CoursesList;
            StudentsList[id].TotalWorkHoursLoad += course.IdCourse;
        }

        Console.WriteLine("Debugging");
    }
    */


    public static string GetFullName(int id)
    {
        return $"{StudentsList[id]?.Name} {StudentsList[id]?.LastName}";
    }


    public static string GetFullInfo(int id)
    {
        return $"{StudentsList[id]?.IdStudent,5} | " +
               //$"{StudentsList[id].GetFullName()} | " +
               $"{GetFullName(id)} | " +
               $"{StudentsList[id]?.Phone} - {StudentsList[id]?.Address}";
    }

    #endregion
}