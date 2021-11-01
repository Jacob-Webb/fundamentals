using System;
using System.Collections.Generic;

public class Graph<TNode, TEdgeData> : IGraph<TNode, TEdgeData>
{
    public struct Edge
    {
        public Edge(TNode dest, TEdgeData value) 
        {
            Dest = dest;
            Value = value;
        }
        TNode Dest { get; set; }
        TEdgeData Value { get; set; }
    }    
    Dictionary<TNode, LinkedList<TNode>> _adjacencyList;
    Dictionary<(TNode, TNode), TEdgeData> _edges;

    public int NodeCount { get {return _adjacencyList.Count;} }
    public int EdgeCount { get {return _edges.Count;} }
    public IEnumerable<TNode> Nodes { get {return _adjacencyList.Keys;} }

    public void AddNode(TNode node)
    {
        _adjacencyList.Add(node, new LinkedList<TNode>());
    }
    public void AddEdge(TNode source, TNode dest, TEdgeData value)
    {
        // error checking to make sure that source and dest are not null
        if (source == null) throw new ArgumentNullException("Parameter must not be null", nameof(source));
        if (dest == null) throw new ArgumentNullException("Parameter must not be null", nameof(dest));
        if (ReferenceEquals(source, dest)) throw new ArgumentException("Source must not be the same node as Destination");

        _edges.Add((source, dest), value);

        LinkedList<TNode> sourceAdjacency;
        _adjacencyList.TryGetValue(source, out sourceAdjacency);
        sourceAdjacency.AddFirst(dest);
        _adjacencyList[source] = sourceAdjacency;

        if (!(_adjacencyList.ContainsKey(dest))) _adjacencyList.Add(dest, null);
    }
    public bool TryGetEdge(TNode source, TNode dest, out TEdgeData value)
    {
        return _edges.TryGetValue((source, dest), out value);
    }
    public bool ContainsNode(TNode node)
    {
        return _adjacencyList.ContainsKey(node);
    }
    public bool ContainsEdge(TNode source, TNode dest)
    {
        return _edges.ContainsKey((source, dest));
    }
    public IEnumerable<Edge> OutgoingEdges(TNode source)
    {
        LinkedList<TNode> sourceAdjacency;
        _adjacencyList.TryGetValue(source, out sourceAdjacency);

        if (sourceAdjacency == null) yield break;

        foreach (TNode dest in sourceAdjacency) {
            TEdgeData value;
            _edges.TryGetValue((source, dest), out value);
            yield return new Edge(dest, value);
        }

    }
}