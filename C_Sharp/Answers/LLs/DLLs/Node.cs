namespace C_Sharp.Answers.LLs.DLLs
{
    // Do not edit the class below.
  public class Node {
    public int Value;
    public Node Prev;
    public Node Next;

    public Node(int value) {
      this.Value = value;
    }
  
    public override string ToString()
    {
        return Value.ToString();
    }
  }
}