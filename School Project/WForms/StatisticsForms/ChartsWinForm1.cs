using ClassLibrary;
using System.Windows.Forms.DataVisualization.Charting;

namespace School_Project.WForms.StatisticsForms;

public partial class ChartsWinForm1 : Form
{
    // counting 
    private int _disciplinesCount;
    private int _gradesCount;
    private int _schoolClassesCount;
    private int _studentsCount;


    /// <summary>
    /// </summary>
    /// <param name="disciplines"></param>
    /// <param name="schoolClasses"></param>
    /// <param name="students"></param>
    /// <param name="grades"></param>
    public ChartsWinForm1()
    {
        InitializeComponent();
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
        /*
        List<KeyValuePair<string, int>> data = new();
        foreach (var schoolClass in _schoolClasses)
            data.Add(
                new KeyValuePair<string, int>
                    (schoolClass.ClassAcronym, schoolClass.Students.Count));
*/

        var chart = new Chart();

        BindingSource bindingSource = new();
        bindingSource.DataSource = SchoolClasses.ListSchoolClasses;

        chart.DataSource = bindingSource;
        chart.DataBindTable(bindingSource);

        chart.Show();

        //chart.DataSource = data;
        //chart.DataSource = _schoolClasses;

        chart.Series["Capital Pago"].YValueMembers = "value";
        chart.Series["Capital Pago"].XValueMember = "key";
        //chartAutoListPayments.Series["Juros Pagos"].YValueMembers =
        //    "JurosPagos";
        //chartAutoListPayments.Series["Juros Pagos"].XValueMember =
        //    "DataDoPagamento";
        //chartAutoListPayments.Series[2].YValueMembers = ;
        //chartAutoListPayments.Series[2].XValueMember = "DataDoPagamento";
        //chartAutoListPayments.Series[2] = ;
        chart.DataBind();
        chart.Show();
        /*
        chartFinanCarro.Series[0].ChartType = 
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
        chartFinanCarro.Series[1].ChartType =
            System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
        */


        Console.WriteLine("Debug point");
    }
}