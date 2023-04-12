using System.Diagnostics;
using ClassLibrary.Courses;
using ClassLibrary.Enrollments;
using ClassLibrary.School;
using ClassLibrary.SchoolClasses;
using School_Project.Properties;
using School_Project.WForms.CoursesForms;
using School_Project.WForms.SchoolClassesForms;
using School_Project.WForms.StatisticsForms;
using School_Project.WForms.StudentsForms;
using School_Project.WForms.TeachersForms;
using Serilog;

// using Log = Microsoft.VisualBasic.Logging.Log;

namespace School_Project.WForms.InitialForms;

public partial class InitialWinForm : Form
{
    //public SchoolDatabase SchoolDatabase = new();
    private readonly Stopwatch _stopwatch;
    private bool _closeFromUser;

    private SchoolContext _context;
    private double elapsedSecondsXFiles;
    private TimeSpan elapsedTimeForm;
    private TimeSpan elapsedTimeXFiles;
    private DateTime startTime;

    //
    // Global Properties for the windows forms
    // to store the data into a list of class
    //

    public InitialWinForm(Stopwatch stopwatch)
    {
        InitializeComponent();
        //_stopwatch=new Stopwatch();
        _stopwatch = stopwatch;
    }


    private void WinFormInitial_Load(object sender, EventArgs e)
    {
        // Configure Serilog logger
        Log.Logger = new LoggerConfiguration()
            .WriteTo.Console()
            .WriteTo.File(
                XFiles.SchoolProjectLoggerFile,
                rollingInterval: RollingInterval.Day)
            .CreateLogger();

        //this.Show();
        //this.ShowDialog();
        ShowInTaskbar = true;
        ShowIcon = true;
        startTime = DateTime.Now;

        // try to read files if they exist
        var xFilesMessages = XFiles.ReadFromFiles(out var myString);

        // Cálculo do tempo decorrido desde o arranque do
        // form até a apresentação do menu principal
        elapsedTimeXFiles = DateTime.Now - startTime;
        elapsedSecondsXFiles = elapsedTimeXFiles.TotalSeconds;

        if (!xFilesMessages)
            MessageBox.Show(
                "Esta é a mensagem que chegou do XFiles!\n\n" + myString,
                "Ler ficheiros");

        // _context = new SchoolContext();
        // _context.Database.EnsureCreated();

        SchoolClasses.ToObtainValuesForCalculatedFields();
        //Students.GetFullInfo();
        Courses.GetStudentsCount();

        ChangeImageInButtons();
    }


    private void InitialWinForm_Shown(object sender, EventArgs e)
    {
        ShowMainMenu();
    }

    private void ShowMainMenu()
    {
        // Cálculo do tempo decorrido desde o arranque do
        // form até a apresentação do menu principal
        elapsedTimeForm = DateTime.Now - startTime;
        var elapsedSecondsForm = elapsedTimeForm.TotalSeconds;


        // Cálculo do tempo decorrido desde o arranque do
        // programa até a apresentação do menu principal
        _stopwatch.Stop();
        var tempoDecorridoProgram = _stopwatch.Elapsed.TotalSeconds;
        //long tempoDecorridoProgram = _stopwatch.ElapsedMilliseconds;
        var tempoDecorridoProgramString = elapsedSecondsForm.ToString("0.000");


        // Mostra o menu principal
        // ...
        MessageBox.Show(
            "XFiles:\t\t Tempo decorrido: " + elapsedSecondsXFiles +
            " segundos\n" +
            "Form:\t\t Tempo decorrido: " + elapsedSecondsForm + " segundos\n" +
            "Programa:\t Tempo decorrido: " + tempoDecorridoProgram +
            " segundos\n");

        Enrollments.UpdateDictionaries();
        SchoolDatabase.UpdateDictionaries();
        Enrollments.AddEnrollmentsToSchoolDatabase();
    }

    private void ButtonCloseProgram_Click(object sender, EventArgs e)
    {
        var xFilesMessages = XFiles.StoreInFiles(out var myString);
        if (!xFilesMessages)
            MessageBox.Show(
                "Esta é a mensagem que chegou do XFiles!\n\n" + myString,
                "Ler ficheiros");

        Console.WriteLine("Testes de Debug");

        //
        // variable to allow the program be closed,
        // other wise it will be cancel in the method
        // in a line with the following statement
        // e.Cancel = true;
        //
        _closeFromUser = true;
        //Application.DoEvents();
        //Close();
        Application.ExitThread();
        Application.Exit();
    }


