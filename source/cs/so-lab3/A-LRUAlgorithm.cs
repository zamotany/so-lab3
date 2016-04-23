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

        }

        public override void HandleRequest(int value)
        {
            for (int i = 0; i < m_Frames.Size; ++i)
                if (m_Frames[i].Value == value)
                    return;

            int j;
            for (j = 0; j < m_Frames.Size && m_Frames[j].ReferenceBit; ++j);

            for (int i = j; i < m_Frames.Size - 1; ++i)
                m_Frames[i] = m_Frames[i + 1];

            m_Frames[m_Frames.Size - 1] = new Frame(value);

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
