using System.Text;

namespace ClassLibrary;

public static class XFiles
{
    //
    // Global Properties for the windows forms
    // to store the data into files of class
    //

    #region Properties

    private static readonly string ProjectFolder =
        Directory.GetCurrentDirectory();

    private static readonly string FilesFolder =
        ProjectFolder + "\\XFiles\\";

    private static readonly string CoursesFile =
        FilesFolder + "CoursesFile.csv";

    private static readonly string SchoolClassesFile =
        FilesFolder + "SchoolClassesFile.csv";

    private static readonly string StudentsFile =
        FilesFolder + "StudentsFile.csv";

    private static readonly string EnrollmentsFile =
        FilesFolder + "EnrollmentsFile.csv";

    private static readonly string TeachersFile =
        FilesFolder + "TeachersFile.csv";

    #endregion


    //
    // Methods
    //

    #region Methods

    //
    // storing data in files
    //

    #region StoreDataInFiles

    public static bool StoreInFiles(out string myString)
    {
        /*
         * 
         * this files must be read in this order
         * 
        */
        var messages = string.Empty;

        // If the directory already exists, this method does nothing.
        var file = new FileInfo(CoursesFile);
        // If the directory already exists, this method does nothing.
        file.Directory.Create();

        var storeSchoolClassesInFile =
            StoreSchoolClassesInFile(out var message_StoreSchoolClassesInFile);

        var storeTeachersInFile =
            StoreTeachersInFile(out var message_StoreTeachersInFile);

        var storeCoursesInFile =
            StoreCoursesInFile(out var message_StoreCoursesInFile);

        var storeEnrollmentsInFile =
            StoreEnrollmentsInFile(out var message_StoreEnrollmentsInFile);

        var storeStudentsInFile =
            StoreStudentsInFile(out var message_StoreStudentsInFile);

        myString =
            message_StoreSchoolClassesInFile + "\n\n" +
            message_StoreTeachersInFile + "\n\n" +
            message_StoreCoursesInFile + "\n\n" +
            message_StoreEnrollmentsInFile + "\n\n" +
            message_StoreStudentsInFile;

        var myBool = storeSchoolClassesInFile && storeTeachersInFile &&
                     storeCoursesInFile && storeEnrollmentsInFile &&
                     storeStudentsInFile;

        return myBool;
    }


    private static bool StoreSchoolClassesInFile(out string myString)
    {
        //
        // constructor for storing info in files
        // with a try and catch
        // and also returning the messages
        //
        var message = string.Empty;

        try
        {
            using (FileStream fileStream =
                   new(SchoolClassesFile, FileMode.Create))
            {
                ;
            }
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            return false;
            throw;
        }


        using (FileStream fileStream = new(SchoolClassesFile, FileMode.Create))
        {
            using (StreamWriter streamWriter = new(fileStream, Encoding.UTF8))
            {
                // Write the header line
                const string headerLine = "IdSchoolClass;" +
                                          "ClassAcronym;" +
                                          "ClassName;" +
                                          "StartDate;" +
                                          "EndDate;" +
                                          "StartHour;" +
                                          "EndHour;" +
                                          "Location;" +
                                          "Type;" +
                                          "Area;" +
                                          "CoursesList";
                streamWriter.WriteLine(headerLine);


                foreach (var schoolClass in SchoolClasses.ListSchoolClasses)
                {
                    var line =
                        $"{schoolClass.IdSchoolClass};" +
                        $"{schoolClass.ClassAcronym};" +
                        $"{schoolClass.ClassName};" +
                        $"{schoolClass.StartDate};" +
                        $"{schoolClass.EndDate};" +
                        $"{schoolClass.StartHour};" +
                        $"{schoolClass.EndHour};" +
                        $"{schoolClass.Location};" +
                        $"{schoolClass.Type};" +
                        $"{schoolClass.Area}";

                    if (schoolClass.CoursesList != null)
                    {
                        var coursesLine =
                            schoolClass.CoursesList.Select(c =>
                                $"{c.IdCourse}");
                        line += $";{string.Join(";", coursesLine)}";
                    }

                    streamWriter.WriteLine(line);
                }

                streamWriter.Flush();
            }
        }

        myString = "Operação realizada com sucesso";
        return true;
    }


