using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_methods
{
	public static class Swapper
	{
		//public static void Swap<T>(ref T a, ref T b) //адреса памяти ref
		//{
		//	T temp = a;
		//	a = b;
		//	b = temp;
		//}

		//public static void Swap<T1, T2>(ref T1 a, ref T2 b) //адреса памяти ref
		//{
		//	T1 temp1 = a;
		//	T2 temp2 = b;
		//}


		public static void Swap<T>(ref T a, ref T b) 
		{
			T temp = a;
			a = b;
			b = temp;
		}

		//public static void Swap<T>(ref T a, ref T b) where T : struct //-value type
		//{
		//	T temp = a;
		//	a = b;
		//	b = temp;
		//}
	}
}
