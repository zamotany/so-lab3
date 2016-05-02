using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.LAB3
{
    class A_LRUAlgorithm : ReplaceAlgorimthm
    {
        public A_LRUAlgorithm(List<int> reqs, int frames) : base(reqs, frames)
        {
            for (int i = 0; i < m_Frames.Size; ++i)
                m_Frames[i].ReferenceBit = true;
        }

        public override void HandleRequest(int value)
        {
            for (int i = 0; i < m_Frames.Size; ++i)
            {
                if (m_Frames[i].Value == value)
                {
                    m_Frames[i].ReferenceBit = true;
                    return;
                }
            }

            bool found = false;
            int k = 0;
            while (!found)
            {
                if(!m_Frames[k].ReferenceBit)
                {
                    m_Frames[k] = new Frame(value, true);
                    moveToEnd(k);
                    found = true;
                }
                else
                {
                    m_Frames[k].ReferenceBit = false;
                    moveToEnd(k);
                    k = k > 0 ? k - 1 : 0;
                }
                k = k < m_Frames.Size ? k + 1 : 0;
            }

            ++m_PagesErrors;
        }

        private void moveToEnd(int frame)
        {
            Frame temp = m_Frames[frame];

            for (int i = frame; i < m_Frames.Size - 1; i++)
                m_Frames[i] = m_Frames[i + 1];
            m_Frames[m_Frames.Size - 1] = temp;
        }

        public override string ToString()
        {
            string output = "";
            for (int k = 0; k < m_Frames.Size; k++)
                output += m_Frames[k].Value.ToString() + ' ';
            return output;
        }
    }
}