    private static bool StoreTeachersInFile(out string myString)
    {
        //
        // constructor for storing info in files
        // with a try and catch
        // and also returning the messages
        //
        var message = string.Empty;

        try
        {
            using FileStream fileStream =
                new(TeachersFile, FileMode.Create);
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            return false;
            throw;
        }


        using (FileStream fileStream = new(TeachersFile, FileMode.Create))
        {
            using (var streamWriter =
                   new StreamWriter(fileStream, Encoding.UTF8))
            {
                var csvStringBuilder = new StringBuilder();

                const string header =
                    "TeacherId;Name;LastName;Address;Phone;Email;" +
                    "Active;Genre;DateOfBirth;IdentificationNumber;" +
                    "ExpirationDateIn;TaxIdentificationNumber;" +
                    "Nationality;Birthplace;Photo;IdCourse";

                csvStringBuilder.AppendLine(header);

                foreach (var teacher in Teachers.TeachersList)
                {
                    var teacherCsv = new StringBuilder();

                    teacherCsv.Append($"{teacher.TeacherId};");
                    teacherCsv.Append($"{teacher.Name};");
                    teacherCsv.Append($"{teacher.LastName};");
                    teacherCsv.Append($"{teacher.Address};");
                    teacherCsv.Append($"{teacher.Phone};");
                    teacherCsv.Append($"{teacher.Email};");
                    teacherCsv.Append($"{teacher.Active};");
                    teacherCsv.Append($"{teacher.Genre};");
                    teacherCsv.Append($"{teacher.DateOfBirth};");
                    teacherCsv.Append($"{teacher.IdentificationNumber};");
                    teacherCsv.Append($"{teacher.ExpirationDateIn};");
                    teacherCsv.Append(
                        $"{teacher.TaxIdentificationNumber};");
                    teacherCsv.Append($"{teacher.Nationality};");
                    teacherCsv.Append($"{teacher.Birthplace};");
                    teacherCsv.Append($"{teacher.Photo};");
                    teacherCsv.Append(string.Join(";",
                        teacher.Courses.Select(c => c.IdCourse)));

                    csvStringBuilder.AppendLine(teacherCsv.ToString());
                }

                streamWriter.Write(csvStringBuilder.ToString());
                streamWriter.Flush();
            }
        }

        myString = "Operação realizada com sucesso";
        return true;
    }

    private static bool StoreCoursesInFile(out string myString)
    {
        //
        // constructor for storing info in files
        // with a try and catch
        // and also returning the messages
        //
        var message = string.Empty;

        try
        {
            using FileStream fileStream = new(CoursesFile, FileMode.Create);
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            return false;
            throw;
        }

        using (FileStream fileStream = new(CoursesFile, FileMode.Create))
        {
            using (StreamWriter streamWriter =
                   new(fileStream, Encoding.UTF8))
            {
                foreach (var line in
                         Courses.ListCourses.Select(course =>
                             $"{course.IdCourse};" +
                             $"{course.Name};" +
                             $"{course.WorkLoad};" +
                             $"{course.Credits}"
                         ))
                    streamWriter.WriteLine(line);
                streamWriter.Flush();
            }
        }

        myString = "Operação realizada com sucesso";
        return true;
    }


    private static bool StoreEnrollmentsInFile(out string myString)
    {
        //
        // constructor for storing info in files
        // with a try and catch
        // and also returning the messages
        //
        try
        {
            using FileStream fileStream =
                new(EnrollmentsFile, FileMode.Create);
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            return false;
            throw;
        }

        using (FileStream fileStream =
               new(EnrollmentsFile, FileMode.Create))
        {
            using (StreamWriter streamWriter = new(fileStream, Encoding.UTF8))
            {
                foreach (var line in
                         Enrollments.ListEnrollments.Select(e =>
                                 $"{e.IdEnrollment};" +
                                 $"{e.Grade};" +
                                 $"{e.StudentId};" +
                                 //$"{e.Student};" +
                                 $"{e.CourseId};"
                         //$"{e.Course}"
                         ))
                {
                    streamWriter.WriteLine(line);
                    streamWriter.Flush();
                }
            }
        }

        myString = "Operação realizada com sucesso";
        return true;
    }


