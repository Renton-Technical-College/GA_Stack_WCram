namespace GA_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();

            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);

            int poppedItem = myStack.Pop();

            Console.WriteLine("Popped Element: " + poppedItem);

        } // Main

    } // class

} // namespace
