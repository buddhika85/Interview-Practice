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

    public void InsertBefore(Node node, Node nodeToInsert)
    {
      // Write your code here.
    }

    public void InsertAfter(Node node, Node nodeToInsert)
    {
      // Write your code here.
    }

    public void InsertAtPosition(int position, Node nodeToInsert)
    {
      // Write your code here.
    }

    public void RemoveNodesWithValue(int value)
    {
      // Write your code here.
    }

    public void Remove(Node node)
    {
      // Write your code here.
    }

    public bool ContainsNodeWithValue(int value)
    {
      // Write your code here.
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