    private static bool StoreStudentsInFile(out string myString)
    {
        //
        // constructor for storing info in files
        // with a try and catch
        // and also returning the messages
        //
        try
        {
            using FileStream fileStream =
                new(StudentsFile, FileMode.Create);
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            return false;
            throw;
        }

        using (FileStream fileStream = new(StudentsFile, FileMode.Create))
        {
            using (StreamWriter streamWriter =
                   new(fileStream, Encoding.UTF8))
            {
                foreach (var line in
                         Students.ListStudents.Select(student =>
                             $"{student.IdStudent};" +
                             $"{student.Name};" +
                             $"{student.LastName};" +
                             $"{student.Address};" +
                             $"{student.PostalCode};" +
                             $"{student.City};" +
                             $"{student.Phone};" +
                             $"{student.Email};" +
                             $"{student.Active};" +
                             $"{student.Genre};" +
                             $"{student.DateOfBirth};" +
                             $"{student.IdentificationNumber};" +
                             $"{student.ExpirationDateIn};" +
                             $"{student.TaxIdentificationNumber};" +
                             $"{student.Nationality};" +
                             $"{student.Birthplace};" +
                             $"{student.Photo}" +
                             $"{student.TotalWorkHoursLoad};" +
                             $"{student.EnrollmentDate};" +
                             $"{student.Enrollments};"))

                    streamWriter.WriteLine(line);

                streamWriter.Flush();
            }
        }

        myString = "Operação realizada com sucesso";
        return true;
    }

    #endregion


    //
    // reading data in files
    //

    #region ReadingDataFromFiles

    public static bool ReadFromFiles(out string myString)
    {
        /*
         * 
         * this files must be read in this order
         * 
         */
        var messages = string.Empty;


        // If the directory already exists, this method does nothing.
        var file = new FileInfo(CoursesFile);
        // If the directory already exists, this method does nothing.
        file.Directory.Create();


        // 1st file to read are the courses file
        var readCoursesFromFile =
            ReadCoursesFromFile(out var message_ReadCoursesFromFile);

        // 2nd file to read are the students file
        var readStudentsFromFile =
            ReadStudentsFromFile(out var message_ReadStudentsFromFile);

        // 3rd file to read are the enrollment file
        var readEnrollmentsInFile =
            ReadEnrollmentsInFile(out var message_ReadEnrollmentsInFile);

        // 4th file to read are the school-classes file
        var readSchoolClassesFromFile =
            ReadSchoolClassesFromFile(
                out var message_ReadSchoolClassesFromFile);

        // 5th file to read are the teachers file
        var readTeachersInFile =
            ReadTeachersInFile(out var message_ReadTeachersInFile);

        myString =
            message_ReadCoursesFromFile + "\n\n" +
            message_ReadStudentsFromFile + "\n\n" +
            message_ReadEnrollmentsInFile + "\n\n" +
            message_ReadSchoolClassesFromFile + "\n\n" +
            message_ReadTeachersInFile;

        var myBool = readCoursesFromFile && readStudentsFromFile &&
                     readEnrollmentsInFile && readSchoolClassesFromFile &&
                     readTeachersInFile;

        return myBool;
    }


    // 1st file to read are the courses file
    private static bool ReadCoursesFromFile(out string myString)
    {
        //
        // constructor for the reading files
        // with a try and catch
        // and also returning the messages
        //

        try
        {
            using var fileStream =
                new FileStream(CoursesFile, FileMode.OpenOrCreate);
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            return false;
            throw;
        }


        using (
            var fileStream =
            new FileStream(CoursesFile, FileMode.OpenOrCreate))
        {
            using (StreamReader streamReader = new(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    // read a line
                    var line = streamReader.ReadLine();

                    // validating the line,
                    // if is not null or empty,
                    // else will continue
                    if (string.IsNullOrEmpty(line)) continue;

                    // split the line into an array of strings
                    var campos = line.Split(';');

                    // validating the line, if has at least 4 fields,
                    // less than 4 will continue reading the file
                    if (campos.Length < 4) continue;

                    _ = int.TryParse(campos[0], out var id);
                    _ = int.TryParse(campos[2], out var workLoad);
                    _ = int.TryParse(campos[3], out var credits);

                    Courses.AddCourse(
                        id, campos[1], workLoad, credits, null
                    );
                }

                streamReader.Close();
            }
        }

        myString = "Operação realizada com sucesso";
        return true;
    }


