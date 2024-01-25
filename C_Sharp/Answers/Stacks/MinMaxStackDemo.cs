using System.Text;
using static System.Console;

namespace C_Sharp.Answers.Stacks
{
    public class MinMaxStackDemo
    {
        public static void Test()
        {
            var stack = new MinMaxStack();
            stack.Push(5);
            WriteLine(stack);
            WriteLine(stack.GetMin());
            WriteLine(stack.GetMax());
            WriteLine(stack.Peek());
            
            stack.Push(7);
            WriteLine(stack);

            WriteLine(stack.GetMin());
            WriteLine(stack.GetMax());
            WriteLine(stack.Peek());
            stack.Push(2);
            WriteLine(stack);

            WriteLine(stack.GetMin());
            WriteLine(stack.GetMax());
            WriteLine(stack.Peek());

            WriteLine(stack.Pop());
            WriteLine(stack);

            WriteLine(stack.Pop());
            WriteLine(stack);

            WriteLine(stack.GetMin());
            WriteLine(stack.GetMax());
            WriteLine(stack.Peek());

        }

    }

    public class MinMaxStack
    {
        private List<Number> _nums = new List<Number>();
        public int Peek()
        {
            if (_nums.Count == 0)
                throw new InvalidOperationException("Empty Stack");              // unavailable
            return PeekNum().Num;
        }     

        public int Pop()
        {
            if (_nums.Count == 0)
                throw new InvalidOperationException("Empty Stack");              // unavailable
            var popped = _nums[_nums.Count - 1];
            _nums.RemoveAt(_nums.Count - 1);
            return popped.Num;
        }

        public void Push(int number)
        {
            _nums.Add(GetNum(number));
        }

        public int GetMin()
        {
            if (_nums.Count == 0)
                throw new InvalidOperationException("Empty Stack");              // unavailable
            return PeekNum().Min;
        }

        public int GetMax()
        {
            if (_nums.Count == 0)
                throw new InvalidOperationException("Empty Stack");              // unavailable
            return PeekNum().Max;
        }
        
        private Number GetNum(int number)
        {
            var peeked = PeekNum();
            return new Number
            {
                Num = number,
                Min = peeked == null ? number : Math.Min(number, peeked.Min),
                Max = peeked == null ? number : Math.Max(number, peeked.Max)
            };
        }

        private Number PeekNum()
        {
            if (_nums.Count == 0)
                return null;
            return _nums[_nums.Count - 1];
        }

        public override string ToString()
        {
            if (_nums.Count == 0)
                return "Empty Stack";
            var sb = new StringBuilder();
            for (int i = _nums.Count - 1; i >= 0 ; i--)
            {
                sb.AppendLine(_nums[i].ToString());
            }
            return sb.ToString();
        }
    }

    public class Number
    {
        public int Num { get; init; }
        public int Min { get; init; }
        public int Max { get; init; }

        public override string ToString()
        {
            return $"[{Num} , Min: {Min}, Max: {Max}]";
        }
    }
}