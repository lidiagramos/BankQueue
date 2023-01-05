using System;

namespace Fila_de_Banco
{
	class Program
	{
		public static void Main(string[] args)
		{
			int escolha = 123;
			int menu;
			
			Console.WriteLine("PARA INICIARMOS DIGITE O CÓDIGO DO BANCO (123)");
			menu = int.Parse(Console.ReadLine());
           	MenuOpcoes MeuMenu = new MenuOpcoes();
			if (menu == escolha)
           		{	
           			MeuMenu.VerOpcoes();		
           		}
			
           		else
           		{
           			Console.WriteLine("O comando digitado é inválido!");
           			Console.ReadKey();
           		}
		}
	}
}