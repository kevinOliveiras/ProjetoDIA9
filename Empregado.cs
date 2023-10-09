using System;
using Projeto;


namespace Projeto
{
    internal class Empregado
    {
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Matricula { get; private set; }
        public int Idade { get; private set; }
        public string DataDeContratacao { get;  private set; }
        public string DataDeNascimento { get;private set; }
        private double salarioMensal;
        public double salarioMinimo = 1320;


        public Empregado(string primeiroNome, string sobrenome, string matricula, string dataDeContratacao, string dataDeNascimento, double SalarioMensal)
        {
            this.Nome = primeiroNome;
            this.Sobrenome = sobrenome;
            this.Matricula = matricula;
            this.DataDeContratacao = dataDeContratacao;
            this.DataDeNascimento = dataDeNascimento;
            this.SalarioMensal = SalarioMensal;

        }

        public double SalarioMensal
        {
            get { return salarioMensal; }
            private set
            {
                salarioMensal = value < salarioMinimo ? salarioMinimo : value;
            }
        }

        public double SalarioAnual => SalarioMensal * 12;


        public void AumentarSalario()
        {
            salarioMensal *= 1.1;
        }





    }
}
