#include "SCAN.h"

SCAN::SCAN(unsigned int n, unsigned int headPosition)
{
	m_maxPosition = n;
	m_headPosition = headPosition;
	m_size = m_iterator = 0;
	m_array = nullptr;
}

void SCAN::setHeadPosition(unsigned int newPosition)
{
	m_headPosition = newPosition;
}

void SCAN::load(const unsigned int * arr, size_t size)
{
	size_t tempSize = size;
	unsigned int * temp = new unsigned int[tempSize];

	for (size_t i = 0; i < tempSize; ++i)
		temp[i] = arr[i];

	size_t min = 0;
	size_t max = size - 1;
	long long p;
	do
	{
		p = -1;
		for (size_t i = min; i < max; ++i)
			if (temp[i] > temp[i + 1])
			{
				std::swap(temp[i], temp[i + 1]);
				if (p < 0) min = i;
				p = i;
			}
		if (min) min--;
		max = p;
	} while (p >= 0);

	m_iterator = m_size = size;
	m_array = new unsigned int[m_size];

	if (m_headPosition < temp[0])
	{
		for (size_t i = 0; i < m_size; ++i)
			m_array[i] = temp[i];
	}
	else if (m_headPosition > temp[size - 1])
	{
		for (size_t i = 0, j = size - 1; i < m_size; ++i, --j)
			m_array[i] = temp[j];
	}
	else
	{
		size_t index = 0;
		for (size_t i = 0; i < size; ++i)
			if (m_headPosition < temp[i])
			{
				index = i;
				break;
			}

		if (m_headPosition < m_maxPosition / 2)
		{
			for (size_t i = 0, j = index - 1; i < index; ++i, --j)
				m_array[i] = temp[j];
			for (size_t i = index; i < m_size; ++i)
				m_array[i] = temp[i - 1];
		}
		else
		{
			for (size_t i = 0, j = index; j < size; ++i, ++j)
				m_array[i] = temp[j];
			for (size_t i = size - index, j = index -1; i < m_size; ++i, --j)
				m_array[i] = temp[j];
		}
	}
}

unsigned int  SCAN::getNext()
{
	return m_array[m_size - m_iterator--];
}

SCAN::~SCAN()
{
	delete[] m_array;
}
