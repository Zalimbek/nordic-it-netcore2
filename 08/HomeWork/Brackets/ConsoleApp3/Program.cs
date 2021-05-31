using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(String[] args)
		{
			string input = "([]}";
			char[] exp = input.ToCharArray();

			if (isExpressionBalanced(exp))
			{
				Console.WriteLine($"The following expression: {input} is balanced ");
			}
			else
			{
				Console.WriteLine($"The following expression: {input} is Not balanced ");
			}

			static Boolean hasPair(char char1, char char2)
			{
				if (char1 == '(' && char2 == ')')
				{
					return true;
				}
				else if (char1 == '{' && char2 == '}')
				{
					return true;
				}
				else if (char1 == '[' && char2 == ']')
				{
					return true;
				}
				else
				{
					return false;
				}
			}

			static Boolean isExpressionBalanced(char[] exp)

			{
				Stack<char> st = new Stack<char>();

				for (int i = 0; i < exp.Length; i++)
				{
					if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')
					{
						st.Push(exp[i]);
					}
					if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']')
					{
						if (st.Count == 0)
						{
							return false;
						}
						else if (!hasPair(st.Pop(), exp[i]))
						{
							return false;
						}
					}
				}

				if (st.Count == 0)
					return true;
				else
				{
					return false;
				}
			}
		}
	}
}

