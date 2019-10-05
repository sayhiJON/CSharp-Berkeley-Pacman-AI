using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Problems.Graphs {
    public class Edge : IEquatable<Edge>, IComparable<Edge> {
        public double Weight {
            get; private set;
        }

        public Node Node {
            get; private set;
        }

        private int p_HashCode = (string.Empty + 1d.ToString()).GetHashCode();

        public Edge() : this(null, 1d) {

        }

        public Edge(Node node) : this(node, 1d) {

        }

        public Edge(Node node, double weight) {
            this.Node = node;
            this.Weight = weight;

            string hashCode = (node != null) ? node.Label + weight.ToString() : string.Empty + weight.ToString();

            this.p_HashCode = hashCode.GetHashCode();
        }

        public int CompareTo(Edge other) {
            if (other == null)
                return -1;

            return other.Weight.CompareTo(other.Weight);
        }

        public bool Equals(Edge other) {
            if (other == null)
                return false;

            return this.p_HashCode == other.p_HashCode;
        }

        public override bool Equals(object obj) {
            Edge other = obj as Edge;

            if (other == null)
                return false;

            return this.p_HashCode == other.p_HashCode;
        }

        public override int GetHashCode() {
            return this.p_HashCode;
        }
    }
}
