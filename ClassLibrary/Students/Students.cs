using ClassLibrary.Enrollments;

namespace ClassLibrary.Students;

public class Students
{
    #region Properties

    public static List<Student?> ListStudents { get; set; } = new();

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
        int totalWorkHours,
        DateOnly enrollmentDate,
        List<Enrollment> enrollments
    )
    {
        ListStudents.Add(new Student
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
                TotalWorkHoursLoad = totalWorkHours,
                EnrollmentDate = enrollmentDate,
                Enrollments = enrollments
            }
        );

        Console.WriteLine("Debugging");
    }


    public static string DeleteStudent(int id)
    {
        var student =
            ListStudents.FirstOrDefault(a => a.IdStudent == id);

        if (student == null)
            return "O estudante não existe!";

        ListStudents.Remove(student);
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
        int totalWorkHours,
        DateOnly enrollmentDate,
        List<Enrollment> enrollments
    )
    {
        if (ListStudents.Count < 1)
            return "A lista está vazia";

        var student =
            ListStudents.FirstOrDefault(
                a => a != null && a.IdStudent == id);

        if (student == null)
            return "O estudante não existe!";

        ListStudents.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Name = name;
        ListStudents.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.LastName = lastName;
        ListStudents.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Address = address;
        ListStudents.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.PostalCode = postalCode;
        ListStudents.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.City = city;
        ListStudents.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Phone = phone;
        ListStudents.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Email = email;
        ListStudents.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Active = active;
        ListStudents.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Genre = genre;
        ListStudents.FirstOrDefault(
                a => a != null && a.IdStudent == id)!.DateOfBirth =
            dateOfBirth;
        ListStudents.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .IdentificationNumber = identificationNumber;
        ListStudents.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .ExpirationDateIn = expirationDateIn;
        ListStudents.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .TaxIdentificationNumber = taxIdentificationNumber;
        ListStudents.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .Nationality = nationality;
        ListStudents.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .Birthplace = birthplace;

        ListStudents.FirstOrDefault(
            a => a != null && a.IdStudent == id)!.Photo = photo;
        ListStudents.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .TotalWorkHoursLoad = totalWorkHours;
        ListStudents.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .EnrollmentDate = enrollmentDate;
        ListStudents.FirstOrDefault(
                a => a != null && a.IdStudent == id)!
            .Enrollments = enrollments;

        ListStudents[id].GetTotalWorkHourLoad();

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
        DateOnly enrollmentDate,
        List<Enrollment> enrollments
    )
    {
        var students = ListStudents;

        if (!string.IsNullOrWhiteSpace(name))
            students = ListStudents
                .Where(a => a?.Name == name).ToList();
        if (!string.IsNullOrWhiteSpace(lastName))
            students = ListStudents
                .Where(a => a?.LastName == lastName)
                .ToList();
        if (!string.IsNullOrWhiteSpace(address))
            students = ListStudents
                .Where(a => a?.Address == address)
                .ToList();
        if (!string.IsNullOrWhiteSpace(postalCode))
            students = ListStudents
                .Where(a => a?.PostalCode == postalCode)
                .ToList();
        if (!string.IsNullOrWhiteSpace(city))
            students = ListStudents
                .Where(a => a?.City == city).ToList();
        if (!string.IsNullOrWhiteSpace(phone))
            students = ListStudents
                .Where(a => a?.Phone == phone).ToList();
        if (!string.IsNullOrWhiteSpace(email))
            students = ListStudents
                .Where(a => a?.Email == email).ToList();
        students = ListStudents
            .Where(a => a?.Active == active).ToList();
        if (!string.IsNullOrWhiteSpace(genre))
            students = ListStudents
                .Where(a => a?.Genre == genre).ToList();

        if (dateOfBirth != default)
            students = ListStudents
                .Where(a =>
                    a?.DateOfBirth == dateOfBirth)
                .ToList();
        if (!string.IsNullOrWhiteSpace(identificationNumber))
            students = ListStudents
                .Where(a =>
                    a?.IdentificationNumber == identificationNumber)
                .ToList();

        if (expirationDateIn != default)
            students = ListStudents
                .Where(a =>
                    a?.ExpirationDateIn == expirationDateIn)
                .ToList();

        if (!string.IsNullOrWhiteSpace(taxIdentificationNumber))
            students = ListStudents
                .Where(a =>
                    a?.TaxIdentificationNumber == taxIdentificationNumber)
                .ToList();

        if (!string.IsNullOrWhiteSpace(nationality))
            students = ListStudents
                .Where(
                    a => a?.Nationality == nationality)
                .ToList();

        if (!string.IsNullOrWhiteSpace(birthplace))
            students = ListStudents
                .Where(a => a?.Birthplace == photo)
                .ToList();

        if (!string.IsNullOrWhiteSpace(photo))
            students = ListStudents
                .Where(a => a?.Photo == photo)
                .ToList();

        if (!int.IsNegative(totalWorkHours))
            students = ListStudents
                .Where(a => a?.TotalWorkHoursLoad == totalWorkHours)
                .ToList();

        if (enrollmentDate != default)
            students = ListStudents
                .Where(
                    a => a?.EnrollmentDate == enrollmentDate)
                .ToList();

        if (enrollments != null)
            students = ListStudents
                .Where(
                    a => a?.Enrollments == enrollments)
                .ToList();

        return students;
    }


    public static int GetLastIndex()
    {
        // handle the case where the collection is empty
        // return ListStudents[^1].IdStudent;
        // return GetLastIndex();
        var lastStudent = ListStudents.LastOrDefault();
        if (lastStudent != null)
            return lastStudent.IdStudent;
        return -1;
    }


    public static int GetLastId()
    {
        var lastStudent = ListStudents.LastOrDefault();
        return lastStudent?.IdStudent ?? GetLastIndex();
        /*
        return lastStudent != null
            ? lastStudent.IdStudent
            : GetLastIndex();
        // handle the case where the collection is empty
        // return ListStudents[^1].IdStudent;
        // return GetLastIndex();
        */
    }


    /*
    public static void GetTotalWorkHours(int id)
    {
        Console.WriteLine("Debugging");

        if (ListStudents.Count <= id ||
            ListStudents[id].StudentCoursesGradesList == null ||
            ListStudents[id].StudentCoursesGradesList.Count <= 0)
        {
            // Handle the case where the list is empty or null,
            // or the index is out of range
            // return "Lista está vazia"
            return;
            if (ListStudents.Count < 1) return;
            if (ListStudents[id].StudentCoursesGradesList.Count == 0) return;
            if (ListStudents[id].StudentCoursesGradesList == null) return;
        }

        // Access the StudentCoursesGradesList property
        // and perform necessary operations

        //
        // Resetting the variable,
        // to start from zero,
        // if not it will accumulate to the previous balance
        //
        ListStudents[id].TotalWorkHoursLoad = 0;

        foreach (var course in ListStudents[id].StudentCoursesGradesList)
        {
            var workHoursLoad = Courses.ListCourses
                .Where(a => a.IdCourse == course.IdCourse)
                .Sum(x => x.WorkLoad);
            //Courses.ListCourses;
            ListStudents[id].TotalWorkHoursLoad += course.IdCourse;
        }

        Console.WriteLine("Debugging");
    }
    */


    public static string GetFullName(int id)
    {
        return $"{ListStudents[id]?.Name} {ListStudents[id]?.LastName}";
    }


    public static string GetFullInfo(int id)
    {
        return $"{ListStudents[id]?.IdStudent,5} | " +
               //$"{ListStudents[id].GetFullName()} | " +
               $"{GetFullName(id)} | " +
               $"{ListStudents[id]?.Phone} - {ListStudents[id]?.Address}";
    }

    #endregion
}