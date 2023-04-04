﻿using System.Globalization;
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


    public static void WriteSchoolClassesToFile(
        out bool Success, out string myString)

    {
        FileStream fileStream;
        try
        {
            fileStream = new FileStream(
                SchoolClassesFilePath, FileMode.OpenOrCreate);
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

        fileStream = new FileStream(SchoolClassesFilePath, FileMode.Create);
        using var streamWriter = new StreamWriter(fileStream, Encoding.UTF8);
        using var csvWriter = new CsvWriter(streamWriter, csvConfig);

        csvWriter.WriteRecords(SchoolClasses.ListSchoolClasses);

        myString = "Operação realizada com sucesso";
        Success = true;
    }

    public static List<SchoolClass> ReadSchoolClassesFromFile(
        out bool Success, out string myString)
    {
        FileStream fileStream;
        try
        {
            fileStream = new FileStream(
                SchoolClassesFilePath, FileMode.OpenOrCreate);
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

        fileStream =
            new FileStream(SchoolClassesFilePath, FileMode.OpenOrCreate);
        using var streamReader = new StreamReader(fileStream);
        using var csvReader = new CsvReader(streamReader, csvConfig);

        myString = "Operação realizada com sucesso";
        Success = true;

        return csvReader.GetRecords<SchoolClass>().ToList();
    }
}