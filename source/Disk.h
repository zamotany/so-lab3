#pragma once

#include <string>

// \brief Disk class for simulation.
// \author Paweł Trysła
class Disk
{
public:
	// \brief Default constructor.
	// \param initHead Initial head's position.
	// \param maxHead Maximal head's position.
	Disk(unsigned int initHead, unsigned int maxHead);

	// \brief Default destructor.
	virtual ~Disk();

	// \brief Set next head's position.
	// \param pos Next position.
	virtual void setNextPosition(unsigned int pos);

	// \brief Get positive diff between current position and prevoius one.
	// \return Delta between current and previous head's position.
	unsigned int getDelta() const;

	// \brief Get current head's position.
	// \return Current head's position.
	unsigned int getCurent() const;

	// \brief Get prevoius head's position.
	// \return Prevoius head's position.
	unsigned int getPrevious() const;

	// \brief Get string represetnation of head's current position, delta and sum of head's movements.
	// \return String with head's representation.
	std::string toString() const;
protected:
	unsigned int m_Current;
	unsigned int m_Previous;
	unsigned int m_Sum;
};