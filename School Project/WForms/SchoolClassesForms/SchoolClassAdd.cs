using ClassLibrary;

namespace School_Project.WForms.SchoolClassesForms;

public partial class SchoolClassAdd : Form
{
    private readonly BindingSource _bSCoursesStudents = new();
    private readonly BindingSource _bSListCourses = new();

    //
    // Global variables for the windows forms
    //
    private readonly BindingSource _bSListSClasses = new();
    private readonly BindingSource _bSListStudents = new();
    private readonly BindingSource _bSsClassesCourses = new();

    private int _coursesCount;


    // keep track of the DataGridViewSchoolClasses row index previousRowIndex
    private int _previousRowIndex = -1;
    private int _schoolClassesCount;
    private int _studentsCount;


    public SchoolClassAdd()
    {
        InitializeComponent();
    }

    private void WinFormStudentAdd_Load(object sender, EventArgs e)
    {
        /*
         * 
         * assign the local variables to is
         * counterpart Global variables from the initial form
         * 
         */
        if (Courses.ListCourses.Count > 0)
            _coursesCount = Courses.GetLastId();

        if (SchoolClasses.ListSchoolClasses.Count > 0)
            _schoolClassesCount = SchoolClasses.GetLastId();

        if (Students.ListStudents.Count > 0)
            _studentsCount = Students.GetLastId();

        SchoolClasses.ToObtainValuesForCalculatedFields();

        /*
         * 
         * date and time picker adjustments
         * 
         */
        //DateTimePicker timePicker = new DateTimePicker();
        dateTimePickerBeginHour.Format = DateTimePickerFormat.Custom;
        dateTimePickerBeginHour.CustomFormat = "HH:mm";
        dateTimePickerBeginHour.ShowUpDown = true;

        dateTimePickerEndHour.Format = DateTimePickerFormat.Custom;
        dateTimePickerEndHour.CustomFormat = "HH:mm";
        dateTimePickerEndHour.ShowUpDown = true;

        dateTimePickerEndCourse.Value =
            dateTimePickerEndCourse.Value.AddMonths(12);
        dateTimePickerBeginHour.Value = DateTime.Today.AddHours(19);
        dateTimePickerEndHour.Value = dateTimePickerBeginHour.Value.AddHours(4);


        //
        // * 
        // * https://stackoverflow.com/questions/6777268/using-datasource-with-checkboxlist
        // * 
        // * 
        // *
        //
        // You can find answer here: Using data-source with CheckBoxList
        //
        //ListBox checkBoxList = MyCheckBoxList;
        //checkBoxList.DataSource = bSListStudents;
        //checkBoxList.DisplayMember = "name";
        //checkBoxList.ValueMember = "enabled";


        //
        // initial update
        // count register and the list
        //
        UpdateLists();
        UpdateLabelsCounts();
        //groupBoxAddSchollClass.ForeColor = Color.White;

        //
        // TransparentTabControl transparentTabControl1 = new();
        // transparentTabControl1.MakeTransparent();
        //
        transparentTabControl1.MakeTransparent();
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[1];
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
        //if (e is {Modifiers: Keys.Control, KeyCode: Keys.V})
        if (e is not {Modifiers: Keys.Control, KeyCode: Keys.V}) return;
        ((TextBox) sender).Paste();
        Console.WriteLine("Testes de Debug");
    }


    private void ButtonSave_Click(object sender, EventArgs e)
    {
        if (!ValidateTextBoxes()) return;
        SchoolClasses.AddSchoolClass(
            (int) numericUpDownSchoolClassID.Value,
            textBoxSchoolClassAcronym.Text,
            textBoxSchoolClassName.Text,
            DateOnly.FromDateTime(dateTimePickerBeginCourse.Value),
            DateOnly.FromDateTime(dateTimePickerEndCourse.Value),
            TimeOnly.FromDateTime(dateTimePickerBeginHour.Value),
            TimeOnly.FromDateTime(dateTimePickerEndHour.Value),
            "location:campos[8]",
            "type:campos[9]",
            "area:campos[10]",
            (int) numericUpDownTotalNumberEnrolledStudents.Value,
            null
        );


        //
        // initial update
        // count register and the list
        //
        UpdateLists();
        UpdateLabelsCounts();
        CleanTextBoxes();
    }


