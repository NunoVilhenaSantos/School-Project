using System.Drawing.Printing;
using System.Reflection;
using ClassLibrary.Courses;
using ClassLibrary.Enrollments;
using ClassLibrary.School;
using ClassLibrary.SchoolClasses;
using ClassLibrary.Students;
using Serilog;
using static System.Windows.Forms.Keys;

namespace School_Project.WForms.StudentsForms;

public partial class StudentAdd : Form
{
    //
    // Global variables for the windows forms
    //
    private readonly BindingSource _bSourceCourses = new();
    private readonly BindingSource _bSourceSearchList = new();
    private readonly BindingSource _bSourceSearchOptions = new();
    private readonly BindingSource _bSourceStudents = new();
    private string _studentPhoto;
    private int _studentsCount;

    public StudentAdd()
    {
        InitializeComponent();
        _studentPhoto = string.Empty;
    }


    private void WinFormLoading_Load(object sender, EventArgs e)
    {
        //
        // assign the local variables to is counterpart
        // in the Global variables from the initial form
        //
        if (Students.StudentsList.Count > 0)
            _studentsCount = Students.StudentsList[^1].IdStudent;

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
            textBoxPostalCode.Text,
            textBoxCity.Text,
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
            0,
            DateOnly.FromDateTime(DateTime.Now)
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
        textBoxPostalCode.Clear();
        textBoxCity.Clear();
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
        // *
        // * 1st 
        // * Data bindings
        // * 
        // *
        _bSourceStudents.DataSource = Students.StudentsList;
        _bSourceCourses.DataSource = Courses.CoursesList;

        _bSourceStudents.ResetBindings(false);
        _bSourceCourses.ResetBindings(false);

        _bSourceStudents.ResetBindings(true);
        _bSourceCourses.ResetBindings(true);


        // *
        // * 2nd 
        // * checkedListBox
        // * must be add before the dataGridView 
        // *
        checkedListBox1.DataSource = _bSourceCourses;
        //_bSourceCourses.ResetBindings(false);
        checkedListBox1.Invalidate();
        checkedListBox1.Refresh();

        // *
        // * 3rd 
        // * dataGridView
        // * must be add after the dataGridView 
        // *

        dataGridView1.DataSource = _bSourceStudents;
        dataGridView1.AutoResizeColumns();

        dataGridView1.Refresh();
        dataGridView1.Update();


        // *
        // * 4rd 
        // * comboBox
        // * must be add after the dataGridView 
        // *
        comboBoxGenre.DataSource = Student.Genreslist;

        // To display all the properties of the Student class
        // in the comboBoxSearchOptions,
        // you can use reflection to get a list
        // of the property names and set the DataSource
        // and DisplayMember properties of the combo-box accordingly.
        // Here's an example code snippet to achieve this:

        _bSourceSearchOptions.DataSource = typeof(Student);
        var properties =
            typeof(Student).GetProperties(BindingFlags.Public |
                                          BindingFlags.Instance);

        var propertyNames =
            properties.Select(property => property.Name).ToList();

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

        var property = typeof(Student)
            .GetProperty(selectedProperty ?? string.Empty);
        var filteredStudents =
            Students.StudentsList
                .Where(
                    student => property != null &&
                               property.GetValue(student)
                                   .ToString() != "").ToList();

        _bSourceSearchList.DataSource = filteredStudents;

        comboBoxSearchList.Refresh();
        dataGridViewSearch.Refresh();
    }


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

        if (!string.IsNullOrEmpty(textBoxLastName.Text) &&
            !string.IsNullOrWhiteSpace(textBoxLastName.Text)) return valid;

