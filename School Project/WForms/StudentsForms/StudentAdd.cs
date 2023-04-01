using System.Reflection;
using ClassLibrary;
using static System.Windows.Forms.Keys;

namespace School_Project.WForms.StudentsForms;

public partial class StudentAdd : Form
{
    private readonly BindingSource _bSourceCourses = new();
    private readonly BindingSource _bSourceSearchList = new();

    private readonly BindingSource _bSourceSearchOptions = new();
    //
    // Global variables for the windows forms
    //

    private readonly BindingSource _bSourceStudents = new();
    private string _studentPhoto;
    private int _studentsCount;

    public StudentAdd()
    {
        InitializeComponent();
    }


    private void WinFormLoading_Load(object sender, EventArgs e)
    {
        //
        // assign the local variables to is counterpart
        // in the Global variables from the initial form
        //
        if (Students.ListStudents.Count > 0 && Students.ListStudents != null)
            _studentsCount = Students.ListStudents[^1].IdStudent;

        //
        // make the transparent tab-control transparent
        // transparentTabControl1.MakeTransparent();
        //
        transparentTabControl1.MakeTransparent();
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[1];

        dateTimePickerBirthDate.Value = DateTime.Now.AddYears(-10);
        dateTimePickerCCValidDate.Value = DateTime.Now.AddYears(10);

        //
        // initial update
        // count register and the list
        //
        UpdateLists();
        UpdateLabelsCounts();
    }


