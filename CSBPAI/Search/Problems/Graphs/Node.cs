using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search.Problems.Graphs {
    public class Node : IComparable<Node>, IEquatable<Node> {
        public string Label {
            get; private set;
        } = string.Empty;

        public List<Edge> Edges {
            get; private set;
        }

        private int p_HashCode = string.Empty.GetHashCode();

        public Node() : this(string.Empty, new List<Edge>()) {

        }

        public Node(string label) : this(label, new List<Edge>()) {

        }

        public Node(string label, List<Edge> edges) {
            this.Label      = label;
            this.p_HashCode = label.GetHashCode();
            this.Edges      = new List<Edge>(edges);
        }

        public int CompareTo(Node other) {
            if (other == null)
                return -1;

            return this.Label.CompareTo(other.Label);
        }

        public bool Equals(Node other) {
            if (other == null)
                return false;

            return this.p_HashCode == other.p_HashCode;
        }

        public override bool Equals(object obj) {
            Node other = obj as Node;

            if (other == null)
                return false;

            return this.p_HashCode == other.p_HashCode;
        }

        public override int GetHashCode() {
            return this.p_HashCode;
        }
    }
}
