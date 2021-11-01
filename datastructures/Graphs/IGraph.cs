using System.Collections.Generic;

public interface IGraph<TNode, TEdgeData>  {
    void AddNode(TNode node);
    void AddEdge(TNode source, TNode dest, TEdgeData value);
    bool TryGetEdge(TNode source, TNode dest, out TEdgeData value);
    bool ContainsNode(TNode node);
    bool ContainsEdge(TNode source, TNode dest);

    //IEnumerable<Edge<TNode, TEdgeData>> OutgoingEdges(TNode source);
}