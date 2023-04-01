using ClassLibrary;
using School_Project.WForms.CoursesForms;
using School_Project.WForms.SchoolClassesForms;
using School_Project.WForms.StatisticsForms;
using School_Project.WForms.StudentsForms;
using System.Globalization;

namespace School_Project.WForms.InitialForms;

public partial class InitialWinForm : Form
{
    private bool _closeFromUser;
    private SchoolContext _context;
    private CultureInfo _culture = CultureInfo.InvariantCulture;


    //
    // Global Properties for the windows forms
    // to store the data into a list of class
    //

    public InitialWinForm()
    {
        InitializeComponent();
    }


    private void WinFormInitial_Load(object sender, EventArgs e)
    {
        var xFilesMessages = XFiles.ReadFromFiles();
        MessageBox.Show(
            "Esta é a mensagem que chegou do XFiles!\n\n" + xFilesMessages,
            "Ler ficheiros");

        _context = new SchoolContext();
        //_context.Database.EnsureCreated();

        ChangeImageInButtons();
    }

    private void ChangeImageInButtons()
    {
        //
        // original code
        //
        //buttonSchoolClass.Image = Resources.Icon_chalkboard_32x32;
        //buttonTeachers.Image = Resources.Icon_id_card_32x32;
        //buttonStudent.Image = Resources.Icon_graduate_32x32;
        //buttonDiscipline.Image = Resources.Icon_book_green_32x32;
        //buttonStudenDisciplines.Image = Resources.Icon_address_card_64x64;
        //buttonCharts.Image = Resources.Icon_bar_chart_32x32;
        //buttonListagens.Image = Resources.Icon_printer_32x32;
        //buttonCloseProgram.Image = Resources.Icon_doughnut_chart_32x32;
        //pictureBox1.Image = Resources.escolaweb_capas_artigos_2_software_de_gestao_escolar_vantagens_para_todos_os_formatos_de_instituicoes_1;
        //pictureBox1.Image = Resources.Students_watching_webinar;
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
        MessageBox.Show("Falta implementar código");
        //Console.WriteLine("Falta implementar código");

        Console.WriteLine("Código implementado");

        SchoolClassAdd schoolClassAdd = new();
        Hide();
        schoolClassAdd.ShowDialog();
        schoolClassAdd.Dispose();
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

    private void buttonAbout_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Falta implementar código");
        Console.WriteLine("Falta implementar código");

        //ChartWpfWindow chartWpfWindow = new();
        Hide();
        //chartWpfWindow.ShowDialog();
        //chartWpfWindow.Close();
        Show();
    }


    private void ButtonCloseProgram_Click(object sender, EventArgs e)
    {
        var xFilesMessages = XFiles.StoreInFiles();
        MessageBox.Show(
            "Esta é a mensagem que chegou do XFiles!\n\n" + xFilesMessages,
            "Gravar ficheiros");

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