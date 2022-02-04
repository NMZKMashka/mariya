using System;

namespace Zadanie_2
{
	class Zadanie_2
	{
		string stroka;
		public Zadanie_2(string stroka)
		{
			this.stroka = stroka;
		}
		public string acs
		{
			get { return stroka; }
			set { stroka = value; }
		}
		public void print(string stroka)
		{
			string stroka2 = "Вячеслав";
			int result = string.Compare(stroka, stroka2);
			if (result < 0 || result > 0)
			{
				Console.WriteLine("Нет такого имени");
				Console.ReadKey();
			}
			else
			{
				Console.WriteLine("Привет, Вячеслав");
				Console.ReadKey();
			}
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите имя:");
			string name_us = Console.ReadLine();
			Zadanie_2 zad_2 = new Zadanie_2(name_us);
			zad_2.print(name_us);
		}
	}
}
