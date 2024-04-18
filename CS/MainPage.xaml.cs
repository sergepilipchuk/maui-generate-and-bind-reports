using System.Drawing;

using DevExpress.XtraReports.UI;

namespace maui_generate_and_bind_reports;

public partial class MainPage : ContentPage
{
    private string outputFileName;
    public MainPage()
    {
        InitializeComponent();

        XtraReport report = GenerateReport();

        outputFileName = Path.Combine(FileSystem.Current.AppDataDirectory, "Report.pdf");

        report.ExportToPdf(outputFileName);

        pdfViewer.DocumentSource = outputFileName;
    }

    private XtraReport GenerateReport()
    {
        XtraReport new_report = new XtraReport()
        {
            Bands = {
                new DetailBand(){
                    HeightF = 25,
                    Controls = {
                        new XRLabel() {
                            Name = "EmployeeName",
                            BoundsF = new RectangleF(0, 0, 250, 25),
                            ExpressionBindings =
                            {
                                new ExpressionBinding("Text", "[Name]")
                            }
                        },
                        new XRLabel() {
                            Name = "EmployeePosition",
                            BoundsF = new RectangleF(250, 0, 250, 25),
                            ExpressionBindings = {
                                new ExpressionBinding("Text", "[Position]")
                            }
                        }
                    }
                }
            }
        };
        EmployeeDataSource employeeDataSource = new EmployeeDataSource();
        new_report.DataSource = employeeDataSource.Employees;
        return new_report;
    }

    private async void OnShareReportButtonClicked(Object sender, EventArgs e)
    {
        await Share.Default.RequestAsync(new ShareFileRequest
        {
            Title = "Share the report",
            File = new ShareFile(outputFileName)
        });
    }
}
