using System.Text;

namespace C_Sharp.Answers.LLs.DLLs
{
  // Feel free to add new properties and methods to the class.
  public class DoublyLinkedList
  {
    public Node Head;
    public Node Tail;
    public int Length { get; private set; }

    public void AddNode(Node node)
    {
      if (Length == 0)
      {
        Head = node;
        Tail = node;
      }
      else
      {
        Tail.Next = node;
        node.Prev = Tail;
        Tail = node;
      }
      ++Length;
    }

    // 1 <-> 2 <-> 3 <-> 4 <-> 5
    // Node 4
    // 4 <-> 1 <-> 2 <-> 3 <-> 4 <-> 5
    // Node 10 <-> 20 <-> 30
    // 10 <-> 20 <-> 30 <-> 4 <-> 1 <-> 2 <-> 3 <-> 4 <-> 5
    public void SetHead(Node node)
    {
      if (Length == 0)
      {
        Head = node;
        Tail = node;
        ++Length;
      }
      else
      {
        var prevHead = Head;
        Head = node;
        ++Length;
        var currNode = Head;
        while(currNode.Next != null)
        {
          currNode = currNode.Next;
          ++Length;          
        }
        currNode.Next = prevHead;
        prevHead.Prev = currNode;
      }
    }


    // 1 <-> 2 <-> 3 <-> 4 <-> 5
    // node 6
    // setTail(6) --> 1 <-> 2 <-> 3 <-> 4 <-> 5 <-> 6
    // node 7 <-> 8 <-> 9
    // setTail(6) --> 1 <-> 2 <-> 3 <-> 4 <-> 5 <-> 6 <-> 7 <-> 8 <-> 9
    public void SetTail(Node node)
    {
      Tail.Next = node;
      ++Length;
      while(node.Next != null)
      {
        node = node.Next;
        ++Length;
      }
      Tail = node;
    }

    // 4 <-> 1 <-> 2 <-> 3 <-> 5 <-> 6
    // insertBefore(node: 6, nodeToInsert: 3) --> 
    // 4 <-> 1 <-> 2 <-> 3 <-> 5 <-> 3 <-> 6
    //
    // case 2: 1 <-> 2 <-> 3 <-> 4
    // insertBefore(node: 3, nodeToInsert: 10) --> 
    // 1 <-> 2 <-> 10 <-> 3 <-> 4
    //
    // case 3: 1 <-> 2 <-> 3 <-> 4
    // insertBefore(node: 2, nodeToInsert: 20 <-> 30 <-> 40) --> 
    // 1 <-> 20 <-> 30 <-> 40 <-> 2 <-> 10 <-> 3 <-> 4
    public void InsertBefore(Node node, Node nodeToInsert)
    {
      if (Length == 0)
        return;               // cannot add before as it is empty
     
      // add before head
      if (node.Value == Head.Value)
      {
        SetHead(nodeToInsert);
        return;
      }

      // add to middle
      var currNode = Head;
      while(currNode.Next != null && currNode.Value != node.Value)
      {
        currNode = currNode.Next;
      }
      if (currNode == null || currNode.Value != node.Value)
        return;             // cannot insert as node before is not found
      
      currNode.Prev.Next = nodeToInsert;
      nodeToInsert.Prev = currNode.Prev;
      ++Length;
      while(nodeToInsert.Next != null)
      {
        nodeToInsert = nodeToInsert.Next;
        ++Length;
      }
      nodeToInsert.Next = currNode;
      currNode.Prev = nodeToInsert;
    }

    public void InsertAfter(Node node, Node nodeToInsert)
    {
      if (Length == 0)
        return;               // cannot add after as it is empty

      // add after the tail
      if (node.Value == Tail.Value)
      {
        SetTail(nodeToInsert);
        return;
      }

      // add to middle
      var currNode = Head;
      while(currNode != null && currNode.Value != node.Value)
      {
        currNode = currNode.Next;
      }

      if (currNode == null || currNode.Value != node.Value)
        return;             // node not found, so cannot insert anything after it
      
      var after = currNode.Next;
      currNode.Next = nodeToInsert;
      nodeToInsert.Prev = currNode;
      ++Length;
      while(nodeToInsert.Next != null)
      {        
        nodeToInsert = nodeToInsert.Next;
        ++Length;
      }
      nodeToInsert.Next = after;
      after.Prev = nodeToInsert;
    }

    public void InsertAtPosition(int position, Node nodeToInsert)
    {
      if (position == 0)
      {
        SetHead(nodeToInsert);
        return;
      }

      if (position == Length)
      {
        SetTail(nodeToInsert);
        return;
      }

      var nodeByIndex = GetNodeByIndex(position);
      if (nodeByIndex == null)
        return;         // no such position
      
      InsertBefore(nodeByIndex, nodeToInsert);
    }

    public Node GetNodeByIndex(int position)
    {
      if (position < 0 || position > Length - 1)
        return null;      // No such position
      // if (position == 0)
      //   return Head;
      // if (position == Length - 1)
      //   return Tail;
      Node? node = Head;
      for (var i = 0; i <= position; i++)
      {
        if (i == position)
          return node;
        node = node.Next;
      }
      return null;
    }

    public void RemoveNodesWithValue(int value)
    {
      var currNode = Head;
      while(currNode != null)
      {
        if (currNode.Value == value)
        {
          if (Length == 1)
          {
            Head = null;
            Tail = null;
          }
          // remove head
          else if (currNode == Head)
          {
            Head = currNode.Next;
            currNode.Next.Prev = null;
          }
          // remove tail
          else if (currNode == Tail)
          {
            Tail = currNode.Prev;
            currNode.Prev.Next = null;
          }
          // remove from middle
          else
          {
            currNode.Prev.Next = currNode.Next;
            currNode.Next.Prev = currNode.Prev;            
          }
          --Length;
        }
        currNode = currNode.Next;
        
      }
    }

    public void Remove(Node node)
    {
      RemoveNodesWithValue(node.Value);
    }

    public bool ContainsNodeWithValue(int value)
    {
      var node = Head;
      while(node != null)
      {
        if (node.Value == value)
          return true;
        node = node.Next;
      }
      return false;
    }

    public override string ToString()
    {
      StringBuilder sb = new();
      sb.AppendLine($"Doubly Linked List with length {Length}");
      sb.AppendLine($"Head; {Head}, Tail: {Tail}");
      var node = Head;
      while(node != null)
      {
        sb.Append($"{node.Value}");
        if (node.Next != null)
          sb.Append(" <-> ");
        node = node.Next;
      }
      sb.Append($"{Environment.NewLine}");
      return sb.ToString();
    }

  }

}