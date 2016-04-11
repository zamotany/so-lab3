#pragma once

#include "FCFS.h"
#include "SSTF.h"
#include "SCAN.h"
#include "CSCAN.h"
#include <mutex>
#include <vector>
#include <iostream>

// \brief Data store with block positions.
// \author Pawe³ Trys³a
class DataStore
{
public:
	// \brief Default constructor.
	// \param readCount How many block will disk have to read.
	// \param headPos Initial position of head.
	// \param maxHeadPos Maximal position of head.
	DataStore(unsigned long readsCount, unsigned long headPos, unsigned long maxHeadPos);

	// \brief Default destructor.
	~DataStore();

	// \brief Get next element from FCFS store.
	// \return Next block position.
	unsigned int popFCFS();

	// \brief Get next element from SSTF store.
	// \return Next block position.
	unsigned int popSSTF();

	// \brief Get next element from SCAN store.
	// \return Next block position.
	unsigned int popSCAN();

	// \brief Get next element from C-SCAN store.
	// \param jump Reference with true if there was a jump, false otherwise.
	// \return Next block position.
	unsigned int popCSCAN();
	
	// \brief Add block positions to queue.
	// \param pos Block positions to add.
	void add(std::vector<unsigned int>& pos);

	// \brief Check if all block positions were poped.
	// \return True if all positions were red, false otherwise.
	bool done();
private:
	unsigned long ReadsCount_;
	FCFS<unsigned int> FCFS_;
	SSTF SSTF_;
	SCAN SCAN_;
	CSCAN CSCAN_;
	std::mutex Mutex_;
	
};