    private void CleanTextBoxes()
    {
        textBoxSchoolClassAcronym.Clear();
        textBoxSchoolClassName.Clear();
        //textBoxStudentPhone.Clear();
        //textBoxStudentAddress.Clear();
    }


    private void UpdateLists()
    {
        // *
        // * 
        // * Data bindings
        // * 
        // *
        _bSListCourses.DataSource = Courses.ListCourses;
        _bSListSClasses.DataSource = SchoolClasses.ListSchoolClasses;
        _bSListStudents.DataSource = Students.ListStudents;

        _bSListCourses.ResetBindings(false);
        _bSListSClasses.ResetBindings(false);
        _bSListStudents.ResetBindings(false);

        _bSListCourses.ResetBindings(true);
        _bSListStudents.ResetBindings(true);
        _bSListStudents.ResetBindings(true);

        // Set the DataSource property of the DataGridView to the BindingSource object
        dataGridViewSchoolClasses.DataSource = _bSListSClasses;

        // Set the AutoGenerateColumns property of the DataGridView to true
        dataGridViewSchoolClasses.AutoGenerateColumns = true;

        // Set the BackgroundColor property of the DataGridView to Color.Transparent
        // this cant be used because gives an error
        //dataGridViewSchoolClasses.BackgroundColor = Color.Transparent;
        dataGridViewSchoolClasses.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;

        checkedListBoxCourses.DataSource = _bSListCourses;
        checkedListBoxCourses.DisplayMember = "Name";
        checkedListBoxCourses.DisplayMember = "FullName";
        checkedListBoxCourses.ValueMember = "IdCourse";

        checkedListBoxStudents.DataSource = _bSListStudents;
        checkedListBoxStudents.DisplayMember = "Name";
        checkedListBoxStudents.DisplayMember = "FullName";
        checkedListBoxStudents.ValueMember = "IdStudent";


        // Update the data source of the dataGridViewSchoolClasses control
        dataGridViewSchoolClasses.Refresh();
        //dataGridViewSchoolClasses.Refresh();


        Console.WriteLine("Testes de Debug");
    }


    private void UpdateLabelsCounts()
    {
        _schoolClassesCount++;
        numericUpDownSchoolClassID.Value = _schoolClassesCount;
    }


