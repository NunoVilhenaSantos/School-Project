﻿using System.Reflection;
using System.Text;
using ClassLibrary.Courses;
using ClassLibrary.Enrollments;
using ClassLibrary.SchoolClasses;
using ClassLibrary.Students;
using ClassLibrary.Teachers;

namespace ClassLibrary;

public static class XFiles
{
    //
    // Global Properties for the windows forms
    // to store the data into files of class
    //

    #region Properties

    // private static readonly string ProjectFolder =
    //     Directory.GetCurrentDirectory();
    private const string ProjectFolder =
        "C:\\Users\\nunov\\Downloads\\Projeto\\";

    internal const string FilesFolder = ProjectFolder + "\\XFiles\\";

    private const string CoursesFile = FilesFolder + "CoursesFile.csv";

    private const string SchoolClassesFile =
        FilesFolder + "SchoolClassesFile.csv";

    private const string StudentsFile = FilesFolder + "StudentsFile.csv";

    private const string EnrollmentsFile = FilesFolder + "EnrollmentsFile.csv";

    private const string TeachersFile = FilesFolder + "Teachers.csv";

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

        // If the directory already exists, this method does nothing.
        var file = new FileInfo(CoursesFile);
        // If the directory already exists, this method does nothing.
        file.Directory?.Create();

        var storeSchoolClassesInFile =
            StoreSchoolClassesInFile(
                out var messageStoreSchoolClassesInFile);
        // SchoolClassesFileHelper.WriteSchoolClassesToFile(
        //     out var successStoreSchoolClassesInCsv,
        //     out var messageStoreSchoolClassesInCsv);

        var storeTeachersInFile =
            StoreTeachersInFile(
                out var messageStoreTeachersInFile);
        // TeachersFileHelper.WriteTeachersToFile(
        //     out var successStoreTeachersInCsv,
        //     out var messageStoreTeachersInCsv);

        var storeCoursesInFile =
            StoreCoursesInFile(
                out var messageStoreCoursesInFile);
        // CoursesFileHelper.WriteCoursesToFile(
        //     out var successStoreCoursesInCsv,
        //     out var messageStoreCoursesInCsv);

        var storeEnrollmentsInFile =
            StoreEnrollmentsInFile(
                out var messageStoreEnrollmentsInFile);
        // EnrollmentsFileHelper.WriteEnrollmentsToFile(
        //     out var successStoreEnrollmentsInCsv,
        //     out var messageStoreEnrollmentsInCsv);

        var storeStudentsInFile =
            StoreStudentsInFile(
                out var messageStoreStudentsInFile);
        // StudentsFileHelper.WriteStudentsToFile(
        //     out var successStoreStudentsInCsv,
        //     out var messageStoreStudentsInCsv);

        myString =
            messageStoreSchoolClassesInFile + "\n\n" +
            messageStoreTeachersInFile + "\n\n" +
            messageStoreCoursesInFile + "\n\n" +
            messageStoreEnrollmentsInFile + "\n\n" +
            messageStoreStudentsInFile;
        // myString +=
        //     messageStoreSchoolClassesInCsv + "\n\n" +
        //     messageStoreTeachersInCsv + "\n\n" +
        //     messageStoreCoursesInCsv + "\n\n" +
        //     messageStoreEnrollmentsInCsv + "\n\n" +
        //     messageStoreStudentsInCsv;

        var myBool =
            storeSchoolClassesInFile && storeTeachersInFile &&
            storeCoursesInFile && storeEnrollmentsInFile &&
            storeStudentsInFile;
        // myBool +=
        //     successStoreSchoolClassesInCsv && successStoreTeachersInCsv &&
        //     successStoreCoursesInCsv && successStoreEnrollmentsInCsv &&
        //     successStoreStudentsInCsv;

