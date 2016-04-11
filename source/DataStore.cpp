#include "DataStore.h"

DataStore::DataStore(unsigned long readsCount, unsigned long headPos, unsigned long maxHeadPos) :
	ReadsCount_(readsCount),
	SSTF_(headPos),
	SCAN_(maxHeadPos, headPos),
	CSCAN_(maxHeadPos, headPos)
{
}

DataStore::~DataStore()
{
}

unsigned int DataStore::popFCFS()
{
	std::lock_guard<std::mutex> lk(Mutex_);

	unsigned int pos = 0;
	FCFS_.dequeue(pos);
	return pos;
}

unsigned int DataStore::popSSTF()
{
	std::lock_guard<std::mutex> lk(Mutex_);

	return SSTF_.getNext();
}

unsigned int DataStore::popSCAN()
{
	std::lock_guard<std::mutex> lk(Mutex_);

	return SCAN_.getNext();
}

unsigned int DataStore::popCSCAN()
{
	std::lock_guard<std::mutex> lk(Mutex_);

	return CSCAN_.getNext();
}

bool DataStore::done()
{
	//std::cout << FCFS_.size() << " " << SCAN_.size() << " " << CSCAN_.size() << std::endl;
	ReadsCount_--;
	return ReadsCount_ == 0;
}

void DataStore::add(std::vector<unsigned int>& pos)
{
	std::lock_guard<std::mutex> lk(Mutex_);

	SSTF_.load(pos.data(), pos.size());
	SCAN_.load(pos.data(), pos.size());
	CSCAN_.load(pos.data(), pos.size());
	for(unsigned int e : pos)
		FCFS_.enqueue(e);
}
