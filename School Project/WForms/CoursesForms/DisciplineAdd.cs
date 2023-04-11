using System.Drawing.Printing;
using System.Reflection;
using System.Windows.Forms.DataVisualization.Charting;
using ClassLibrary.Courses;
using ClassLibrary.Enrollments;
using ClassLibrary.School;
using ClassLibrary.SchoolClasses;
using ClassLibrary.Students;
using Serilog;

namespace School_Project.WForms.CoursesForms;

public partial class DisciplineAdd : Form
{
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
        if (Courses.CoursesList.Count > 0)
        {
            _disciplinesCount = Courses.CoursesList.Count;
            _disciplinesCount = Courses.GetLastId();
        }

        //
        // 
        // assign the local variables to is
        // counterpart Global variables from the initial form
        // 
        //
        if (Courses.CoursesList.Count > 0)
            _coursesCount = Courses.GetLastId();

        if (SchoolClasses.SchoolClassesList.Count > 0)
            _schoolClassesCount = SchoolClasses.GetLastId();

        if (Students.StudentsList.Count > 0)
            _studentsCount = Students.GetLastId();

        SchoolClasses.ToObtainValuesForCalculatedFields();

        //
        // make the transparent tab-control transparent
        // transparentTabControl1.MakeTransparent();
        //
        transparentTabControl1.MakeTransparent();
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[1];

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
        if (e is {Modifiers: Keys.Control, KeyCode: Keys.V})
        {
            ((TextBox) sender).Paste();
            Console.WriteLine("Testes de Debug");
        }
    }

    private void ButtonSave_Click(object sender, EventArgs e)
    {
        if (!ValidateTextBoxes()) return;

        Courses.AddCourse(
            (int) numericUpDownDisciplineID.Value,
            textBoxDisciplineName.Text,
            (int) numericUpDownNumberHours.Value,
            0
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
        Courses.GetStudentsCount();

        //
        // first chart
        //

        //chart1.DataBind();
        chart1.Series.Clear();
        chart1.Series.Add("Students Count");
        chart1.Series.Add("Average Grade");
        chart1.Series.Add("Highest Grade");
        chart1.Series.Add("Lowest Grade");
        chart1.Series["Students Count"].ChartType = SeriesChartType.Column;
        chart1.Series["Average Grade"].ChartType = SeriesChartType.Line;
        chart1.Series["Highest Grade"].ChartType = SeriesChartType.Point;
        chart1.Series["Lowest Grade"].ChartType = SeriesChartType.Point;
        chart1.Series["Average Grade"].BorderWidth = 3;


        foreach (var course in Courses.CoursesList)
        {
            var courseEnrollments =
                Enrollments.ListEnrollments.Where(e =>
                    e.CourseId == course.IdCourse);
            var courseAverageGrade = courseEnrollments.Any()
                ? courseEnrollments.Average(e => e.Grade)
                : 0;
            var courseHighestGrade = courseEnrollments.Any()
                ? courseEnrollments.Max(e => e.Grade)
                : 0;
            var courseLowestGrade = courseEnrollments.Any()
                ? courseEnrollments.Min(e => e.Grade)
                : 0;

            chart1.Series["Students Count"].Points
                .AddXY(course.Name, course.StudentsCount);
            chart1.Series["Average Grade"].Points
                .AddXY(course.Name, courseAverageGrade);
            chart1.Series["Highest Grade"].Points
                .AddXY(course.Name, courseHighestGrade);
            chart1.Series["Lowest Grade"].Points
                .AddXY(course.Name, courseLowestGrade);

            chart1.Series["Average Grade"].YAxisType = AxisType.Secondary;
            chart1.Series["Highest Grade"].YAxisType = AxisType.Secondary;
            chart1.Series["Lowest Grade"].YAxisType = AxisType.Secondary;
        }

        chart1.DataBind();


        // *
        // * 1st 
        // * Data bindings
        // * 
        // *
        _bSListCourses.DataSource = Courses.CoursesList;
        _bSListStudents.DataSource = Students.StudentsList;

        _bSListCourses.ResetBindings(false);
        _bSListStudents.ResetBindings(false);

        _bSListCourses.ResetBindings(true);
        _bSListStudents.ResetBindings(true);


        // *
        // * 2nd 
        // * checkedListBox
        // * must be add before the dataGridView 
        // *
        checkedListBox1.DataSource = _bSListStudents;
        //checkedListBoxStudents.DisplayMember = "Name";
        //checkedListBoxStudents.DisplayMember = "FullName";
        //checkedListBoxStudents.ValueMember = "IdStudent";


        // *
        // * 3rd 
        // * dataGridView
        // * must be add after the dataGridView 
        // *

        // Set the DataSource property of the DataGridView to the BindingSource object
        dataGridView1.DataSource = _bSListCourses;

        // Set the AutoGenerateColumns property of the DataGridView to true
        dataGridView1.AutoGenerateColumns = true;

        // Set the BackgroundColor property of the DataGridView to Color.Transparent
        // this cant be used because gives an error
        //dataGridViewSchoolClasses.BackgroundColor = Color.Transparent;
        dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
        dataGridViewSearch.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;


        // Update the data source of the dataGridViewSchoolClasses control
        dataGridView1.Refresh();


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

        var property = typeof(Course)
            .GetProperty(selectedProperty ?? string.Empty);
        var filteredCourse =
            Courses.CoursesList
                .Where(course => property != null &&
                                 property.GetValue(course)
                                     .ToString() != "").ToList();

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
        // This will change the selected tab page of transparentTabControl1 to the second tab page. 
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[1];

        // by rows
        // var to retain the value of the index, by row or cell
        var rc = -1;
        foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;

        // by cells
        if (dataGridView1.CurrentCell != null)
            //for find the row index number
            rc = dataGridView1.CurrentCell.RowIndex;


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
        var selectedCourse = (Course) _bSListCourses.Current;

        // Get the IdSchoolClass from the selected school class from the data source
        var index = selectedCourse.IdCourse;

        // send a msg to the user to chose if he wants to delete or not the record
        var msg =
            "Tem a certeza que deseja apagar o seguinte registo?" +
            $"\n{Courses.GetFullInfo(index)}";

        var dialogResult = MessageBox.Show(
            msg, "Apagar",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);

        if (dialogResult == DialogResult.OK)
        {
            MessageBox.Show(Courses.DeleteCourse(index));

            UpdateLists();
        }


        Console.WriteLine("Testes de Debug");
    }


    private void ButtonEdit_Click(object sender, EventArgs e)
    {
        //
        // cast the selected object to be displayed in the dialog box
        //
        //var disciplineToEdit = listBoxDisciplines.SelectedItem! as Course;

        //if (disciplineToEdit != null)
        //{
        //    //
        //    // open the edit form with the student editing
        //    //
        //    DisciplineEdit disciplineEdit = new(disciplineToEdit.IdCourse);
        //    disciplineEdit.ShowDialog();
        //}
        //else
        //{
        //    MessageBox.Show(
        //        "Tem de selecionar para poder Adicionar ou Remover ", "Editar",
        //        MessageBoxButtons.OK, MessageBoxIcon.Warning
        //    );
        //}

        //UpdateLists();

        // This will change the selected tab page of transparentTabControl1 to the second tab page. 
        transparentTabControl1.SelectedTab = transparentTabControl1.TabPages[1];

        // Get the selected school class from the data source
        var selectedCourse = (Course) _bSListCourses.Current;

        if (selectedCourse == null)
        {
            MessageBox.Show(
                "Tem de selecionar para poder Adicionar ou Remover ",
                "Editar",
                MessageBoxButtons.OK, MessageBoxIcon.Warning
            );
            return;
        }

        // Get the IdSchoolClass from the selected school class from the data source
        var index = selectedCourse.IdCourse;

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
        DisciplineEdit disciplineEdit = new(selectedCourse);
        if (disciplineEdit.ShowDialog() == DialogResult.OK)
            // redraw the list with the new data
            UpdateLists();
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

    private void DataGridView_Scroll(
        object sender, ScrollEventArgs e)
    {
        // If the scroll event is for scrolling the vertical bar, update the selected school class
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
        var selectedCourse = (Course) _bSListCourses.Current;

        // Get the students for the selected course from the data source
        var selectedCoursesEnrollmentsStudents = Enrollments.ListEnrollments
            .Where(x => x.CourseId == selectedCourse.IdCourse)
            .Select(e => e.StudentId)
            .ToList();

        var selectedCourseEnrollments = Enrollments.ListEnrollments
            .Where(x => x.CourseId == selectedCourse.IdCourse)
            .ToList();

        var selectedCourseStudents = selectedCourseEnrollments
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
            var student = (Student) checkedListBox1.Items[i];
            checkedListBox1.SetItemChecked(i,
                selectedCoursesEnrollmentsStudents.Contains(student.IdStudent));
        }

        // Update the previous row index
        _previousRowIndex = dataGridView1.CurrentCell.RowIndex;
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
        CoursesSearch coursesSearch = new();
        coursesSearch.ShowDialog();
        coursesSearch.Dispose();
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
        MessageBox.Show("Temos estudante(s) para adicionar, vamos lá.");
        var courseToAddStudents = (Course) _bSListCourses.Current;

        //
        // cycle to evaluate which student(s) are select and add it
        //

        // Select students from CheckedListBox control and create a list of students
        var selectedStudents =
            checkedListBox1.CheckedItems
                .Cast<Student>()
                .ToList();

        // Get all students that are currently enrolled in the course
        var enrolledStudents =
            SchoolDatabase.GetStudentsInCourse(courseToAddStudents.IdCourse);

        // Identify students to be removed
        var studentsToRemove =
            enrolledStudents.Except(selectedStudents).ToList();

        // Identify students to add
        var studentsToAdd =
            selectedStudents.Except(enrolledStudents).ToList();

        // Display message boxes with counts
        MessageBox.Show(
            $"Selected students: {selectedStudents.Count}\n" +
            $"Enrolled students: {enrolledStudents.Count}\n" +
            $"Students to remove: {studentsToRemove.Count}\n" +
            $"Students to add: {studentsToAdd.Count}");


        // Enroll the selected students in the course
        try
        {
            SchoolDatabase.EnrollStudentsInCourse(selectedStudents,
                courseToAddStudents.IdCourse);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Error enrolling students in course");
        }

        // Unenroll students to be removed from the course
        try
        {
            SchoolDatabase.UnenrollStudentsFromCourse(
                studentsToRemove, courseToAddStudents.IdCourse);
        }
        catch (Exception ex)
        {
            Log.Error(ex,
                "Error unenrolling students from course");
        }

        MessageBox.Show("Student enrollments updated successfully.");

        // Update calculations and UI
        SchoolClasses.ToObtainValuesForCalculatedFields();
        Courses.GetStudentsCount();
        UpdateLists();

        // Store previous row index and update UI
        var currentRowIndex = dataGridView1.CurrentCell.RowIndex;
        _previousRowIndex = currentRowIndex + 1;
        UpdateSelectedData();
        _previousRowIndex = currentRowIndex;

        Console.WriteLine("Debug tests");
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
        //pd.DefaultPageSettings.Landscape = true;
        pd.DocumentName = "List of Course";

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
            Courses.CoursesList.Count);

        // Define the column widths and headers
        var colWidths = new[]
            {60, 400, 60, 60, 50};
        var colHeaders = new[]
        {
            "Course ID ", "Name", "Work Load", "Credits", "Students Count"
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
            var course = Courses.CoursesList[i];

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
                course.IdCourse.ToString("N0"),
                font, Brushes.Black, e.MarginBounds.Left, y);
            x = e.MarginBounds.Left + colWidths[0];

            //y += font.Height + 5;
            // Print the class name
            e.Graphics.DrawString(course.Name, font, Brushes.Black, x, y);
            x += colWidths[1];

            //y += font.Height + 10;
            // Print the start date
            e.Graphics.DrawString(course.WorkLoad.ToString("N"),
                font, Brushes.Black, x, y);
            x += colWidths[2];

            // Print the end date
            e.Graphics.DrawString(course.Credits.ToString("N"),
                font, Brushes.Black, x, y);
            x += colWidths[3];

            // Print the start hour
            e.Graphics.DrawString(course.StudentsCount.ToString(),
                font, Brushes.Black, x, y);
            x += colWidths[4];

            y += font.Height + 5;
        }

        // Draw the bottom line of the header row
        e.Graphics.DrawLine(
            Pens.Black,
            e.MarginBounds.Left, y + font.Height,
            e.MarginBounds.Right, y + font.Height);


        // If there are more pages, indicate that there are more pages
        if (_endIndex < Courses.CoursesList.Count)
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

    #region Attributes

    // BindingSource for combo-boxes and data-grids 
    private readonly BindingSource _bSCoursesStudents = new();
    private readonly BindingSource _bSListCourses = new();
    private readonly BindingSource _bSListStudents = new();
    private readonly BindingSource _bSourceSearchList = new();
    private readonly BindingSource _bSourceSearchOptions = new();
    private readonly BindingSource _bSsClassesCourses = new();

    // retention of the last ID of each class 
    private int _coursesCount;
    private int _disciplinesCount;
    private int _schoolClassesCount;
    private int _studentsCount;

    // retention of the photo
    private string _photoFile;

    // pages control
    private const int ItemsPerPage = 55;
    private int _currentPage = 1;
    private int _startIndex;
    private int _endIndex;

    // keep track of the DataGridViewSchoolClasses row index previousRowIndex
    private int _previousRowIndex = -1;

    #endregion
}