using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.LAB3
{
    class OPTAlgorithm : ReplaceAlgorimthm
    {
        public OPTAlgorithm(List<int> reqs, int frames) : base(reqs, frames)
        {
        }

        public override void HandleRequest(int value)
        {
            for (int i = 0; i < m_Frames.Size; ++i)
            {
                if (m_Frames[i].Value == value)
                    return;
            }

            Dictionary<int, int> distance = new Dictionary<int, int>();

            for(int i = 0; i < m_Frames.Size; i++)
            {
                distance.Add(i, 0);
                for(int k = 0; k < m_Requests.Count; k++)
                {
                    distance[i] = k;
                    if (m_Requests[k] == m_Frames[i].Value)
                        break;
                }
            }

            int index = 0;
            int max = 0;
            for(int i = 0; i < distance.Count; i++)
            {
                if(distance[i] > max)
                {
                    max = distance[i];
                    index = i;
                }
            }

            m_Frames[index] = new Frame(value);
            m_PagesErrors++;
        }
        public override string ToString()
        {
            string output = "OPT: ";
            for (int k = 0; k < m_Frames.Size; k++)
                output += m_Frames[k].Value.ToString() + ' ';
            return output;
        }
    }
}
