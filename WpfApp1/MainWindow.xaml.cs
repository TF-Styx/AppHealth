using LiveCharts.Defaults;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<double> num1 = new List<double>();
            num1.Add(1);
            num1.Add(2);
            num1.Add(3);
            List<double> num2 = new List<double>();
            num2.Add(15);
            num2.Add(20);
            num2.Add(30);

            SeriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Values = new ChartValues<ObservablePoint>
                    {
                        new ObservablePoint(num1, num2),
                    },
                    PointGeometrySize = 15
                }
            };

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
    }
}
