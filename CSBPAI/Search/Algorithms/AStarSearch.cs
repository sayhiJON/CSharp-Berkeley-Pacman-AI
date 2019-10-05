using System;
using System.Collections.Generic;
using Search.Algorithms.Interfaces;
using Search.Heuristics;
using Search.Heuristics.Interfaces;
using Search.Problems;
using Search.Utility.Classes;

namespace Search.Algorithms {
    public class AStarSearch : SearchAlgorithm {
        public override State[] Search(SearchProblem problem, IHeuristic heuristic = null) {
            if (heuristic == null)
                heuristic = new NullHeuristic();

            /*
                Implement the A* search algorithm here.

                The SearchProblem class contains useful methods for implementing the algorithm:
                    SearchProblem.GetStartingState()
                    SearchProblem.IsGoalState(State state)
                    SearchProblem.GetSuccessors(State state)

                The SearchAlgorithm class also contains a way to time the execution of your implementation:
                    SearchAlgorithm.StartStopwatch()
                    SearchAlgorithm.StopStopwatch()

                    These will update the SearchAlgorithm.Duration property

                The IHeuristic interface contains a method for evaluating a state, given a problem:
                    IHeuristic.EvaluateState(SearchProblem problem, State state)

                The PriorityQueue<T> class is an implementation of the priority queue structure. See the Uility.Classes.PriorityQueue.cs file.
                
                Examples:
                    SearchProblem Examples:
                        problem.GetStartingState(); // gets the starting state of the problem

                    SearchAlgorithm Examples:
                        this.StartStopwatch(); // starts timing the execution of code

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
