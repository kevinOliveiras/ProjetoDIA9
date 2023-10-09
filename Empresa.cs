using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDIA9
{
    internal class Empresa
    {
        private string nome { get; set; }
        private List <Empregado> empregados = new List<Empregado>();
        


        public void CadastrarEmpregado(Empregado empregado)
        {
            empregados.Add(empregado);
            
        }
        public void ListarTodosEmpregados()
        {
            Console.WriteLine("Lista dos empregados:");
            foreach (var empregado in empregados)
            {
                Console.WriteLine(empregado);
            }          

        }
        
        
        
        
        public void Promover(string primeiroNome, string sobrenome) 
        {

        }
        public void Demitir(string primeiroNome, string sobrenome) 
        {

        }
        public double ListarSalarioAnual() 
        {
            return 0;
        }
    }
}
