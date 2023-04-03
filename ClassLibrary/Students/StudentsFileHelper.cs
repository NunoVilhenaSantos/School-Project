using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace ClassLibrary.Students;

public class StudentsFileHelper
{
    //
    // Global Properties for the windows forms
    // to store the data into files of class
    //

    #region Properties

    private static readonly string StudentsFilePath =
        XFiles.FilesFolder + "students.csv";

    #endregion


    public static void WriteStudentsToFile()
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using var fileStream =
            new FileStream(StudentsFilePath, FileMode.Create);
        using var streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
        using var csvWriter = new CsvWriter(streamWriter, csvConfig);

        csvWriter.WriteRecords(Students.ListStudents);
    }

    public static List<Student> ReadStudentsFromFile()
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using var fileStream =
            new FileStream(StudentsFilePath, FileMode.OpenOrCreate);
        using var streamReader = new StreamReader(fileStream);
        using var csvReader = new CsvReader(streamReader, csvConfig);

        return csvReader.GetRecords<Student>().ToList();
    }
}