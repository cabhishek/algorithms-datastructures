namespace CodingPractice.Stacks
{
    public static class StackRunner
    {
        public static void run()
        {
            IStack stack = new LinkedStack();
            stack.push(5);
            stack.push(3);
            stack.push(4);
        }
    }
}