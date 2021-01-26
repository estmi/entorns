using System;
namespace Descodificador
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, c = 0, a;
			string f = null; //que farà el programa, codificar o descodificar
			Console.WriteLine("Vols codificar o descodificar? (c/d)");
                        Console.WriteLine("Hola, fet amb linux.");
			while (f != "c" && f != "d")
			{
				f = Console.ReadLine();
			}
			Console.WriteLine("Introdueix el texte:");
			string t = Console.ReadLine();
			Console.WriteLine("Introdueix la clau: (un número entre 1 i 9)");
			while (c < 1 || c > 9)
			{
				c = Convert.ToInt32(Console.ReadLine());
			}
			if (f == "c")
			{
				for (i = 0; i < t.Length; i++)
				{
					a = t[i];
					Console.Write((char)(a + c));
				}
			}
			else
			{
				c = c * -1;
				for (i = 0; i < t.Length; i++)
				{
					a = t[i];
					Console.Write((char)(a + c));
				}
			}
		}
	}
}
