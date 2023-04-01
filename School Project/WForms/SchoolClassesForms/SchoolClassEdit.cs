using ClassLibrary;

namespace School_Project.WForms.SchoolClassesForms;

public partial class SchoolClassEdit : Form
{
    private readonly BindingSource _bSListCourses = new();
    private readonly BindingSource _bSListSClasses = new();
    private readonly BindingSource _bSListStudents = new();

    //
    // Global variables to be used in this windows form
    // Variáveis globais do formulário do Windows
    //
    private readonly SchoolClass _schoolClassToEdit;


    public SchoolClassEdit(SchoolClass schoolClassForEditing)
    {
        InitializeComponent();

        // assigning the parent variable to
        // the local variables to be edited
        _schoolClassToEdit = schoolClassForEditing;
    }


    private void WinFormStudentEdit_Load(object sender, EventArgs e)
    {
        //
        // inserir os dados nas caixas de textos
        //
        numericUpDownSchoolClassID.Value =
            _schoolClassToEdit.IdSchoolClass;
        textBoxSchoolClassAcronym.Text = _schoolClassToEdit.ClassAcronym;
        textBoxSchoolClassName.Text = _schoolClassToEdit.ClassName;

        numericUpDownTotalNumberEnrolledStudents.Value =
            _schoolClassToEdit.GetStudentsCount();
        numericUpDownWorkingHours.Value = _schoolClassToEdit.GetWorkHourLoad();
        numericUpDownTotalCourses.Value = _schoolClassToEdit.GetCoursesCount();

        dateTimePickerBeginCourse.Value =
            _schoolClassToEdit.StartDate.ToDateTime(
                TimeOnly.FromDateTime(DateTime.Now));
        dateTimePickerEndCourse.Value =
            _schoolClassToEdit.EndDate.ToDateTime(
                TimeOnly.FromDateTime(DateTime.Now));

        dateTimePickerBeginHour.Value =
            _schoolClassToEdit.StartDate.ToDateTime(
                _schoolClassToEdit.StartHour);
        dateTimePickerEndHour.Value =
            _schoolClassToEdit.EndDate.ToDateTime(_schoolClassToEdit.EndHour);

        //
        // 
        // Data bindings
        // 
        //
        _bSListCourses.DataSource = Courses.ListCourses;
        _bSListSClasses.DataSource = SchoolClasses.ListSchoolClasses;
        _bSListStudents.DataSource = Students.ListStudents;

        //var scCoursesList = SchoolClasses.ConsultSchoolClasses;
        //_bSsClassesCourses.DataSource = scCoursesList;

        //var cStudentsList = Courses.ConsultCourse(1, "", 0, new List<Enrollment>());
        //_bSCoursesStudents.DataSource = SchoolClasses.ListSchoolClasses;


        //dataGridViewSchoolClasses.DataSource = _bSListSClasses;

        checkedListBoxCourses.DataSource = _bSListCourses;
        checkedListBoxCourses.DisplayMember = "Name";
        checkedListBoxCourses.DisplayMember = "FullName";
        checkedListBoxCourses.ValueMember = "IdCourse";

        checkedListBoxStudents.DataSource = _bSListStudents;
        checkedListBoxStudents.DisplayMember = "Name";
        checkedListBoxStudents.DisplayMember = "FullName";
        checkedListBoxStudents.ValueMember = "IdStudent";

        // *
        // * 
        // * date and time picker adjustments
        // * 
        // *
        dateTimePickerBeginHour.Format = DateTimePickerFormat.Custom;
        dateTimePickerBeginHour.CustomFormat = "HH:mm";
        dateTimePickerBeginHour.ShowUpDown = true;

        dateTimePickerEndHour.Format = DateTimePickerFormat.Custom;
        dateTimePickerEndHour.CustomFormat = "HH:mm";
        dateTimePickerEndHour.ShowUpDown = true;

        //
        //
        //
        UpdateSelectedSchoolClass();
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
            MessageBox.Show("Tecla V, via e.KeyCode");
         */

        //if (e.Modifiers == Keys.Control && e.KeyCode == Keys.V)
        if (e is not { Modifiers: Keys.Control, KeyCode: Keys.V }) return;

        ((TextBox)sender).Paste();
        Console.WriteLine("Testes de Debug");
    }


    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void ButtonSave_Click(object sender, EventArgs e)
    {
        if (ValidateTextBoxes())
        {
            //
            // inserir os dados das caixas
            //
            _schoolClassToEdit.ClassAcronym = textBoxSchoolClassAcronym.Text;
            _schoolClassToEdit.ClassName = textBoxSchoolClassName.Text;

            //_schoolClassToEdit.IdSchoolClass=numericUpDownSchoolClassID.Value;
            _schoolClassToEdit.ClassAcronym = textBoxSchoolClassAcronym.Text;
            _schoolClassToEdit.ClassName = textBoxSchoolClassName.Text;

            //numericUpDownTotalNumberEnrolledStudents.Value = _schoolClassToEdit.GetStudentsCount();
            //numericUpDownWorkingHours.Value = _schoolClassToEdit.GetWorkHourLoad();
            //numericUpDownTotalCourses.Value = _schoolClassToEdit.GetCoursesCount();

            _schoolClassToEdit.StartDate =
                DateOnly.FromDateTime(dateTimePickerBeginCourse.Value);
            _schoolClassToEdit.EndDate =
                DateOnly.FromDateTime(dateTimePickerEndCourse.Value);

            _schoolClassToEdit.StartHour =
                TimeOnly.FromDateTime(dateTimePickerBeginHour.Value);
            _schoolClassToEdit.EndHour =
                TimeOnly.FromDateTime(dateTimePickerEndHour.Value);

            Close();
        }
    }


