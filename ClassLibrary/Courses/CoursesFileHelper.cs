using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace ClassLibrary.Courses;

public class CoursesFileHelper
{
    //
    // Global Properties for the windows forms
    // to store the data into files of class
    //

    #region Properties

    private static readonly string CoursesFilePath =
        XFiles.FilesFolder + "courses.csv";

    #endregion


    public static void WriteCoursesToFile()
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using var writer = new StreamWriter(CoursesFilePath);
        using var csvWriter = new CsvWriter(writer, csvConfig);

        csvWriter.WriteRecords(Courses.ListCourses);
    }

    public static List<Course> ReadCoursesFromFile()
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using var fileStream =
            new FileStream(CoursesFilePath, FileMode.OpenOrCreate);
        using var reader = new StreamReader(fileStream);
        using var csvReader = new CsvReader(reader, csvConfig);

        return csvReader.GetRecords<Course>().ToList();
    }
}