using StoreWithPagamentOOP.Entites;
using StoreWithPagamentOOP.Entites.Enum;
using StoreWithPagamentOOP.Service;
using System;
namespace StoreWithPagamentOOP;

public class Program
{
    static void Main()
    {
        Client kaiky = new Client("kaiky", ETypeClient.Comum, "kaikygabrielalves707@gmail.com", 100);
        Product mouse = new Product("mouse multilaser",10,200);
        Carrinho carrinhoCompra = new Carrinho(kaiky);
        carrinhoCompra.AddProducts(mouse);
        carrinhoCompra.Pagar(new PagamentPix(),new EmailServicePagament());
    }
}