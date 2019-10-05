using Search.Heuristics;
using Search.Heuristics.Interfaces;
using Search.Problems.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Problems.Graphs {
    public class GraphProblem : SearchProblem, ISearchProblem {
        private Node    p_Start = null;
        private Node[]  p_Goals = null;

        public GraphProblem(Node start, Node[] goals, IHeuristic heuristic = null) {
            this.p_Start = start;
            this.p_Goals = goals;
            this.p_Heuristic = heuristic;

            if (heuristic == null)
                this.p_Heuristic = new NullHeuristic();

            this.ExpandedStates = new List<State>();
        }

        public override double EvaluateState(State state) {
            return this.p_Heuristic.EvaluateState(this, state);
        }

        public override State GetStartingState() {
            return new GraphState(this.p_Start.Label, this.p_Start, 0);
        }

        public override State[] GetSuccessors(State state) {
            GraphState current = state as GraphState;

            if (current == null)
                return null;

            List<GraphState> successors = new List<GraphState>();
            
            foreach (Edge edge in current.Self.Edges)
                successors.Add(new GraphState(edge.Node.Label, edge.Node, edge.Weight));

            this.ExpandedStates.Add(current);

            return successors.ToArray();
        }

        public override bool IsGoalState(State state) {
            GraphState current = state as GraphState;

            if (current == null)
                return false;

            foreach (Node node in this.p_Goals) {
                if (current.Self.Equals(node))
                    return true;
            }

            return false;
        }
    }
}