    // 2nd file to read are the students file
    private static bool ReadStudentsFromFile(out string myString)
    {
        //
        // constructor for the reading files
        // with a try and catch
        // and also returning the messages
        //
        try
        {
            using FileStream fileStream =
                new(StudentsFile, FileMode.OpenOrCreate);
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            return false;
            throw;
        }

        using (FileStream fileStream =
               new(StudentsFile, FileMode.OpenOrCreate))
        {
            using (StreamReader streamReader = new(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    // reading a line
                    var line = streamReader.ReadLine();

                    // validating the line, if is not null or empty,
                    // else will continue reading the file
                    if (string.IsNullOrEmpty(line)) continue;

                    // split the line into an array of strings
                    var campos = line.Split(';');

                    // validating the line, if has at least 18 fields,
                    // less than 18 will continue reading the file
                    if (campos.Length < 18) continue;

                    _ = int.TryParse(campos[0], out var id);
                    _ = bool.TryParse(campos[8], out var active);
                    _ = DateOnly.TryParse(campos[10], out var dateOfBirth);
                    _ = DateOnly.TryParse(campos[12], out var expirationDateIn);
                    _ = int.TryParse(campos[17], out var totalWorkHours);
                    _ = DateOnly.TryParse(campos[18], out var enrollmentDate);

                    Students.AddStudent(
                        id,
                        campos[1],
                        campos[2],
                        campos[3],
                        campos[4],
                        campos[5],
                        campos[6],
                        campos[7],
                        active,
                        campos[9],
                        dateOfBirth,
                        campos[11],
                        expirationDateIn,
                        campos[13],
                        campos[14],
                        campos[15],
                        campos[16],
                        totalWorkHours,
                        enrollmentDate,
                        new List<Enrollment>()
                    );
                }

                streamReader.Close();
            }
        }

        myString = "Operação realizada com sucesso";
        return true;
    }


    // 3rd file to read are the enrollment file
    private static bool ReadEnrollmentsInFile(out string myString)
    {
        //
        // constructor for the reading files
        // with a try and catch
        // and also returning the messages
        //

        try
        {
            using FileStream fileStream =
                new(EnrollmentsFile, FileMode.OpenOrCreate);
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            return false;
            throw;
        }

        using (FileStream fileStream =
               new(EnrollmentsFile, FileMode.OpenOrCreate))
        {
            using (StreamReader streamReader = new(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    // reading a line
                    var line = streamReader.ReadLine();

                    // validating the line, if is not null or empty,
                    // else will continue reading the file
                    if (string.IsNullOrEmpty(line)) continue;

                    // split the line into an array of strings
                    var campos = line.Split(';');

                    // validating the line, if has at least 5 fields,
                    // less than 5 will continue reading the file
                    if (campos.Length < 4) continue;
                    //
                    //
                    // public int IdEnrollment { get; }
                    // public decimal? Grade { get; set; }
                    // public int StudentId { get; set; }
                    // public Student Student { get; set; }
                    // public int CourseId { get; set; }
                    // public Course Course { get; set; }
                    //
                    //
                    _ = int.TryParse(campos[0], out var idEnrollment);
                    _ = decimal.TryParse(campos[1], out var grade);
                    _ = int.TryParse(campos[2], out var studentId);
                    _ = int.TryParse(campos[3], out var courseId);

                    // verificar este ciclo porque esta adicionar todos tem que
                    // adicionar na lista deste estudante o que lhe pertence
                    Enrollments.AddEnrollment(
                        // IdEnrollment=idEnrollment,
                        grade,
                        studentId,
                        //Student = student,
                        courseId
                    //Course = course
                    );
                }

                streamReader.Close();
            }
        }

        myString = "Operação realizada com sucesso";
        return true;
    }

