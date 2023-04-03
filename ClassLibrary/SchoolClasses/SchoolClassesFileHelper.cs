using System.Globalization;
using System.Text;
using CsvHelper;
using CsvHelper.Configuration;

namespace ClassLibrary.SchoolClasses;

public class SchoolClassesFileHelper
{
    //
    // Global Properties for the windows forms
    // to store the data into files of class
    //

    #region Properties

    private static readonly string SchoolClassesFilePath =
        XFiles.FilesFolder + "schoolclasses.csv";

    #endregion


    public static void WriteSchoolClassesToFile()
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using var fileStream =
            new FileStream(SchoolClassesFilePath, FileMode.Create);
        using var streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
        using var csvWriter = new CsvWriter(streamWriter, csvConfig);

        csvWriter.WriteRecords(SchoolClasses.ListSchoolClasses);
    }

    public static List<SchoolClass> ReadSchoolClassesFromFile()
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using var fileStream =
            new FileStream(SchoolClassesFilePath, FileMode.OpenOrCreate);
        using var streamReader = new StreamReader(fileStream);
        using var csvReader = new CsvReader(streamReader, csvConfig);

        return csvReader.GetRecords<SchoolClass>().ToList();
    }
}