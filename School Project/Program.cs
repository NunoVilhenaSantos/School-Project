using School_Project.WForms.InitialForms;
using System.Globalization;

namespace School_Project;

internal static class Program
{
    private static CultureInfo _culture = CultureInfo.InvariantCulture;

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        Application.EnableVisualStyles();
        Application.DoEvents();
        Application.CurrentCulture = _culture;

        //Application.Run(new MainWinForm());
        
        Application.Run(new InitialWinForm());
    }
}