using System;
namespace Descodificador
{
	class Program
	{
		static void Main(string[] args)
		{
			int clau = 0, codiAscii;
			string funcio = null; //que farà el programa, codificar o descodificar Esteve Miquel Guitart
			Console.WriteLine("Vols codificar o descodificar? (c/d)");
			//Console.WriteLine("Hola, fet amb linux. I ara amb WindowsVM");
			while (funcio != "c" && funcio != "d")//validacio d'entrada
			{
				funcio = Console.ReadLine();
			}
			Console.WriteLine("Introdueix el texte:");//texte a codificar o descodificar
			string t = Console.ReadLine();
			Console.WriteLine("Introdueix la clau: (un número entre 1 i 9)");//clau de codificacio
			while (clau < 1 || clau > 9)//validacio d'entrada
			{
				clau = Convert.ToInt32(Console.ReadLine());
			}
			if (funcio == "c")//Aplicar la clau si es de codificar o descodificar s'haplica al codi ascii la suma de la clau
			{
				for (int i = 0; i < t.Length; i++)
				{
					codiAscii = t[i];
					Console.Write((char)(codiAscii + clau));
				}
			}
			else
			{
				clau = clau * -1;
				for (int i = 0; i < t.Length; i++)
				{
					codiAscii = t[i];
					Console.Write((char)(codiAscii + clau));
				}
			}
		}
	}
}
