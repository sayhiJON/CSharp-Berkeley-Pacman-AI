using Search.Heuristics.Interfaces;
using Search.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Algorithms.Interfaces {
    public interface ISearchAlgorithm {
        State[] Search(SearchProblem problem, IHeuristic heuristic = null);
    }
}
