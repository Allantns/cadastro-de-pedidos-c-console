using System;
using System.Collections.Generic;

    public class Item
    {
        private static List<ItemPedido> pedidos;

        static Item(){
            pedidos = new List<ItemPedido>();
        }

        public static void Inserir(ItemPedido pedido){

            pedidos.Add(pedido);
        }

        public static void Listar(){

            foreach(ItemPedido p in pedidos){

                Console.WriteLine("[Item]:"+p.descricao+ "[valor unitário]:" +p.valor_unitario+"[quantidade]:"+p.quantidade);

                
                 }
        }
        public static void Totalizar(){

            double total = 0;
            foreach(ItemPedido pedido in pedidos){
                total = total + (pedido.valor_unitario * pedido.quantidade);
            }
            Console.WriteLine("O valor total do pedido é:"  +total+ "R$"  );


        }
        
    }
