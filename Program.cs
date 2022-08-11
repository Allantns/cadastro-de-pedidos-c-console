using System;

namespace ItemPededidos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;

            Console.WriteLine("CADASTRO E CONSULTA DE PEDIDOS");
            do {
                ItemPedido item = new ItemPedido();

                Console.WriteLine("Informe a descrição do pedido:");
                item.descricao = Console.ReadLine();

                Console.WriteLine("Informe o valor unitario do item:");
                item.valor_unitario = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual a quantidade desejada?");
                item.quantidade = int.Parse(Console.ReadLine());

                Item.Inserir(item);

                Console.WriteLine("Deseja adicionar mais itens ao pedido: [s/n]");
                opcao = Console.ReadLine();

                switch(opcao){
                    case "s":
                    Console.WriteLine("adicione o novo item:");
                    break;

                    case "n":
                    Console.WriteLine("os itens adicionados ao pedido são:");
                    Item.Listar();
                    Item.Totalizar();
                    break;

                    default:
                    Console.WriteLine("o valor inserido é invalido!");
                    break;
                }
            } while(opcao == "s");
        }
    }
}
