using ClassLibrary.Students;

namespace School_Project.WForms.StudentsForms;

public partial class StudentEdit : Form
{
    //
    // Global variables to be used in this windows form
    // Variáveis globais do formulário do Windows
    //
    private readonly Student? _studentToEdit;


    public StudentEdit(int studentForEditing)
    {
        InitializeComponent();

        // assigning the parent variable to
        // the local variables to be edited
        _studentToEdit = Students.ListStudents[studentForEditing];

        DataUpdateValues();
    }


    private void WinForm_Load(object sender, EventArgs e)
    {
        //
        // inserir os dados nas caixas de textos
        //
        numericUpDownStudentID.Value = _studentToEdit.IdStudent;
        textBoxStudentName.Text = _studentToEdit.Name;
        textBoxStudentLastName.Text = _studentToEdit.LastName;
        textBoxStudentPhone.Text = _studentToEdit.Phone;
        textBoxStudentAddress.Text = _studentToEdit.Address;
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


    private void ButtonCancel_Click(object sender, EventArgs e)
    {
        Close();
    }


    private void ButtonSave_Click(object sender, EventArgs e)
    {
        if (ValidateTextBoxes())
        {
            _studentToEdit.Name = textBoxStudentName.Text;
            _studentToEdit.LastName = textBoxStudentLastName.Text;
            _studentToEdit.Address = textBoxStudentAddress.Text;
            _studentToEdit.Phone = textBoxStudentPhone.Text;

            Close();
        }
    }


    private bool ValidateTextBoxes()
    {
        if (
            string.IsNullOrEmpty(textBoxStudentName.Text) ||
            string.IsNullOrWhiteSpace(textBoxStudentName.Text))
        {
            MessageBox.Show(
                "Insira o Nome",
                "Nome",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBoxStudentName.Focus();
            return false;
        }


        if (
            string.IsNullOrEmpty(textBoxStudentLastName.Text) ||
            string.IsNullOrWhiteSpace(textBoxStudentLastName.Text))
        {
            MessageBox.Show(
                "Insira o apelido do estudante",
                "Apelido do Estudante",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            labelStudentLastName.Focus();
            return false;
        }

        return true;
    }


    private void TextBoxStudentPhone_KeyPress(object sender,
        KeyPressEventArgs e)
    {
        // validating if it's a digit
        if (char.IsDigit(e.KeyChar) || (Keys) e.KeyChar == Keys.Back) return;
        e.Handled = true;
    }


    private void DataUpdateValues()
    {
        // debugging point
        Console.WriteLine("Debug point");


        /*
         * update the count of students in each class
         */
        ;


        // debugging point
        Console.WriteLine("Debug point");

        UpdateDataGrid();
        UpdateChart();

        // debugging point
        Console.WriteLine("Debug point");
    }


    private void UpdateDataGrid()
    {
        // Set up the DataGridView.
        dataGridView1.Dock = DockStyle.Fill;

        // Automatically generate the DataGridView columns.
        dataGridView1.AutoGenerateColumns = true;

        // Set up the data source.
        BindingSource bindingSource1 = new()
        {
            DataSource = _studentToEdit
        };
        dataGridView1.DataSource = bindingSource1;

        // Automatically resize the visible rows.
        dataGridView1.AutoSizeRowsMode =
            DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

        // Set the DataGridView control's border.
        dataGridView1.BorderStyle = BorderStyle.Fixed3D;

        // Put the cells in edit mode when user enters them.
        dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;


        /*
        //
        // rebinding the data, so the system will refresh the info
        dataGridView1.DataSource = _studentToEdit.StudentCoursesGrades.ToArray();
        dataGridView1.AutoResizeColumns();
        dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;


        //dataGridView2 = new DataGridView();
        //dataGridView2.DataSource = _schoolClasses;
        //dataGridView2.AutoResizeColumns();
        //dataGridView2.AutoResizeRows();
        //dataGridView2.Show();
        */
        Console.WriteLine("Debug point");
    }


    private void UpdateChart()
        //private void ButtonHouseLoanChart_Click(object sender, EventArgs e)
    {
        //CasaUpdateListBoxValues();


        /*
         * ================================================================================
         * 
         * entered data set for the chart
         * that set from the list with the values
         * total amount of interest
         * and the total amount of capital paid
         * 
         * 
         */

        //chart1.DataSource = null;
        chart1.DataSource = _studentToEdit;

        chart1.Series["Series1"].YValueMembers = "value";
        chart1.Series["Series1"].XValueMember = "key";
        //chartAutoListPayments.Series["Juros Pagos"].YValueMembers =
        //    "JurosPagos";
        //chartAutoListPayments.Series["Juros Pagos"].XValueMember =
        //    "DataDoPagamento";

        chart1.DataBind();
        // chart1.Show();
        /*
        chartFinanCarro.Series[0].ChartType = 
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
        chartFinanCarro.Series[1].ChartType =
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
        */


        Console.WriteLine("Debug point");
    }
}