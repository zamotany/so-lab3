#include "Program.h"

Program::Program(const std::string config) :
	Config_(config),
	DS_(Config_.getInt("Generator", "ReadsCount", 0), Config_.getInt("Head", "InitPos", 1), Config_.getInt("Head", "MaxPos", 1)),
	Log_("out", "Analysis.%t.csv"),
	ReadsCount_(Config_.getInt("Generator", "ReadsCount", 0))
{
	Log_.out("Pos_FCFS, Delta_FCFS, MoveSum_FCFS, Pos_SSTF, Delta_SSTF, MoveSum_SSTF, Pos_SCAN, Delta_SCAN, MoveSum_SCAN, Pos_CSCAN, Delta_CSCAN, MoveSum_CSCAN");
}

Program::~Program()
{
}

int Program::exec()
{
	std::vector<unsigned int> positions;
	Random rand;

	for (unsigned long r = ReadsCount_; r > 0; r--)
		positions.push_back(rand.next(1, Config_.getInt("Head", "MaxPos", 1) - 1));
	DS_.add(positions);

	Disk fcfs(Config_.getInt("Head", "InitPos", 1), Config_.getInt("Head", "MaxPos", 1));
	Disk sstf(Config_.getInt("Head", "InitPos", 1), Config_.getInt("Head", "MaxPos", 1));
	Disk scan(Config_.getInt("Head", "InitPos", 1), Config_.getInt("Head", "MaxPos", 1));
	CSCANDisk cscan(Config_.getInt("Head", "InitPos", 1), Config_.getInt("Head", "MaxPos", 1));

	do
	{
		fcfs.setNextPosition(DS_.popFCFS());
		sstf.setNextPosition(DS_.popSSTF());
		scan.setNextPosition(DS_.popSCAN());
		cscan.setNextPosition(DS_.popCSCAN());

		std::string str = "";
		str += fcfs.toString() + ',';
		str += sstf.toString() + ',';
		str += scan.toString() + ',';
		str += cscan.toString();
		std::cout << str << std::endl;
		Log_.out(str);
	}
	while (!DS_.done());
	std::cin.get();
	return 0;
}
