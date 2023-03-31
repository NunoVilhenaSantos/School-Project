using System.Collections.ObjectModel;
using ClassLibrary;

namespace School_Project.WPF;

/// <summary>
///     Lógica interna para ChartWpfWindow.xaml
/// </summary>
public partial class ChartWpfWindow : Window
{
    public ChartWpfWindow(
    )
    {
        InitializeComponent();

        UpdateDataGridInfo();
    }


    public ISeries[] Series1 { get; set; }
        =
        {
            new LineSeries<double>
            {
                Values = new double[] {2, 1, 3, 5, 3, 4, 6},
                Fill = null
            }
        };

    public ISeries[] Series2 { get; set; }
        =
        {
            new LineSeries<int>
            {
                Values = new[] {4, 6, 5, 3, -3, -1, 2}
            },
            new ColumnSeries<double>
            {
                Values = new double[] {2, 5, 4, -2, 4, -3, 5}
            }
        };


    private void UpdateDataGridInfo()
    {
        var path = Directory.GetCurrentDirectory();

        MessageBox.Show(
            $"{path} | {Directory.GetCurrentDirectory()}");


        //
        // updating data for the data-grid
        //
        DataGridStudents.ItemsSource = Students.ListStudents;

        //
        // updating data for the data-grid
        //
        DataGridSchoolClasses.ItemsSource = SchoolClasses.ListSchoolClasses;

        //
        // updating data for the data-grid
        //
        UpdateChart();
    }


    private void UpdateChart()
    {
        /*
        INotifyCollectionChanged

        The INotifyCollectionChanged interface is provided by the
        .Net framework and it is widely used all over the framework,
        there are some classes that already implement the
        interface such as the ObservableCollection class,
        this class notifies the subscriber when you add,
        remove, insert, replace or clear the collection.
        */

        // since valuesCollection is of type ObservableCollection 
        // LiveCharts will update when you add,
        // remove, replace or clear the collection
        var valuesCollection = new ObservableCollection<double>();


        var lineSeries = new LineSeries<double>();
        lineSeries.Values = valuesCollection;

        valuesCollection.Add(4);
        valuesCollection.Add(6);
        valuesCollection.Add(2);
        // you should see the values in the user interface.


        // but in the following series, you will not see the change in the user interface.
        var valuesCollection2 = new List<double>();

        lineSeries = new LineSeries<double>();
        lineSeries.Values = valuesCollection2;

        valuesCollection2.Add(4);
        valuesCollection2.Add(6);
        valuesCollection2.Add(2);
        // the UI will not update automatically.

        CartesianChart cartesianChart = new();

        //valuesCollection= new ObservableCollection<double>();

        //LiveChartsCore.SkiaSharpView.WPF.UpdateChart(cartesianChart, valuesCollection);
        // cartesianChart.Series = (IEnumerable<ISeries>)studentsList.ToArray();
    }
}