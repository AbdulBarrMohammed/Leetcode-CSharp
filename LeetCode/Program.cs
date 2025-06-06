﻿

using LeetCode.BinarySearch;
using LeetCode.Search2DMatrix;

public class Program
{
    public static void Main(string[] args)
    {
        var matrix = new int[][] { new int[] { 1, 2, 4, 8 },
                                  new int[] { 10, 11, 12, 13 },
                                 new int[] { 14, 20, 30, 40 } };
        Console.WriteLine(Search2DMatrix.SearchMatrix(matrix, 10));

        //var piles = new int[] { 312884470 };
        //Console.WriteLine(KokoBananas.MinEatingSpeed(piles, 312884469));
        var arry = new int[] {4,5,1,2,3 };
        Console.WriteLine(FindMinRotatedArray.FindMin(arry));
    }

    static int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();
        for (int i = 0; i < tokens.Length; i++)
        {
            if (tokens[i] == "+")
            {
                int numOne = stack.Pop();
                int numTwo = stack.Pop();
                int currTotal = numOne + numTwo;
                stack.Push(currTotal);
            }
            else if (tokens[i] == "*")
            {
                int numOne = stack.Pop();
                int numTwo = stack.Pop();
                int currTotal = numOne * numTwo;
                stack.Push(currTotal);
            }
            else if (tokens[i] == "/")
            {
                int numOne = stack.Pop();
                int numTwo = stack.Pop();
                int currTotal = numTwo / numOne;
                stack.Push(currTotal);
            }
            else if (tokens[i] == "-")
            {
                int numOne = stack.Pop();
                int numTwo = stack.Pop();
                int currTotal = numTwo - numOne;
                stack.Push(currTotal);
            }
            else
            {
                stack.Push(int.Parse(tokens[i]));
            }
        }
        return stack.Pop();
    }



    bool IsValid(string s)
    {
        var stack = new List<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (stack.Count != 0)
            {
                if (s[i] == ')' && stack[^1] == '(')
                {
                    stack.RemoveAt(stack.Count - 1);
                }
                else if (s[i] == '}' && stack[^1] == '{')
                {
                    stack.RemoveAt(stack.Count - 1);
                }
                else if (s[i] == ']' && stack[^1] == '[')
                {
                    stack.RemoveAt(stack.Count - 1);
                }
                else
                {
                    stack.Add(s[i]);
                }

            }
            else
            {
                stack.Add(s[i]);
            }
        }

        return stack.Count == 0;
    }

}


/*

public class MinStack {

    private Stack<int> stack;
    private Stack<int> minVals;
    public MinStack()
    {
        stack = new Stack<int>();
        minVals = new Stack<int>();


    }

    public void Push(int val)
    {
        if (minVals.Count == 0 || val <= minVals.Peek())
        {
            minVals.Push(val);
        }
        stack.Push(val);
    }

    public void Pop()
    {
        if ((int)stack.Peek() == (int)minVals.Peek())
        {
            minVals.Pop();
        }
        stack.Pop();
    }
    public int Top()
    {
        return (int)stack.Peek();
    }
    public int GetMin()
    {
        return minVals.Peek();
    }



}
 */
