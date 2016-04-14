#include "CSCANDisk.h"

CSCANDisk::CSCANDisk(unsigned int initHead, unsigned int maxHead) :
	Disk(initHead, maxHead),
	m_WasJump(false),
	m_MaxHead(maxHead),
	m_FirstSet(true)
{
}

CSCANDisk::~CSCANDisk()
{
}

void CSCANDisk::setNextPosition(unsigned int pos)
{
	if (m_FirstSet)
	{
		std::cout << "jump FS" << std::endl;
		m_Current = pos;
		if (m_Previous - m_Current > m_MaxHead - m_Previous + m_Current)
		{
			m_Sum += m_MaxHead - m_Previous + m_Current;
		}
		else
		{
			m_Sum
		}
		m_FirstSet = false;
	}
	else
	{
		if (pos < m_Current && m_Current > m_Previous && !m_WasJump)
		{
			std::cout << "jump" << std::endl;
			m_Previous = m_Current;
			m_Sum += pos + m_MaxHead - m_Current;
			m_Current = pos;
			m_WasJump = true;
		}
		else if (m_Previous > m_Current && m_Current < pos && !m_WasJump)
		{
			std::cout << "jump" << std::endl;
			m_Previous = m_Current;
			m_Sum += m_Current + m_MaxHead - pos;
			m_Current = pos;
			m_WasJump = true;
		}
		else
		{
			Disk::setNextPosition(pos);
			m_WasJump = false;
		}
	}
}
