using Search.Heuristics.Interfaces;
using Search.Problems;
using Search.Problems.Graphs;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Heuristics {
    public class PiecewiseHeuristic<T> : IHeuristic {
        private Dictionary<int, double> p_Function = new Dictionary<int, double>();

        public PiecewiseHeuristic(Dictionary<int, double> function) {
            this.p_Function = function;
        }

        public double EvaluateState(SearchProblem problem, State state) {
            return (this.p_Function.ContainsKey(state.GetHashCode())) ? this.p_Function[state.GetHashCode()] : 0d;
        }
    }
}
