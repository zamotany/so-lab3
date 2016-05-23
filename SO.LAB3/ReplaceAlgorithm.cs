using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.LAB3
{
    abstract class ReplaceAlgorimthm
    {
        protected PhysicalMemory m_Frames;
        protected int m_PagesErrors;
        protected List<int> m_Requests;
        protected bool m_FinishedInit;
        private int m_NextFrameToInit;

        public ReplaceAlgorimthm(List<int> reqs, int frames)
        {
            m_Requests = reqs;
            m_PagesErrors = 0;
            m_FinishedInit = false;
            m_NextFrameToInit = 0;
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

        protected void InitFrame(int value)
        {
            if(!m_FinishedInit)
            {
                m_Frames[m_NextFrameToInit++].Value = value;
                m_PagesErrors++;
                if (m_NextFrameToInit >= m_Frames.Size)
                    m_FinishedInit = true;
            }
        }

        public abstract void HandleRequest(int value);

        public override abstract string ToString();
    }
}
