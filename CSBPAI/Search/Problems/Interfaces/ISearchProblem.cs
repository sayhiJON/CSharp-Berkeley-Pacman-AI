using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Problems.Interfaces {
    public interface ISearchProblem {
        State GetStartingState();
        bool IsGoalState(State state);
        State[] GetSuccessors(State state);
        double EvaluateState(State state);
    }
}
