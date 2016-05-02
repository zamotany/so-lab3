using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.LAB3
{
    class RANDAlgorithm : ReplaceAlgorimthm
    {
        private Random m_Random;

        public RANDAlgorithm(List<int> reqs, int frames) : base(reqs, frames)
        {
            m_Random = new Random(Guid.NewGuid().GetHashCode());
        }

        public override void HandleRequest(int value)
        {
            for (int i = 0; i < m_Frames.Size; ++i)
                if (m_Frames[i].Value == value)
                    return;

            m_Frames[m_Random.Next(0, m_Frames.Size - 1)] = new Frame(value);

            ++m_PagesErrors;
        }

        public override string ToString()
        {
            string output = "RAND: ";
            for (int k = 0; k < m_Frames.Size; k++)
                output += m_Frames[k].Value.ToString() + ' ';
            return output;
        }
    }
}
