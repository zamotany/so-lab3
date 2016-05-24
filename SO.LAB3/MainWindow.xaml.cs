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

namespace SO.LAB3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<int> m_Requests;
        private FIFOAlgorithm m_FIFO;
        private OPTAlgorithm m_OPT;
        private LRUAlgorithm m_LRU;
        private A_LRUAlgorithm m_ALRU;
        private RANDAlgorithm m_RAND;
        private List<DataItem> m_Data;

        private static bool m_CustomRequests = false;

        public MainWindow()
        {
            InitializeComponent();
            FramesTextBox.Text = "4";
            RequestsTextBox.Text = "26";
            MaxValueTextBox.Text = "10";
            m_Data = new List<DataItem>();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = false;
            m_Data.Clear();
            DataGrid.ItemsSource = null;
            DataGrid.ItemsSource = m_Data;

            if (m_CustomRequests)
                HandleCustomRequests();
            else
            {
                m_Requests = new List<int>();
                RequestsGenerator gen = new RequestsGenerator(
                    int.Parse(RequestsTextBox.Text),
                    1,
                    int.Parse(MaxValueTextBox.Text)
                    );
                m_Requests.AddRange(gen.Requests);
            }

            m_FIFO = new FIFOAlgorithm(m_Requests, int.Parse(FramesTextBox.Text));
            m_OPT = new OPTAlgorithm(m_Requests, int.Parse(FramesTextBox.Text));
            m_LRU = new LRUAlgorithm(m_Requests, int.Parse(FramesTextBox.Text));
            m_ALRU = new A_LRUAlgorithm(m_Requests, int.Parse(FramesTextBox.Text));
            m_RAND = new RANDAlgorithm(m_Requests, int.Parse(FramesTextBox.Text));

            DataItem item = new DataItem(-1);
            item.FIFO = m_FIFO.ToString();
            item.OPT = m_OPT.ToString();
            item.LRU = m_LRU.ToString();
            item.ALRU = m_ALRU.ToString();
            item.RAND = m_RAND.ToString();
            m_Data.Add(item);
            DataGrid.Items.Refresh();

            for (int i = 0; i < m_Requests.Count; m_Requests.RemoveAt(i))
            {
                m_FIFO.HandleRequest(m_Requests[i]);
                m_OPT.HandleRequest(m_Requests[i]);
                m_LRU.HandleRequest(m_Requests[i]);
                m_ALRU.HandleRequest(m_Requests[i]);
                m_RAND.HandleRequest(m_Requests[i]);

                item = new DataItem(m_Requests[i]);
                item.FIFO = m_FIFO.ToString();
                item.OPT = m_OPT.ToString();
                item.LRU = m_LRU.ToString();
                item.ALRU = m_ALRU.ToString();
                item.RAND = m_RAND.ToString();
                m_Data.Add(item);
                DataGrid.Items.Refresh();
            }

            FIFOLabel.Content = m_FIFO.PagesErrors.ToString();
            OPTLabel.Content = m_OPT.PagesErrors.ToString();
            LRULabel.Content = m_LRU.PagesErrors.ToString();
            ALRULabel.Content = m_ALRU.PagesErrors.ToString();
            RANDLabel.Content = m_ALRU.PagesErrors.ToString();

            button.IsEnabled = true;
        }

        private void HandleCustomRequests()
        {
            string[] requests = RequestsTextBox.Text.Split(new char[] { ' ' });
            m_Requests = new List<int>(requests.Length);
            foreach (string r in requests)
            {
                if(!r.Equals(""))
                    m_Requests.Add(int.Parse(r));
            }
        }

        public static bool IsNumeric(string text)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[^0-9]+");
            return regex.IsMatch(text);
        }

        public static bool IsRequestsStringValid(string text)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[^ 0123456789]+");
            return regex.IsMatch(text);
        }

        private void FramesTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = IsNumeric(e.Text);
        }

        private void RequestsTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (m_CustomRequests)
            {
                e.Handled = IsRequestsStringValid(e.Text);
            }
            else
                e.Handled = IsNumeric(e.Text);
        }

        private void MaxValueTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = IsNumeric(e.Text);
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            MaxValueTextBox.IsEnabled = false;
            m_CustomRequests = true;
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            RequestsTextBox.Text = null;
            m_CustomRequests = false;
            MaxValueTextBox.IsEnabled = true;
        }

        void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            int count;
            if (int.TryParse(simulateCount.Text, out count) && count > 0)
            {
                IsEnabled = false;
                var handler =  new System.ComponentModel.CancelEventHandler(MainWindow_Closing);
                Closing += handler;

                int fifoPageErrors = 0;
                int optPageErrors = 0;
                int lruPageErrors = 0;
                int alruPageErrors = 0;
                int randPageErrors = 0;

                for (int i = 0; i < count; i++)
                {
                    button.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

                    fifoPageErrors += m_FIFO.PagesErrors;
                    optPageErrors += m_OPT.PagesErrors;
                    lruPageErrors += m_LRU.PagesErrors;
                    alruPageErrors += m_ALRU.PagesErrors;
                    randPageErrors += m_RAND.PagesErrors;
                }

                Window resultsWindow = new SimulationResults(
                    count, fifoPageErrors, optPageErrors,
                    lruPageErrors, alruPageErrors, randPageErrors);
                resultsWindow.Show();
                resultsWindow.Closed += delegate
                {
                    IsEnabled = true;
                    Closing -= handler;
                };
            }
            else
            {
                MessageBox.Show("Ilość symulacji nie jest poprawną liczbą.", "Błąd", MessageBoxButton.OK);
                simulateCount.Text = 1.ToString();
            }
        }

        private void simulateCount_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = IsNumeric(e.Text);
        }
    }
}
