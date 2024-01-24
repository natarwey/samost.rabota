class Program
{
    static bool IsTrue(string expression)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char c in expression)
        {
            if (c == '(' || c == '[' || c == '{')
            {
                stack.Push(c);
            }
            else if (c == ')' || c == ']' || c == '}')
            {
                if (stack.Count == 0)
                {
                    return false;
                }

                char top = stack.Pop();

                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{'))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    static void Main(string[] args)
    {
        string expression = Console.ReadLine();
        bool isTrue = IsTrue(expression);
        Console.WriteLine($"Выражение \"{expression}\" {(isTrue ? "верно" : "не верно")}");
    }
}