using C_Sharp.Answers.Extensions;
using static System.Console;

namespace C_Sharp.Answers.Stacks
{
    public class SortStackDemo
    {
        public static void Demo()
        {
            var stack = new List<int> { -5, 2, -2, 4, 3, 1};
            var sortStackDemo = new SortStackDemo();
            WriteLine($"{sortStackDemo.SortStack(stack).Display(",")}");
        }

        public List<int> SortStack(List<int> stack) 
        {
            if (stack.Count == 0)
                return  stack;
            var top = PopStack(stack);
            SortStack(stack);
            InsertInSortedOrder(stack, top);
            return stack;
        }

        private void InsertInSortedOrder(List<int> stack, int toPush)
        {
            if (stack.Count == 0 || PeekStack(stack) <= toPush)
            {
                PushStack(stack, toPush);
                return;
            }
            var top = PopStack(stack);
            InsertInSortedOrder(stack, toPush);
            PushStack(stack, top);
        }

        private void PushStack(List<int> stack, int top)
        {
            stack.Add(top);
        }

        private int PeekStack(List<int> stack)
        {
            return stack[GetLastIndex(stack)];
        }

        private int PopStack(List<int> stack)
        {
            var lastIndex = GetLastIndex(stack);
            var popped = stack[lastIndex];
            stack.RemoveAt(lastIndex);
            return popped;
        }

        private static int GetLastIndex(List<int> stack)
        {
            return stack.Count - 1;
        }
    }
}