using System.Text;

public class LinkedList
{
    public int value;
    public LinkedList next;

    public LinkedList(int value)
    {
        this.value = value;
        this.next = null;
    }


    public override string ToString()
    {
        var node = this;
        StringBuilder sb = new();
        sb.Append(node.value);
        while(node.next != null)
        {
            node = node.next;
            sb.Append($" --> {node.value}");
        }
        return sb.ToString();
    }
}