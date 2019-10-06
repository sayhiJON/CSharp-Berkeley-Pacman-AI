using Search.Algorithms;
using Search.Heuristics;
using Search.Problems;
using Search.Problems.Graphs;
using Search.Utility.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Search {
    class Program {
        static void Main(string[] args) {
            AStar_0();
            AStar_1_Graph_Heuristic();

            Console.Read();
        }

        private static void AStar_0() {
            Console.WriteLine("AStar_0");

            Node a = new Node("A");
            Node b = new Node("B");
            Node c = new Node("C");
            Node d = new Node("D");
            Node e = new Node("E");
            Node f = new Node("F");
            Node g = new Node("G");
            Node h = new Node("H");

            a.Edges.Add(new Edge(b, 2.0d));

            b.Edges.Add(new Edge(h, 4.0d));
            b.Edges.Add(new Edge(d, 1.0d));
            b.Edges.Add(new Edge(c, 2.0d));
            b.Edges.Add(new Edge(a, 2.0d));

            c.Edges.Add(new Edge(b, 2.0d));

            d.Edges.Add(new Edge(e, 2.5d));
            d.Edges.Add(new Edge(f, 2.0d));
            d.Edges.Add(new Edge(g, 1.5d));

            GraphProblem problem = new GraphProblem(a, new Node[] { f, h });
            AStarSearch search = new AStarSearch();
            State[] results = search.Search(problem);

            Console.WriteLine("Expanded States:");

            for (int index = 0; index < problem.ExpandedStates.Count; index++) {
                GraphState state = problem.ExpandedStates[index] as GraphState;
                Console.Write(state.Label);

                if (index != problem.ExpandedStates.Count - 1)
                    Console.Write("->");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Solution from starting state:");

            for (int index = 0; index < results.Length; index++) {
                GraphState state = results[index] as GraphState;
                Console.Write(state.Label);

                if (index != results.Length - 1)
                    Console.Write("->");
            }

            Console.WriteLine("\n");
        }

        private static void AStar_1_Graph_Heuristic() {
            Console.WriteLine("AStar_1_Graph_Heuristic");

            Node s = new Node("S");
            Node a = new Node("A");
            Node b = new Node("B");
            Node c = new Node("C");
            Node d = new Node("D");
            Node g = new Node("G");

            s.Edges.Add(new Edge(a, 2.0d));
            s.Edges.Add(new Edge(b, 3.0d));
            s.Edges.Add(new Edge(d, 5.0d));

            a.Edges.Add(new Edge(c, 3.0d));
            a.Edges.Add(new Edge(s, 2.0d));

            b.Edges.Add(new Edge(d, 4.0d));
            b.Edges.Add(new Edge(s, 3.0d));

            c.Edges.Add(new Edge(a, 3.0d));
            c.Edges.Add(new Edge(d, 1.0d));
            c.Edges.Add(new Edge(g, 2.0d));

            d.Edges.Add(new Edge(b, 4.0d));
            d.Edges.Add(new Edge(c, 1.0d));
            d.Edges.Add(new Edge(g, 5.0d));
            d.Edges.Add(new Edge(s, 5.0d));

            Dictionary<int, double> piecewise = new Dictionary<int, double> {
                { s.GetHashCode(), 6.0d },
                { a.GetHashCode(), 2.5d },
                { b.GetHashCode(), 5.25d },
                { c.GetHashCode(), 1.125d },
                { d.GetHashCode(), 1.0625d },
                { g.GetHashCode(), 0d }
            };

            GraphProblem problem = new GraphProblem(s, new Node[] { g });
            AStarSearch search = new AStarSearch();
            State[] results = search.Search(problem, new PiecewiseHeuristic<Node>(piecewise));

            Console.WriteLine("Expanded States:");

            for (int index = 0; index < problem.ExpandedStates.Count; index++) {
                GraphState state = problem.ExpandedStates[index] as GraphState;
                Console.Write(state.Label);

                if (index != problem.ExpandedStates.Count - 1)
                    Console.Write("->");
            }

            Console.WriteLine("\n");
            Console.WriteLine("Solution from starting state:");

            for (int index = 0; index < results.Length; index++) {
                GraphState state = results[index] as GraphState;
                Console.Write(state.Label);

                if (index != results.Length - 1)
                    Console.Write("->");
            }

            Console.WriteLine("\n");
        }
    }
}
