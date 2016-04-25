using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solab3
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
                    found = true;
                    for(int j = 0; j < m_Frames.Size; j++)
                    {
                        if (j != k)
                            m_Frames[j].ReferenceBit = false;
                    }
                }
                else
                {

                }
                k = k < m_Frames.Size ? k + 1 : 0;
            }

            ++m_PagesErrors;
        }

        public override string ToString()
        {
            string output = "A-LRU: ";
            for (int k = 0; k < m_Frames.Size; k++)
                output += m_Frames[k].Value.ToString() + ' ';
            return output;
        }
    }
}
