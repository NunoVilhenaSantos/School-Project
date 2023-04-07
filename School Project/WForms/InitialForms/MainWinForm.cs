using System.Globalization;
using ClassLibrary.School;
using School_Project.WForms.CoursesForms;
using School_Project.WForms.SchoolClassesForms;
using School_Project.WForms.StatisticsForms;
using School_Project.WForms.StudentsForms;

namespace School_Project.WForms.InitialForms;

public partial class MainWinForm : Form
{
    private bool _closeFromUser;

    private CultureInfo _culture = CultureInfo.InvariantCulture;

    public MainWinForm()
    {
        InitializeComponent();
    }


    private void MainWinForm_Load(object sender, EventArgs e)
    {
        // maximize win-form
        WindowState = FormWindowState.Maximized;

        // maximize win-form
        MainWinFormWindowsStateControl();

        MaximizeBox = true;

        // try to read files if they exist
        var xFilesMessages = XFiles.ReadFromFiles(out var myString);
        if (!xFilesMessages)
            MessageBox.Show(
                "Esta é a mensagem que chegou do XFiles!\n\n" + myString,
                "Ler ficheiros");
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
        Application.Exit();
        //Close();
    }


    private void ButtonSchoolClass_Click(object sender, EventArgs e)
    {
        //MessageBox.Show("Falta implementar código");
        //Console.WriteLine("Falta implementar código");

        Console.WriteLine("Código implementado");

        SchoolClassAdd schoolClassAdd = new();
        schoolClassAdd.ShowDialog();
    }


    private void ButtonStudent_Click(object sender, EventArgs e)
    {
        StudentAdd studentAdd = new();
        studentAdd.ShowDialog();
    }


    private void ButtonDiscipline_Click(object sender, EventArgs e)
    {
        DisciplineAdd winFormDisciplineAdd = new();
        winFormDisciplineAdd.ShowDialog();
    }


    private void ButtonStudenDisciplines_Click(
        object sender, EventArgs e)
    {
        StudentDiscipline winFormStudentDiscipline = new();
        winFormStudentDiscipline.ShowDialog();
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

    private void menuStrip1_ItemClicked(object sender,
        ToolStripItemClickedEventArgs e)
    {
    }


    #region Form1_WindowsStateControl

    /*
     * 
     * https://social.msdn.microsoft.com/Forums/windows/en-US/c5080938-af0c-4a16-a5bb-49bd8d14b7ba/how-do-i-maximize-my-form-on-startup-c?forum=winforms
     * 
     */


    public void MainWinFormWindowsStateControl()
    {
        FormClosing += MainWinForm_FormClosing;
        LocationChanged += MainWinForm_LocationChanged;
        Resize += MainWinForm_Resize;


        StartPosition = FormStartPosition.Manual;
        Location = WFormSettings.Default.MainWinFormLocation;
        WindowState = WFormSettings.Default.MainWinFormLocationState;

        /*
         *
        public global::System.Windows.Forms.FormWindowState MainWinFormLocationState {
            get {
                return ((global::System.Windows.Forms.FormWindowState)(this["MainWinFormLocationState"]));
            }
            set {
                this["MainWinFormLocationState"] = value;
            }
         *
         * 
         */

        if (WindowState == FormWindowState.Normal)
            Size = WFormSettings.Default.MainWinFormSize;
    }


    private void MainWinForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        WFormSettings.Default.Save();
    }

    private void MainWinForm_Resize(object sender, EventArgs e)
    {
        WFormSettings.Default.MainWinFormLocationState =
            WindowState;
        if (WindowState == FormWindowState.Normal)
            WFormSettings.Default.MainWinFormSize = Size;
    }

    private void MainWinForm_LocationChanged(object sender, EventArgs e)
    {
        if (WindowState == FormWindowState.Normal)
            WFormSettings.Default.MainWinFormLocation = Location;
    }

    #endregion
}