using System.Diagnostics;
using System.Globalization;
using School_Project.WForms.InitialForms;

namespace School_Project;

internal static class Program
{
    internal static readonly CultureInfo
        _culture = CultureInfo.InvariantCulture;

    internal static Stopwatch stopwatch;

    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // inicializar o relógio
        stopwatch = new Stopwatch();
        stopwatch.Start();


        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        Application.EnableVisualStyles();
        Application.DoEvents();
        Application.CurrentCulture = _culture;

        //Application.Run(new MainWinForm());

        Application.Run(new InitialWinForm(stopwatch));
    }
}