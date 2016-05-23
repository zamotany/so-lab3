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

        public RequestsGenerator(int size, int min, int max)
        {
            m_Requests = new int[size];
            Generate(min, max);
        }

        public int[] Requests
        {
            get
            {
                return m_Requests;
            }
        }

        private void Generate(int min, int max)
        {
            Random rand = new Random();
            int seed = rand.Next(min, max + 1);
            int r = rand.Next(2, (int)(.1 * m_Requests.Length));
            int t = rand.Next(1, r);
            for(int i = 0, k = 0; i < m_Requests.Length; i++, k++)
            {
                if (k < r)
                {
                    m_Requests[i] = rand.Next(Math.Max(0, seed - t), Math.Min(max + 1, seed + t + 1));
                }
                else
                {
                    k = -1;
                    r = rand.Next(2, (int)(.1 * m_Requests.Length));
                    t = rand.Next(1, r);
                    seed = rand.Next(min, max + 1);
                    m_Requests[i] = seed;
                }
            }
        }
    }
}
