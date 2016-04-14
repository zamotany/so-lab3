using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solab3
{
    class Frame
    {
        private int m_Value;
        private bool m_ReferenceBit;

        public Frame(int value = 0, bool referenceBit = false)
        {
            m_Value = value;
            m_ReferenceBit = referenceBit;
        }

        public int Value
        {
            get { return m_Value; }
        }

        public bool ReferenceBit
        {
            get { return m_ReferenceBit; }
        }
    }
}