    private bool ValidateTextBoxes()
    {
        // variable to validate the text-boxes and send a boolean if this function gets a valid
        var valid = true;

        if (
            string.IsNullOrEmpty(textBoxSchoolClassAcronym.Text) ||
            string.IsNullOrWhiteSpace(textBoxSchoolClassAcronym.Text))
        {
            MessageBox.Show(
                "Insira o Nome",
                "Nome",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxSchoolClassAcronym.Focus();
            valid = false;
        }


        if (
            string.IsNullOrEmpty(textBoxSchoolClassName.Text) ||
            string.IsNullOrWhiteSpace(textBoxSchoolClassName.Text))
        {
            MessageBox.Show(
                "Insira o apelido do estudante",
                "Apelido do Estudante",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            labelStudentLastName.Focus();
            valid = false;
        }

        return valid;
    }


    private void ButtonAddCourses_Click(object sender, EventArgs e)
    {
        //
        //
        // cast the selected object to be displayed in the dialog box
        // check what was selected, row or cell.
        // 
        //
        /*
        var schoolClassToEditByRow = dataGridViewSchoolClasses.SelectedRows;
        var schoolClassToEditByCell = dataGridViewSchoolClasses.SelectedCells;
        var schoolClassToEdit = -1;

        if (schoolClassToEditByRow.Count > 0 &&
            schoolClassToEditByRow != null)
        {
            schoolClassToEdit = schoolClassToEditByRow[0].Index;
        }
        else if (schoolClassToEditByCell.Count > 0 &&
                 schoolClassToEditByCell != null)
        {
            schoolClassToEdit = schoolClassToEditByCell[0].RowIndex;
        }
        else
        {
            MessageBox.Show(
                "Ainda não tem uma turma criada por isso não pode adicionar disciplina(s), nem estudante(s)",
                "Adicionar / remover disciplina(s)",
                MessageBoxButtons.OK, MessageBoxIcon.Error
            );
            return;
        }

        if (schoolClassToEdit == -1)
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Adicionar ou Remover",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }
        */

        if (checkedListBoxCourses.CheckedItems.Count == 0)
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
        MessageBox.Show("Temos disciplinas para adicionar, vamos lá.");


        //
        // cycle to evaluate which coursesList are select and add it
        //
        List<Course> newCoursesList = new();

        foreach (var a in Courses.ListCourses)
            foreach (var t in checkedListBoxCourses.CheckedItems)
                if (t is Course toVerify && a.IdCourse == toVerify.IdCourse)
                    newCoursesList.Add(toVerify);

        //
        // debugging
        //
        var nova =
            "Disciplinas selecionadas " +
            $"{newCoursesList.Count}\n";
        nova = newCoursesList.Aggregate(
            nova, (current, item) =>
                current +
                string.Concat(values: $"{item.IdCourse} - {item.Name}\n"));
        MessageBox.Show(nova);


        //
        // adding the new list to the class
        //
        _schoolClassToEdit.CoursesList = newCoursesList;

        Console.WriteLine("Testes de Debug");

        SchoolClasses.ToObtainValuesForCalculatedFields();

        //UpdateLists();
    }


    private void UpdateSelectedSchoolClass()
    {
        /*
        // Check if the row index has changed
        if (dataGridViewSchoolClasses.CurrentCell == null ||
            dataGridViewSchoolClasses.CurrentCell.RowIndex ==
            _previousRowIndex) return;
        */

        // Get the selected school class from the data source
        //var selectedSchoolClass = (SchoolClass) _bSListSClasses.Current;

        // Get the courses for the selected school class from the data source
        var selectedSchoolClassCourses = _schoolClassToEdit.CoursesList;

        // Set the checked items in the checkedListBoxCourses control
        for (var i = 0; i < checkedListBoxCourses.Items.Count; i++)
        {
            var course = (Course)checkedListBoxCourses.Items[i];
            checkedListBoxCourses.SetItemChecked(i,
                selectedSchoolClassCourses.Contains(course));
        }

        // Update the previous row index
        //_previousRowIndex = dataGridViewSchoolClasses.CurrentCell.RowIndex;
    }
}