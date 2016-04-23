using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solab3
{
    public partial class Form1 : Form
    {
        private List<int> m_Requests;
        private FIFOAlgorithm m_FIFO;
        private LRUAlgorithm m_LRU;
        private A_LRUAlgorithm m_ALRU;
        private RANDAlgorithm m_RAND;

        public Form1()
        {
            InitializeComponent();
            RequestsNumericUpDown.Value = 1;
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            // Return if requests number is incorrect.
            if ((int)RequestsNumericUpDown.Value == 0)
            {
                MessageBox.Show("Requests number must be grater than 0.");
                return;
            }
            
            // Normal execution.
            beginButton.Enabled = false;
            init();
            exec();
            beginButton.Enabled = true;
        }

        private void init()
        {
            m_Requests = new List<int>((int)RequestsNumericUpDown.Value);
            m_FIFO = new FIFOAlgorithm(m_Requests, (int)frameNumericUpDown.Value);
            m_LRU = new LRUAlgorithm(m_Requests, (int)frameNumericUpDown.Value);
            m_ALRU = new A_LRUAlgorithm(m_Requests, (int)frameNumericUpDown.Value);
            m_RAND = new RANDAlgorithm(m_Requests, (int)frameNumericUpDown.Value);

            Random rand = new Random(Guid.NewGuid().GetHashCode());

            console.Text = "Requests: ";
            for (int i = 0; i < m_Requests.Capacity; i++)
            {
                int temp = rand.Next(1, (int)MaxFrameValNumericUpDown.Value);
                m_Requests.Add(temp);
                console.Text += temp.ToString() + ' ';
            }
            console.Text += "\r\n";

            for (int i = 0; i < (int)frameNumericUpDown.Value; i++)
            {
                m_FIFO[i].Value = m_Requests[i >= (int)RequestsNumericUpDown.Value ? 0 : i];
                m_LRU[i].Value = m_Requests[i >= (int)RequestsNumericUpDown.Value ? 0 : i];
                m_ALRU[i].Value = m_Requests[i >= (int)RequestsNumericUpDown.Value ? 0 : i];
                m_RAND[i].Value = m_Requests[i >= (int)RequestsNumericUpDown.Value ? 0 : i];
            }

        }

        private void exec()
        {
            for (int i = 0; i < m_Requests.Count;)
            {
                m_FIFO.HandleRequest(m_Requests[i]);
                m_LRU.HandleRequest(m_Requests[i]);
                m_ALRU.HandleRequest(m_Requests[i]);
                m_RAND.HandleRequest(m_Requests[i]);
                m_Requests.RemoveAt(i);
                FIFO_PagesErrors.Text = m_FIFO.PagesErrors.ToString();
                LRU_PagesErrors.Text = m_LRU.PagesErrors.ToString();
                ALRU_PagesErrors.Text = m_ALRU.PagesErrors.ToString();
                RAND_PagesErrors.Text = m_ALRU.PagesErrors.ToString();
                console.Text += m_FIFO.ToString() + "\t" + m_LRU.ToString() + "\t" + m_ALRU.ToString() + "\t" + m_RAND.ToString() + "\r\n";
            }
            
        }
    }
}