        MessageBox.Show("Insira o apelido do estudante",
            "Apelido do Estudante",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        valid = false;
        labelLastName.Select();

        return valid;
    }


    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        ClearTextBoxes();
    }


    private void ButtonStudentRemove_Click(object sender, EventArgs e)
    {
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[1];

        // by rows
        var rc = -1; // var 
        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;

        // by cells
        if (dataGridView1.CurrentCell != null)
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;

        if (Students.StudentsList == null)
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Apagar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );

        if (int.IsPositive(rc))
        {
            var s =
                "Tem a certeza que deseja apagar o seguinte registo?\n" +
                $"{Students.StudentsList[rc].Name} " +
                $"{Students.StudentsList[rc].LastName}";

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
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[1];

        // by rows
        var rc = -1;
        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;

        // by cells
        if (dataGridView1.CurrentCell != null)
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;

        if (Students.StudentsList == null)
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Editar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        if (!int.IsPositive(rc)) return;
        var studentToEdit = (Student) _bSourceStudents.Current;

        StudentEdit winFormStudentEdit = new(studentToEdit);
        winFormStudentEdit.ShowDialog();
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


    private void ButtonAddEnrollments_Click(object sender, EventArgs e)
    {
        //
        //
        // cast the selected object to be displayed in the dialog box
        // check what was selected, row or cell.
        // 
        //
        var courseToEditByRow = dataGridView1.SelectedRows;
        var courseToEditByCell = dataGridView1.SelectedCells;
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
                "Ainda não tem uma disciplina criada " +
                "por isso não pode adicionar estudante(s)",
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

        if (checkedListBox1.CheckedItems.Count == 0)
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
        MessageBox.Show("Temos disciplina(s) para adicionar, vamos lá.");
        var studentToAddCourses = (Student) _bSourceStudents.Current;

        //
        // cycle to evaluate which student(s) are select and add it
        //
        // SchoolDatabase.EnrollStudentInCourses(
        //     checkedListBox1.CheckedItems
        //         .Cast<Course>().ToList(),
        //     studentToAddCourses.IdStudent);

        // Select courses from CheckedListBox control and create a list of courses
        var selectedCourses =
            checkedListBox1.CheckedItems
                .Cast<Course>()
                .ToList();

        // Get all courses that the student is currently enrolled in
        var enrolledCourses =
            SchoolDatabase.GetCoursesForStudent(studentToAddCourses.IdStudent);

        // Identify courses to be removed
        var coursesToRemove =
            enrolledCourses.Except(selectedCourses).ToList();

        // Identify courses to add
        var coursesToAdd =
            selectedCourses.Except(enrolledCourses).ToList();

        // Display message boxes with counts
        MessageBox.Show(
            $"Selected courses: {selectedCourses.Count}\n" +
            $"Enrolled courses: {enrolledCourses.Count}\n" +
            $"Courses to remove: {coursesToRemove.Count}\n" +
            $"Courses to add: {coursesToAdd.Count}");

        // Enroll the student in the selected courses
        try
        {
            SchoolDatabase.EnrollStudentInCourses(selectedCourses,
                studentToAddCourses.IdStudent);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error enrolling student in courses");
        }

        // Unenroll the student from courses to be removed
        try
        {
            SchoolDatabase.UnenrollStudentFromCourses(coursesToRemove,
                studentToAddCourses.IdStudent);
        }
        catch (Exception ex)
        {
            Log.Error(ex,
                "Error unenrolling student from courses");
        }

        MessageBox.Show("Student enrollments updated successfully.");

        SchoolClasses.ToObtainValuesForCalculatedFields();
        Courses.GetStudentsCount();
        UpdateLists();

        var linhaAtual = dataGridView1.CurrentCell.RowIndex;
        _previousRowIndex = linhaAtual + 1;
        UpdateSelectedData();
        _previousRowIndex = linhaAtual;

        Console.WriteLine("Testes de Debug");
    }


    private void DataGridView_CellBeginEdit(
        object sender, DataGridViewCellCancelEventArgs e)
    {
        // Get the column index of the cell being edited
        var columnIndex = e.ColumnIndex;

        // Check if the column is read-only
        if (columnIndex is 0 or 2)
            // Cancel the edit operation for the read-only column
            e.Cancel = true;
    }


    private void DataGridView_CellEnter(
        object sender, DataGridViewCellEventArgs e)
    {
        UpdateSelectedData();
    }


    private void DataGridView_Scroll(object sender, ScrollEventArgs e)
    {
        // If the scroll event is for scrolling the
        // vertical bar, update the selected school class
        if (e.ScrollOrientation == ScrollOrientation.VerticalScroll)
            UpdateSelectedData();
    }


    private void UpdateSelectedData()
    {
        // Check if the row index has changed
        if (dataGridView1.CurrentCell == null ||
            dataGridView1.CurrentCell.RowIndex ==
            _previousRowIndex) return;

        // Get the selected course from the data source
        var current = (Student) _bSourceStudents.Current;

        // Get the students for the selected course from the data source
        var selectedCoursesEnrollmentsStudents =
            Enrollments.ListEnrollments
                .Where(x => x.StudentId == current.IdStudent)
                .Select(e => e.CourseId)
                .ToList();

        var selectedCourseEnrollments =
            Enrollments.ListEnrollments
                .Where(x =>
                    x.StudentId == current.IdStudent)
                .ToList();

        var selectedCourseStudents =
            selectedCourseEnrollments
                .Select(e => e.StudentId)
                .ToList();

        if (selectedCourseEnrollments == null)
        {
            checkedListBox1.Invalidate();
            return;
        }

        // Set the checked items in the checkedListBoxStudents control
        for (var i = 0; i < checkedListBox1.Items.Count; i++)
        {
            var course = (Course) checkedListBox1.Items[i];
            checkedListBox1
                .SetItemChecked(i,
                    selectedCoursesEnrollmentsStudents
                        .Contains(course.IdCourse));
        }

        // Update the previous row index
        _previousRowIndex = dataGridView1.CurrentCell.RowIndex;
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

        var studentToView = Students.StudentsList[rc];

        var studentToViewEnrollment =
            Enrollments.ConsultEnrollment(studentToView.IdStudent);

        if (studentToViewEnrollment.Any())
            foreach (var enrollment in studentToViewEnrollment)
                // Subtract 1 from the Courses list
                checkedListBox1.SetItemChecked(
                    enrollment.CourseId - 1, true);

        // update the numericUpDownLabel value
        numericUpDownTotalWorkLoad.Value =
            Students.StudentsList[^1].TotalWorkHoursLoad;

        numericUpDownTotalWorkLoad.Value =
            studentToView.TotalWorkHoursLoad;

        Console.WriteLine("Testes de Debug");
    }

    private void ButtonAddPhoto_Click(object sender, EventArgs e)
    {
        OpenFileDialog fileDialog = new();
        fileDialog.ShowDialog();
        //openFileDialog1.ShowDialog();

        //Students.StudentsList[^1].Photo = fileDialog.FileName;
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

    private void ButtonSearchForm_Click(object sender, EventArgs e)
    {
        StudentSearch studentSearch = new();
        studentSearch.ShowDialog();
        studentSearch.Dispose();
    }


    private void TransparentTabControl1_SelectedIndexChanged(
        object sender, EventArgs e)
    {
        if (transparentTabControl1.SelectedTab ==
            transparentTabControl1.TabPages[0])
        {
            comboBoxSearchList.Visible = false;
            comboBoxSearchOptions.Visible = false;
            buttonAddCourses.Visible = false;
            //buttonAddStudent.Visible = false;
        }
        else if (transparentTabControl1.SelectedTab ==
                 transparentTabControl1.TabPages[1])
        {
            comboBoxSearchList.Visible = false;
            comboBoxSearchOptions.Visible = false;
            buttonAddCourses.Visible = true;
            //buttonAddStudent.Visible = true;
        }
        else if (transparentTabControl1.SelectedTab ==
                 transparentTabControl1.TabPages[2])
        {
            comboBoxSearchList.Visible = true;
            comboBoxSearchOptions.Visible = true;
            buttonAddCourses.Visible = false;
            //buttonAddStudent.Visible = false;
        }
        else if (transparentTabControl1.SelectedTab ==
                 transparentTabControl1.TabPages[3])
        {
            comboBoxSearchList.Visible = true;
            comboBoxSearchOptions.Visible = true;
            buttonAddCourses.Visible = false;
            //buttonAddStudent.Visible = false;
        }
    }

    private void TransparentTabControl1_TabIndexChanged(
        object sender, EventArgs e)
    {
        TransparentTabControl1_SelectedIndexChanged(sender, e);
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

    private void ChartPrintPreview()
    {
        // Create a new PrintDocument object and set its properties
        PrintDocument pd = new();
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
        PrintPreviewDialog dlg = new()
        {
            Document = pd
        };
        dlg.ShowDialog();
    }


    private void DataPrintPreview()
    {
        // Create a new PrintDocument object
        PrintDocument pd = new();
        pd.DefaultPageSettings.Landscape = true;
        pd.DocumentName = "List of Students";

        // Set the PrintPage event handler for the PrintDocument object
        pd.PrintPage += PrintPage;

        // Show the PrintPreviewDialog
        PrintPreviewDialog ppd = new()
        {
            Document = pd
        };
        ppd.ShowDialog();
    }


    private void PrintPage(object sender, PrintPageEventArgs e)
    {
        // Set up the print document with the appropriate font and margins
        //var font = new Font("Arial", 12);
        var font = new Font("Arial", 10);
        var x = e.MarginBounds.Left;
        var y = e.MarginBounds.Top;
        var width = e.MarginBounds.Width;
        var height = e.MarginBounds.Height;

        _startIndex = (_currentPage - 1) * ItemsPerPage;
        _endIndex = Math.Min(_startIndex + ItemsPerPage,
            Students.StudentsList.Count);

        // Define the column headers and widths
        var colHeaders = new[]
        {
            // "ID", "Name", "Last Name", "Date of Birth", "Gender",
            // "ID Number", "Tax ID", "Phone", "Email", "Address",
            // "Enrollment Status", "Enrollment Date", "Expiration Date",
            // "Emergency Contact"
            "Id", "Name", "LastName", "Address", "PostalCode", "City",
            "Phone", "Email", "Active", "Genre", "Date Birth",
            "ID Number", "ID Expiration Date",
            "VAT ID", "Nationality", "Birthplace",
            "CoursesCount", "TotalWorkHoursLoad", "EnrollmentDate"
        };
        var colWidths = new[]
            //                         email    gender                       
            //   0,   1,   2,   3,   4,   5,  6,   7,  8,  9, 10, 11,  12,  13
            //  14, 15, 16, 17, 18
            {
                40, 100, 100, 200, 200, 150, 50, 100, 80, 80, 80, 80, 100, 150,
                50, 50, 50, 50, 50
            };

        // Print the title
        e.Graphics.DrawString("Student List",
            new Font("Arial", 16, FontStyle.Bold), Brushes.Black, x, y);
        y += font.Height * 2;

        // Print the column headers and lines
        for (var i = 0; i < colHeaders.Length; i++)
        {
            e.Graphics.DrawString(colHeaders[i], font, Brushes.Black, x, y);
            x += colWidths[i];

            if (i != 8) continue;

            x = e.MarginBounds.Left + colWidths[0];
            y += font.Height;
        }

        y += font.Height;

        // Draw the header row bottom line
        e.Graphics.DrawLine(Pens.Black, e.MarginBounds.Left, y,
            e.MarginBounds.Right, y);

        // Define the new font
        font = new Font("Arial", 10);

        // Print the table data
        // Print the data for each class
        for (var i = _startIndex; i < _endIndex; i++)
        {
            var student = Students.StudentsList[i];

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
            y += font.Height + 2;
            e.Graphics.DrawString(
                student.IdStudent.ToString("#####"), font, Brushes.Black,
                e.MarginBounds.Left, y);
            x = e.MarginBounds.Left + colWidths[0];

            // Print the class name
            e.Graphics.DrawString(
                student.Name, font, Brushes.Black, x, y);
            x += colWidths[1];

            // Print the start date
            e.Graphics.DrawString(
                student.LastName, font,
                Brushes.Black, x, y);
            x += colWidths[2];

            // Print the end date
            e.Graphics.DrawString(
                //student.EndDate.ToString("d"),
                student.Address,
                font,
                Brushes.Black, x, y);
            x += colWidths[3];

            // Print the start hour
            e.Graphics.DrawString(
                //student.StartHour.ToString("t"),
                $"{student.PostalCode} {student.City}",
                font,
                Brushes.Black, x, y);
            x += colWidths[4];

            // Print the end hour
            e.Graphics.DrawString(
                //student.EndHour.ToString("t"),
                student.Phone,
                font,
                Brushes.Black, x, y);
            x += colWidths[5];

            // Print the location
            e.Graphics.DrawString(
                student.Email,
                font, Brushes.Black, x, y);
            x += colWidths[6];

            // Print the type
            // breaking the line
            y += font.Height;
            e.Graphics.DrawString(
                student.Active.ToString(),
                font, Brushes.Black, x, y);

            // resetting left margin 
            //x += colWidths[7];
            // 
            x = e.MarginBounds.Left + colWidths[0];

            // Print the area
            e.Graphics.DrawString(
                student.Genre,
                font, Brushes.Black, x, y);
            //x += colWidths[7];
            x += colWidths[8];

            // Print the number of courses
            e.Graphics.DrawString(
                //student.CoursesCount?.ToString("N") ?? "",
                student.DateOfBirth.ToString("d"),
                font, Brushes.Black, x, y);
            x += colWidths[9];

            // Print the WorkHourLoad
            e.Graphics.DrawString(
                //student.WorkHourLoad?.ToString("N") ?? "",
                student.IdentificationNumber,
                font, Brushes.Black, x, y);
            x += colWidths[10];

            // Print the StudentsCount
            e.Graphics.DrawString(
                student.ExpirationDateIn.ToString("d"),
                font, Brushes.Black, x, y);
            x += colWidths[11];

            // Print the ClassAverage
            e.Graphics.DrawString(
                //student.ClassAverage?.ToString("N") ?? "",
                student.TaxIdentificationNumber,
                font, Brushes.Black, x, y);
            x += colWidths[12];

            // Print the HighestGrade
            e.Graphics.DrawString(
                //student.HighestGrade?.ToString("N") ?? "",
                student.Nationality,
                font, Brushes.Black, x, y);
            x += colWidths[13];

            // Print the LowestGrade
            e.Graphics.DrawString(
                //student.LowestGrade?.ToString("N") ?? "",
                student.Birthplace,
                font, Brushes.Black, x, y);
            x += colWidths[14];


            y += font.Height + 5;
            //y += 5;
            // Draw the bottom line of the student data row
            e.Graphics.DrawLine(
                Pens.CadetBlue,
                e.MarginBounds.Left, y,
                e.MarginBounds.Right, y);
            //y += font.Height;
            y += 2;
        }

        // Draw the bottom line of the header row
        e.Graphics.DrawLine(
            Pens.Black, e.MarginBounds.Left, y + font.Height,
            e.MarginBounds.Right, y + font.Height);

        // If there are more pages, indicate that there are more pages
        if (_endIndex < Students.StudentsList.Count)
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


    #region Print Preview Attributes

    // pages control
    private const int ItemsPerPage = 10;
    private int _currentPage = 1;
    private int _startIndex;
    private int _endIndex;

    // keep track of the DataGridViewSchoolClasses row index previousRowIndex
    private int _previousRowIndex = -1;

    #endregion
}