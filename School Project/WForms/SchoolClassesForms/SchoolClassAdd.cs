using System.Drawing.Printing;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;
using ClassLibrary.Courses;
using ClassLibrary.School;
using ClassLibrary.SchoolClasses;
using ClassLibrary.Students;
using Serilog;

namespace School_Project.WForms.SchoolClassesForms;

public partial class SchoolClassAdd : Form
{
    private const int ItemsPerPage = 10;

    //
    // Global variables for the windows forms
    //
    private readonly BindingSource _bSCoursesStudents = new();
    private readonly BindingSource _bSListCourses = new();
    private readonly BindingSource _bSListSClasses = new();
    private readonly BindingSource _bSListStudents = new();
    private readonly BindingSource _bSourceSearchList = new();
    private readonly BindingSource _bSourceSearchOptions = new();
    private readonly BindingSource _bSsClassesCourses = new();

    private int _coursesCount;


    private int _currentPage = 1;
    private int _endIndex;
    private string _photoFile;

    // keep track of the DataGridViewSchoolClasses row index previousRowIndex
    private int _previousRowIndex = -1;
    private int _schoolClassesCount;
    private int _startIndex;
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
        if (Courses.CoursesList.Count > 0)
            _coursesCount = Courses.GetLastId();

        if (SchoolClasses.SchoolClassesList.Count > 0)
            _schoolClassesCount = SchoolClasses.GetLastId();

        if (Students.StudentsList.Count > 0)
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
        // TransparentTabControl transparentTabControl1 = new();
        // transparentTabControl1.MakeTransparent();
        //
        transparentTabControl1.MakeTransparent();
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[1];

