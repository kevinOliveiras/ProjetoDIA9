using Projeto;
using System;
using System.Collections.Generic;

/// <summary>
/// Esta classe representa uma empresa e mantém uma lista de empregados. Ela oferece métodos para cadastrar empregados,
/// listar todos os empregados, promover, demitir e listar o salário anual de um empregado.
/// </summary>
namespace Projeto
{
    internal class Empresa
    {
        // Lista para armazenar empregados da empresa
        private List<Empregado> empregados = new List<Empregado>();

        /// <summary>
        /// Método para cadastrar um empregado na empresa.
        /// </summary>
        /// <param name="empregado">O empregado a ser cadastrado.</param>
        public void CadastrarEmpregado(Empregado empregado)
        {
            empregados.Add(empregado);

        }
        
        /// <summary>
        /// Método para listar todos os empregados da empresa.
        /// </summary>
        public void ListarTodosEmpregados()
        {
            Console.WriteLine("Lista dos empregados:");
            foreach (var empregado in empregados)
            {
                Console.WriteLine($"{empregado.Nome} {empregado.Sobrenome} - Matrícula: {empregado.Matricula}\n");
            }

        }

        /// <summary>
        /// Método para promover um empregado, aumentando seu salário em 10%.
        /// </summary>
        /// <param name="nome">O nome do empregado a ser promovido.</param>
        /// <param name="sobrenome">O sobrenome do empregado a ser promovido.</param>
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
        
        /// <summary>
        /// Demite um empregado da empresa.
        /// </summary>
        /// <param name="nome">O nome do empregado a ser demitido.</param>
        /// <param name="sobrenome">O sobrenome do empregado a ser demitido.</param>
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
        
        /// <summary>
        /// Lista o salário anual de um empregado.
        /// </summary>
        /// <param name="nome">O nome do empregado.</param>
        /// <param name="sobrenome">O sobrenome do empregado.</param>
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
