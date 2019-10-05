using Search.Algorithms.Interfaces;
using Search.Heuristics.Interfaces;
using Search.Problems;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Algorithms {
    public abstract class SearchAlgorithm : ISearchAlgorithm {
        public virtual TimeSpan Duration { get; set; }

        private Stopwatch p_Stopwatch = new Stopwatch();

        public abstract State[] Search(SearchProblem problem, IHeuristic heuristic = null);

        public virtual void StartStopwatch() {
            if (this.p_Stopwatch == null)
                this.p_Stopwatch = new Stopwatch();

            if (this.p_Stopwatch.IsRunning)
                this.p_Stopwatch.Stop();

            this.p_Stopwatch.Reset();
            this.p_Stopwatch.Start();
        }

        public virtual void StopStopwatch() {
            this.p_Stopwatch.Stop();
            this.Duration = this.p_Stopwatch.Elapsed;
        }
    }
}
