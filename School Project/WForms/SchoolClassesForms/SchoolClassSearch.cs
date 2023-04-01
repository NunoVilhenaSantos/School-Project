using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_Project.WForms.SchoolClassesForms
{
    public partial class SchoolClassSearch : Form
    {
        private readonly BindingSource _bSListSClasses = new();
        private readonly BindingSource _bSourceSearchOptions = new();
        private readonly BindingSource _bSourceSearchList = new();

        public SchoolClassSearch()
        {
            InitializeComponent();
        }

        private void ButtonClose_Click(object sender, EventArgs e)
        {
            Close();
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
        }


        private void UpdateLists()
        {
            // *
            // * 
            // * Data bindings
            // * 
            // *
            //_bSListCourses.DataSource = Courses.ListCourses;
            _bSListSClasses.DataSource = SchoolClasses.ListSchoolClasses;
            //_bSListStudents.DataSource = Students.ListStudents;

            //_bSListCourses.ResetBindings(false);
            _bSListSClasses.ResetBindings(false);
            //_bSListStudents.ResetBindings(false);

            //_bSListCourses.ResetBindings(true);
            _bSListSClasses.ResetBindings(true);
            //_bSListStudents.ResetBindings(true);

            // Set the DataSource property of the DataGridView to the BindingSource object
            dataGridViewSchoolClasses.DataSource = _bSListSClasses;

            // Set the AutoGenerateColumns property of the DataGridView to true
            dataGridViewSchoolClasses.AutoGenerateColumns = true;

            // Set the BackgroundColor property of the DataGridView to Color.Transparent
            // this cant be used because gives an error
            //dataGridViewSchoolClasses.BackgroundColor = Color.Transparent;
            dataGridViewSchoolClasses.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

            //checkedListBoxCourses.DataSource = _bSListCourses;
            //checkedListBoxCourses.DisplayMember = "Name";
            //checkedListBoxCourses.DisplayMember = "FullName";
            //checkedListBoxCourses.ValueMember = "IdCourse";

            //checkedListBoxStudents.DataSource = _bSListStudents;
            //checkedListBoxStudents.DisplayMember = "Name";
            //checkedListBoxStudents.DisplayMember = "FullName";
            //checkedListBoxStudents.ValueMember = "IdStudent";


            // Update the data source of the dataGridViewSchoolClasses control
            dataGridViewSchoolClasses.Refresh();
            //dataGridViewSchoolClasses.Refresh();


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
            foreach (var property in properties)
            {
                propertyNames.Add(property.Name);
            }

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


        //private void ComboBoxSearchOptions_SelectedIndexChanged(object sender, EventArgs e)
        private void ComboBoxSearchOptions_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            // Get the name of the selected property
            var selectedProperty =
                comboBoxSearchOptions.SelectedItem.ToString();

            // Create a new list to store the filtered results
            List<SchoolClass> filteredSchoolClass = new();

            var property = typeof(SchoolClass).GetProperty(selectedProperty);
            foreach (var schoolClass in SchoolClasses.ListSchoolClasses)
            {
                if (property == null ||
                    property.GetValue(schoolClass).ToString() == "")
                    continue;

                filteredSchoolClass.Add(schoolClass);
            }

            //_bSourceSearchList.DataSource = filteredSchoolClass;
            //_bSourceSearchList.DataSource = Students.ListStudents.Select(s => s.GetType().GetProperty(selectedProperty).GetValue(s)).ToList();

            var propertyValues = SchoolClasses.ListSchoolClasses
                .Select(sC =>
                    sC.GetType().GetProperty(selectedProperty)?.GetValue(sC))
                .Where(value => value != null)
                .Distinct()
                .ToList();

            _bSourceSearchList.DataSource = propertyValues;
            // dataGridViewSchoolClasses.DataSource = _bSListSClasses;
        }

        private void ComboBoxSearchList_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            // Get the name of the selected property
            var selectedProperty =
                comboBoxSearchOptions.SelectedItem.ToString();

            // Get the name of the selected property
            var selectedValue =
                comboBoxSearchList.SelectedItem;

            var convertedValue =
                Convert.ChangeType(selectedValue, selectedProperty.GetType());
            
            var propertyValues1 = SchoolClasses.ListSchoolClasses
                .Select(x =>
                    x.GetType().GetProperty(selectedProperty)
                        ?.GetValue(x))
                .Where(value => value == selectedValue)
                //.Distinct()
                .ToList();

            var propertyValues2 = SchoolClasses.ListSchoolClasses
                .Select(x =>
                    x.GetType().GetProperty(selectedProperty)?.GetValue(x))
                .Where(value => value != null && value.Equals(convertedValue) ==
                    true)
                //.Distinct()
                .ToList();


            var consultSchoolClasses =
                SchoolClasses.ConsultSchoolClasses(
                    null, // int id,
                    "", //string classAcronym,
                    "", //string className,
                    default, //DateOnly startDate,
                    default, //DateOnly endDate,
                    default, //TimeOnly startHour,
                    default, //TimeOnly endHour,
                    "", //string location,
                    "", //string type,
                    "", //string area,
                    null, //int studentsCount,
                    //List<Student>? studentsList
                    null);

            var propertyValues3 =
                SchoolClasses.ConsultSchoolClasses(
                    selectedProperty, selectedValue);

            //dataGridViewSchoolClasses.DataSource = propertyValues;
            dataGridViewSchoolClasses.DataSource = propertyValues3;
            dataGridViewSchoolClasses.AutoGenerateColumns = true;
            dataGridViewSchoolClasses.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;
        }
    }
}