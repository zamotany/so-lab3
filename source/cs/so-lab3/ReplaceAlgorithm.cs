using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solab3
{
    abstract class ReplaceAlgorimthm
    {
        protected PhysicalMemory m_Frames;
        protected int m_PagesErrors;
        protected List<int> m_Requests;

        public ReplaceAlgorimthm(List<int> reqs, int frames)
        {
            m_Requests = reqs;
            m_PagesErrors = 0;
            m_Frames = new PhysicalMemory(frames);  
        }

        public int PagesErrors
        {
            get
            {
                return m_PagesErrors;
            }
        }

        public Frame this[int index]
        {
            get { return m_Frames[index]; }
            set { m_Frames[index] = value; }
        }

        public abstract void HandleRequest(int value);

        public override abstract string ToString();
    }
}
