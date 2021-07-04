using System;

namespace Delegate_demo
{
		class Program
		{
			//delegate int PerformCalculation(int a, int b);

		
		static void Main(string[] args)
		{
			////var calc = new SimpleCalc();
			//Console.WriteLine(SimpleCalc.Sum(10, 10));
			//Console.WriteLine(SimpleCalc.Multiply(10, 10));

			PerformCalculation performcalculation;
			int result;
			//performcalculation = SimpleCalc.Sum;
			//result = performcalculation(10, 5);
			//Console.WriteLine(result);

			//performcalculation = SimpleCalc.Multiply;
			//result = performcalculation(10, 5);
			//Console.WriteLine(result);

			//PerformCalculation perfCalc1 = SimpleCalc.Sum;
			//PerformCalculation perfCalc2 = SimpleCalc.Multiply;
			//PerformCalculation perfCalc3 = (PerformCalculation)Delegate.Combine(perfCalc1, perfCalc2);

			//result = perfCalc3(100, 100);
			//Console.WriteLine("perfCalc3 (Sum, Multiply)= "+result);

			//PerformCalculation perfCalc4 = perfCalc1;
			//perfCalc4 += perfCalc2;
			//perfCalc4 += perfCalc3;
			//result = perfCalc4(100, 100);
			//Console.WriteLine("perfCalc4(Sum,Multiply)"+ result);

			//Console.WriteLine("***");
			//perfCalc4 = (PerformCalculation)Delegate.Remove(perfCalc4, perfCalc3);
			//result = perfCalc4(100, 100);
			//Console.WriteLine("perfCalc4 (Sum, Multiply)="+ result);

			Func<int, int, int> performCalculation;
			performCalculation = SimpleCalc.Sum;
			result = performcalculation(100, 100);
			Console.WriteLine(result);
			ConsoleWriteLine(1,1.5F, true);
			Action<int, LoaderOptimizationAttribute, bool> cw;
			cw = ConsoleWriteLine;
				cw(15, MathF.PI, false);

		}
		private static void ConsoleWriteLine(int a, float b, bool c)
		{
			Console.WriteLine($"{a}, {b}, {c}");
		}
		}
	}

