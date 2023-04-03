using ClassLibrary;
using System.Windows.Forms.DataVisualization.Charting;

namespace School_Project.WForms.StatisticsForms;

public partial class ChartsWinForm : Form
{
    public ChartsWinForm(
    )
    {
        InitializeComponent();
    }

    internal int DisciplinesCount { get; private set; }
    internal int SchoolClassesCount { get; private set; }
    internal int StudentsCount { get; private set; }
    internal int GradesCount { get; private set; }


    private void ChartsWinForm_Load(object sender, EventArgs e)
    {
        //
        // assign the local variables to is counterpart
        // Global variables from the initial form
        //

        if (Courses.ListCourses.Count > 0)
            DisciplinesCount = Courses.ListCourses[^1].IdCourse;
        if (SchoolClasses.ListSchoolClasses.Count > 0)
            SchoolClassesCount =
                SchoolClasses.ListSchoolClasses[^1].IdSchoolClass;
        if (Students.ListStudents.Count > 0)
            StudentsCount = Students.ListStudents[^1].IdStudent;
        //if (Library._grades.Count > 0) _gradesCount = _grades.Count;

        DataUpdateValues();
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


    private void DataUpdateValues()
    {
        // debugging point
        Console.WriteLine("Debug point");

        /*
        // call the method to update all info
        // it's a method that calculates all need information
        // about the loan
        FinanciamenteCasa.CalcularValoresEmprestimo();


        // update the values on all displaying boxes
        numericUpDownHousePayment.Value =
            FinanciamenteCasa.PagamentoMensal;
        dateTimePickerHouseDateTerm.Value =
            FinanciamenteCasa.DataFimPagamento;
        numericUpDownHouseSpreadValue.Value =
            FinanciamenteCasa.ValorTaxaSpread;
        numericUpDownHouseAmortizaçãoAntecipada.Value =
            FinanciamenteCasa.ValorAmortizaçãoAntecipada;
        numericUpDownHouseMTIC.Value =
            FinanciamenteCasa.ValorTotalPrestações;
        numericUpDownHouseTotalAmountInterest.Value =
            FinanciamenteCasa.ValorTotalJuros;
        

        // update the list of payments with the new values
        // it's a method that creates a list of payments
        // during that period
        FinanciamenteCasa.ListagemPagamentos();


        // apresentar a lista de movimentos numa caixa de texto
        //FinanciamentoCarro.ShowMsg = true;
        FinanciamenteCasa.TestIPmt();
        FinanciamenteCasa.TestPmt();
        FinanciamenteCasa.TestPPmt();
        FinanciamenteCasa.ShowMsg = false;
        */

        /*
         * update the count of students in each class
         */
        foreach (var item in SchoolClasses.ListSchoolClasses)
            item.GetStudentsCount();


        Console.WriteLine("Debug point");
        //buttonHouseLoanChart.PerformClick();


        //buttonUpdateHouseLoanDataGrid.PerformClick();
        UpdateDataGrid();
        UpdateChart();

        Console.WriteLine("Debug point");
    }


    private void UpdateDataGrid()
    //private void ButtonUpdateHouseLoanDataGrid_Click(object sender, EventArgs e)
    {
        //
        // rebinding the data, so the system will refresh the info
        dataGridView1.DataSource = null;
        dataGridView1.DataSource = SchoolClasses.ListSchoolClasses;
        dataGridView1.AutoResizeColumns();
        dataGridView1.AutoSizeColumnsMode =
            DataGridViewAutoSizeColumnsMode.AllCells;


        //dataGridView2 = new DataGridView();
        dataGridView2.DataSource = null;
        dataGridView2.DataSource = SchoolClasses.ListSchoolClasses;
        dataGridView2.AutoResizeColumns();
        dataGridView2.AutoResizeRows();
        //dataGridView2.Show();

        Console.WriteLine("Debug point");
    }

    private void UpdateChart()
    {
        using var chartStudents = new Chart();
        chartStudents.DataSource = Students.ListStudents;
        //chartStudents.DataBindTable(Students.ListStudents);
        chartStudents.DataBind();
        chartStudents.Show();

        using var chartPayments = new Chart();
        chartPayments.DataSource = Students.ListStudents;
        chartPayments.DataBind();
        chartPayments.Show();

        Console.WriteLine("Debug point");
    }

    /*
    private void UpdateChart()
    {
         * ================================================================================
         * 
         * entered data set for the chart
         * that set from the list with the values
         * total amount of interest
         * and the total amount of capital paid
         * 
         * 
        List<KeyValuePair<string, int>> data = new();
        foreach (var schoolClass in _schoolClassesList)
            data.Add(
                new KeyValuePair<string, int>
                    (schoolClass.ClassAcronym, schoolClass.Students.Count));
  
        BindingSource bindingSource1 = new();
        bindingSource1.DataSource = Students.ListStudents;

        var chart1 = new Chart();
        chart1.DataSource = bindingSource1;
        chart1.DataBindTable(bindingSource1);
        chart1.Show();

        BindingSource bindingSource2 = new();
        bindingSource2.DataSource = Students.ListStudents;

        var chart2 = new Chart();
        //chart2.DataSource = data;
        chart2.DataSource = bindingSource2;

        //chart2.Series["Capital Pago"].YValueMembers = "value";
        //chart2.Series["Capital Pago"].XValueMember = "key";
        //chartAutoListPayments.Series["Juros Pagos"].YValueMembers =
        //    "JurosPagos";
        //chartAutoListPayments.Series["Juros Pagos"].XValueMember =
        //    "DataDoPagamento";
        //chartAutoListPayments.Series[2].YValueMembers = ;
        //chartAutoListPayments.Series[2].XValueMember = "DataDoPagamento";
        //chartAutoListPayments.Series[2] = ;
        //chart2.DataBind();
        //chart2.Show();
        
        //chartFinanCarro.Series[0].ChartType = 
        //    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
        //chartFinanCarro.Series[1].ChartType =
        //    System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
  

        //Console.WriteLine("Debug point");
    }
    */
}