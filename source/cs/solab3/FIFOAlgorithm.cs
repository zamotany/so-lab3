using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solab3
{
    class FIFOAlgorithm : ReplaceAlgorimthm
    {
        public FIFOAlgorithm(List<int> reqs, int frames) : base(reqs, frames)
        {

        }

        public override void HandleRequest(int value)
        {
            throw new NotImplementedException();
        }
    }
}
