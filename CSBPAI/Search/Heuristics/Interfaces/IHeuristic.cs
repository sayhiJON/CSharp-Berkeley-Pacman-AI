using Search.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Heuristics.Interfaces {
    public interface IHeuristic {
        double EvaluateState(SearchProblem problem, State state);
    }
}
