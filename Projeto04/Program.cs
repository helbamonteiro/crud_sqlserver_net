
using Projeto04.Controllers;

namespace Projeto04
{
    public class Program
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("\n PROJETO DE CADASTRO DE EMPRESA E FUNCIONARIOS\n");

            Console.WriteLine("(1) CADASTRAR EMPRESA");
            Console.WriteLine("(2) ATUALIZAR EMPRESA");
            Console.WriteLine("(3) EXCLUIR EMPRESA");
            Console.WriteLine("(4) CONSULTAR EMPRESA");

            Console.WriteLine("\nINFORME A OPÇÃO DESEJADA: ");
            var opcao = int.Parse(Console.ReadLine());

            var empresaController = new EmpresaController();

            switch (opcao)
            {
                case 1: empresaController.CadastrarEmpresa(); break;
                case 2: empresaController.AtualizarEmpresa(); break;
                case 3: empresaController.ExcluirEmpresa(); break;
                case 4: empresaController.ConsultarEmpresas(); break;
                default:
                    Console.WriteLine("\nOPÇÃO INVALIDA");
                    break;
            }
            Console.Write("\nDESEJA CONTINUAR? (S,N): ");
            var continuar = Console.ReadLine();

            if (continuar.Equals("S", StringComparison.OrdinalIgnoreCase))
            {
                Console.Clear();
                Main(args); //recursividade!
            }
            else
            {
                Console.WriteLine("\nFIM DO PROGRAMA!");
            }
        }
    }
}
