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

    private const string TeachersFilePath = XFiles.FilesFolder + "teachers.csv";

    #endregion


    public static void WriteTeachersToFile(
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
            fileStream = new FileStream(TeachersFilePath, FileMode.Create);
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

        fileStream = new FileStream(TeachersFilePath, FileMode.Create);
        var streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
        var csvWriter = new CsvWriter(streamWriter, csvConfig);

        csvWriter.WriteRecords(Teachers.TeachersList);

        myString = "Operação realizada com sucesso";
        success = true;
    }

    public static List<Teacher> ReadTeachersFromFile(
        out bool sucess, out string myString)
    {
        //
        // constructor for the reading files
        // with a try and catch
        // and also returning the messages
        //

        FileStream fileStream;
        try
        {
            fileStream =
                new FileStream(TeachersFilePath, FileMode.OpenOrCreate);
        }
        catch (IOException ex)
        {
            myString = "Error accessing the file: " + ex.Source + " | " +
                       ex.Message;
            sucess = false;
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            myString = "Error accessing the file: " + e.Source + " | " +
                       e.Message;
            sucess = false;
        }

        var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
        {
            Delimiter = ";"
        };

        fileStream = new FileStream(TeachersFilePath, FileMode.OpenOrCreate);
        var streamReader = new StreamReader(fileStream);
        var csvReader = new CsvReader(streamReader, csvConfig);

        myString = "Operação realizada com sucesso";
        sucess = true;

        return csvReader.GetRecords<Teacher>().ToList();
    }
}