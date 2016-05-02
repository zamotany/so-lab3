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

        public MainWindow()
        {
            InitializeComponent();
            FramesTextBox.Text = "4";
            RequestsTextBox.Text = "8";
            MaxValueTextBox.Text = "8";
            m_Data = new List<DataItem>();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            button.IsEnabled = false;
            m_Data.Clear();
            DataGrid.ItemsSource = null;
            DataGrid.ItemsSource = m_Data;

            m_Requests = new List<int>(int.Parse(RequestsTextBox.Text));
            m_FIFO = new FIFOAlgorithm(m_Requests, int.Parse(FramesTextBox.Text));
            m_OPT = new OPTAlgorithm(m_Requests, int.Parse(FramesTextBox.Text));
            m_LRU = new LRUAlgorithm(m_Requests, int.Parse(FramesTextBox.Text));
            m_ALRU = new A_LRUAlgorithm(m_Requests, int.Parse(FramesTextBox.Text));
            m_RAND = new RANDAlgorithm(m_Requests, int.Parse(FramesTextBox.Text));

            Random rand = new Random(Guid.NewGuid().GetHashCode());

            int temp = 0;
            for (int i = 0; i < m_Requests.Capacity; i++)
            {
                temp = rand.Next(1, int.Parse(MaxValueTextBox.Text));
                m_Requests.Add(temp);
            }

            for (int i = 0; i < int.Parse(FramesTextBox.Text); i++)
            {
                m_FIFO[i].Value = m_Requests[i >= int.Parse(RequestsTextBox.Text) ? 0 : i];
                m_OPT[i].Value = m_Requests[i >= int.Parse(RequestsTextBox.Text) ? 0 : i];
                m_LRU[i].Value = m_Requests[i >= int.Parse(RequestsTextBox.Text) ? 0 : i];
                m_ALRU[i].Value = m_Requests[i >= int.Parse(RequestsTextBox.Text) ? 0 : i];
                m_RAND[i].Value = m_Requests[i >= int.Parse(RequestsTextBox.Text) ? 0 : i];
            }

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

        public static bool isNumeric(string text)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("[^0-9.-]+");
            return !regex.IsMatch(text);
        }

        private void FramesTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !isNumeric(e.Text);
        }

        private void RequestsTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !isNumeric(e.Text);
        }

        private void MaxValueTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !isNumeric(e.Text);
        }
    }
}
