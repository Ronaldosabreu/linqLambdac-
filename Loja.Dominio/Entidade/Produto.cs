using System;
using System.Collections.Generic;

namespace Loja.Dominio
{
  public class Produto
  {
    private List<Produto> _produtos;

    public Produto()
    {
      _produtos = new List<Produto>();

    }



    public List<Produto> Listar()
    {
      _produtos.Add(new Produto(){Id= Guid.NewGuid(), Nome = "Banana", Quantidade = 5, Valor = 5, DataVencimento =  DateTime.Now.AddDays(5) });
      _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Pera", Quantidade = 10, Valor = 15, DataVencimento = DateTime.Now.AddDays(4) });
      _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Maça", Quantidade = 15, Valor = 25, DataVencimento = DateTime.Now.AddDays(3) });
      _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Manga", Quantidade = 20, Valor = 35, DataVencimento = DateTime.Now.AddDays(2) });
      _produtos.Add(new Produto() { Id = Guid.NewGuid(), Nome = "Uva", Quantidade = 25, Valor = 45, DataVencimento = DateTime.Now.AddDays(1) });

      return _produtos;
    }

    public Guid Id { get; set; }
    public string Nome { get; set; }
    public int Quantidade{ get; set; }
    public decimal Valor { get; set; }
    public DateTime DataVencimento { get; set; }

  }
}
