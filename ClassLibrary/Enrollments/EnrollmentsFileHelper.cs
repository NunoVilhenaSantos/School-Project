using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;

namespace ClassLibrary.Enrollments;

public class EnrollmentsFileHelper
{
    //
    // Global Properties for the windows forms
    // to store the data into files of class
    //

    #region Properties

    private static readonly string EnrollmentsFilePath =
        XFiles.FilesFolder + "enrollments.csv";

    #endregion


    public static void WriteEnrollmentsToFile()
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using var writer = new StreamWriter(EnrollmentsFilePath);
        using var csvWriter = new CsvWriter(writer, csvConfig);

        csvWriter.WriteRecords(Enrollments.ListEnrollments);
    }

    public static List<Enrollment> ReadEnrollmentsFromFile()
    {
        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        using var fileStream =
            new FileStream(EnrollmentsFilePath, FileMode.OpenOrCreate);
        using var reader = new StreamReader(fileStream);
        using var csvReader = new CsvReader(reader, csvConfig);

        return csvReader.GetRecords<Enrollment>().ToList();
    }
}