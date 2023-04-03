using System.Globalization;
using System.Text;
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

        using var fileStream = new FileStream(CoursesFilePath, FileMode.Create);
        using var streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
        using var csvWriter = new CsvWriter(streamWriter, csvConfig);

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
        using var streamWriter = new StreamReader(fileStream);
        using var csvReader = new CsvReader(streamWriter, csvConfig);

        return csvReader.GetRecords<Course>().ToList();
    }
}