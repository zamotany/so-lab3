using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solab3
{
    class FIFOAlgorithm : ReplaceAlgorimthm
    {
        public FIFOAlgorithm(List<int> reqs, int frames) : base(reqs, frames)
        {

        }

        public override void HandleRequest(int value)
        {
            for (int i = 0; i < m_Frames.Size; ++i)
                if (m_Frames[i].Value == value)
                    return;

            for (int i = 0; i < m_Frames.Size - 1; ++i)
                m_Frames[i] = m_Frames[i + 1];

            m_Frames[m_Frames.Size - 1] = new Frame(value);

            ++m_PagesErrors;
        }
    }
}
