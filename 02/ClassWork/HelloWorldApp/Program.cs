using System;
using System.Text;

namespace HelloWorldApp
{
/// <summary>
/// The main entry point
/// </summary>
	public class Program
	{
		/*
		 * This is my superclass for
		 * License
		 */
		static void Main(string[] args)
		{
			Console.InputEncoding = Encoding.Unicode;  // support unicode for input
			Console.OutputEncoding = Encoding.Unicode; // support unicode for output
													   //bool b = DoDocExample("test", 12);

			//Console.WriteLine("Введите имя:");
			//Console.WriteLine(
			//	$"Привет,{Console.ReadLine()}");
			//Console.WriteLine(a);
			///*
			// * объявление переменных
			// */

			//int intExample;
			//int intSecondSexample = 10;

			//string s1;
			//s1 = Console.ReadLine();
			//char symbol = '@';
			//double i = 123.45;
			//float pi = 3.1415;

			//bool someValue = false;
			////C# обозначения
			//int indexOfSome = 2;
			//string fileName = "some file name";
			char letter = 'A';
			Console.WriteLine(letter);
			Console.WriteLine((int)letter);
			System.Char letter2 = 'B';
			Console.WriteLine(letter2);
			string name = "Alice";
			Console.WriteLine(name);
			String name2 = "Bob";
			Console.WriteLine(name2);

			byte age = 36; //0..255
			Byte age2 = age;
			Console.WriteLine(age2);

			sbyte temp = 126;//-128..127
			sbyte temp2 = temp;
			Console.WriteLine(temp2);

			short pressure = -21200;//-32768..32767
			Int16 pressure2 = pressure;
			Console.WriteLine(pressure2);

			ushort yearOfBirth = 1982;//0..65635
			UInt16 yearOfBirth2 = yearOfBirth;
			Console.WriteLine(yearOfBirth2);

			int minutesInYear = 365 * 24 * 60;
			Int32 minutesInYear2 = minutesInYear;
			Console.WriteLine(minutesInYear2);

			uint minutesInYearUnsigned = 365 * 24 * 60;
			UInt32 minutesInYearUnsigned2 = minutesInYearUnsigned;
			Console.WriteLine(minutesInYearUnsigned2);

			float f = 3.5F;
			Single f2 = f / 3;
			Console.WriteLine(f2);

			double d = 3.5;
			Double d2 = d / 3;
			Console.WriteLine(d2);

			Console.WriteLine();
			Console.WriteLine();
			Console.Write("Введите ваш возраст: ");
			string inputFromConsole = Console.ReadLine();
			int myAge = int.Parse(inputFromConsole);
			int doubleAge = myAge * 2;
			Console.WriteLine(doubleAge);


		}
	}
}
