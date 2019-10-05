using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Problems {
    /// <summary>
    /// Compares two State objects for ordering purposes.
    /// </summary>
    public class StateComparer : IComparer<State> {
        /// <summary>
        /// Compares two <see cref="State"/>s and determines if one is greater than the other.
        /// </summary>
        /// <param name="x">First <see cref="State"/> to compare.</param>
        /// <param name="y">Second <see cref="State"/> to compare.</param>
        /// <returns>-1 if <paramref name="x"/> is less than <paramref name="y"/>. 0 if they are equal. 1 if <paramref name="x"/> is greater than <paramref name="y"/>.</returns>
        public int Compare(State x, State y) {
            if (x == null)
                return -1;

            if (y == null)
                return 1;

            if (x.Cost < y.Cost)
                return -1;

            if (x.Cost == y.Cost)
                return 0;

            return 1;
        }
    }
}
