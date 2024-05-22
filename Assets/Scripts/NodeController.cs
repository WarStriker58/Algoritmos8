using System.Collections;
using UnityEngine;

public class NodeController : MonoBehaviour
{
    [SerializeField] private SimplyLinkedList<NodeController> adjacentNodes = new SimplyLinkedList<NodeController>();
    [SerializeField] private int weightNumb;
    public int index;

    public void AddAdjacentNode(NodeController node)
    {
        adjacentNodes.InsertNodeAtEnd(node);
    }
    
    public NodeController SelecRandomAdjancent()
    {
        index = Random.Range(0, adjacentNodes.length);
        return adjacentNodes.ObtainNodeAtPosition(index);
    }
    
    public void SetWeight(int weight)
    {
        weightNumb = weight;
    }

    public int GetNodeWeight()
    {
        return weightNumb;
    }
}