using Projeto;
using System;
using System.Collections.Generic;


namespace Projeto
{
    internal class Empresa
    {
        
        private List<Empregado> empregados = new List<Empregado>();



        public void CadastrarEmpregado(Empregado empregado)
        {
            empregados.Add(empregado);

        }
        public void ListarTodosEmpregados()
        {
            Console.WriteLine("Lista dos empregados:");
            foreach (var empregado in empregados)
            {
                Console.WriteLine($"{empregado.Nome} {empregado.Sobrenome} - Matrícula: {empregado.Matricula}\n");
            }

        }




        public void Promover(string nome, string sobrenome)
        {
            Empregado empregado= empregados.Find(e => e.Nome==nome && e.Sobrenome==sobrenome);
            if (empregado != null)
            {
                empregado.AumentarSalario();
                Console.WriteLine($"{empregado.Nome} {empregado.Sobrenome} Promovido!\n");
            }
            else
            {
                Console.WriteLine("Empregado nao encontrado.\n");
            }
        }
        public void Demitir(string nome, string sobrenome)
        {
            Empregado empregado = empregados.Find(e => e.Nome == nome && e.Sobrenome == sobrenome);
            if (empregado != null)
            {
                empregados.Remove(empregado);
                Console.WriteLine($"{empregado.Nome} {empregado.Sobrenome} Demitido!\n");
            }
            else
            {
                Console.WriteLine("Empregado nao encontrado.\n");
            }


        }
        public void ListarSalarioAnual(string nome, string sobrenome)
        {
            Empregado empregado = empregados.Find(e => e.Nome == nome && e.Sobrenome == sobrenome);
            if (empregado != null)
            {
                Console.WriteLine($"Salario anual de {empregado.Nome} {empregado.Sobrenome}: {empregado.SalarioAnual} \n");
            }
            else
            {
                Console.WriteLine("Empregado nao encontrado.\n");
            }
        }

        /*public void ListarSalario(string nome, string sobrenome)
        {
            Empregado empregado = empregados.Find(e => e.PrimeiroNome == nome && e.Sobrenome == sobrenome);
            if (empregado != null)
            {
                Console.WriteLine($"Salario anual de {empregado.PrimeiroNome} {empregado.Sobrenome}: {empregado.SalarioMensal} \n");
            }
            else
            {
                Console.WriteLine("Empregado nao encontrado.\n");
            }

        }*/
           
    }
}
