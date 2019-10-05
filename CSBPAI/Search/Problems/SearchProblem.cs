using Search.Heuristics;
using Search.Heuristics.Interfaces;
using Search.Problems.Interfaces;
using System.Collections.Generic;

namespace Search.Problems {
    public abstract class SearchProblem : ISearchProblem {
        public      List<State> ExpandedStates { get; set; }

        public abstract double  EvaluateState(State state);
        public abstract State   GetStartingState();
        public abstract State[] GetSuccessors(State state);
        public abstract bool    IsGoalState(State state);
    }
}
