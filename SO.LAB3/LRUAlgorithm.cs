using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.LAB3
{
    class LRUAlgorithm : ReplaceAlgorimthm
    {
        public LRUAlgorithm(List<int> reqs, int frames) : base(reqs, frames)
        {

        }

        public override void HandleRequest(int value)
        {
            for (int i = 0; i < m_Frames.Size; ++i)
                if (m_Frames[i].Value == value)
                {
                    Frame temp = m_Frames[i];
                    for (int j = i; j < m_Frames.Size - 1; ++j)
                        m_Frames[j] = m_Frames[j + 1];

                    m_Frames[m_Frames.Size - 1] = temp;
                    return;
                }

            for (int i = 0; i < m_Frames.Size - 1; ++i)
                m_Frames[i] = m_Frames[i + 1];

            m_Frames[m_Frames.Size - 1] = new Frame(value);

            ++m_PagesErrors;
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
