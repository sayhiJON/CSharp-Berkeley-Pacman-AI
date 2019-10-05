using Search.Heuristics.Interfaces;
using Search.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Heuristics {
    public class NullHeuristic : IHeuristic {
        public double EvaluateState(SearchProblem problem, State state) {
            return 0d;
        }
    }
}
