using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Search.Heuristics;
using Search.Heuristics.Interfaces;
using Search.Problems;
using Search.Utility.Classes;

namespace Search.Algorithms {
    public class DepthFirstSearch : SearchAlgorithm {
        /// <summary>
        /// Algorithm specific implementation for searching.
        /// </summary>
        /// <param name="problem">The <see cref="SearchProblem"/> to be searched.</param>
        /// <param name="heuristic">The <see cref="IHeuristic"/> to use when evaluating states.</param>
        /// <returns>An <see cref="Array"/> of <see cref="State"/>s that will lead to the solution or null if no solution is possible.</returns>
        protected override State[] RunSearch(SearchProblem problem, IHeuristic heuristic) {
            /*
                Implement the Breadth First Search algorithm here.

                The SearchProblem class contains useful methods for implementing the algorithm:
                    SearchProblem.GetStartingState()
                    SearchProblem.IsGoalState(State state)
                    SearchProblem.GetSuccessors(State state)

                The SearchAlgorithm class also contains a way to time the execution of your implementation:
                    The SearchAlgorithm.Duration property will contain a TimeSpan of your code's execution time

                The IHeuristic interface contains a method for evaluating a state, given a problem:
                    IHeuristic.EvaluateState(SearchProblem problem, State state)

                .NET contains built in data structures for implementing some of the search algorithms
                    - Queue<T>
                    - Stack<T>

                The PriorityQueue<T> class is an implementation of the priority queue structure. See the Uility.Classes.PriorityQueue.cs file.
                
                Examples:
                    SearchProblem Examples:
                        problem.GetStartingState(); // gets the starting state of the problem

                    Heuristic Examples:
                        heuristic.EvaluateState(problem, state);    // returns a double with the expected value of this state in terms of reaching the goal state

                    PriorityQueue<T> Examples:
                        PriorityQueue<State> pQueue = new PriorityQueue<State>();   // creates a new priority queue instance for State objects
                        pQueue.push(state, 4.3);    // places the State object "state" in queue with a priority of 4.3
                        State next = pQueue.Top;    // gets the State object in queue with the smallest priority value
                        pQueue.Pop();               // removes the State object with the smallest priority value from the queue
            */

            return null;
        }
    }
}