    private bool ValidateTextBoxes()
    {
        if (
            string.IsNullOrEmpty(textBoxSchoolClassAcronym.Text) ||
            string.IsNullOrWhiteSpace(textBoxSchoolClassAcronym.Text))
        {
            MessageBox.Show(
                "Insira o Acrónimo da Turma",
                "Acrónimo da Turma",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxSchoolClassAcronym.Select();
            return false;
        }

        if (!string.IsNullOrEmpty(textBoxSchoolClassName.Text) &&
            !string.IsNullOrWhiteSpace(textBoxSchoolClassName.Text))
            return true;

        MessageBox.Show(
            "Insira o Nome da Turma",
            "Nome da Turma",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        labelStudentLastName.Select();
        return false;
    }


    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        CleanTextBoxes();
    }


    private void ButtonStudentRemove_Click(object sender, EventArgs e)
    {
        // by rows
        var rowText = string.Empty;
        // var to retain the value of the index, by row or cell
        var rc = -1;
        foreach (DataGridViewRow row in dataGridViewSchoolClasses.SelectedRows)
            //for find the row index number
            rc = dataGridViewSchoolClasses.CurrentCell.RowIndex;

        // by cells
        if (dataGridViewSchoolClasses.CurrentCell != null)
            //for find the row index number
            rc = dataGridViewSchoolClasses.CurrentCell.RowIndex;


        if (int.IsNegative(rc))
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Editar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        //
        // get the answer, if yes or soups, displaying the message
        //

        // Get the selected school class from the data source
        var selectedSchoolClass = (SchoolClass) _bSListSClasses.Current;

        // Get the IdSchoolClass from the selected school class from the data source
        var index = selectedSchoolClass.IdSchoolClass;

        // send a msg to the user to chose if he wants to delete or not the record
        var msg =
            "Tem a certeza que deseja apagar o seguinte registo?" +
            $"\n{SchoolClasses.GetFullInfo(index)}";

        var dialogResult = MessageBox.Show(
            msg, "Apagar",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);

        if (dialogResult == DialogResult.OK)
        {
            MessageBox.Show(SchoolClasses.DeleteSchoolClass(index));

            UpdateLists();
        }


        Console.WriteLine("Testes de Debug");
    }


    private void ButtonStudentEdit_Click(object sender, EventArgs e)
    {
        //try
        //{
        // Get the selected school class from the data source
        var selectedSchoolClass = (SchoolClass) _bSListSClasses.Current;

        if (selectedSchoolClass == null)
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Editar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        // Get the IdSchoolClass from the selected school class from the data source
        var index = selectedSchoolClass.IdSchoolClass;

        if (index < 0)
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Editar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        //
        // open the edit form with the studentForValidation editing
        //
        SchoolClassEdit schoolClassEdit =
            new(selectedSchoolClass);
        if (schoolClassEdit.ShowDialog() == DialogResult.OK)
            // redraw the list with the new data
            UpdateLists();
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show(
        //        $"Error editing school class object: {ex.Message}",
        //        "Editar",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error
        //    );
        //}
    }


    private void TextBoxNames_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (
            char.IsLetter(e.KeyChar) || // validating if its a letter
            char.IsSeparator(e.KeyChar) || // validating if its a separator
            char.IsWhiteSpace(e.KeyChar) || // validating if its a whitespace
            char.IsDigit(e.KeyChar) || // validating if its a digit
            e.KeyChar is (char) Keys.Back or '.' or '\'' or '-'
            // validating if its a backspace
            // validating if its a dot
            // validating if its an apostrophe
            // validating if its a separator
        )
            return;
        e.Handled = true;
    }


    private void TextBoxStudentPhone_KeyPress(
        object sender, KeyPressEventArgs e)
    {
        // validating paste (control + v)
        if (Keys.V.Equals(e.KeyChar) &&
            Keys.Control.Equals(e.KeyChar))
        {
            ((TextBox) sender).Paste();
            return;
        }

        // validating if its a digit
        if (char.IsDigit(e.KeyChar) || e.KeyChar == (char) Keys.Back) return;

        e.Handled = true;
    }


    private void ButtonAddStudents_Click(
        object sender, EventArgs e)
    {
        /*
         *
         * cast the selected object to be displayed in the dialog box
         * check what was selected, row or cell.
         * 
         */
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
                "Ainda não tem uma turma criada por isso não pode adicionar disciplinas, nem estudantes",
                "Adicionar / remover estudante(s)",
                MessageBoxButtons.OK, MessageBoxIcon.Error
            );
            return;
        }

