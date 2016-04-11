#pragma once

#include <string>
#include <iostream>
#include <algorithm>
#include "Disk.h"

// \brief CSCAN Disk class for simulation.
// \author Paweł Trysła
class CSCANDisk : public Disk
{
public:
	// \brief Default constructor.
	// \param initHead Initial head's position.
	// \param maxHead Maximal head's position.
	CSCANDisk(unsigned int initHead, unsigned int maxHead);

	// \brief Default destructor.
	~CSCANDisk();

	// \brief Set next head's position.
	// \param pos Next position.
	void setNextPosition(unsigned int pos);
private:
	bool m_WasJump;
	unsigned int m_MaxHead;
	bool m_FirstSet;
};