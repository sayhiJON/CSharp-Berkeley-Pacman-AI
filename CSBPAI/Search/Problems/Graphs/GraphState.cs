using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Problems.Graphs {
    public class GraphState : State {
        public string Label {
            get => this.p_Label;
            private set {
                if (this.p_Label != value) {
                    this.p_Label = value;
                    this.p_HashCode = value.GetHashCode();
                }
            } 
        }

        public Node Self {
            get; set;
        } = null;

        private string  p_Label     = string.Empty;
        private int     p_HashCode  = string.Empty.GetHashCode();

        public GraphState(string label, Node self, double cost) {
            this.Label = label;
            this.Self = self;
            this.Cost = cost;
        }

        public override bool Equals(State other) {
            if (other == null)
                return false;

            GraphState state = other as GraphState;

            if (state == null)
                return false;

            return this.p_HashCode == state.p_HashCode;
        }

        public override bool Equals(object obj) {
            if (obj == null)
                return false;

            GraphState state = obj as GraphState;

            if (state == null)
                return false;

            return this.p_HashCode == state.p_HashCode;
        }

        public override int GetHashCode() {
            return this.p_HashCode;
        }
    }
}
