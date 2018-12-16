using DemoLibrary;
using System.Windows;

namespace SampleAPIWPF
{
    /// <summary>
    /// Lógica interna para SunInfo.xaml
    /// </summary>
    public partial class SunInfo : Window
    {
        public SunInfo()
        {
            InitializeComponent();
        }

        private async void LoadSunInfo_Click(object sender, RoutedEventArgs e)
        {
            var sunInfo = await SunProcessor.LoadSunInformation();
            sunriseText.Text = $"Sunrise is at {sunInfo.Sunrise.ToLocalTime().ToShortTimeString()}";
            sunsetText.Text = $"Sunset is at {sunInfo.Sunset.ToLocalTime().ToShortTimeString()}";
        }
    
    }
}