    // 4th file to read are the school-classes file
    private static bool ReadSchoolClassesFromFile(out string myString)
    {
        //
        // constructor for the reading files
        // with a try and catch
        // and also returning the messages
        //

        try
        {
            using FileStream fileStream =
                new(SchoolClassesFile, FileMode.OpenOrCreate);
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            return false;
            throw;
        }

        using (FileStream fileStream =
               new(SchoolClassesFile, FileMode.OpenOrCreate))
        {
            using (StreamReader streamReader = new(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    // read a line
                    var line = streamReader.ReadLine();

                    // validating the line,
                    // if is not null or empty,
                    // else will continue
                    if (string.IsNullOrEmpty(line)) continue;

                    // split the line into an array of strings
                    var campos = line.Split(';');

                    // validating the line,
                    // if is not null or empty,
                    // else will continue
                    if (campos.Length < 10) continue;


                    // ---------------------------------------------------------
                    //
                    // cycle to evaluate which students are select and add it
                    //
                    // ---------------------------------------------------------

                    //
                    // temp variable of the class student to
                    // retain the students for studentForValidation
                    //
                    List<Course> coursesList = new();

                    // validating the line,
                    // if has more than 3 fields,
                    // will read the disciplines
                    if (campos.Length > 9)
                        foreach (var c in Courses.ListCourses)
                            for (var index = 10; index < campos.Length; index++)
                            {
                                int.TryParse(campos[index], out var idCourse);
                                if (c.IdCourse == idCourse) coursesList.Add(c);
                            }

                    _ = int.TryParse(campos[0], out var id);
                    _ = DateOnly.TryParse(campos[3], out var startDate);
                    _ = DateOnly.TryParse(campos[4], out var endDate);
                    _ = TimeOnly.TryParse(campos[5], out var startHour);
                    _ = TimeOnly.TryParse(campos[6], out var endHour);

                    if (startDate == default)
                        startDate = DateOnly.FromDateTime(DateTime.Now)
                            .AddYears(-1);
                    if (endDate == default)
                        endDate = DateOnly.FromDateTime(DateTime.Now)
                            .AddYears(1);

                    if (startHour == default)
                        startHour = TimeOnly.FromDateTime(DateTime.Now)
                            .AddHours(9);
                    if (endHour == default) endHour = startHour.AddHours(8);

                    SchoolClasses.AddSchoolClass(
                        id, campos[1], campos[2],
                        startDate, endDate,
                        startHour, endHour,
                        campos[7], campos[8], campos[9],
                        0,
                        coursesList
                    );
                }

                streamReader.Close();
            }
        }

        myString = "Operação realizada com sucesso";
        return true;
    }


    // 5th file to read are the teachers file
    private static bool ReadTeachersInFile(out string myString)
    {
        //
        // constructor for the reading files
        // with a try and catch
        // and also returning the messages
        //
        var message = string.Empty;

        try
        {
            using FileStream fileStream =
                new(TeachersFile, FileMode.OpenOrCreate);
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            return false;
            throw;
        }

        using (FileStream fileStream =
               new(TeachersFile, FileMode.OpenOrCreate))
        {
            using (StreamReader streamReader = new(fileStream))
            {
                while (!streamReader.EndOfStream)
                {
                    // read a line
                    var line = streamReader.ReadLine();

                    // validating the line,
                    // if is not null or empty,
                    // else will continue
                    if (string.IsNullOrEmpty(line)) continue;

                    // split the line into an array of strings
                    var campos = line.Split(';');


                    // validating the line,
                    // if is not null or empty,
                    // else will continue
                    if (campos.Length < 18) continue;


                    // ---------------------------------------------------------
                    //
                    // cycle to evaluate which students are select and add it
                    //
                    // ---------------------------------------------------------

                    //
                    // temp variable of the class student to
                    // retain the students for studentForValidation
                    //
                    List<Course> coursesList = new();

                    // validating the line,
                    // if has more than 3 fields,
                    // will read the disciplines
                    if (campos.Length > 18)
                        foreach (var c in Courses.ListCourses)
                            for (var index = 19; index < campos.Length; index++)
                            {
                                int.TryParse(campos[index], out index);
                                if (c.IdCourse == index) coursesList.Add(c);
                            }


                    _ = int.TryParse(campos[0], out var id);
                    _ = bool.TryParse(campos[8], out var active);
                    _ = DateOnly.TryParse(campos[10], out var dateOfBirth);
                    _ = DateOnly.TryParse(campos[12], out var expirationDateIn);
                    _ = int.TryParse(campos[17], out var coursesCount);
                    _ = int.TryParse(campos[18], out var totalWorkHours);

                    Teachers.AddTeacher(
                        id,
                        campos[1],
                        campos[2],
                        campos[3],
                        campos[4],
                        campos[5],
                        campos[6],
                        campos[7],
                        active,
                        campos[9],
                        dateOfBirth,
                        campos[11],
                        expirationDateIn,
                        campos[13],
                        campos[14],
                        campos[15],
                        campos[16],
                        coursesCount,
                        totalWorkHours,
                        coursesList
                    );
                }

                streamReader.Close();
            }
        }

        myString = "Operação realizada com sucesso";
        return true;
    }

    #endregion

    #endregion
}