using System;
using MyList;
using MyStack;
namespace PosfixInfix
{
    public class Program
    {
        private static string operators = "+-*/()";
        private static int[] priorities = { 3, 3, 4, 4, 5, 5 };
        static void Main(string[] args)
        {
            string[] d = {"(", "(", "10", "+", "111", ")", "*", "10",")","/","(","7","+","9","/","3",")"};
          //  string[] d = { "(", "(", "A", "+", "B", ")", "*", "C", ")", "/", "(", "D", "+", "E", "/", "G", ")" };
            ArrayList e = new ArrayList(d.Length);
            for (int i = 0; i < d.Length; i++)
                e.add(d[i]);
            ArrayList Postfix = infix2posfix(e);
            for (int i = 0; i < Postfix.size(); i++)
                Console.Write(Postfix.get(i));
            Console.WriteLine("\n" + Calculate(Postfix));
            Console.ReadLine();
        }
        public static double Calculate(ArrayList postfix)
        {
            ArrayStack s = new ArrayStack(postfix.size());
            for (int i = 0; i < postfix.size(); i++)
            {
                if (isOperator(postfix.get(i).ToString()))
                {
                    if (postfix.get(i).Equals("+"))
                    {
                        double X1 = double.Parse(s.pop().ToString());
                        double X2 = double.Parse(s.pop().ToString());
                        s.push(X2 + X1);
                    }
                    else if(postfix.get(i).Equals("-"))
                    {
                        double X1 = double.Parse(s.pop().ToString());
                        double X2 = double.Parse(s.pop().ToString());
                        s.push(X2 - X1);
                    }
                    else if (postfix.get(i).Equals("*"))
                    {
                        double X1 = double.Parse(s.pop().ToString());
                        double X2 = double.Parse(s.pop().ToString());
                        s.push(X2 * X1);
                    }

                    else
                    {
                        double X1 = double.Parse(s.pop().ToString());
                        double X2 = double.Parse(s.pop().ToString());
                        s.push(X2 / X1);
                    }
                }
                else
                    s.push(postfix.get(i));
            }
            return double.Parse(s.peek().ToString());
        }
        public static ArrayList infix2posfix(ArrayList infix)
        {
            ArrayList postfix = new ArrayList(infix.size());
            Stack s = new ArrayStack(infix.size());
            for (int i = 0; i < infix.size(); ++i)
            {
                string token = infix.get(i).ToString();
                if (!isOperator(token) && !isParenthesis(token))
                    postfix.add(token);
                else if (isParenthesis(token))
                {
                    if (token.Equals("("))
                        s.push(token);
                    else
                    {
                        bool popContinue = true;
                        while (popContinue)
                        {
                            if (s.peek().Equals("("))
                            {
                                s.pop(); 
                                popContinue = false;
                            }
                            else
                                postfix.add(s.pop());
                        }
                        
                    }
                }
                else
                {
                    if (s.isEmpty() || s.peek().Equals("("))
                        s.push(token);
                    else
                    {
                        while (!s.isEmpty() && priority(token) <= priority(s.peek().ToString()))
                            postfix.add(s.pop());
                        s.push(token);
                    }
                }
            }
            while (!s.isEmpty()) postfix.add(s.pop());
            return postfix;
        }
        private static bool isParenthesis(string x) { return operatorIndex(x) >= 4; }
        private static bool isOperand(string x) { return operatorIndex(x) == -1; }
        private static bool isOperator(string x) { return operatorIndex(x) >= 0; }
        private static int priority(string x) { return priorities[operatorIndex(x)]; }
        private static int operatorIndex(string x)
        {
            for (int i = 0; i < priorities.Length; i++)
                if (operators[i].ToString().Equals(x))
                    return i;
            return -1;
        }

    }
}
