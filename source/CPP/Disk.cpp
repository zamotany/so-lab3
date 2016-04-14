#include "Disk.h"

Disk::Disk(unsigned int initHead, unsigned int maxHead) :
	m_Current(initHead),
	m_Previous(initHead),
	m_Sum(0)
{
}

Disk::~Disk()
{
}

void Disk::setNextPosition(unsigned int pos)
{
	m_Previous = m_Current;
	m_Current = pos;
	m_Sum += getDelta();
}

unsigned int Disk::getDelta() const
{
	return (unsigned int)abs((long)m_Current - (long)m_Previous);
}

unsigned int Disk::getCurent() const
{
	return m_Current;
}

unsigned int Disk::getPrevious() const
{
	return m_Previous;
}

std::string Disk::toString() const
{
	return std::string(std::to_string(m_Current) + ',' + std::to_string(getDelta()) + ',' + std::to_string(m_Sum));
}
