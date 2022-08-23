using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declaraçao e instanciaçao do objeto
            Produto prod = new Produto();
            Cliente cli = new Cliente();
            Console.Write("Digite o nome do cliente");
            cli.setNome(Console.ReadLine());

            Console.Write("Digite o CPF do cliente");
            cli.setCpf(Console.ReadLine());

            Console.Write("Digite o endereço do cliente");
            cli.setEndereco(Console.ReadLine());

            Console.Write("digite a idade do cliente");
            cli.setIdade(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Digite o codigo do produto: ");
            prod.setCodigo(Convert.ToInt32(Console.ReadLine()));

            Console.Write("Digite a descricao do produto:");
            prod.setDescricao(Console.ReadLine());

            Console.Write("Digite a categoria do produto: ");
            prod.setCategoria(Console.ReadLine());

            Console.Write("Digite o valor do produto: ");
            prod.setValor(Convert.ToDouble(Console.ReadLine()));

            Console.WriteLine("Codigo = " + prod.getCodigo() + "\nDescricao:" + prod.getDescricao() + "\nCategoria: = " + prod.getCategoria() + "\nValor = " + prod.getValor().ToString());

            Console.WriteLine("Nome = " + cli.getNome() + "\nEndereco = " + cli.getEndereco() + "\nCPF =" + cli.getCpf() + "\nIdade =" + cli.getIdade());
            
            Console.ReadKey();

        }
    }
}
