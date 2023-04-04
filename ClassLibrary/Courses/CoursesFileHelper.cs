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


    public static void WriteCoursesToFile(
        out bool Success, out string myString)
    {
        FileStream fileStream;
        try
        {
            fileStream =
                new FileStream(CoursesFilePath, FileMode.OpenOrCreate);
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            Success = false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            Success = false;
        }

        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        fileStream = new FileStream(CoursesFilePath, FileMode.Create);
        using var streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
        using var csvWriter = new CsvWriter(streamWriter, csvConfig);

        csvWriter.WriteRecords(Courses.ListCourses);

        myString = "Operação realizada com sucesso";
        Success = true;
    }

    public static List<Course> ReadCoursesFromFile(
        out bool Success, out string myString)
    {
        FileStream fileStream;
        try
        {
            fileStream =
                new FileStream(CoursesFilePath, FileMode.OpenOrCreate);
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            Success = false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            Success = false;
        }

        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        fileStream = new FileStream(CoursesFilePath, FileMode.OpenOrCreate);
        using var streamWriter = new StreamReader(fileStream);
        using var csvReader = new CsvReader(streamWriter, csvConfig);

        myString = "Operação realizada com sucesso";
        Success = true;

        return csvReader.GetRecords<Course>().ToList();
    }
}