using System;
using ProjetoDIA9;

namespace ProjetoDIA9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();

            while (true)
            {
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
                        Console.WriteLine("Digite o primeiro nome do empregado:");
                        string primeiroNome= Console.ReadLine();
                        Console.WriteLine("Digite o sobrenome do empregado:");
                        string sobrenome = Console.ReadLine();
                        Console.WriteLine("Digite a matricula:");
                        string matricula = Console.ReadLine();
                        Console.WriteLine("Digite a idade:");
                        int idade = int.Parse( Console.ReadLine());
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
                        empresa.ListarTodosEmpregados(); 
                        break;


                    case 3:


                    case 4:


                    case 5:


                    case 6:
                        Environment.Exit(0);
                        break;
                }
            }

        }
    }
}
