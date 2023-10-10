using System;
using Projeto;

/// <summary>
/// Esta classe representa um empregado em um sistema, armazenando informações como nome, sobrenome, matrícula,
/// data de contratação, data de nascimento e salário mensal. Também oferece funcionalidades para aumentar o salário
/// e calcular o salário anual.
/// </summary>
namespace Projeto
{
    internal class Empregado
    {
        // Propriedades para armazenar informações do empregado
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Matricula { get; private set; }
        public int Idade { get; private set; }
        public string DataDeContratacao { get;  private set; }
        public string DataDeNascimento { get;private set; }
        
        // Variável privada para armazenar o salário mensal
        private double salarioMensal;
        
        // Valor mínimo do salário permitido
        public double salarioMinimo = 1320;

        // Construtor para inicializar um objeto Empregado com informações iniciais
        public Empregado(string primeiroNome, string sobrenome, string matricula, string dataDeContratacao, string dataDeNascimento, double SalarioMensal)
        {
            this.Nome = primeiroNome;
            this.Sobrenome = sobrenome;
            this.Matricula = matricula;
            this.DataDeContratacao = dataDeContratacao;
            this.DataDeNascimento = dataDeNascimento;
            this.SalarioMensal = SalarioMensal;

        }
        
        // Propriedade para acessar e definir o salário mensal, garantindo que não seja menor que o salário mínimo
        public double SalarioMensal
        {
            get { return salarioMensal; }
            private set
            {
                salarioMensal = value < salarioMinimo ? salarioMinimo : value;
            }
        }
        
        // Propriedade para calcular o salário anual baseado no salário mensal
        public double SalarioAnual => SalarioMensal * 12;

        // Método para aumentar o salário em 10%
        public void AumentarSalario()
        {
            salarioMensal *= 1.1;
        }





    }
}
