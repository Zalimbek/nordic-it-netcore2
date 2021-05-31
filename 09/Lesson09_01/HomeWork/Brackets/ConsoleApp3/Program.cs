using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
	class Program
	{
		static void Main(String[] args)
		{
			string input = "([]}";//1
			char[] exp = input.ToCharArray();//2

			if (isExpressionBalanced(exp))//1
			{
				Console.WriteLine($"The following expression: {input} is balanced ");//1
			}
			else
			{
				Console.WriteLine($"The following expression: {input} is Not balanced ");//1
			}

			static Boolean hasPair(char char1, char char2) //N*(
			{
				if (char1 == '(' && char2 == ')')//2
				{
					return true;//1
				}
				else if (char1 == '{' && char2 == '}')//2
				{
					return true;//1
				}
				else if (char1 == '[' && char2 == ']')//2
				{
					return true;//1
				}
				else
				{
					return false;//1
				}
			}

			static Boolean isExpressionBalanced(char[] exp) 

			{
				Stack<char> st = new Stack<char>();//1

				for (int i = 0; i < exp.Length; i++) //2+2*(N-1)/2*(
				{
					if (exp[i] == '{' || exp[i] == '(' || exp[i] == '[')//3
					{
						st.Push(exp[i]);//1
					}
					if (exp[i] == '}' || exp[i] == ')' || exp[i] == ']') // 3
					{
						if (st.Count == 0) //1
						{
							return false; //1
						}
						else if (!hasPair(st.Pop(), exp[i])) // not sure, 2?
						{
							return false; //1
						}
					}
				}

				if (st.Count == 0) //1
					return true;//1
				else
				{
					return false; //1
				}
			}
		}
	}
}
// O()=1+2+1+1+1+N*(2+1+2+1+2+1+1)+1+2+2*(N-1)/2*(3+1+3+1+1+2+1)+1+1+1=6+N*(10)+3+2*(N-1)/2*12=9+10*N+12*N-12=22*N-3.
// Ω()=1+2+1+1+N*(2+1)+1+2*(N-1)/2*(3+1+3+1+2)+1+1=5+3*N+1+(N-1)*10+2=8+3*N+10*N-10=13*N-2

