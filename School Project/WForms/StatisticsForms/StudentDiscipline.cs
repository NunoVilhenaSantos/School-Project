using ClassLibrary.Courses;
using ClassLibrary.Enrollments;
using ClassLibrary.School;
using ClassLibrary.Students;
using School_Project.WForms.StudentsForms;

namespace School_Project.WForms.StatisticsForms;

public partial class StudentDiscipline : Form
{
    //
    // constructor
    //
    public StudentDiscipline()
    {
        InitializeComponent();
        _disciplinesCount = -1;
        _studentsCount = -1;
    }


    //
    /// <summary>
    ///     Form Loader for the form Students and Courses
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void WinFormStudentDiscipline_Load(object sender, EventArgs e)
    {
        //
        // assign the local variables to is counterpart Global variables from the initial form
        //
        if (Students.StudentsList.Count > 0)
            _studentsCount = Students.StudentsList[^1].IdStudent;

        if (Courses.CoursesList.Count > 0)
            _disciplinesCount = Courses.CoursesList[^1].IdCourse;

        //
        // initial update
        // count register and the list
        //
        UpdateLists();
    }


    private void WinForm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape) Close();
    }


    private void TextBox_KeyUp(object sender, KeyEventArgs e)
    {
        Console.WriteLine("Testes de Debug");
        /*
         * 
         * https://stackoverflow.com/questions/1876663/how-do-i-allow-ctrl-v-paste-on-a-winforms-textbox
         * 
         * The following code should help:
         * 
         * 
         */
        /*
         *
         * Tests done to discover the right combination
         * 
        if (e.KeyData == (Keys) (86 + 131072))
            MessageBox.Show(
                "Tecla Control + tecla V, via e.KeyData" +
                "\nif (e.KeyData == (Keys) (86+131072))");

        if (e.Modifiers == Keys.Control)
            MessageBox.Show("Tecla Control, via e.Modifiers ");

        if (e.KeyCode == Keys.V)
            MessageBox.Show("Tecla V");
         */

        //if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
        if (e is not {Modifiers: Keys.Control, KeyCode: Keys.V}) return;
        ((TextBox) sender).Paste();
        Console.WriteLine("Testes de Debug");
    }


    private void UpdateLists()
    {
        //
        // list box has a problem
        //
        // that's why it is necessary to clear the list with a null and
        // then re-associate the class again and that's how it works.
        //
        _bSourceListStudents = new BindingSource
        {
            Site = null,
            DataMember = null,
            DataSource = Students.StudentsList,
            Position = 0,
            RaiseListChangedEvents = true,
            Sort = null,
            AllowNew = false,
            Filter = null
        };

        _bindingSourceListCourses = new BindingSource
        {
            Site = null,
            DataMember = null,
            DataSource = Courses.CoursesList,
            Position = 0,
            RaiseListChangedEvents = true,
            Sort = null,
            AllowNew = false,
            Filter = null
        };

        _bSourceEnrollments = new BindingSource
        {
            Site = null,
            DataMember = null,
            DataSource = Enrollments.ListEnrollments,
            Position = 0,
            RaiseListChangedEvents = true,
            Sort = null,
            AllowNew = false,
            Filter = null
        };


        //
        // checked list-box
        //
        checkedListBoxDisciplines.DataSource = _bindingSourceListCourses;
        //checkedListBoxDisciplines.Items.Clear();
        //checkedListBoxDisciplines.Items.AddRange(

        listBoxStudents.DataSource = _bSourceListStudents;
        // listBoxStudent.DisplayMember = "NomeCompleto";
        //listBoxStudents.SelectedItem = null;

        dataGridView1.DataSource = _bSourceEnrollments;
        // Set the second and third column to be read-only
        dataGridView1.Columns[2].ReadOnly =
            true; // Column 3 is index 2 (since column indexes are zero-based)
        dataGridView1.Columns[3].ReadOnly = true; // Column 4 is index 3

        // Alternatively, you can also refer to the columns by their names:
        dataGridView1.Columns["StudentId"].ReadOnly = true;
        dataGridView1.Columns["CourseId"].ReadOnly = true;

        dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;

        //
        // disabling the panel for the button's Remove and Edit
        //
        groupBoxStudentsList.Enabled = Students.GetLastId() != 0;
        groupBoxDisciplinesList.Enabled = Courses.GetLastId() != 0;

        Console.WriteLine("Testes de Debug");
    }


    private void ButtonStudentDisciplinesAdding_Click(
        object sender, EventArgs e)
    {
        var studentToEdit = (Student) listBoxStudents.SelectedItem;

        if (studentToEdit == null)
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Adicionar ou Remover",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        if (checkedListBoxDisciplines.CheckedItems.Count == 0)
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Adicionar ou Remover",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        MessageBox.Show("Temos disciplinas, vamos lá");

        //
        // cycle to evaluate which disciplines_temp are select and add it
        //
        SchoolDatabase.EnrollStudentInCourses(
            checkedListBoxDisciplines.CheckedItems
                .Cast<Course>()
                .ToList(),
            studentToEdit.IdStudent);

        Console.WriteLine("Debug point");


        foreach (var t in checkedListBoxDisciplines.CheckedItems)
        {
            var b = (Course) t;
            var c =
                Courses.CoursesList.FirstOrDefault(
                    a => a.IdCourse == b.IdCourse);
        }

        Console.WriteLine("Debug point");

        UpdateLists();

        Console.WriteLine("Testes de Debug");
    }


    private void ListBoxStudents_SelectedIndexChanged(
        object sender, EventArgs e)
    {
        if (Courses.CoursesList == null)
            return;

        var studentToView = (Student) _bSourceListStudents.Current;

        var studentCurses =
            SchoolDatabase.GetCoursesForStudent(studentToView.IdStudent);

        if (studentCurses == null)
        {
            //checkedListBoxDisciplines.Invalidate();
            return;
        }

        // Clear all checked items in the checkedListBoxCourses control
        foreach (int i in checkedListBoxDisciplines.CheckedIndices)
            checkedListBoxDisciplines.SetItemChecked(i, false);

        // Set the checked items in the checkedListBoxCourses control
        foreach (var index in
                 studentCurses
                     .Select(course =>
                         checkedListBoxDisciplines.Items.IndexOf(course))
                     .Where(index => index >= 0))
        {
            checkedListBoxDisciplines.SetItemChecked(index, true);
        }

        var studentEnrollments =
            Enrollments.ConsultEnrollment(-1, studentToView.IdStudent);

        _bSourceEnrollments.DataSource = studentEnrollments;
    }


    private void ButtonStudentRemove_Click(object sender, EventArgs e)
    {
        //
        // cast the selected object to be displayed in the dialog box
        //
        var studentToErase = listBoxStudents.SelectedItem as Student;
        studentToErase = (Student) _bSourceListStudents.Current;

        if (listBoxStudents.SelectedItem == null)
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Apagar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        //
        // get the answer, if yes or soups, displaying the message
        //
        var s =
            "Tem a certeza que deseja apagar o seguinte registo?\n" +
            $"{studentToErase.IdStudent} | " +
            $"{studentToErase.Name} {studentToErase.LastName}";

        var dialogResult =
            MessageBox.Show(
                s, "Apagar",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

        if (dialogResult == DialogResult.OK)
        {
            Students.DeleteStudent(studentToErase.IdStudent);
            UpdateLists();
        }


        Console.WriteLine("Testes de Debug");
    }


    private void ButtonStudentEdit_Click(object sender, EventArgs e)
    {
        //
        // cast the selected object to be displayed in the dialog box
        //
        var studentToEdit = listBoxStudents.SelectedItem as Student;

        // Get the selected school class from the data source
        studentToEdit = (Student) _bSourceListStudents.Current;

        if (listBoxStudents.SelectedItem != null)
        {
            //
            // open the edit form with the studentForValidation editing
            //
            if (studentToEdit != null)
            {
                StudentEdit winFormStudentEdit = new(studentToEdit);
                winFormStudentEdit.ShowDialog();
            }

            // redraw the list with the new data
            UpdateLists();
        }
        else
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Editar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
        }
    }

    #region Attributs

    //
    // Global variables for the windows forms
    //

    private int _disciplinesCount;
    private int _studentsCount;
    BindingSource _bSourceListStudents;
    BindingSource _bindingSourceListCourses;
    BindingSource _bSourceEnrollments;

    #endregion
}