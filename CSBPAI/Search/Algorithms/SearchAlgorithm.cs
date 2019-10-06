using Search.Algorithms.Interfaces;
using Search.Heuristics.Interfaces;
using Search.Problems;
using System;
using System.Diagnostics;
using Search.Utility.Classes;
using Search.Heuristics;

namespace Search.Algorithms {
    /// <summary>
    /// Base class for all search algorithm implementations.
    /// </summary>
    public abstract class SearchAlgorithm : ISearchAlgorithm {
        /// <summary>
        /// Gets the running time of the search algorithm's implementation.
        /// </summary>
        public TimeSpan Duration { get; private set; }

        private Stopwatch p_Stopwatch = new Stopwatch();

        /// <summary>
        /// Searches for a solution to the provided problem using the algorithm of the derived class.
        /// </summary>
        /// <param name="problem">The <see cref="SearchProblem"/> to be searched.</param>
        /// <param name="heuristic">The <see cref="IHeuristic"/> to use when evaluating states.</param>
        /// <returns>An <see cref="Array"/> of <see cref="State"/>s that will lead to the solution or null if no solution is possible.</returns>
        public State[] Search(SearchProblem problem, IHeuristic heuristic = null) {
            if (heuristic == null)
                heuristic = new NullHeuristic();

            this.StartStopwatch();

            State[] result = this.RunSearch(problem, heuristic);

            this.StopStopwatch();

            return result;
        }

        /// <summary>
        /// Algorithm specific implementation for searching.
        /// </summary>
        /// <param name="problem">The <see cref="SearchProblem"/> to be searched.</param>
        /// <param name="heuristic">The <see cref="IHeuristic"/> to use when evaluating states.</param>
        /// <returns>An <see cref="Array"/> of <see cref="State"/>s that will lead to the solution or null if no solution is possible.</returns>
        protected abstract State[] RunSearch(SearchProblem problem, IHeuristic heuristic);

        /// <summary>
        /// Starts recording execution time.
        /// </summary>
        private void StartStopwatch() {
            if (this.p_Stopwatch == null)
                this.p_Stopwatch = new Stopwatch();

            if (this.p_Stopwatch.IsRunning)
                this.p_Stopwatch.Stop();

            this.p_Stopwatch.Reset();
            this.p_Stopwatch.Start();
        }

        /// <summary>
        /// Stops recording execution time and updates the <see cref="Duration"/> property.
        /// </summary>
        private void StopStopwatch() {
            this.p_Stopwatch.Stop();
            this.Duration = this.p_Stopwatch.Elapsed;
        }
    }
}
