using static System.Console;
using System.Text;


namespace C_Sharp.Answers.LLs.TestLL
{
    public class LinkedList {
    public int Value;
    public LinkedList Next = null;

    public LinkedList(int value) {
      this.Value = value;
    }

    public void Show()
    {
        WriteLine(this);
    }

    public override string ToString()
    {
        var node = this;
        StringBuilder sb = new();
        sb.Append(node.Value);
        while(node.Next != null)
        {
            node = node.Next;
            sb.Append($" --> {node.Value}");
        }
        return sb.ToString();
    }
  }
}