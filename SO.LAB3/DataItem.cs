using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.LAB3
{
    class DataItem
    {
        private int m_Request;
        private string m_FIFO;
        private string m_OPT;
        private string m_LRU;
        private string m_ALRU;
        private string m_RAND;

        public DataItem(int request)
        {
            m_Request = request;
        }

        public int Request
        {
            get { return m_Request; }
        }

        public string FIFO
        {
            get { return m_FIFO; }
            set { m_FIFO = value; }
        }

        public string OPT
        {
            get { return m_OPT; }
            set { m_OPT = value; }
        }

        public string LRU
        {
            get { return m_LRU; }
            set { m_LRU = value; }
        }

        public string ALRU
        {
            get { return m_ALRU; }
            set { m_ALRU = value; }
        }

        public string RAND
        {
            get { return m_RAND; }
            set { m_RAND = value; }
        }
    }
}
