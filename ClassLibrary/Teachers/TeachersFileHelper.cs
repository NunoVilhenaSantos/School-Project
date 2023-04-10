using System.Globalization;
using System.Text;
using ClassLibrary.School;
using CsvHelper;
using CsvHelper.Configuration;
using Serilog;

namespace ClassLibrary.Teachers;

//using CsvBuilder;

public static class TeachersFileHelper
{
    //
    // Global Properties for the windows forms
    // to store the data into files of class
    //

    #region Properties

    private const string TeachersFilePath = XFiles.FilesFolder + "teachers.csv";

    #endregion

    //
    // public static void WriteTeachersToFile(
    //     out bool success, out string myString)
    // {
    //     //
    //     // constructor for the reading files
    //     // with a try and catch
    //     // and also returning the messages
    //     //
    //
    //     FileStream fileStream;
    //     try
    //     {
    //         fileStream =
    //             new FileStream(TeachersFilePath, FileMode.Create,
    //                 FileAccess.ReadWrite);
    //         fileStream.Close();
    //     }
    //     catch (IOException ex)
    //     {
    //         myString = "Error accessing the file: " + ex.Source + " | " +
    //                    ex.Message;
    //         success = false;
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //         myString = "Error accessing the file: " + e.Source + " | " +
    //                    e.Message;
    //         success = false;
    //     }
    //
    //     var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
    //     {
    //         Delimiter = ";"
    //     };
    //
    //     fileStream =
    //         new FileStream(TeachersFilePath, FileMode.Create,
    //             FileAccess.ReadWrite);
    //     var streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
    //     var csvWriter = new CsvWriter(streamWriter, csvConfig);
    //
    //     csvWriter.WriteRecords(Teachers.TeachersList);
    //
    //     fileStream.Close();
    //
    //     myString = "Operação realizada com sucesso";
    //     success = true;
    // }

    public static void WriteTeachersToFile(
        out bool success, out string myString)
    {
        try
        {
            using (var fileStream =
                   new FileStream(TeachersFilePath,
                       FileMode.Create, FileAccess.Write))
            {
                var csvConfig =
                    new CsvConfiguration(CultureInfo.InvariantCulture)
                    {
                        Delimiter = ";"
                    };

                using (var streamWriter =
                       new StreamWriter(fileStream, Encoding.UTF8))
                using (var csvWriter = new CsvWriter(streamWriter, csvConfig))
                {
                    csvWriter.WriteRecords(Teachers.TeachersList);
                }

                myString = "Operação realizada com sucesso";
                success = true;
                Log.Information(
                    "WriteTeachersToFile " +
                    "completed successfully with message: " +
                    "{myString}", myString);
            }
        }
        catch (IOException ex)
        {
            Log.Error(ex,
                "Error accessing the file {FilePath}",
                TeachersFilePath);
            myString = "Error accessing the file: " +
                       ex.Source + " | " + ex.Message;
            success = false;
        }
        catch (Exception e)
        {
            Log.Error(e, "Error writing to file {FilePath}",
                TeachersFilePath);
            myString = "Error accessing the file: "
                       + e.Source + " | " + e.Message;
            success = false;
        }
    }


    public static List<Teacher> ReadTeachersFromFile(
        out bool success, out string myString)
    {
        //
        // constructor for the reading files
        // with a try and catch
        // and also returning the messages
        //

        FileStream fileStream;
        try
        {
            fileStream = new FileStream(TeachersFilePath, FileMode.OpenOrCreate,
                FileAccess.Read);
            fileStream.Close();
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            success = false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            success = false;
        }

        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        fileStream = new FileStream(TeachersFilePath, FileMode.OpenOrCreate,
            FileAccess.Read);
        var streamReader = new StreamReader(fileStream);
        var csvReader = new CsvReader(streamReader, csvConfig);

        myString = "Operação realizada com sucesso";
        success = true;

        fileStream.Close();

        return csvReader.GetRecords<Teacher>().ToList();
    }
}