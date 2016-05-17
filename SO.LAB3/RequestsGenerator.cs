using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.LAB3
{
    class RequestsGenerator
    {
        private int[] m_Requests;
        private Process[] m_Processes;

        private class Process
        {
            private int[] m_Requests;
            private int m_Next;

            public Process(int size)
            {
                m_Requests = new int[size];
                m_Next = 0;
            }

            public int Next
            {
                get
                {
                    m_Next %= m_Requests.Length;
                    return m_Requests[m_Next++];
                }
            }

            public int Size
            {
                get
                {
                    return m_Requests.Length;
                }
            }

            public int[] Requests
            {
                get
                {
                    return m_Requests;
                }
            }
        }

        public RequestsGenerator(int size)
        {
            m_Requests = new int[size];
            Generate(4, 2, 6, 1);
        }

        public int[] Requests
        {
            get
            {
                return m_Requests;
            }
        }

        private void Generate(int processes, int reqMin, int reqMax, int valMin)
        {
            m_Processes = new Process[processes];
            Random rand = new Random();

            int totalRequests = 0;
            for (int i = 0; i < m_Processes.Length; i++)
            {
                m_Processes[i] = new Process(rand.Next(reqMin, reqMax + 1));
                totalRequests += m_Processes[i].Size;
            }

            List<int> reqs = new List<int>(totalRequests);
            for (int i = 0; i < reqs.Capacity; i++)
                reqs.Add(valMin + i);

            for (int i = 0; i < m_Processes.Length; i++)
            {
                for (int k = 0; k < m_Processes[i].Size; k++)
                {
                    int index = rand.Next(0, reqs.Count);
                    m_Processes[i].Requests[k] = reqs[index];
                    reqs.RemoveAt(index);
                }
            }

            for (int i = 0; i < m_Requests.Length; i++)
                m_Requests[i] = m_Processes[i % m_Processes.Length].Next;
        }
    }
}
