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
        private bool m_WasInitialised;

        public Form1()
        {
            InitializeComponent();
            m_WasInitialised = false;
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            beginButton.Enabled = false;
            if(!m_WasInitialised)
                init();
            exec();
            beginButton.Enabled = true;
        }

        private void init()
        {
            m_WasInitialised = true;
            m_Requests = new List<int>((int)RequestsNumericUpDown.Value);
            m_FIFO = new FIFOAlgorithm(m_Requests, (int)frameNumericUpDown.Value);

            Random rand = new Random();

            console.Text = "Requests: ";
            for (int i = 0; i < m_Requests.Capacity; i++)
            {
                int temp = rand.Next(1, (int)MaxFrameValNumericUpDown.Value);
                m_Requests.Add(temp);
                console.Text += temp.ToString() + ' ';
            }
               
            for (int i = 0; i < (int)frameNumericUpDown.Value; i++)
                m_FIFO[i].Value = m_Requests[i >= (int)RequestsNumericUpDown.Value ? -1 : i];

        }

        private void exec()
        {
            for (int i = 0; i < m_Requests.Count;)
            {
                m_FIFO.HandleRequest(m_Requests[i]);
                m_Requests.RemoveAt(i);
                fifope.Text = m_FIFO.PagesErrors.ToString();
                console.Text += "\r\nFIFO: ";
                for (int k = 0; k < (int)frameNumericUpDown.Value; k++)
                {
                    console.Text += m_FIFO[k].Value.ToString() + ' ';
                }
            }
            
        }
    }
}