    private void WinFormAdd_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Escape) Close();
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
        if (e is not {Modifiers: Keys.Control, KeyCode: V}) return;

        ((TextBox) sender).Paste();

        Console.WriteLine("Testes de Debug");
    }


    private void ButtonSave_Click(object sender, EventArgs e)
    {
        if (!ValidateTextBoxes()) return;

        Students.AddStudent(
            (int) numericUpDownStudentID.Value,
            textBoxName.Text,
            textBoxLastName.Text,
            textBoxAddress.Text,
            textBox2.Text,
            textBox1.Text,
            textBoxPhone.Text,
            textBoxEmail.Text,
            true,
            comboBoxGenre.Text,
            DateOnly.FromDateTime(dateTimePickerBirthDate.Value),
            textBoxCC.Text,
            DateOnly.FromDateTime(dateTimePickerCCValidDate.Value),
            textBoxNIF.Text,
            textBoxNationality.Text,
            textBoxBirthPlace.Text,
            _studentPhoto,
            0,
            DateOnly.FromDateTime(DateTime.Now),
            null
        );

        //
        // initial update
        // count register and the list
        //
        UpdateLists();
        UpdateLabelsCounts();
        ClearTextBoxes();
    }


    private void ClearTextBoxes()
    {
        //(int)numericUpDownStudentID.Value;
        textBoxName.Clear();
        textBoxLastName.Clear();
        textBoxAddress.Clear();
        textBox2.Clear();
        textBox1.Clear();
        textBoxPhone.Clear();
        textBoxEmail.Clear();
        //true;
        //comboBoxGenre.Items.Clear();
        //DateOnly.FromDateTime(dateTimePickerBirthDate.Value);
        textBoxCC.Clear();
        //DateOnly.FromDateTime(dateTimePickerCCValidDate.Value);
        textBoxNIF.Clear();
        textBoxNationality.Clear();
        textBoxBirthPlace.Clear();
        _studentPhoto = string.Empty;
        //0;
        //DateOnly.FromDateTime(DateTime.Now);
        //null;
    }


    private void UpdateLists()
    {
        //
        //
        // binding section for data grids and checked lists 
        // 
        //
        _bSourceStudents.DataSource = Students.ListStudents;
        dataGridView1.DataSource = _bSourceStudents;
        dataGridView1.AutoResizeColumns();

        _bSourceCourses.DataSource = Courses.ListCourses;
        checkedListBoxDisciplines.DataSource = _bSourceCourses;
        comboBoxGenre.DataSource = Student.Genreslist;


        _bSourceStudents.ResetBindings(false);
        _bSourceCourses.ResetBindings(false);

        _bSourceStudents.ResetBindings(true);
        _bSourceCourses.ResetBindings(true);


        // To display all the properties of the Student class in the comboBoxSearchOptions,
        // you can use reflection to get a list of the property names and set the DataSource
        // and DisplayMember properties of the combobox accordingly.
        // Here's an example code snippet to achieve this:

        _bSourceSearchOptions.DataSource = typeof(Student);
        var properties =
            typeof(Student).GetProperties(BindingFlags.Public |
                                          BindingFlags.Instance);

        List<string> propertyNames = new();
        foreach (var property in properties)
        {
            propertyNames.Add(property.Name);
        }

        comboBoxSearchOptions.DataSource = propertyNames;
        comboBoxSearchOptions.DisplayMember = "ToString()";


        //_bSourceSearchList.DataSource = Students.ConsultStudent;
        comboBoxSearchList.DataSource = _bSourceSearchList;
        dataGridView2.DataSource = _bSourceSearchList;
        dataGridView2.AutoResizeColumns();

        _bSourceSearchOptions.ResetBindings(false);
        _bSourceSearchList.ResetBindings(false);

        _bSourceSearchOptions.ResetBindings(true);
        _bSourceSearchList.ResetBindings(true);

        dataGridView1.Refresh();
        dataGridView1.Update();

        dataGridView2.Refresh();
        dataGridView2.Update();

        Console.WriteLine("Testes de Debug");
    }

    private void ComboBoxSearchOptions_SelectedIndexChanged(object sender,
        EventArgs e)
    {
        // Get the name of the selected property
        var selectedProperty = comboBoxSearchOptions.SelectedItem.ToString();

        // Create a new list to store the filtered results
        List<Student> filteredStudents = new();

        var property = typeof(Student).GetProperty(selectedProperty);
        foreach (var student in Students.ListStudents)
        {
            if (property == null || property.GetValue(student).ToString() == "")
                continue;

            filteredStudents.Add(student);
        }

        _bSourceSearchList.DataSource = filteredStudents;
        //_bSourceSearchList.DataSource = Students.ListStudents.Select(s => s.GetType().GetProperty(selectedProperty).GetValue(s)).ToList();

        comboBoxSearchList.Refresh();
        dataGridView2.Refresh();
    }


    /*
    private void ComboBoxSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Get the name of the selected property
        string propertyName = comboBoxSearchOptions.SelectedItem.ToString();

        // Get the PropertyInfo for the selected property
        PropertyInfo propertyInfo = typeof(Student).GetProperty(propertyName);

        // Create a new list to store the filtered results
        List<Student> filteredList = new();

        // Iterate through each student in the ConsultStudent list
        foreach (Student student in Students.ListStudents)
        {
            // Get the value of the selected property for the current student
            object propertyValue = propertyInfo.GetValue(student);

            // If the property value is not null and matches the search term
            //if (propertyValue != null && propertyValue.ToString().Contains(searchTerm))
            //if (propertyValue != null && propertyValue.ToString().Contains("teste"))
            if (propertyValue != null && propertyValue.ToString().Contains("t"))
            {
                // Add the student to the filtered list
                filteredList.Add(student);
            }
        }

        // Set the DataSource of the search list to the filtered list
        _bSourceSearchList.DataSource = filteredList;
    }
    */

    private void UpdateLabelsCounts()
    {
        _studentsCount++;
        numericUpDownStudentID.Value = _studentsCount;
    }


    private bool ValidateTextBoxes()
    {
        var valid = true;


        if (
            string.IsNullOrEmpty(textBoxName.Text) ||
            string.IsNullOrWhiteSpace(textBoxName.Text))
        {
            MessageBox.Show("Insira o Nome",
                "Nome",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            valid = false;
            textBoxName.Select();
        }


        if (
            string.IsNullOrEmpty(textBoxLastName.Text) ||
            string.IsNullOrWhiteSpace(textBoxLastName.Text))
        {
            MessageBox.Show("Insira o apelido do estudante",
                "Apelido do Estudante",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            valid = false;
            labelLastName.Select();
        }

        return valid;
    }


    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        ClearTextBoxes();
    }


    private void ButtonStudentRemove_Click(object sender, EventArgs e)
    {
        // by rows
        var rowText = string.Empty;
        var rc = -1; // var 
        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;

        // by cells
        if (dataGridView1.CurrentCell != null)
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;

        if (Students.ListStudents == null)
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Apagar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );

        if (int.IsPositive(rc))
        {
            var s =
                "Tem a certeza que deseja apagar o seguinte registo?\n" +
                $"{Students.ListStudents[rc].Name} " +
                $"{Students.ListStudents[rc].LastName}";

            var dialogResult = MessageBox.Show(
                s, "Apagar",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
                dataGridView1.Rows.RemoveAt(rc);
        }

        Console.WriteLine("Testes de Debug");
    }


    private void ButtonStudentEdit_Click(object sender, EventArgs e)
    {
        // by rows
        var rowText = string.Empty;
        var rc = -1;
        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;

        // by cells
        if (dataGridView1.CurrentCell != null)
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;

        if (Students.ListStudents != null)
        {
            if (int.IsPositive(rc))
            {
                StudentEdit winFormStudentEdit = new(rc);
                winFormStudentEdit.ShowDialog();
            }
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


    private void TextBoxNames_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (
            char.IsLetter(e.KeyChar) || // validating if it's a letter
            char.IsSeparator(e.KeyChar) || // validating if it's a separator
            char.IsWhiteSpace(e.KeyChar) || // validating if it's a whitespace
            e.KeyChar is (char) Back or '.' or '\'' or '-'
            // validating if it's a backspace
            // validating if it's a dot
            // validating if it's an apostrophe
            // validating if it's a separator
        )
            return;
        e.Handled = true;
    }


    private void TextBoxStudentPhone_KeyPress(
        object sender, KeyPressEventArgs e)
    {
        // validating if it's a digit
        if (char.IsDigit(e.KeyChar) || e.KeyChar == (char) Back) return;
        e.Handled = true;
    }


    private void ButtonStudentDisciplinesAdding_Click(
        object sender, EventArgs e)
    {
        if (Students.ListStudents == null)
        {
            MessageBox.Show(
                "Ainda não tem um único estudante inserido",
                "Adicionar disciplina",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }


        var rowText = string.Empty;
        var rc = -1;
        // by rows
        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;

        // by cells
        if (dataGridView1.CurrentCell != null)
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;


        if (rc != -1)
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


        //
        // open the edit form with the studentForValidation editing
        //
        MessageBox.Show("Temos disciplinas, vamos lá");


        //
        // cycle to evaluate which disciplines are select and add it
        //

        //
        // temp variable of the class discipline to
        // retain the disciplines for that studentForValidation
        //
        List<Enrollment> enrollments = new();

        foreach (var c in Courses.ListCourses)
        foreach (var t in checkedListBoxDisciplines.CheckedItems)
            if (t is Course v && c.IdCourse == v.IdCourse)
                enrollments.Add(
                    new Enrollment
                    {
                        //Grade = 0,
                        //StudentId = ,
                        //Student = 0,
                        CourseId = c.IdCourse,
                        Course = c
                    }
                );


        UpdateLists();

        Console.WriteLine("Testes de Debug");
    }


    private void ListBoxStudents_SelectedIndexChanged(
        object sender, EventArgs e)
    {
        //
        // cast the selected object to be displayed in the dialog box
        //


        if (dataGridView1.SelectedRows == null) return;

        var rc = -1;
        var rowText = string.Empty;

        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
        {
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;
            rowText += row.Cells[rc].Value + ", ";
            dataGridView1.Rows.RemoveAt(row.Index);
        }

        MessageBox.Show("Current Row Index is = " + rowText);

        //for find the row index number
        rc = dataGridView1.CurrentCell.RowIndex;
        MessageBox.Show("Current Row Index is = " + rc);

        var studentToView = Students.ListStudents[rc];


        if (studentToView?.Enrollments != null)
            foreach (var enrollment in studentToView.Enrollments)
                //
                // subtract 1 from the Courses list,
                // because the list starts at 1 and
                // all other objects start from 0
                //
                checkedListBoxDisciplines.SetItemChecked(
                    enrollment.CourseId - 1, true);

        // update the numericUpDownLabel with  the value
        numericUpDownTotalWorkLoad.Value =
            Students.ListStudents[^1].TotalWorkHoursLoad;

        numericUpDownTotalWorkLoad.Value =
            studentToView.TotalWorkHoursLoad;

        Console.WriteLine("Testes de Debug");
    }

    private void ButtonAddPhoto_Click(object sender, EventArgs e)
    {
        OpenFileDialog fileDialog = new();
        fileDialog.ShowDialog();
        //openFileDialog1.ShowDialog();

        //Students.ListStudents[^1].Photo = fileDialog.FileName;
        _studentPhoto = fileDialog.FileName;
        pictureBoxPhotoDisplay.ImageLocation = fileDialog.FileName;
    }

    private void ButtonExit_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void ButtonNew_Click(object sender, EventArgs e)
    {
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[0];
    }

    private void ButtonSearch_Click(object sender, EventArgs e)
    {
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[2];
    }
}