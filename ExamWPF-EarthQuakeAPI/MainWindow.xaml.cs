using System.Collections.Generic;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;
using ExamWPF_EarthQuakeApi.Models;
using Newtonsoft.Json;

namespace ExamWPF_EarthQuakeAPI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            gridInformation.IsReadOnly = true;
        }

        private void TextBoxSearchCountPreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = new Regex("[^0-9]+").IsMatch(e.Text);
        }

        public void ShowInfo(int text)
        {
            using (WebClient web = new WebClient())
            {
                var url = $"https://earthquake.usgs.gov/fdsnws/event/1/query?format=geojson&limit={text}";

                var json = web.DownloadString(url);

                var result = JsonConvert.DeserializeObject<GeoInformationJSON.GeoData>(json);

                GeoInformationJSON.GeoData data = result;

                List<GeoInformation> geoInformation = new List<GeoInformation>();
                for (int i = 0; i < text; i++)
                {
                    geoInformation.Add(new GeoInformation { Magnitude = data.features[i].properties.mag, Place = data.features[i].properties.place, Time = data.features[i].properties.time, EpicenterDepth = data.features[i].properties.sig });
                };
                gridInformation.ItemsSource = geoInformation;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ShowInfo(int.Parse(textBoxSearchCount.Text));
        }
    }
}
