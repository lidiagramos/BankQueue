using System;

namespace Fila_de_Banco
{
	public class MenuOpcoes
	{
		public void VerOpcoes()
		{

			int opcao = 0, cpf, agencia, conta, esalt;
			string nome;
			
			do
			{
				Console.Clear();
				Console.WriteLine("MENU DE OPÇÕES: DIGITE:");
            	Console.WriteLine("1 - Se cadastrar.");
           	 	Console.WriteLine("2 - Alterar cadastro.");
           		Console.WriteLine("3 - Iniciar o atendimento.");
				Console.WriteLine("ESCOLHA SUA OPÇÃO");
				opcao = int.Parse(Console.ReadLine());
				Console.Clear();
				
				switch (opcao)
				{
					case 1:
						Console.WriteLine("Vamos iniciar seu cadastro.");
						Console.WriteLine("Digite seu nome:");
						nome = (Console.ReadLine());
						Console.WriteLine("Digite seu CPF.");
						cpf = int.Parse(Console.ReadLine());
						Console.WriteLine("Digite o número da agência.");
						agencia = int.Parse(Console.ReadLine());
						Console.WriteLine("Digite o número de sua conta.");
						conta = int.Parse(Console.ReadLine());
						Console.WriteLine("Cadastro realizado com sucesso!");
						break;
						
					case 2:
						Console.WriteLine("Vamos alterar seu cadastro.");
						Console.WriteLine("Para alterar seus dados digite:");
					 	Console.WriteLine("1 - Alterar o Nome.");
           	 			Console.WriteLine("2 - Alterar o CPF.");
           				Console.WriteLine("3 - Alterar o Número da Agência.");
						Console.WriteLine("4 - Alterar o Número da Conta.");
						esalt = int.Parse(Console.ReadLine());
						Console.Clear();
						break;
						
					default:
						Console.WriteLine("Vamos iniciar o atendimento.");
						break;
				}
				Console.ReadKey();
			}while (opcao != 3);
		}
	}
}
