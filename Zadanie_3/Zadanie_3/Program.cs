using System;
using Zadanie_3;
namespace Zadanie_3
{
	class Zadanie_3
	{
	public int [] mass;

		public Zadanie_3(int[] mass)
		{
			this.mass = mass;
		}

		int razmer;
		public Zadanie_3( int razmer)
		{
			this.razmer = razmer;
		}
		public int this [int razmer]
		{ get { return mass[razmer]; }
			set { mass[razmer] = value; }
		}
		public int acss
		{
			get { return razmer; }
			set { razmer = value; }
		}
		
		public void ran()
		{
			Random rnd = new Random();
			for (int i = 0; i < mass.Length; i++)
			{
				mass[i] = rnd.Next(10);
				Console.WriteLine(mass[i]);
			}
		}

		public void print()
		{
			int count = 0;
			Console.WriteLine("Элементы кратные 3:");
			for (int i = 0; i < mass.Length; i++)
			{
				if (mass[i] % 3 == 0 && mass[i] > 0)
				{
					Console.WriteLine(mass[i]);
					count++;
				/*	Console.WriteLine("Массив" + mass[i]);
					Console.ReadKey();*/
				}
			}
			Console.WriteLine("Количество элементов кратных 3: "+count);
			Console.ReadKey();




		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Введите размерность массива");
			int razmer = int.Parse(Console.ReadLine());
			int[] mass = new int[razmer];
		//	Zadanie_3 zad_3 = new Zadanie_3(razmer);
			Zadanie_3 zad_33 = new Zadanie_3(mass);
			zad_33.ran();
		//	Console.WriteLine(zad_33);
			zad_33.print();
		}
	}
}