        //
        // disable a few controls
        //
        //buttonSearch.Visible = false;
        //comboBoxSearchList.Visible = false;
        //comboBoxSearchOptions.Visible = false;

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
    }


    private void UpdateLists()
    {
        chart1.Series.Clear();
        chart1.Series.Add("Students Count");
        chart1.Series.Add("Courses Count");
        chart1.Series.Add("Work Hour Load");

        chart1.Series["Students Count"].ChartType = SeriesChartType.Column;
        chart1.Series["Courses Count"].ChartType = SeriesChartType.Line;
        chart1.Series["Work Hour Load"].ChartType = SeriesChartType.Line;

        foreach (var schoolClass in SchoolClasses.SchoolClassesList)
        {
            chart1.Series["Students Count"].Points.AddXY(schoolClass.ClassName,
                schoolClass.StudentsCount);
            chart1.Series["Courses Count"].Points.AddXY(schoolClass.ClassName,
                schoolClass.CoursesCount);
            chart1.Series["Work Hour Load"].Points.AddXY(schoolClass.ClassName,
                schoolClass.WorkHourLoad);
            chart1.Series["Courses Count"].BorderWidth = 3;
            chart1.Series["Work Hour Load"].BorderWidth = 3;
            //chart1.Series["Courses Count"].YAxisType = AxisType.Secondary;
            chart1.Series["Work Hour Load"].YAxisType = AxisType.Secondary;
        }

        chart1.DataBind();


        // *
        // * 1st 
        // * Data bindings
        // * 
        // *
        _bSListCourses.DataSource = Courses.CoursesList;
        _bSListSClasses.DataSource = SchoolClasses.SchoolClassesList;
        _bSListStudents.DataSource = Students.StudentsList;

        _bSListCourses.ResetBindings(false);
        _bSListSClasses.ResetBindings(false);
        _bSListStudents.ResetBindings(false);

        _bSListCourses.ResetBindings(true);
        _bSListSClasses.ResetBindings(true);
        _bSListStudents.ResetBindings(true);


        // *
        // * 2nd 
        // * checkedListBox
        // * must be add before the dataGridView 
        // *

        var query1 = Courses.CoursesList
            .ToList()
            .Select(q => new
            {
                FullName = q.Name + " " + q.Credits,
                FullInfo = q.IdCourse + q.Name + " " + q.Credits
            });
        checkedListBoxCourses.DataSource = _bSListCourses;
        //checkedListBoxCourses.DisplayMember = "Name";
        //checkedListBoxCourses.DisplayMember = "GetFullName()";
        //checkedListBoxCourses.DisplayMember = "GetFullInfo()";
        //checkedListBoxCourses.DisplayMember = "ToString()";
        //checkedListBoxCourses.ValueMember = "IdCourse";

        var query2 = Students.StudentsList
            .ToList()
            .Select(q => new
            {
                FullName = q.Name + " " + q.LastName,
                FullInfo = q.IdStudent + q.Name + " " + q.LastName
            });
        checkedListBoxStudents.DataSource = _bSListStudents;
        //checkedListBoxStudents.DisplayMember = "Name";
        //checkedListBoxStudents.DisplayMember = "LastName";
        //checkedListBoxStudents.DisplayMember = "GetFullName()";
        //checkedListBoxStudents.DisplayMember = "query2.FullName";
        //checkedListBoxStudents.DisplayMember = "ToString()";
        //checkedListBoxStudents.ValueMember = "IdStudent";


        // *
        // * 3rd 
        // * dataGridView
        // * must be add after the dataGridView 
        // *

        // Set the DataSource property of the DataGridView to the BindingSource object
        dataGridViewSchoolClasses.DataSource = _bSListSClasses;

        // Set the AutoGenerateColumns property of the DataGridView to true
        dataGridViewSchoolClasses.AutoGenerateColumns = true;

        // Set the BackgroundColor property of the DataGridView to Color.Transparent
        // this cant be used because gives an error
        //dataGridViewSchoolClasses.BackgroundColor = Color.Transparent;
        dataGridViewSchoolClasses.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridViewSearch.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;

        // Update the data source of the dataGridViewSchoolClasses control
        dataGridViewSchoolClasses.Refresh();


        // To display all the properties of the Student class
        // in the comboBoxSearchOptions,
        // you can use reflection to get a list
        // of the property names and set the DataSource
        // and DisplayMember properties of the combobox accordingly.
        // Here's an example code snippet to achieve this:

        _bSourceSearchOptions.DataSource = typeof(SchoolClass);
        var properties =
            typeof(SchoolClass).GetProperties(BindingFlags.Public |
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

        var property = typeof(SchoolClass)
            .GetProperty(selectedProperty ?? string.Empty);
        var filteredSchoolClass =
            SchoolClasses.SchoolClassesList
                .Where(
                    schoolClass => property != null &&
                                   property
                                       .GetValue(schoolClass)
                                       .ToString() != "").ToList();

        _bSourceSearchList.DataSource = filteredSchoolClass;

        comboBoxSearchList.Refresh();
        dataGridViewSearch.Refresh();
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
        // This will change the selected tab page of transparentTabControl1 to the second tab page. 
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[1];

        // by rows
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
        // This will change the selected tab page of transparentTabControl1 to the second tab page. 
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[1];

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
                "Ainda não tem uma turma criada por isso " +
                "não pode adicionar disciplinas, nem estudantes",
                "Adicionar / remover estudante(s)",
                MessageBoxButtons.OK, MessageBoxIcon.Error
            );
            return;
        }

        if (schoolClassToEdit == -1)
        {
            MessageBox.Show(
                "Selecione uma turma para poder " +
                "adicionar o(s) estudante(s).",
                "Adicionar / remover estudante(s)",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        if (checkedListBoxCourses.CheckedItems.Count == 0)
        {
            MessageBox.Show(
                "Selecione uma disciplina para poder " +
                "adicionar o(s) estudante(s).",
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

        // Get the selected course from the data source
        var selectedSchoolClass = (SchoolClass) _bSListSClasses.Current;

        //
        // cycle to evaluate which coursesList are select and add it
        //

        SchoolDatabase.EnrollStudentsInClass(
            checkedListBoxStudents.CheckedItems.Cast<Student>().ToList(),
            selectedSchoolClass.IdSchoolClass);
        SchoolDatabase.EnrollStudentsInCourses(
            checkedListBoxCourses.CheckedItems.Cast<Course>().ToList(),
            checkedListBoxStudents.CheckedItems.Cast<Student>().ToList());
        SchoolDatabase.AssignCoursesToClass(
            checkedListBoxCourses.CheckedItems.Cast<Course>().ToList(),
            selectedSchoolClass.IdSchoolClass);


        //
        // debugging
        //
        var nova =
            "Estudantes selecionados " +
            $"{checkedListBoxStudents.CheckedItems
                .Cast<Student>().ToList().Count}\n";
        nova = checkedListBoxStudents.CheckedItems
            .Cast<Student>().ToList().Aggregate(
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
                "Ainda não tem uma turma criada por isso não " +
                "pode adicionar disciplina(s), nem estudante(s)",
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
        SchoolDatabase.AssignCoursesToClass(
            checkedListBoxCourses.CheckedItems.Cast<Course>().ToList(),
            schoolClassToEdit);

        //
        // debugging
        //
        var nova =
            "Disciplinas selecionadas " +
            $"{checkedListBoxCourses.CheckedItems
                .Cast<Course>().ToList().Count}\n";
        nova = checkedListBoxCourses.CheckedItems
            .Cast<Course>().ToList().Aggregate(
                nova, (current, item) =>
                    current + string.Concat(
                        values: $"{item.IdCourse} - {item.Name}\n"));
        MessageBox.Show(nova);

        SchoolClasses.ToObtainValuesForCalculatedFields();

        UpdateLists();

        Console.WriteLine("Testes de Debug");
    }


    private void DataGridViewSchoolClasses_CellEnter(
        object sender, DataGridViewCellEventArgs e)
    {
        UpdateSelectedSchoolClass();
    }

    private void DataGridViewSchoolClasses_Scroll(
        object sender, ScrollEventArgs e)
    {
        // If the scroll event is for scrolling the vertical bar,
        // update the selected school class
        if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            UpdateSelectedSchoolClass();
    }


   

    private void UpdateSelectedSchoolClass()
    {
        if (dataGridViewSchoolClasses.CurrentCell == null) return;

        // Get the selected school class from the data source
        var selectedSchoolClass = (SchoolClass) _bSListSClasses.Current;

        // Get the courses for the selected school class from the data source
        var selectedSchoolClassCourses =
            new HashSet<Course>(
                SchoolDatabase.GetCoursesForSchoolClass(
                    selectedSchoolClass.IdSchoolClass));

        if (selectedSchoolClassCourses == null)
        {
            checkedListBoxCourses.Invalidate();
            return;
        }

        // Clear all checked items in the checkedListBoxCourses control
        foreach (int i in checkedListBoxCourses.CheckedIndices)
            checkedListBoxCourses.SetItemChecked(i, false);

        // Set the checked items in the checkedListBoxCourses control
        foreach (var course in selectedSchoolClassCourses)
        {
            var index = checkedListBoxCourses.Items.IndexOf(course);

            if (index >= 0)
                checkedListBoxCourses.SetItemChecked(index, true);
        }

        // Update the previous row index
        _previousRowIndex = dataGridViewSchoolClasses.CurrentCell.RowIndex;
    }

    private void CheckedListBoxCourses_SelectedIndexChanged(
        object sender, EventArgs e)
    {
        // Get the selected school class from the data source
        var selectedSchoolClass = (SchoolClass) _bSListSClasses.Current;

        // Get the selected course from the CheckedListBox
        var selectedCourse = (Course) checkedListBoxCourses.SelectedItem;

        // If either the school class or course is null, exit the method
        if (selectedSchoolClass == null || selectedCourse == null)
        {
            Log.Warning(
                "Either selectedSchoolClass " +
                "or selectedCourse is null.");
            return;
        }

        // If the checked list box is empty, exit the method
        if (checkedListBoxStudents.Items.Count == 0)
        {
            Log.Warning("CheckedListBoxStudents is empty.");
            return;
        }

        // Clear all checked items
        foreach (int i in checkedListBoxStudents.CheckedIndices)
            checkedListBoxStudents.SetItemChecked(i, false);

        // Get the students enrolled in the selected course
        var enrolledStudents = new HashSet<Student>();
        if (SchoolDatabase.CourseClasses
                .ContainsKey(selectedSchoolClass.IdSchoolClass) &&
            SchoolDatabase.CourseStudents
                .ContainsKey(selectedCourse.IdCourse))
        {
            enrolledStudents =
                SchoolDatabase.GetEnrolledStudentsByCourseForClass(
                    selectedSchoolClass.IdSchoolClass)[selectedCourse.IdCourse];
        }
        else
        {
            Log.Error(
                $"Unable to retrieve enrolled students " +
                $"for school class {selectedSchoolClass.IdSchoolClass} " +
                $"and course {selectedCourse.IdCourse}");
        }

        // Update checked items based on the enrollments
        foreach (
            var enrollment in
            checkedListBoxStudents.CheckedItems
                .Cast<Student>().Intersect(enrolledStudents))
        {
            checkedListBoxStudents.SetItemChecked(
                checkedListBoxStudents.Items.IndexOf(enrollment), true);
        }

        Log.Information(
            $"Updated checked items for course " +
            $"{selectedCourse.IdCourse} in school class " +
            $"{selectedSchoolClass.IdSchoolClass}");
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
        _photoFile = openFileDialog1.FileName;
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
            buttonAddCourse.Visible = false;
            buttonAddStudent.Visible = false;
        }
        else if (transparentTabControl1.SelectedTab ==
                 transparentTabControl1.TabPages[1])
        {
            comboBoxSearchList.Visible = false;
            comboBoxSearchOptions.Visible = false;
            buttonAddCourse.Visible = true;
            buttonAddStudent.Visible = true;
        }
        else if (transparentTabControl1.SelectedTab ==
                 transparentTabControl1.TabPages[2])
        {
            comboBoxSearchList.Visible = true;
            comboBoxSearchOptions.Visible = true;
            buttonAddCourse.Visible = false;
            buttonAddStudent.Visible = false;
        }
        else if (transparentTabControl1.SelectedTab ==
                 transparentTabControl1.TabPages[3])
        {
            comboBoxSearchList.Visible = true;
            comboBoxSearchOptions.Visible = true;
            buttonAddCourse.Visible = false;
            buttonAddStudent.Visible = false;
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

    private void ButtonPrint_Click(object sender, EventArgs e)
    {
        if (transparentTabControl1.SelectedTab ==
            transparentTabControl1.TabPages[0])
        {
        }
        else if (transparentTabControl1.SelectedTab ==
                 transparentTabControl1.TabPages[1])
        {
            DataPrintPreview();
        }
        else if (transparentTabControl1.SelectedTab ==
                 transparentTabControl1.TabPages[2])
        {
            DataPrintPreview();
        }
        else if (transparentTabControl1.SelectedTab ==
                 transparentTabControl1.TabPages[3])
        {
            //ChartPrint();
            ChartPrintPreview();
        }
    }

    private void ChartPrint()
    {
        // Create a new PrintDocument object and set its properties
        var pd = new PrintDocument();
        pd.DocumentName = "Chart1";

        // Handle the PrintPage event to render the chart onto the page
        pd.PrintPage += (s, ev) =>
        {
            var bmp = new Bitmap(chart1.Width, chart1.Height);
            chart1.DrawToBitmap(bmp,
                new Rectangle(0, 0, bmp.Width, bmp.Height));
            ev.Graphics.DrawImage(bmp, ev.MarginBounds);
            ev.HasMorePages = false;
        };

        // Show a print dialog and print the chart if the user clicks "OK"
        // Show the print preview dialog
        var printDialog1 = new PrintPreviewDialog();
        var result = printDialog1.ShowDialog();
        if (result == DialogResult.OK) pd.Print();
    }


    private void ChartPrintPreview()
    {
        // Create a new PrintDocument object and set its properties
        var pd = new PrintDocument();
        pd.DefaultPageSettings.Landscape = true;
        pd.DocumentName = "Chart1";

        // Handle the PrintPage event to render the chart onto the page
        pd.PrintPage += (s, ev) =>
        {
            var bmp = new Bitmap(chart1.Width, chart1.Height);
            chart1.DrawToBitmap(bmp,
                new Rectangle(0, 0, bmp.Width, bmp.Height));
            ev.Graphics.DrawImage(bmp, ev.MarginBounds);
            ev.HasMorePages = false;
        };


        // Show the print preview dialog
        var dlg = new PrintPreviewDialog();
        dlg.Document = pd;
        dlg.ShowDialog();
    }

    private void DataPrintPreview()
    {
        // Create a new PrintDocument object
        var pd = new PrintDocument();
        pd.DefaultPageSettings.Landscape = true;
        pd.DocumentName = "List of School Classes";

        // Set the PrintPage event handler for the PrintDocument object
        pd.PrintPage += PrintPage;

        // Show the PrintPreviewDialog
        var ppd = new PrintPreviewDialog();
        ppd.Document = pd;
        ppd.ShowDialog();
    }


    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        // Set up the print document with the appropriate font and margins
        var font = new Font("Arial", 12);
        var x = e.MarginBounds.Left;
        var y = e.MarginBounds.Top;
        var width = e.MarginBounds.Width;
        var height = e.MarginBounds.Height;

        _startIndex = (_currentPage - 1) * ItemsPerPage;
        _endIndex = Math.Min(_startIndex + ItemsPerPage,
            SchoolClasses.SchoolClassesList.Count);

        // Define the column widths and headers
        var colWidths = new[]
            {60, 120, 80, 80, 80, 80, 80, 60, 60, 60, 80, 80, 80, 80, 80};
        var colHeaders = new[]
        {
            "Acronym", "Class Name", "Start Date", "End Date",
            "Start Hour", "End Hour", "Location", "Type", "Area",
            "Courses", "Work Hours", "Students",
            "Avg Grade", "Max Grade", "Min Grade"
        };

        // Define the table lines
        var tableLines = new[]
        {
            new
            {
                X1 = e.MarginBounds.Left, Y1 = y, X2 = e.MarginBounds.Right,
                Y2 = y
            },
            new
            {
                X1 = e.MarginBounds.Left, Y1 = y + font.Height,
                X2 = e.MarginBounds.Right, Y2 = y + font.Height
            }
        };

        font = new Font("Arial", 8);
        // Print the column headers and lines
        for (var i = 0; i < colHeaders.Length; i++)
        {
            e.Graphics.DrawString(
                colHeaders[i], font, Brushes.Black, x, y);
            x += colWidths[i];
            e.Graphics.DrawLine(
                Pens.Black, x, y, x, y + font.Height);
        }

        // Draw the bottom line of the header row
        e.Graphics.DrawLine(
            Pens.Black, e.MarginBounds.Left, y + font.Height,
            e.MarginBounds.Right, y + font.Height);

        // Move to the next row
        y += font.Height + 10;

        // Print the table data
        // Print the data for each class
        for (var i = _startIndex; i < _endIndex; i++)
        {
            var schoolClass = SchoolClasses.SchoolClassesList[i];

            // Define the row lines
            var rowLines = new[]
            {
                new
                {
                    X1 = e.MarginBounds.Left,
                    Y1 = y,
                    X2 = e.MarginBounds.Right,
                    Y2 = y
                },
                new
                {
                    X1 = e.MarginBounds.Left,
                    Y1 = y + font.Height,
                    X2 = e.MarginBounds.Right,
                    Y2 = y + font.Height
                }
            };

            // Print the class acronym
            e.Graphics.DrawString(
                schoolClass.ClassAcronym, font, Brushes.Black,
                e.MarginBounds.Left, y);
            x = e.MarginBounds.Left + colWidths[0];

            y += font.Height + 5;
            // Print the class name
            e.Graphics.DrawString(
                schoolClass.ClassName, font, Brushes.Black, x, y);
            x += colWidths[1];

            y += font.Height + 10;
            // Print the start date
            e.Graphics.DrawString(
                schoolClass.StartDate.ToString("d"), font,
                Brushes.Black, x, y);
            x += colWidths[2];

            // Print the end date
            e.Graphics.DrawString(
                schoolClass.EndDate.ToString("d"), font,
                Brushes.Black, x, y);
            x += colWidths[3];

            // Print the start hour
            e.Graphics.DrawString(
                schoolClass.StartHour.ToString("t"), font,
                Brushes.Black, x, y);
            x += colWidths[4];

            // Print the end hour
            e.Graphics.DrawString(
                schoolClass.EndHour.ToString("t"), font,
                Brushes.Black, x, y);
            x += colWidths[5];

            // Print the location
            e.Graphics.DrawString(
                schoolClass.Location, font, Brushes.Black, x, y);
            x += colWidths[6];

            // Print the type
            e.Graphics.DrawString(
                schoolClass.Type, font, Brushes.Black, x, y);
            x += colWidths[7];

            // Print the area
            e.Graphics.DrawString(
                schoolClass.Area, font, Brushes.Black, x, y);
            x += colWidths[8];

            // Print the number of courses
            e.Graphics.DrawString(
                schoolClass.CoursesCount?.ToString("N") ?? "",
                font, Brushes.Black, x, y);
            x += colWidths[9];

            // Print the WorkHourLoad
            e.Graphics.DrawString(
                schoolClass.WorkHourLoad?.ToString("N") ?? "",
                font, Brushes.Black, x, y);
            x += colWidths[10];

            // Print the StudentsCount
            e.Graphics.DrawString(
                schoolClass.StudentsCount?.ToString("N") ?? "",
                font, Brushes.Black, x, y);
            x += colWidths[11];

            // Print the ClassAverage
            e.Graphics.DrawString(
                schoolClass.ClassAverage?.ToString("N") ?? "",
                font, Brushes.Black, x, y);
            x += colWidths[12];

            // Print the HighestGrade
            e.Graphics.DrawString(
                schoolClass.HighestGrade?.ToString("N") ?? "",
                font, Brushes.Black, x, y);
            x += colWidths[13];

            // Print the LowestGrade
            e.Graphics.DrawString(
                schoolClass.LowestGrade?.ToString("N") ?? "",
                font, Brushes.Black, x, y);
            x += colWidths[14];

            y += font.Height + 5;
        }

        // Draw the bottom line of the header row
        e.Graphics.DrawLine(
            Pens.Black, e.MarginBounds.Left, y + font.Height,
            e.MarginBounds.Right, y + font.Height);

        // If there are more pages, indicate that there are more pages
        if (_endIndex < SchoolClasses.SchoolClassesList.Count)
        {
            e.HasMorePages = true;
            _currentPage++;
        }
        else
        {
            e.HasMorePages = false;
            //_currentPage = 1;
        }
    }
}