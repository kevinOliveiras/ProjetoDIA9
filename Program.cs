using System;
using Projeto;

/// <summary>
/// Esta classe contém o método de entrada (Main) que cria uma instância da classe Empresa e permite ao usuário
/// interagir com o sistema para cadastrar, listar, promover, demitir e listar o salário anual de empregados.
/// </summary>
namespace Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instância da classe Empresa
            Empresa empresa = new Empresa();

            while (true)
            {
                 // Exibe o menu de opções
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Cadastrar Empregado:");
                Console.WriteLine("2. Listar todos Empregados:");
                Console.WriteLine("3. Promover um Empregado:");
                Console.WriteLine("4. Demitir um Empregado:");
                Console.WriteLine("5. Listar salario anual do Empregado:");
                Console.WriteLine("6. Sair");
                Console.WriteLine("Escolhe uma opçao:");

                int op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        // Solicita informações do empregado e cadastra na empresa
                        Console.WriteLine("Digite o primeiro nome do empregado:");
                        string primeiroNome = Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome do empregado:");
                        string sobrenome = Console.ReadLine();
                        Console.WriteLine("Digite a matricula:");
                        string matricula = Console.ReadLine();
                        Console.WriteLine("Digite a idade:");
                        int idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("Digite a data de nascimento do empregado:");
                        string dataDeNascimento = Console.ReadLine();
                        Console.WriteLine("Digite a data de contratacao do empregado:");
                        string dataDeContratacao = Console.ReadLine();
                        Console.WriteLine("Digite o salario  do empregado:");
                        double salarioMensal = double.Parse(Console.ReadLine());

                        Empregado empregado = new Empregado(primeiroNome, sobrenome, matricula, dataDeNascimento, dataDeContratacao, salarioMensal);
                        empresa.CadastrarEmpregado(empregado);
                        break;




                    case 2:
                        // Lista todos os empregados da empresa
                        empresa.ListarTodosEmpregados();
                        break;


                    case 3:
                        // Solicita o nome e sobrenome do empregado a ser promovido
                        Console.WriteLine("Digite o nome do empregado:");
                        string nomePromover = Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome do empregado:");
                        string sobrenomePromover = Console.ReadLine();
                        empresa.Promover(nomePromover, sobrenomePromover);
                        break;



                    case 4:
                        // Solicita o nome e sobrenome do empregado a ser demitido
                        Console.WriteLine("Digite o nome do empregado:");
                        string nomeDemitir = Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome do empregado:");
                        string sobrenomeDemitir = Console.ReadLine();
                        empresa.Demitir(nomeDemitir, sobrenomeDemitir);
                        break;


                    case 5:
                        // Solicita o nome e sobrenome do empregado para listar o salário anual
                        Console.WriteLine("Digite o nome do empregado:");
                        string nomeSalarioAnual= Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome do empregado:");
                        string sobrenomeSalarioAnual = Console.ReadLine();
                        empresa.ListarSalarioAnual(nomeSalarioAnual,sobrenomeSalarioAnual)
                        ; break;


                    case 6:
                        // Encerra o programa
                        Environment.Exit(0);
                        break;

                    /*case 7:
                        Console.WriteLine("Digite o nome do empregado:");
                        string nomeSalario = Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome do empregado:");
                        string sobrenomeSalario = Console.ReadLine();
                        empresa.ListarSalario(nomeSalario, sobrenomeSalario)
                        
                        ; break;*/
                }
            }

        }
    }
}
