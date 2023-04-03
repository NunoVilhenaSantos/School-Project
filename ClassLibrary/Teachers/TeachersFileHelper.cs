using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace ClassLibrary.Teachers;

//using CsvBuilder;

public static class TeachersFileHelper
{
    //
    // Global Properties for the windows forms
    // to store the data into files of class
    //

    #region Properties

    private static readonly string TeachersFilePath =
        XFiles.FilesFolder + "teachers.csv";

    #endregion


    public static void WriteTeachersToFile()
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using var fileStream =
            new FileStream(TeachersFilePath, FileMode.Create);
        using var streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
        using var csvWriter = new CsvWriter(streamWriter, csvConfig);

        csvWriter.WriteRecords(Teachers.TeachersList);
    }

    public static List<Teacher> ReadTeachersFromFile()
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using var fileStream =
            new FileStream(TeachersFilePath, FileMode.OpenOrCreate);
        using var streamReader = new StreamReader(fileStream);
        using var csvReader = new CsvReader(streamReader, csvConfig);

        return csvReader.GetRecords<Teacher>().ToList();
    }
}