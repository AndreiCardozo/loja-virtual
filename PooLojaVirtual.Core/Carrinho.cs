using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace PooLojaVirtual.Models
{
    public class Carrinho : Entidade
    {
        public List<ItemCarrinho> Itens { get; set; } = new List<ItemCarrinho>();

        public double Total
        {
            get
            {
                return Itens.Sum(item => item.Subtotal);
            }
        }

        public void Adicionar(Produto produto, int quantidade)
        {
            var itemNoCarrinho = Itens.FirstOrDefault(item => item.Produto.Id == produto.Id);

            if (itemNoCarrinho == null)
            {
                var item = new ItemCarrinho(produto, quantidade);
                Itens.Add(item);
            }
            else
            {
                itemNoCarrinho.Quantidade += quantidade;
            }
        }

        public void Remover(int idProduto)
        {
            var itemNoCarrinho = Itens.FirstOrDefault(item => item.Produto.Id == idProduto);
            if (itemNoCarrinho != null)
            {
                Itens.Remove(itemNoCarrinho);
            }
        }
    }
}