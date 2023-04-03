using ClassLibrary.Students;

namespace School_Project.WForms.StudentsForms;

public partial class StudentForm : Form
{
    private readonly BindingSource _bindingSource = new();

    public StudentForm()
    {
        InitializeComponent();

        _bindingSource.DataSource = Students.ListStudents;
    }
}