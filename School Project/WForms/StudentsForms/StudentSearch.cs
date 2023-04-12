using System.Reflection;
using ClassLibrary.Students;

namespace School_Project.WForms.StudentsForms;

public partial class StudentSearch : Form
{
    //private readonly BindingSource _bSListSClasses = new();
    private readonly BindingSource _bSListStudents = new();
    private readonly BindingSource _bSourceSearchList = new();
    private readonly BindingSource _bSourceSearchOptions = new();

    public StudentSearch()
    {
        InitializeComponent();
    }

    private void SchoolClassSearch_Load(object sender, EventArgs e)
    {
        //
        // initial update
        // count register and the list
        //
        UpdateLists();
        //UpdateLabelsCounts();
        //groupBoxAddSchollClass.ForeColor = Color.White;
        KeyPreview = true;
    }


    private void WinForm_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Escape) Close();
    }


    private void ButtonClose_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void UpdateLists()
    {
        // *
        // * 
        // * Data bindings
        // * 
        // *
        //_bSListCourses.DataSource = Courses.CoursesList;
        _bSListStudents.DataSource = Students.StudentsList;
        //_bSListStudents.DataSource = Students.StudentsList;

        //_bSListCourses.ResetBindings(false);
        _bSListStudents.ResetBindings(false);
        //_bSListStudents.ResetBindings(false);

        //_bSListCourses.ResetBindings(true);
        _bSListStudents.ResetBindings(true);
        //_bSListStudents.ResetBindings(true);

        // Set the DataSource property of the DataGridView to the BindingSource object
        dataGridViewSchoolClasses.DataSource = _bSListStudents;

        // Set the AutoGenerateColumns property of the DataGridView to true
        dataGridViewSchoolClasses.AutoGenerateColumns = true;

        // Set the BackgroundColor property of the DataGridView to Color.Transparent
        // this cant be used because gives an error
        //dataGridViewSchoolClasses.BackgroundColor = Color.Transparent;
        dataGridViewSchoolClasses.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;


        // Update the data source of the dataGridViewSchoolClasses control
        dataGridViewSchoolClasses.Refresh();
        //dataGridViewSchoolClasses.Refresh();


        // To display all the properties of the Student class
        // in the comboBoxSearchOptions,
        // you can use reflection to get a list
        // of the property names and set the DataSource
        // and DisplayMember properties of the combobox accordingly.
        // Here's an example code snippet to achieve this:

        _bSourceSearchOptions.DataSource = typeof(Student);
        var properties =
            typeof(Student).GetProperties(BindingFlags.Public |
                                          BindingFlags.Instance);

        List<string> propertyNames = new();
        foreach (var property in properties) propertyNames.Add(property.Name);

        comboBoxSearchOptions.DataSource = propertyNames;
        comboBoxSearchOptions.DisplayMember = "ToString()";


        //_bSourceSearchList.DataSource = Students.ConsultStudent;
        comboBoxSearchList.DataSource = _bSourceSearchList;
        //dataGridViewSearch.DataSource = _bSourceSearchList;
        //dataGridViewSearch.AutoResizeColumns();

        _bSourceSearchOptions.ResetBindings(false);
        _bSourceSearchList.ResetBindings(false);

        _bSourceSearchOptions.ResetBindings(true);
        _bSourceSearchList.ResetBindings(true);

        //dataGridViewSearch.Refresh();
        //dataGridViewSearch.Update();


        Console.WriteLine("Testes de Debug");
    }


    private void ComboBoxSearchOptions_SelectedIndexChanged(
        object sender, EventArgs e)
    {
        // Check if the selected item is null or empty
        if (string.IsNullOrEmpty(
                comboBoxSearchOptions.SelectedItem?.ToString()))
            return;


        // Get the name of the selected property
        var selectedProperty =
            comboBoxSearchOptions.SelectedItem.ToString();

        // Create a new list to store the filtered results

        // Get the PropertyInfo object for the selected property of the SchoolClass type
        var property = typeof(Student)
            .GetProperty(selectedProperty ?? string.Empty);

        // Create a new list to store the filtered results
        var filteredStudents =
            Students.StudentsList
                .Where(s =>
                    property?.GetValue(s)?.ToString() != null &&
                    property.GetValue(s).ToString() != "")
                .ToList();


        // Create a list of distinct values for the selected property from all SchoolClass objects
        var propertyValues = Students.StudentsList
            .Select(s => s.GetType().GetProperty(selectedProperty)?.GetValue(s))
            .Where(value => value != null)
            .Distinct()
            .ToList();

        _bSourceSearchList.DataSource = propertyValues;
        // dataGridViewSchoolClasses.DataSource = _bSListSClasses;
    }

    private void ComboBoxSearchList_SelectedIndexChanged(
        object sender, EventArgs e)
    {
        // Get the selected property name
        var selectedProperty = comboBoxSearchOptions.SelectedItem.ToString();

        // Get the name of the selected property
        var selectedValue =
            comboBoxSearchList.SelectedItem;

        // Create a new list to store the filtered results
        List<Student> filteredStudent = new();

        var property = typeof(Student).GetProperty(selectedProperty);
        foreach (var s in Students.StudentsList)
        {
            if (property == null ||
                (property?.GetValue(s)?.ToString() != null &&
                 property.GetValue(s).ToString() != ""))
                continue;

            filteredStudent.Add(s);
        }

        // Get the property values and convert them to the appropriate type
        var propertyValues = Students.StudentsList
            .Select(s =>
            {
                var value =
                    s.GetType().GetProperty(selectedProperty)?.GetValue(s);
                if (value != null && value.GetType() == typeof(DateTime))
                    // Convert the value to DateTime and remove the time component
                    value = ((DateTime) value).Date;
                return value;
            })
            .Where(value => value != null)
            .Distinct()
            .ToList();


        var propertyValues3 =
            Students.ConsultStudents(
                selectedProperty, selectedValue);


        dataGridViewSchoolClasses.DataSource = propertyValues3;
        dataGridViewSchoolClasses.AutoGenerateColumns = true;
        dataGridViewSchoolClasses.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;
    }
}