#pragma once

#include <iostream>
#include <vector>
#include "DataStore.h"
#include "Disk.h"
#include "CSCANDisk.h"
#include "extlib\Random.h"
#include "extlib\INIParser.h"
#include "extlib\Logger.h"

// \brief Main program class.
// \author Pawe³ Trys³a
class Program
{
public:
	// \brief Default constructor.
	// \param config Path to configuration file.
	Program(const std::string config);

	// \brief Default destructor.
	~Program();

	// \brief Execute mathod.
	// \return Status code.
	int exec();
private:
	INIParser Config_;
	Logger Log_;
	DataStore DS_;
	unsigned long ReadsCount_;
};