using System;
namespace Descodificador
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, c = 0, a;
			string f = null; //que farà el programa, codificar o descodificar Esteve Miquel Guitart
			Console.WriteLine("Vols codificar o descodificar? (c/d)");
			//Console.WriteLine("Hola, fet amb linux. I ara amb WindowsVM");
			while (f != "c" && f != "d")//validacio d'entrada
			{
				f = Console.ReadLine();
			}
			Console.WriteLine("Introdueix el texte:");//texte a codificar o descodificar
			string t = Console.ReadLine();
			Console.WriteLine("Introdueix la clau: (un número entre 1 i 9)");//clau de codificacio
			while (c < 1 || c > 9)//validacio d'entrada
			{
				c = Convert.ToInt32(Console.ReadLine());
			}
			if (f == "c")//Aplicar la clau si es de codificar o descodificar s'haplica al codi ascii la suma de la clau
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
