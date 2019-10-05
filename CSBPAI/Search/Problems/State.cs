using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Problems {
    public abstract class State : IEquatable<State> {
        public virtual double Cost { get; set; }

        public abstract bool Equals(State other);

        public abstract override bool   Equals(object obj);
        public abstract override int    GetHashCode();
    }
}
