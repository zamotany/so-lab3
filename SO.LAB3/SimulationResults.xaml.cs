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
using System.Windows.Shapes;

namespace SO.LAB3
{
    /// <summary>
    /// Interaction logic for SimulationResults.xaml
    /// </summary>
    public partial class SimulationResults : Window
    {
        public SimulationResults(float count, float fifo, float opt, float lru, float alru, float rand)
        {
            InitializeComponent();
            FIFOLabel.Content = (fifo / count).ToString();
            OPTLabel.Content = (opt / count).ToString();
            LRULabel.Content = (lru / count).ToString();
            ALRULabel.Content = (alru / count).ToString();
            RANDLabel.Content = (rand / count).ToString();
        }

        private void closeButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
