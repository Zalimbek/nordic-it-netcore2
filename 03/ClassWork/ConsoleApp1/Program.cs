using System;
using System.Text;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			// BooleanLessonPart();
			//ConstantsLessonPart();
			//ObjectLessonPart();
			//DynamicLessonPart();
			//VarLessonPart();
			//ReferenceAndValueTypes();
			ArraysLessonPart();
			//NullableLessonPart();
		}
		private static void NullableLessonPart()
		{
			int? a = 5;
			float? b = null;;
			Console.WriteLine(a.HasValue);
			Console.WriteLine(b.HasValue);
			if (a.HasValue)
			{
				Console.WriteLine(a.Value);
			}
			if (b.HasValue)
			{
				Console.WriteLine(b.Value);
			}

		}
		private static void ArraysLessonPart()
		{
			string[] cities = new string[3];
			cities[0] = "Moscow";
			cities[1] = "New York";
			cities[2] = "Dallas";

			for (/*1*/ int i = 0; /*2*/ i < 3;/*3*/i++)
				{
				Console.WriteLine(cities[i]);
				
				}

			string[] trees = new string[3];
			trees[0] = "Yasen";
			trees[1] = "Klen";
			trees[2]="Lipa";

			int[] ages = new int[3];
			ages[0] = 21;
			ages[1] = 6;
			ages[2] = 42;

			for ( int i = 0; i < 3; i++)
				{
				Console.WriteLine($"{trees[i]} - vozrast v godah {ages[i]}");

			}

		}

		private static void ReferenceAndValueTypes()
		{
			int A = 255;
			A = 0;
			Console.WriteLine(A);

			string s = null;
			s = new string("SSS");
			s = "";
			s = string.Empty;
			Console.WriteLine(string.Empty==null);

			Console.WriteLine();
			Console.WriteLine(default(int));

			var sss = default(string);
			Console.WriteLine(sss);

		}
		static void ConstantsLessonPart()
		{
			const string name = "Masha";
			const byte age = 20;

			string welcomeText = "Hello " + name;
		}

		static void ObjectLessonPart()
		{
			object name1 = "Masha";
			Console.WriteLine(name1);

			string name2 = "Sasha ";
			Console.WriteLine($"{name2}, букв в имени: {name2.Length}");
		}

		static void DynamicLessonPart()
		{
			dynamic name3 = "Masha";
			Console.WriteLine(name3.Length);
		}

		static void VarLessonPart()
		{
			var name4= "Alexander";
			Console.WriteLine(name4.GetType().FullName);
			var age4 = 29;
			Console.WriteLine(age4.GetType().FullName);
		}

		//static void BooleanLessonPart()








	}
}
