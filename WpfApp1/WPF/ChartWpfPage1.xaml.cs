using System.Collections.Generic;
using System.IO;
using System.Windows.Controls;
using ClassLibrary;

namespace School_Project.WPF;

/// <summary>
///     Interação lógica para ChartWpfPage1.xam
/// </summary>
public partial class ChartWpfPage1 : Page
{
    public ChartWpfPage1(List<SchoolClass> schoolClass)
    {
        InitializeComponent();

        SchoolClass = schoolClass;

        UpdateDataGridInfo();
    }

    private List<SchoolClass> SchoolClass { get; }

    private void UpdateDataGridInfo()
    {
        foreach (var schoolClass in SchoolClass)
            schoolClass.GetStudentsCount();

        var path = Directory.GetCurrentDirectory();

        MessageBox.Show(
            $"{path} | {Directory.GetCurrentDirectory()}");

        DataGrid.ItemsSource = SchoolClass;
    }
}