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

    public static string StoreInFiles()
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

        var message_StoreSchoolClassesInFile = StoreSchoolClassesInFile();

        var message_StoreTeachersInFile = StoreTeachersInFile();

        var message_StoreCoursesInFile = StoreCoursesInFile();

        var message_StoreEnrollmentsInFile = StoreEnrollmentsInFile();

        var message_StoreStudentsInFile = StoreStudentsInFile();

        return messages =
            message_StoreSchoolClassesInFile + "\n\n" +
            message_StoreTeachersInFile + "\n\n" +
            message_StoreCoursesInFile + "\n\n" +
            message_StoreEnrollmentsInFile + "\n\n" +
            message_StoreStudentsInFile;
    }


    private static string StoreSchoolClassesInFile()
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
                   new(SchoolClassesFile, FileMode.Create)) ;
        }
        catch (IOException ex)
        {
            return "Error accessing the file: " + ex.Message;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return "Error accessing the file: " + e.Message;
            throw;
        }

        /*
        using (FileStream fileStream = new(SchoolClassesFile, FileMode.Create))
        {
            using (streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
            {
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
                    //$"{schoolClass.StudentsCount};" +
                    //$"{schoolClass.WorkHourLoad};" +
                    //$"{schoolClass.CoursesList}";

                    //
                    // check if the list of disciplines of the student is not null
                    // else write the line without this info
                    //
                    if (schoolClass.CoursesList != null)
                        line =
                            schoolClass.CoursesList.Aggregate(
                                line, (current, c)
                                    => current + $";{c.IdCourse}");

                    streamWriter.WriteLine(line);
                }

                streamWriter.Flush();
            }
        }
        */

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
            }
        }

        return "Operação realizada com sucesso";
    }


    private static string StoreTeachersInFile()
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
            return "Error accessing the file: " + ex.Message;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return "Error accessing the file: " + e.Message;
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
            }
        }

        return "Operação concluida com sucesso";
    }

    private static string StoreCoursesInFile()
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
            return "Error accessing the file: " + ex.Message;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return "Error accessing the file: " + e.Message;
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
                             $"{course.Credits}"))
                {
                    streamWriter.WriteLine(line);
                }
            }
        }

        return "Operação concluida com sucesso";
    }


    private static string StoreEnrollmentsInFile()
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
            return "Error accessing the file: " + ex.Message;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return "Error accessing the file: " + e.Message;
            throw;
        }

        using (FileStream fileStream =
               new(EnrollmentsFile, FileMode.Create))
        {
            StreamWriter streamWriter = new(fileStream, Encoding.UTF8);

            foreach (var line in
                     Enrollments.ListEnrollments.Select(e =>
                         $"{e.IdEnrollment};" +
                         $"{e.Grade};" +
                         $"{e.StudentId};" +
                         $"{e.Student};" +
                         $"{e.CourseId};" +
                         $"{e.Course}"))
                streamWriter.WriteLine(line);
        }

        return "Operação concluida com sucesso";
    }


    private static string StoreStudentsInFile()
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
            return "Error accessing the file: " + ex.Message;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return "Error accessing the file: " + e.Message;
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

        return "Operação concluida com sucesso";
    }

    #endregion


    //
    // reading data in files
    //

    #region ReadingDataFromFiles

    public static string ReadFromFiles()
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
        var message_ReadCoursesFromFile = ReadCoursesFromFile();

        // 2nd file to read are the students file
        var message_ReadStudentsFromFile = ReadStudentsFromFile();

        // 3rd file to read are the enrollment file
        var message_ReadEnrollmentsInFile = ReadEnrollmentsInFile();

        // 4th file to read are the school-classes file
        var message_ReadSchoolClassesFromFile = ReadSchoolClassesFromFile();

        // 5th file to read are the teachers file
        var message_ReadTeachersInFile = ReadTeachersInFile();

        return messages =
            message_ReadCoursesFromFile + "\n\n" +
            message_ReadStudentsFromFile + "\n\n" +
            message_ReadEnrollmentsInFile + "\n\n" +
            message_ReadSchoolClassesFromFile + "\n\n" +
            message_ReadTeachersInFile;
    }


    // 1st file to read are the courses file
    private static string ReadCoursesFromFile()
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
            return "Error accessing the file: " + ex.Source + " | " +
                   ex.Message;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return "Error accessing the file: " + e.Message;
            throw;
        }


        using (
            var fileStream =
            new FileStream(CoursesFile, FileMode.OpenOrCreate))
        {
            StreamReader streamReader = new(fileStream);

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

                _ = int.TryParse(campos[0], out var id);
                _ = int.TryParse(campos[2], out var workLoad);
                _ = int.TryParse(campos[2], out var credits);
                int Credits;
                Courses.AddCourse(
                    id, campos[1], workLoad, credits, null
                );
            }

            streamReader.Close();
        }

        return "Operação concluida com sucesso";
    }


    // 2nd file to read are the students file
    private static string ReadStudentsFromFile()
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
            return "Error accessing the file: " + ex.Message;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return "Error accessing the file: " + e.Message;
            throw;
        }

        using (FileStream fileStream =
               new(StudentsFile, FileMode.OpenOrCreate))
        {
            StreamReader streamReader = new(fileStream);

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

        return "Operação concluida com sucesso";
    }


    // 3rd file to read are the enrollment file
    private static string ReadEnrollmentsInFile()
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
            return "Error accessing the file: " + ex.Message;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return "Error accessing the file: " + e.Message;
            throw;
        }

        using (FileStream fileStream =
               new(EnrollmentsFile, FileMode.OpenOrCreate))
        {
            StreamReader streamReader = new(fileStream);

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
                //if (campos.Length < 15) continue;
                /*
                 *
                 * public int IdEnrollment { get; }
                 * public decimal? Grade { get; set; }
                 * public int StudentId { get; set; }
                 * public Student Student { get; set; }
                 * public int CourseId { get; set; }
                 * public Course Course { get; set; }
                 *
                 * 
                 */
                _ = int.TryParse(campos[0], out var idEnrollment);
                _ = decimal.TryParse(campos[1], out var grade);
                _ = int.TryParse(campos[2], out var studentId);
                _ = int.TryParse(campos[4], out var courseId);

                // verificar este ciclo porque esta adicionar todos
                // tem que adicionar na lista deste estudante o que lhe pertence
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

        return "Operação concluida com sucesso";
    }

    // 4th file to read are the school-classes file
    private static string ReadSchoolClassesFromFile()
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
            return "Error accessing the file: " + ex.Message;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            return "Error accessing the file: " + e.Message;
            throw;
        }

        using (FileStream fileStream =
               new(SchoolClassesFile, FileMode.OpenOrCreate))
        {
            StreamReader streamReader = new(fileStream);

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


                // -----------------------------------------------------------------
                //
                // cycle to evaluate which students are select and add it
                //
                // -----------------------------------------------------------------

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
                    endDate = DateOnly.FromDateTime(DateTime.Now).AddYears(1);

                if (startHour == default)
                    startHour = TimeOnly.FromDateTime(DateTime.Now).AddHours(9);
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

        return "Operação concluida com sucesso";
    }


    // 5th file to read are the teachers file
    private static string ReadTeachersInFile()
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
            message = "Error accessing the file: " + ex.Message;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            message = "Error accessing the file: " + e.Message;
            throw;
        }

        using (FileStream fileStream =
               new(TeachersFile, FileMode.OpenOrCreate))
        {
            StreamReader streamReader = new(fileStream);

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


                // -----------------------------------------------------------------
                //
                // cycle to evaluate which students are select and add it
                //
                // -----------------------------------------------------------------

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

        return "Operação concluida com sucesso";
    }

    #endregion

    #endregion
}