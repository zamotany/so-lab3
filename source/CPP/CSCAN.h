#pragma once
#include <iostream>

// \brief CSCAN algorythm class.
// \details Class representing a queue that runs on C-SCAN (Circular Scan) disk scheduling algorithm.
class CSCAN
{
private:
	// \var Maximal position of the head (last track on the virtual disk).
	unsigned int m_maxPosition;

	// \var Actual position of the virtual disk head.
	unsigned int m_headPosition;

	// \var Pointer to the array of next positions.
	unsigned int * m_array;

	// \var Size of the array.
	size_t m_size;

	// \var Variable size used to iterate above array elemets, not to use for user.
	size_t m_iterator;
public:
	// \brief Default constructor.
	// \param n            Maximal position of the head (last track on the virtual disk).
	// \param headPosition Initial position of the head, 0 by default.
	CSCAN(unsigned int n, unsigned int headPosition = 0);

	// \brief Sets head on the given position.
	// \param newPosition New position of the head.
	void setHeadPosition(unsigned int newPosition);

	// \brief Load an array of positions of the head before scheduling.
	// \param arr          Pointer to an array.
	// \param size         Size of the given array.
	void load(const unsigned int * arr, size_t size);

	// \brief Returns an array of the next positions of the head after scheduling.
	// \return Pointer to an array of the next positions of the head.
	unsigned int getNext();

	// \brief Returns number of elements in the array.
	// \return Number of elements.
	size_t size() const { return m_iterator - 1; }

	// \brief Destructor.
	~CSCAN();
};
