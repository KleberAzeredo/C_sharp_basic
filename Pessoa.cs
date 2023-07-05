using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace Projetos.Models // caminho lógico para identificar classes que estejam no mesmo domínio
{
    public class Pessoa
    {
        public string Nome { get; set; } // propriedades da classe, dar comando 'prop' e clicar Tab
        public int Idade { get; set; } // get: 'pega' um valor, set: é atribuido um valor a ele

        public void Apresentar(){ // método ou função,  atribui uma ação
            Console.WriteLine($"Olá! Meu nome é {Nome} \n Tenho {Idade} anos.");
        }
    }
}