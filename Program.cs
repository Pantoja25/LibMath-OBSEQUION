﻿namespace LibMath_OBSEQUION {
	internal class Program {
		static void Main(string[] args) {
			LibMath libMath = new LibMath();

			Console.WriteLine("MENU");
			Console.WriteLine("1 - Área do Triagolo");
			Console.WriteLine("2 - Área do Quadrado");
			Console.WriteLine("3 - Área do Retângulo");
			Console.WriteLine("4 - Área do Losangolo");
			Console.WriteLine("5 - Área do Trapézio");
			Console.WriteLine("6 - Área do Círculo");
			Console.WriteLine("0 - Sair\n");

			Console.WriteLine("Digite o Número:	");
			int resp = Convert.ToInt16(Console.ReadLine());

			switch (resp) {
				case 1:
					Console.WriteLine("Digite o valor do lado");


					break;

				case 2:
					Console.WriteLine("Digite o valor do lado");

					break;

				case 3:
					Console.WriteLine("Digite o valor do lado");

					break;

				case 4:
					Console.WriteLine("Digite o valor do lado");

					break;

				case 5:
					Console.WriteLine("Digite o valor do lado");
					break;

				case 6:
					Console.WriteLine("Digite o valor do lado");

					break;

			}
		}
	}
}