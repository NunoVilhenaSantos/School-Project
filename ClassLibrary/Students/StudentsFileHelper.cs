using System.Globalization;
using System.Text;
using ClassLibrary.School;
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


    public static void WriteStudentsToFile(
        out bool Success, out string myString)
    {
        try
        {
            using (var fileStream =
                   new FileStream(StudentsFilePath, FileMode.Create,
                       FileAccess.Write
                   ))
            {
            }
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

        using (var fileStream =
               new FileStream(StudentsFilePath, FileMode.Create,
                   FileAccess.Write))
        using (var streamWriter = new StreamWriter(fileStream, Encoding.UTF8))
        using (var csvWriter = new CsvWriter(streamWriter, csvConfig))
        {
            csvWriter.WriteRecords(Students.ListStudents);

            myString = "Operação realizada com sucesso";
            Success = true;
        }
    }

    public static List<Student> ReadStudentsFromFile(
        out bool Success, out string myString)
    {
        try
        {
            using (var fileStream =
                   new FileStream(StudentsFilePath, FileMode.OpenOrCreate,
                       FileAccess.Read))
            {
            }
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

        using (var fileStream =
               new FileStream(StudentsFilePath, FileMode.OpenOrCreate,
                   FileAccess.Read))
        using (var streamReader = new StreamReader(fileStream))
        using (var csvReader = new CsvReader(streamReader, csvConfig))
        {
            myString = "Operação realizada com sucesso";
            Success = true;

            return csvReader.GetRecords<Student>().ToList();
        }
    }
}