using ByteETA.Core.Models;
using ByteETA.Core.Services;

namespace ByteETA.UI
{
    public partial class Form : System.Windows.Forms.Form
    {
        private readonly CalculatorService _calculatorService;

        public Form()
        {
            InitializeComponent();
            _calculatorService = new CalculatorService();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            cbFileUnit.DataSource = Enum.GetValues(typeof(FileUnit));
            cbInternetUnit.DataSource = Enum.GetValues(typeof(SpeedUnit));

            cbFileUnit.SelectedIndex = 2; //Default GB
            cbInternetUnit.SelectedIndex = 1; //Default Mbps
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            FileUnit selectedFileUnit = (FileUnit)(cbFileUnit.SelectedItem ?? FileUnit.GB);
            SpeedUnit selectedSpeedUnit = (SpeedUnit)(cbInternetUnit.SelectedItem ?? SpeedUnit.Mbps);

            var file = new ByteETA.Core.Models.FileInfo((double)nupFileSize.Value, (FileUnit)(cbFileUnit.SelectedItem ?? FileUnit.GB));
            var internet = new InternetInfo((double)nupInternetSpeed.Value, (SpeedUnit)(cbInternetUnit.SelectedItem ?? SpeedUnit.Mbps));

            TimeSpan _result = _calculatorService.CalculateDownloadTime(internet, file);

            string _readableResult = _calculatorService.GetReadableTime(_result);

            MessageBox.Show(this, $" {_readableResult}", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);

            nupFileSize.Value = 0;
            nupInternetSpeed.Value = 0;

            nupFileSize.Focus();
        }
    }
}