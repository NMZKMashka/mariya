using System;
using Зятева_C_sharp;

namespace Зятева_C_sharp {
	class Zadaniya
	{
		int chislo;
		public Zadaniya(int chislo)
		{
			this.chislo = chislo;
		}
	public int ass
		{
			get { return chislo; }
			set { chislo = value; }
		}
		public void print()
		{
			if (chislo > 7)
			{
				Console.WriteLine("Привет");
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("Введите другое число!");
				Console.ReadKey();
			}
		}
	}
}
	class Program
	{
		static void Main(string[] args)
		{
		Console.WriteLine("1 задание: Если введенное число больше 7, то вывести Привет.");
		Console.WriteLine("Введите число");
		int chislo = int.Parse(Console.ReadLine());
		Zadaniya zad = new Zadaniya(chislo);
		zad.print();
	}
}