    private void ChangeImageInButtons()
    {
        //
        // original code
        //
        //buttonSchoolClass.Image = Properties.Resources.Icon_chalkboard_32x32;
        //buttonTeachers.Image = Properties.Resources.Icon_id_card_32x32;
        //buttonStudent.Image = Properties.Resources.Icon_graduate_32x32;
        //buttonDiscipline.Image = Properties.Resources.Icon_book_green_32x32;
        //buttonStudenDisciplines.Image = Properties.Resources.Icon_address_card_64x64;
        //buttonCharts.Image = Properties.Resources.Icon_bar_chart_32x32;
        //buttonListagens.Image = Properties.Resources.Icon_printer_32x32;
        //buttonCloseProgram.Image = Properties.Resources.Icon_doughnut_chart_32x32;
        //pictureBox1.Image = Properties.Resources.escola-web;
        pictureBox1.Image = Resources.Students_watching_webinar;
    }


    private void ButtonSchoolClass_Click(object sender, EventArgs e)
    {
        //MessageBox.Show("Falta implementar código");
        //Console.WriteLine("Falta implementar código");

        Console.WriteLine("Código implementado");

        SchoolClassAdd schoolClassAdd = new();
        Hide();
        schoolClassAdd.ShowDialog();
        schoolClassAdd.Dispose();
        Show();
    }


    private void ButtonTeachers_Click(object sender, EventArgs e)
    {
        //MessageBox.Show("Falta implementar código");
        //Console.WriteLine("Falta implementar código");

        Console.WriteLine("Código implementado");

        TeacherAdd teacherAdd = new();
        Hide();
        teacherAdd.ShowDialog();
        teacherAdd.Dispose();
        Show();
    }


    private void ButtonStudent_Click(object sender, EventArgs e)
    {
        StudentAdd winFormStudentAdd = new();
        Hide();
        winFormStudentAdd.ShowDialog();
        winFormStudentAdd.Dispose();
        Show();
    }


    private void ButtonDiscipline_Click(object sender, EventArgs e)
    {
        DisciplineAdd winFormDisciplineAdd = new();
        Hide();
        winFormDisciplineAdd.ShowDialog();
        winFormDisciplineAdd.Dispose();
        Show();
    }


    private void ButtonStudentDisciplines_Click(
        object sender, EventArgs e)
    {
        StudentDiscipline winFormStudentDiscipline = new();
        Hide();
        winFormStudentDiscipline.ShowDialog();
        winFormStudentDiscipline.Dispose();
        Show();

        //winFormStudentDiscipline.ShowDialog();
    }

    private void ButtonCharts_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Falta implementar código");
        Console.WriteLine("Falta implementar código");

        ChartsWinForm chartsWinForm = new();
        Hide();
        chartsWinForm.ShowDialog();
        chartsWinForm.Dispose();
        Show();
    }

    private void ButtonListagens_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Falta implementar código");
        Console.WriteLine("Falta implementar código");

        //School_Project.WPF.ChartWpfWindow chartWpfWindow = new();
        Hide();
        //chartWpfWindow.ShowDialog();
        //chartWpfWindow.Close();
        Show();
    }

    private void ButtonAbout_Click(object sender, EventArgs e)
    {
        var formAbout = new FormAbout();
        //Hide();
        formAbout.ShowDialog();
        formAbout.Close();
        //Show();

        /*
        // Remove the picture box from the form's control collection
        this.Controls.Remove(pictureBox1);
        pictureBox1.Dispose();

        // Create a new panel and set its properties
        Panel panel1 = new();
        panel1.Dock = DockStyle.Fill;

        // Add the panel to the form's control collection in the same position as the picture box
        int index = this.Controls.IndexOf(pictureBox1);
        tableLayoutPanelInitialForm.Controls.Add(panel1, 1, 3);
        tableLayoutPanelInitialForm.SetRowSpan(panel1, 6);

        //this.Controls.SetChildIndex(panel1, index);

        // Add the user control to the panel
        UControl.UC_About uC_Sobre = new()
        {
            Dock = DockStyle.Fill,
            Visible = true,
            //Size = new Size(898, 580),
        };
        panel1.Controls.Add(uC_Sobre);

        // Set the panel's Visible property to true to make it show up
        panel1.Visible = true;

        // Remove the panel from the form's control collection and re-insert the picture box in its place
        //this.tableLayoutPanelInitialForm.Controls.Remove(panel1);
        //this.tableLayoutPanelInitialForm.Controls.Add(pictureBox1, 1, 1);
        //this.tableLayoutPanelInitialForm.SetRowSpan(pictureBox1, 9);
        */
    }


    private void WinFormInitial_FormClosing(object sender,
        FormClosingEventArgs e)
    {
        // Cancel the Closing event from closing the form.
        if (!_closeFromUser)
            // e.Cancel = true;
            buttonCloseProgram.PerformClick();
        // Call method to save file...
    }
}