        return myBool;
    }


    private static bool StoreSchoolClassesInFile(out string myString)
    {
        //
        // constructor for storing info in files
        // with a try and catch
        // and also returning the messages
        //
        FileStream fileStream;
        try
        {
            fileStream = new FileStream(SchoolClassesFile, FileMode.Create);
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
        }

        //fileStream = new FileStream(SchoolClassesFile, FileMode.Create);
        StreamWriter streamWriter = new(fileStream, Encoding.UTF8);

        // Write the header line
        // const string headerLine =
        //     "IdSchoolClass;" +
        //     "ClassAcronym;" +
        //     "ClassName;" +
        //     "StartDate;" +
        //     "EndDate;" +
        //     "StartHour;" +
        //     "EndHour;" +
        //     "Location;" +
        //     "Type;" +
        //     "Area;" +
        //     "CoursesList";
        // streamWriter.WriteLine(headerLine);

        // Read the public properties to build the header line
        var properties = typeof(SchoolClass)
            .GetProperties(
                BindingFlags.Public | BindingFlags.Instance);

        // Create a list with the public properties
        // to build the header line
        var propertyNames =
            string.Join(";",
                properties.Select(p => p.Name.Normalize()));

        // Write the header line
        streamWriter.WriteLine(propertyNames);

        foreach (var line in from schoolClass in
                     SchoolClasses.SchoolClasses.ListSchoolClasses
                 let line = string.Empty
                 select $"{schoolClass.IdSchoolClass};" +
                        $"{schoolClass.ClassAcronym};" +
                        $"{schoolClass.ClassName};" +
                        $"{schoolClass.StartDate};" +
                        $"{schoolClass.EndDate};" +
                        $"{schoolClass.StartHour};" +
                        $"{schoolClass.EndHour};" +
                        $"{schoolClass.Location};" +
                        $"{schoolClass.Type};" +
                        $"{schoolClass.Area}" +
                        string.Join(";",
                            schoolClass.CoursesList != null,
                            schoolClass.CoursesList
                                .Select(c => c.IdCourse)))
            // if (schoolClass.CoursesList != null)
            // {
            //     var coursesLine =
            //         schoolClass.CoursesList.Select(c =>
            //             $"{c.IdCourse}");
            //     line += $";{string.Join(";", coursesLine)}";
            // }
            streamWriter.WriteLine(line);

        //streamWriter.Flush();
        //fileStream.Flush();
        //fileStream.Close();
        streamWriter.Close();

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

        FileStream fileStream;
        try
        {
            fileStream = new FileStream(TeachersFile, FileMode.Create);
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
        }
        //fileStream = new FileStream(TeachersFile, FileMode.Create);
        StreamWriter streamWriter = new(fileStream, Encoding.UTF8);

        // const string header =
        //     "TeacherId;Name;LastName;Address;Phone;Email;" +
        //     "Active;Genre;DateOfBirth;IdentificationNumber;" +
        //     "ExpirationDateIn;TaxIdentificationNumber;" +
        //     "Nationality;Birthplace;Photo;IdCourse";
        // streamWriter.Write(header);

        // Read the public properties to build the header line
        var properties =
            typeof(Teacher).GetProperties(
                BindingFlags.Public | BindingFlags.Instance);

        // Create a list with the public properties
        // to build the header line
        var propertyNames =
            string.Join(";",
                properties.Select(p => p.Name.Normalize()));

        // Write the header line
        streamWriter.WriteLine(propertyNames);

        foreach (var line in from teacher in
                     Teachers.Teachers.TeachersList
                 let line = string.Empty
                 select $"{teacher.TeacherId};" +
                        $"{teacher.Name};" +
                        $"{teacher.LastName};" +
                        $"{teacher.Address};" +
                        $"{teacher.Phone};" +
                        $"{teacher.Email};" +
                        $"{teacher.Active};" +
                        $"{teacher.Genre};" +
                        $"{teacher.DateOfBirth};" +
                        $"{teacher.IdentificationNumber};" +
                        $"{teacher.ExpirationDateIn};" +
                        $"{teacher.TaxIdentificationNumber};" +
                        $"{teacher.Nationality};" +
                        $"{teacher.Birthplace};" +
                        $"{teacher.Photo};" +
                        string.Join(";",
                            teacher.Courses?
                                .Select(c => c.IdCourse)))
            streamWriter.Write(line);

        //streamWriter.Flush();
        //fileStream.Flush();
        //fileStream.Close();
        streamWriter.Close();

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

        FileStream fileStream;
        try
        {
            fileStream = new FileStream(CoursesFile, FileMode.Create);
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
        }
        // fileStream = new FileStream(CoursesFile, FileMode.Create);
        StreamWriter streamWriter =
            new(fileStream, Encoding.UTF8);

        // Read the public properties to build the header line
        var properties =
            typeof(Course).GetProperties(
                BindingFlags.Public | BindingFlags.Instance);

        // Create a list with the public properties
        // to build the header line
        var propertyNames =
            string.Join(";", properties
                .Select(p => p.Name.Normalize()));

        // Write the header line
        streamWriter.WriteLine(propertyNames);

        foreach (var line in Courses.Courses.ListCourses
                     .Select(course =>
                         $"{course.IdCourse};" +
                         $"{course.Name};" +
                         $"{course.WorkLoad};" +
                         $"{course.Credits}"
                     ))
            streamWriter.WriteLine(line);

        //streamWriter.Flush();
        //fileStream.Flush();
        //fileStream.Close();
        streamWriter.Close();

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
        FileStream fileStream;
        try
        {
            fileStream = new FileStream(EnrollmentsFile, FileMode.Create);
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
        }
        // fileStream = new FileStream(EnrollmentsFile, FileMode.Create);
        StreamWriter streamWriter = new(fileStream, Encoding.UTF8);

        // Read the public properties to build the header line
        var properties = typeof(Enrollment)
            .GetProperties(
                BindingFlags.Public | BindingFlags.Instance);

        // Create a list with the public properties
        // to build the header line
        var propertyNames =
            string.Join(";",
                properties.Select(p => p.Name.Normalize()));

        // Write the header line
        streamWriter.WriteLine(propertyNames);

        foreach (var line in
                 Enrollments.Enrollments.ListEnrollments
                     .Select(e =>
                             $"{e.IdEnrollment};" +
                             $"{e.Grade};" +
                             $"{e.StudentId};" +
                             //$"{e.Student};" +
                             $"{e.CourseId};"
                         //$"{e.Course}"
                     ))
            streamWriter.WriteLine(line);

        //streamWriter.Flush();
        //fileStream.Flush();
        //fileStream.Close();
        streamWriter.Close();

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
        FileStream fileStream;
        try
        {
            fileStream = new FileStream(StudentsFile, FileMode.Create);
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
        }
        // fileStream = new FileStream(StudentsFile, FileMode.Create);
        StreamWriter streamWriter = new(fileStream, Encoding.UTF8);

        // Read the public properties to build the header line
        var properties = typeof(Student)
            .GetProperties(
                BindingFlags.Public | BindingFlags.Instance);

        // Create a list with the public properties
        // to build the header line
        var propertyNames =
            string.Join(";",
                properties.Select(p => p.Name.Normalize()));

        // Write the header line
        streamWriter.WriteLine(propertyNames);
        
        foreach (var line in
                 Students.Students.ListStudents
                     .Select(student =>
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

        //streamWriter.Flush();
        //fileStream.Flush();
        //fileStream.Close();
        streamWriter.Close();

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

        // If the directory already exists, this method does nothing.
        var file = new FileInfo(CoursesFile);
        // If the directory already exists, this method does nothing.
        file.Directory?.Create();


        // 1st file to read are the courses file
        var readCoursesFromFile =
            ReadCoursesFromFile(
                out var messageReadCoursesFromFile);
        // CoursesFileHelper.ReadCoursesFromFile(
        //     out var successReadCoursesFromCsv,
        //     out var messageReadCoursesFromCsv);

        // 2nd file to read are the students file
        var readStudentsFromFile =
            ReadStudentsFromFile(
                out var messageReadStudentsFromFile);
        // StudentsFileHelper.ReadStudentsFromFile(
        //     out var successReadStudentsFromCsv,
        //     out var messageReadStudentsFromCsv);

        // 3rd file to read are the enrollment file
        var readEnrollmentsInFile =
            ReadEnrollmentsInFile(
                out var messageReadEnrollmentsInFile);
        // EnrollmentsFileHelper.ReadEnrollmentsFromFile(
        //     out var successReadEnrollmentsInCsv,
        //     out var messageReadEnrollmentsInCsv);

        // 4th file to read are the school-classes file
        var readSchoolClassesFromFile =
            ReadSchoolClassesFromFile(
                out var messageReadSchoolClassesFromFile);
        // SchoolClassesFileHelper.ReadSchoolClassesFromFile(
        //     out var successReadSchoolClassesFromCsv,
        //     out var messageReadSchoolClassesFromCsv);

        // 5th file to read are the teachers file
        var readTeachersInFile =
            ReadTeachersInFile(
                out var messageReadTeachersInFile);
        // TeachersFileHelper.ReadTeachersFromFile(
        //     out var successReadTeachersInCsv,
        //     out var messageReadTeachersInCsv);

        myString =
            messageReadCoursesFromFile + "\n\n" +
            messageReadStudentsFromFile + "\n\n" +
            messageReadEnrollmentsInFile + "\n\n" +
            messageReadSchoolClassesFromFile + "\n\n" +
            messageReadTeachersInFile;
        // myString +=
        //     messageReadCoursesFromCsv + "\n\n" +
        //     messageReadStudentsFromCsv + "\n\n" +
        //     messageReadEnrollmentsInCsv + "\n\n" +
        //     messageReadSchoolClassesFromCsv + "\n\n" +
        //     messageReadTeachersInCsv;

        var myBool = readCoursesFromFile && readStudentsFromFile &&
                     readEnrollmentsInFile && readSchoolClassesFromFile &&
                     readTeachersInFile;
        // myBool += successReadCoursesFromCsv &&
        //           successReadStudentsFromCsv &&
        //           successReadEnrollmentsInCsv &&
        //           successReadSchoolClassesFromCsv &&
        //           successReadTeachersInCsv;

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

        FileStream fileStream;
        try
        {
            fileStream = new FileStream(CoursesFile, FileMode.OpenOrCreate);
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
        // fileStream = new FileStream(CoursesFile, FileMode.OpenOrCreate);
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

            // validating the line, if has at least 4 fields,
            // less than 4 will continue reading the file
            if (campos.Length < 4) continue;
            if (campos[0].ToLower().Contains("id")) continue;

            _ = int.TryParse(campos[0], out var id);
            _ = int.TryParse(campos[2], out var workLoad);
            _ = int.TryParse(campos[3], out var credits);

            Courses.Courses.AddCourse(
                id, campos[1], workLoad, credits, null
            );
        }

        streamReader.Close();

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
        FileStream fileStream;
        try
        {
            fileStream = new FileStream(StudentsFile, FileMode.OpenOrCreate);
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
        // fileStream = new FileStream(StudentsFile, FileMode.OpenOrCreate);
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

            // validating the line, if has at least 18 fields,
            // less than 18 will continue reading the file
            if (campos.Length < 18) continue;
            if (campos[0].ToLower().Contains("id")) continue;

            _ = int.TryParse(campos[0], out var id);
            _ = bool.TryParse(campos[8], out var active);
            _ = DateOnly.TryParse(campos[10], out var dateOfBirth);
            _ = DateOnly.TryParse(campos[12], out var expirationDateIn);
            _ = int.TryParse(campos[17], out var totalWorkHours);
            _ = DateOnly.TryParse(campos[18], out var enrollmentDate);

            Students.Students.AddStudent(
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

        FileStream fileStream;
        try
        {
            fileStream = new FileStream(EnrollmentsFile, FileMode.OpenOrCreate);
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
        // fileStream = new FileStream(EnrollmentsFile, FileMode.OpenOrCreate);
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
            if (campos.Length < 4) continue;
            if (campos[0].ToLower().Contains("id")) continue;

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
            //_ = int.TryParse(campos[0], out var idEnrollment);
            _ = decimal.TryParse(campos[1], out var grade);
            _ = int.TryParse(campos[2], out var studentId);
            _ = int.TryParse(campos[3], out var courseId);

            // verificar este ciclo porque esta adicionar todos tem que
            // adicionar na lista deste estudante o que lhe pertence
            Enrollments.Enrollments.AddEnrollment(
                // IdEnrollment=idEnrollment,
                grade,
                studentId,
                //Student = student,
                courseId
                //Course = course
            );
        }

        streamReader.Close();

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

        FileStream fileStream;
        try
        {
            fileStream =
                new FileStream(SchoolClassesFile, FileMode.OpenOrCreate);
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
        //fileStream = new FileStream(SchoolClassesFile, FileMode.OpenOrCreate);
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
            if (campos[0].ToLower().Contains("id")) continue;

            // ---------------------------------------------------------
            //
            // cycle to evaluate which students are select and add it
            //
            // ---------------------------------------------------------

            //
            // temp variable of the class student to
            // retain the students for studentForValidation
            //
            List<Course>? coursesList = new();

            // validating the line,
            // if has more than 3 fields,
            // will read the disciplines
            if (campos.Length > 9)
                foreach (var c in Courses.Courses.ListCourses)
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

            SchoolClasses.SchoolClasses.AddSchoolClass(
                id, campos[1], campos[2],
                startDate, endDate,
                startHour, endHour,
                campos[7], campos[8], campos[9],
                0,
                coursesList
            );
        }

        streamReader.Close();

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

        FileStream fileStream;
        try
        {
            fileStream = new FileStream(TeachersFile, FileMode.OpenOrCreate);
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
        // fileStream = new FileStream(TeachersFile, FileMode.OpenOrCreate);
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
            if (campos[0].ToLower().Contains("id")) continue;

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
                foreach (var c in Courses.Courses.ListCourses)
                    for (var index = 19; index < campos.Length; index++)
                    {
                        _ = int.TryParse(campos[index], out index);
                        if (c.IdCourse == index) coursesList.Add(c);
                    }

            _ = int.TryParse(campos[0], out var id);
            _ = bool.TryParse(campos[8], out var active);
            _ = DateOnly.TryParse(campos[10], out var dateOfBirth);
            _ = DateOnly.TryParse(campos[12], out var expirationDateIn);
            _ = int.TryParse(campos[17], out var coursesCount);
            _ = int.TryParse(campos[18], out var totalWorkHours);

            Teachers.Teachers.AddTeacher(
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

        myString = "Operação realizada com sucesso";
        return true;
    }

    #endregion

    #endregion
}