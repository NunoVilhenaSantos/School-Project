using System.Globalization;
using System.Text;
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

        using var fileStream =
            new FileStream(EnrollmentsFilePath, FileMode.Create);
        using var streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
        using var csvWriter = new CsvWriter(streamWriter, csvConfig);

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
        using var streamReader = new StreamReader(fileStream);
        using var csvReader = new CsvReader(streamReader, csvConfig);

        return csvReader.GetRecords<Enrollment>().ToList();
    }
}