        if (schoolClassToEdit == -1)
        {
            MessageBox.Show(
                "Selecione uma turma para poder adicionar o(s) estudante(s).",
                "Adicionar / remover estudante(s)",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        if (checkedListBoxCourses.CheckedItems.Count == 0)
        {
            MessageBox.Show(
                "Selecione uma disciplina para poder adicionar o(s) estudante(s).",
                "Adicionar / remover estudante(s)",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        if (checkedListBoxStudents.CheckedItems.Count == 0)
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Adicionar / remover estudante(s)",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        //
        // open the edit form with the studentForValidation editing
        //
        MessageBox.Show("Temos estudante(s), vamos lá.");

        //
        // cycle to evaluate which coursesList are select and add it
        //
        List<Student> newStudents = new();
        List<Course> newCourses = new();

        foreach (var s in Students.ListStudents)
        foreach (var v in checkedListBoxStudents.CheckedItems)
            if (v is Student verify && s.IdStudent == verify.IdStudent)
                newStudents.Add(verify);

        foreach (var c in Courses.ListCourses)
        foreach (var t in checkedListBoxCourses.CheckedItems)
            if (t is Course verify && c.IdCourse == verify.IdCourse)
                newCourses.Add(verify);


        //
        // adding the new list to the class
        //
        foreach (var student in newStudents)
        foreach (var course in newCourses)
            Enrollments.AddEnrollment(student.IdStudent, course.IdCourse);


        //
        // debugging
        //
        var nova =
            "Estudantes selecionados " +
            $"{newStudents.Count}\n";
        nova = newStudents.Aggregate(
            nova, (current, item) =>
                current + string.Concat(
                    values: $"{item.IdStudent} - {item.Name}\n"));
        MessageBox.Show(nova);

        Console.WriteLine("Testes de Debug");

        UpdateLists();
    }


    private void ButtonAddCourses_Click(object sender, EventArgs e)
    {
        //
        //
        // cast the selected object to be displayed in the dialog box
        // check what was selected, row or cell.
        // 
        //
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
                current + string.Concat(
                    values: $"{item.IdCourse} - {item.Name}\n"));
        MessageBox.Show(nova);


        //
        // adding the new list to the class
        //
        SchoolClasses.ListSchoolClasses[schoolClassToEdit].CoursesList =
            newCoursesList;

        dataGridViewSchoolClasses.InvalidateRow(_previousRowIndex);
        dataGridViewSchoolClasses.InvalidateRow(schoolClassToEdit);

        SchoolClasses.ToObtainValuesForCalculatedFields();

        UpdateLists();

        Console.WriteLine("Testes de Debug");
    }


    private void DataGridViewSchoolClasses_CellEnter(object sender,
        DataGridViewCellEventArgs e)
    {
        UpdateSelectedSchoolClass();
    }

    private void DataGridViewSchoolClasses_Scroll(object sender,
        ScrollEventArgs e)
    {
        // If the scroll event is for scrolling the vertical bar, update the selected school class
        if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            UpdateSelectedSchoolClass();
    }

    private void UpdateSelectedSchoolClass()
    {
        // Check if the row index has changed
        if (dataGridViewSchoolClasses.CurrentCell == null ||
            dataGridViewSchoolClasses.CurrentCell.RowIndex ==
            _previousRowIndex) return;

        // Get the selected school class from the data source
        var selectedSchoolClass = (SchoolClass) _bSListSClasses.Current;

        // Get the courses for the selected school class from the data source
        var selectedSchoolClassCourses = selectedSchoolClass.CoursesList;

        if (selectedSchoolClassCourses == null)
        {
            checkedListBoxCourses.Invalidate();
            return;
        }

        // Set the checked items in the checkedListBoxCourses control
        for (var i = 0; i < checkedListBoxCourses.Items.Count; i++)
        {
            var course = (Course) checkedListBoxCourses.Items[i];
            checkedListBoxCourses.SetItemChecked(i,
                selectedSchoolClassCourses.Contains(course));
        }

        // Update the previous row index
        _previousRowIndex = dataGridViewSchoolClasses.CurrentCell.RowIndex;
    }


    private void CheckedListBoxCourses_SelectedIndexChanged(
        object sender, EventArgs e)
    {
        var selectedRows = dataGridViewSchoolClasses.SelectedRows;
        if (selectedRows == null || selectedRows.Count == 0)
            // handle the case where no row is selected
            return;

        var selectedIndex = selectedRows[0].Index;
        if (selectedIndex < 0 ||
            selectedIndex >= SchoolClasses.ListSchoolClasses.Count)
            // handle the case where the selected index is out of range
            return;

        var courseToView = selectedRows[0];

        // the rest of the code that uses courseToView

        if (Courses.ListCourses == null) return;

        if (SchoolClasses.ListSchoolClasses == null ||
            SchoolClasses.ListSchoolClasses[courseToView.Index]
                .CoursesList == null) return;


        //
        // insert coursesList into the checked list-box
        //
        // checkedListBoxStudents.Items.Clear();
        //checkedListBoxStudents.Items.AddRange(Students.ListStudents.ToArray());


        foreach (
                var c in
                SchoolClasses.ListSchoolClasses[courseToView.Index]
                    .CoursesList)
            //
            // subtract 1 from the Courses list,
            // because the list starts at 1 and
            // all other objects start from 0
            //
            checkedListBoxStudents.SetItemChecked(c.IdCourse - 1, true);

        numericUpDownTotalNumberEnrolledStudents.Value =
            SchoolClasses
                .ListSchoolClasses[courseToView.Index]
                .GetStudentsCount();

        Console.WriteLine("Testes de Debug");
    }


    private void DataGridViewSchoolClasses_CellBeginEdit(
        object sender, DataGridViewCellCancelEventArgs e)
    {
        // Get the column index of the cell being edited
        var columnIndex = e.ColumnIndex;

        // Check if the column is read-only
        if (columnIndex is 0 or 2)
            // Cancel the edit operation for the read-only column
            e.Cancel = true;
    }

    private void ButtonExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ButtonNew_Click(object sender, EventArgs e)
    {
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[0];
        textBoxSchoolClassAcronym.Focus();
    }

    private void ButtonAddPhoto_Click(object sender, EventArgs e)
    {
        openFileDialog1.ShowDialog();
    }
}