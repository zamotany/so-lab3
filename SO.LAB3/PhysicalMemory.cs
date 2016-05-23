using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SO.LAB3
{
    class PhysicalMemory
    {
        private List<Frame> m_Frames;

        public PhysicalMemory(int frames)
        {
            m_Frames = new List<Frame>(frames);
            for (int i = 0; i < frames; i++)
                m_Frames.Add(new Frame());
        }

        public int Size
        {
            get { return m_Frames.Count; }
        }

        public Frame this[int index]
        {
            get { return m_Frames[index]; }
            set { m_Frames[index] = value; }
        }
    }
}
