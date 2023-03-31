namespace ClassLibrary;

public class Teachers
{
    public static List<Teacher> TeachersList = new();


    public static void AddTeacher(
        int id,
        string name,
        string lastName,
        string address,
        string postalCode,
        string city,
        string mobile,
        string email,
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
            Mobile = mobile,
            Email = email,
            Courses = courses
        };
        TeachersList.Add(teacher);
    }


    public static List<Teacher> ConsultTeacher(
        int id, string name, string lastName, string address,
        string postalCode, string city, string mobile, string email
    )
    {
        var teachers = TeachersList;

        if (!string.IsNullOrWhiteSpace(name))
            teachers = teachers.Where(x => x.Name == name).ToList();
        if (!string.IsNullOrWhiteSpace(lastName))
            teachers = teachers.Where(x => x.LastName == lastName).ToList();
        if (!string.IsNullOrWhiteSpace(address))
            teachers = teachers.Where(x => x.Address == address).ToList();
        if (!string.IsNullOrWhiteSpace(postalCode))
            teachers = teachers.Where(x => x.PostalCode == postalCode).ToList();
        if (!string.IsNullOrWhiteSpace(city))
            teachers = teachers.Where(x => x.City == city).ToList();
        if (!string.IsNullOrWhiteSpace(mobile))
            teachers = teachers.Where(x => x.Mobile == mobile).ToList();
        if (!string.IsNullOrWhiteSpace(email))
            teachers = teachers.Where(x => x.Email == email).ToList();

        return teachers;
    }


    public static string EditTeacher(
        int id, string name, string lastName, string address,
        string postalCode, string city, string mobile, string email
    )
    {
        if (TeachersList.Count < 1) return "Lista está vazia";

        var teacher = TeachersList.FirstOrDefault(x => x.TeacherId == id);

        if (teacher == null) return "Professor(a) não existe";

        TeachersList.FirstOrDefault(clt => clt.TeacherId == id).Name = name;
        TeachersList.FirstOrDefault(clt => clt.TeacherId == id).LastName =
            lastName;
        TeachersList.FirstOrDefault(clt => clt.TeacherId == id).Address =
            address;
        TeachersList.FirstOrDefault(clt => clt.TeacherId == id).PostalCode =
            postalCode;
        TeachersList.FirstOrDefault(clt => clt.TeacherId == id).City = city;
        TeachersList.FirstOrDefault(clt => clt.TeacherId == id).Mobile = mobile;
        TeachersList.FirstOrDefault(clt => clt.TeacherId == id).Email = email;

        return "Professor(a) alterado(a) com sucesso";
    }


    public static string RemoveTeacher(int id)
    {
        var teacher = TeachersList.FirstOrDefault(x => x.TeacherId == id);

        if (teacher == null) return "Professor(a) não existe";

        TeachersList.Remove(teacher);
        return "Professor(a) apagado";
    }


    public static int GetLastIndex()
    {
        // handle the case where the collection is empty
        // return ListStudents[^1].IdStudent;
        // return GetLastIndex();
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
        // return ListStudents[^1].IdStudent;
        // return GetLastIndex();
        */
    }
}