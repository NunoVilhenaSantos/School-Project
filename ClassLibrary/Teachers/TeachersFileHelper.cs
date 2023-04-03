using System.Globalization;
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

        using var writer = new StreamWriter(TeachersFilePath);
        using var csvWriter = new CsvWriter(writer, csvConfig);

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
        using var reader = new StreamReader(fileStream);
        using var csvReader = new CsvReader(reader, csvConfig);

        return csvReader.GetRecords<Teacher>().ToList();
    }
}