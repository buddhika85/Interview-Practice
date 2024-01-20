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

    public void SetHead(Node node)
    {
      // Write your code here.
    }

    public void SetTail(Node node)
    {
      // Write your code here.
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