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
        public Form1()
        {
            InitializeComponent();
        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            beginButton.Enabled = false;
            exec();
            beginButton.Enabled = true;
        }

        private void exec()
        {
            List<int> requests = new List<int>((int)RequestsNumericUpDown.Value);
            Random rand = new Random();
            for (int i = 0; i < requests.Capacity; i++)
            {
                requests.Add(rand.Next(1, (int)MaxFrameValNumericUpDown.Value));
                RequestsListView.Items.Add(requests[i].ToString());
            }
            //initialise frames for every algorithm
        }
    }
}
