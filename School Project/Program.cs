using School_Project.WForms.InitialForms;

namespace School_Project;

internal static class Program
{
    /// <summary>
    ///     The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        //Application.Run(new Form1());
        Application.Run(new InitialWinForm());
        Application.Run(new MainWinForm());
    }
}