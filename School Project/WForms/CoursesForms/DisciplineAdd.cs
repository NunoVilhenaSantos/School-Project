using ClassLibrary;
using School_Project.WForms.SchoolClassesForms;
using System.Reflection;

namespace School_Project.WForms.CoursesForms;

public partial class DisciplineAdd : Form
{
    private readonly BindingSource _bSCoursesStudents = new();
    private readonly BindingSource _bSListCourses = new();
    private readonly BindingSource _bSListStudents = new();
    private readonly BindingSource _bSourceSearchList = new();
    private readonly BindingSource _bSourceSearchOptions = new();
    private readonly BindingSource _bSsClassesCourses = new();

    private int _disciplinesCount;

    private int _coursesCount;
    private string _photoFile;

    // keep track of the DataGridViewSchoolClasses row index previousRowIndex
    private int _previousRowIndex = -1;
    private int _schoolClassesCount;
    private int _studentsCount;


    public DisciplineAdd()
    {
        InitializeComponent();

        //
        // assign the local variables to is counterpart
        // Global variables from the initial form
        //
    }


    private void ButtonExit_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void DisciplineAdd_Load(object sender, EventArgs e)
    {
        //
        // assign the local variables to is counterpart
        // Global variables from the initial form
        //
        if (Courses.ListCourses.Count > 0)
        {
            _disciplinesCount = Courses.ListCourses.Count;
            _disciplinesCount = Courses.GetLastId();
        }
        //
        // 
        // assign the local variables to is
        // counterpart Global variables from the initial form
        // 
        //
        if (Courses.ListCourses.Count > 0)
            _coursesCount = Courses.GetLastId();

        if (SchoolClasses.ListSchoolClasses.Count > 0)
            _schoolClassesCount = SchoolClasses.GetLastId();

        if (Students.ListStudents.Count > 0)
            _studentsCount = Students.GetLastId();

        SchoolClasses.ToObtainValuesForCalculatedFields();


        //
        // make the transparent tab-control transparent
        // transparentTabControl1.MakeTransparent();
        //
        transparentTabControl1.MakeTransparent();

        //
        // initial update
        // count register and the list
        //
        UpdateLists();
        UpdateLabelsCounts();
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
        if (e is { Modifiers: Keys.Control, KeyCode: Keys.V })
        {
            ((TextBox)sender).Paste();
            Console.WriteLine("Testes de Debug");
        }
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        if (!ValidateTextBoxes()) return;

        Courses.AddCourse(
            (int)numericUpDownDisciplineID.Value,
            textBoxDisciplineName.Text,
            (int)numericUpDownNumberHours.Value,
            0, null
        );

        //
        // initial update
        // count register and the list
        //
        UpdateLists();
        UpdateLabelsCounts();
        CleanTextBoxes();
    }


    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        CleanTextBoxes();
    }


    private void CleanTextBoxes()
    {
        // clean the text a put an value of zero in the numeric box
        textBoxDisciplineName.Clear();
        numericUpDownNumberHours.Value = 0;
    }


    private void UpdateLists()
    {
        //
        // list box has a problem
        //
        // that's why it is necessary to clear the list with a null and
        // then re-associate the class again and that's how it works.
        //
        listBoxDisciplines.DataSource = null;
        listBoxDisciplines.DataSource = Courses.ListCourses;
        //
        // activate this option if you want a specific value else it will use the override method to string
        //listBoxDisciplines.DisplayMember = "Name";
        listBoxDisciplines.ClearSelected();

        // *
        // * 
        // * Data bindings
        // * 
        // *
        _bSListCourses.DataSource = Courses.ListCourses;
        _bSListStudents.DataSource = Students.ListStudents;

        _bSListCourses.ResetBindings(false);
        _bSListStudents.ResetBindings(false);

        _bSListCourses.ResetBindings(true);
        _bSListStudents.ResetBindings(true);

        // Set the DataSource property of the DataGridView to the BindingSource object
        dataGridViewCourses.DataSource = _bSListCourses;

        // Set the AutoGenerateColumns property of the DataGridView to true
        dataGridViewCourses.AutoGenerateColumns = true;

        // Set the BackgroundColor property of the DataGridView to Color.Transparent
        // this cant be used because gives an error
        //dataGridViewSchoolClasses.BackgroundColor = Color.Transparent;
        dataGridViewCourses.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridViewSearch.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;


        checkedListBoxStudents.DataSource = _bSListStudents;
        checkedListBoxStudents.DisplayMember = "Name";
        checkedListBoxStudents.DisplayMember = "FullName";
        checkedListBoxStudents.ValueMember = "IdStudent";


        // Update the data source of the dataGridViewSchoolClasses control
        dataGridViewCourses.Refresh();


        // To display all the properties of the Student class
        // in the comboBoxSearchOptions,
        // you can use reflection to get a list
        // of the property names and set the DataSource
        // and DisplayMember properties of the combobox accordingly.
        // Here's an example code snippet to achieve this:

        _bSourceSearchOptions.DataSource = typeof(Course);
        var properties =
            typeof(Course).GetProperties(BindingFlags.Public |
                                              BindingFlags.Instance);

        List<string> propertyNames = new();
        foreach (var property in properties) propertyNames.Add(property.Name);

        comboBoxSearchOptions.DataSource = propertyNames;
        comboBoxSearchOptions.DisplayMember = "ToString()";


        //_bSourceSearchList.DataSource = Students.ConsultStudent;
        comboBoxSearchList.DataSource = _bSourceSearchList;
        dataGridViewSearch.DataSource = _bSourceSearchList;
        dataGridViewSearch.AutoResizeColumns();

        _bSourceSearchOptions.ResetBindings(false);
        _bSourceSearchList.ResetBindings(false);

        _bSourceSearchOptions.ResetBindings(true);
        _bSourceSearchList.ResetBindings(true);

        dataGridViewSearch.Refresh();
        dataGridViewSearch.Update();


        Console.WriteLine("Testes de Debug");
    }



    private void ComboBoxSearchOptions_SelectedIndexChanged(
        object sender, EventArgs e)
    {
        // Get the name of the selected property
        var selectedProperty = comboBoxSearchOptions.SelectedItem.ToString();

        // Create a new list to store the filtered results
        List<Course> filteredCourse = new();

        var property = typeof(Course).GetProperty(selectedProperty);
        foreach (var course in Courses.ListCourses)
        {
            if (property == null ||
                property.GetValue(course).ToString() == "")
                continue;

            filteredCourse.Add(course);
        }

        _bSourceSearchList.DataSource = filteredCourse;

        comboBoxSearchList.Refresh();
        dataGridViewSearch.Refresh();
    }



    private void UpdateLabelsCounts()
    {
        _disciplinesCount++;
        numericUpDownDisciplineID.Value = _disciplinesCount;
    }


    private bool ValidateTextBoxes()
    {
        var valid = true;


        if (string.IsNullOrEmpty(textBoxDisciplineName.Text) ||
            string.IsNullOrWhiteSpace(textBoxDisciplineName.Text))
        {
            MessageBox.Show(
                "Insira um nome valido", "Disciplina",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            valid = false;
            textBoxDisciplineName.Select();
        }


        if (numericUpDownNumberHours.Value == 0)
        {
            MessageBox.Show(
                "Insira um valor válido", "Carga horária",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            valid = false;
            numericUpDownNumberHours.Select();
        }

        return valid;
    }


    private void ButtonRemove_Click(object sender, EventArgs e)
    {
        //
        // cast the selected object to be displayed in the dialog box
        //
        var disciplineToDelete = listBoxDisciplines.SelectedItem as Course;

        if (listBoxDisciplines.SelectedItem != null)
        {
            //
            // local variable that will contain the response
            //

            var dialogResult =
                //
                // get the answer, if yes or soups, displaying the message
                //
                MessageBox.Show(
                    "Remover o curso " + $"{disciplineToDelete}",
                    "Apagar",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                );

            if (dialogResult == DialogResult.OK)
            {
                var index = listBoxDisciplines.SelectedIndex;

                Courses.DeleteCourse(index);
                UpdateLists();
            }
        }
        else
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Apagar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
        }

        UpdateLists();
        Console.WriteLine("Testes de Debug");
    }


    private void ButtonEdit_Click(object sender, EventArgs e)
    {
        //
        // cast the selected object to be displayed in the dialog box
        //
        var disciplineToEdit = listBoxDisciplines.SelectedItem! as Course;

        if (disciplineToEdit != null)
        {
            //
            // open the edit form with the student editing
            //
            DisciplineEdit disciplineEdit = new(disciplineToEdit.IdCourse);
            disciplineEdit.ShowDialog();
        }
        else
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ", "Editar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
        }

        UpdateLists();
    }


    private void DataGridViewCourses_CellEnter(
        object sender, DataGridViewCellEventArgs e)
    {
        UpdateSelectedCourse();
    }

    private void DataGridViewCourses_Scroll(
        object sender, ScrollEventArgs e)
    {
        // If the scroll event is for scrolling the vertical bar, update the selected school class
        if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            UpdateSelectedCourse();
    }


    private void UpdateSelectedCourse()
    {
        // Check if the row index has changed
        if (dataGridViewCourses.CurrentCell == null ||
            dataGridViewCourses.CurrentCell.RowIndex ==
            _previousRowIndex) return;

        // Get the selected course from the data source
        var selectedCourse = (Course)_bSListCourses.Current;

        // Get the students for the selected course from the data source
        var selectedCoursesEnrollmentsStudents = Enrollments.ListEnrollments.Where(x => x.CourseId == selectedCourse.IdCourse).Select(e => e.Student).ToList();
        var selectedCourseEnrollments = Enrollments.ListEnrollments.Where(x => x.CourseId == selectedCourse.IdCourse).ToList();
        var selectedCourseStudents = selectedCourseEnrollments.Select(e => e.Student).ToList();

        if (selectedCourseStudents == null)
        {
            checkedListBoxStudents.Invalidate();
            return;
        }

        // Set the checked items in the checkedListBoxStudents control
        for (var i = 0; i < checkedListBoxStudents.Items.Count; i++)
        {
            var student = (Student)checkedListBoxStudents.Items[i];
            checkedListBoxStudents.SetItemChecked(i,
                selectedCourseStudents.Contains(student));
        }

        // Update the previous row index
        _previousRowIndex = dataGridViewCourses.CurrentCell.RowIndex;
    }


    private void ButtonNew_Click(object sender, EventArgs e)
    {
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[0];
        textBoxDisciplineName.Focus();
    }


    private void ButtonSearch_Click(object sender, EventArgs e)
    {
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[2];
    }


    private void TransparentTabControl1_SelectedIndexChanged(
        object sender, EventArgs e)
    {
        if (transparentTabControl1.SelectedTab ==
            transparentTabControl1.TabPages[0])
        {
            comboBoxSearchList.Visible = false;
            comboBoxSearchOptions.Visible = false;
            buttonAddStudents.Visible = false;
            //buttonAddStudent.Visible = false;
        }
        else if (transparentTabControl1.SelectedTab ==
                 transparentTabControl1.TabPages[1])
        {
            comboBoxSearchList.Visible = false;
            comboBoxSearchOptions.Visible = false;
            buttonAddStudents.Visible = true;
            //buttonAddStudent.Visible = true;
        }
        else if (transparentTabControl1.SelectedTab ==
                 transparentTabControl1.TabPages[2])
        {
            comboBoxSearchList.Visible = true;
            comboBoxSearchOptions.Visible = true;
            buttonAddStudents.Visible = false;
            //buttonAddStudent.Visible = false;
        }
        else if (transparentTabControl1.SelectedTab ==
                 transparentTabControl1.TabPages[3])
        {
            comboBoxSearchList.Visible = true;
            comboBoxSearchOptions.Visible = true;
            buttonAddStudents.Visible = false;
            //buttonAddStudent.Visible = false;
        }

    }

    private void TransparentTabControl1_TabIndexChanged(
        object sender, EventArgs e)
    {
        TransparentTabControl1_SelectedIndexChanged(sender, e);
    }

    private void ButtonSearchForm_Click(object sender, EventArgs e)
    {
        SchoolClassSearch schoolClassSearch = new();
        schoolClassSearch.ShowDialog();
        schoolClassSearch.Dispose();
    }






    private void ButtonAddEnrollments_Click(object sender, EventArgs e)
    {
        //
        //
        // cast the selected object to be displayed in the dialog box
        // check what was selected, row or cell.
        // 
        //
        var courseToEditByRow = dataGridViewCourses.SelectedRows;
        var courseToEditByCell = dataGridViewCourses.SelectedCells;
        var courseToEdit = -1;

        if (courseToEditByRow.Count > 0 &&
            courseToEditByRow != null)
        {
            courseToEdit = courseToEditByRow[0].Index;
        }
        else if (courseToEditByCell.Count > 0 &&
                 courseToEditByCell != null)
        {
            courseToEdit = courseToEditByCell[0].RowIndex;
        }
        else
        {
            MessageBox.Show(
                "Ainda não tem uma disciplina criada por isso não pode adicionar estudante(s)",
                "Adicionar ou Remover",
                MessageBoxButtons.OK, MessageBoxIcon.Error
            );
            return;
        }

        if (courseToEdit == -1)
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Adicionar ou Remover",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        if (checkedListBoxStudents.CheckedItems.Count == 0)
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Adicionar ou Remover",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        //
        // open the edit form with the studentForValidation editing
        //
        MessageBox.Show("Temos estudante(s) para adicionar, vamos lá.");
        var courseToAdd = (Course)_bSListCourses.Current; ;

        //
        // cycle to evaluate which student(s) are select and add it
        //
        List<Enrollment> newEnrollmentList = new();

        foreach (var a in Students.ListStudents)
            foreach (var t in checkedListBoxStudents.CheckedItems)
                if (t is Student toVerify && a.IdStudent == toVerify.IdStudent)
                {
                    newEnrollmentList.Add(
                        new Enrollment
                        {
                            Grade = null,
                            StudentId = toVerify.IdStudent,
                            Student = toVerify,
                            CourseId = courseToAdd.IdCourse,
                            Course = courseToAdd,
                        }
                        );
                    Enrollments.AddEnrollment(toVerify.IdStudent, courseToAdd.IdCourse);
                }

        //
        // debugging
        //
        var nova =
            "Disciplinas selecionadas " +
            $"{newEnrollmentList.Count}\n";
        nova = newEnrollmentList.Aggregate(
            nova, (current, item) =>
                current + string.Concat(
                    values:
                    $"{item.StudentId} - {item.Student.Name}|" +
                    $"{item.CourseId} - {item.Course.Name}\n")
                );
        MessageBox.Show(nova);


        //
        // adding the new list to the class
        //
        //Enrollments.ListEnrollments[courseToEdit].CoursesList = newEnrollmentList;

        //dataGridViewSchoolClasses.InvalidateRow(_previousRowIndex);
        //dataGridViewSchoolClasses.InvalidateRow(courseToEdit);

        SchoolClasses.ToObtainValuesForCalculatedFields();

        UpdateLists();

        Console.WriteLine("Testes de Debug");
    }






}