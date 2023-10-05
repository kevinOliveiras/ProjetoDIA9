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

                    case 2:


                    case 3:


                    case 4:


                    case 5:


                    case 6:
                        break;
                }
            }

        }
    }
}
