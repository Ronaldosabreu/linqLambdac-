using Loja.Dominio;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace EstudosRevisaoLinq
{
  class Program
  {
    static void Main(string[] args)
    {
      #region estudos
      //int[] numero = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

      ////var filtro = numero.Where(n => n > 4).OrderByDescending(x=>x);
      //var filtro = from num in numero
      //                          where num > 4
      //                          orderby num descending
      //                          select num;

      //foreach (var item in filtro)
      //{
      //  Console.WriteLine("Numeros maiores que 4: " + item);
      ////}

      //string[] cores = { "Preto", "Branco", "Verde", "Vermelho", "Azul", "Roxo", "Amarelo", "Laranja", "Rosa", "Marron" };
      ////var filtro = cores.Where(n => n.Contains("e") || n.Contains("z"));

      //var filtro = from cor in cores
      //             where cor.Contains("e") && cor.Contains("z")
      //            orderby cor descending
      //             select cor;

      //foreach (var item in filtro)
      //{
      //  Console.WriteLine("Filtrado: " + item);
      //}


      //var produto = new Produto();
      //var produtos = produto.Listar().Where(x => x.Valor > 5);


      //foreach (Produto item in produtos)
      //{
      //  Console.WriteLine("Items: " + item.Nome);
      //}

      //new Produto().Listar().Where(p=>p.Valor>15).ToList().ForEach(item =>
      //      {
      //        Console.WriteLine(item.Nome);
      //        Console.WriteLine(item.Valor);
      //      }
      //);

      //var resultado = new Produto().Listar();
      //if (resultado.Any(p => p.Quantidade > 15))
      //{
      //  Console.WriteLine("Existem produtos mais que 15 ");
      //}


      //new Produto().Listar()
      //  //.Where( p => p.Nome.StartsWith("U") || p.Nome.EndsWith("a"))
      //  .Where( p => p.DataVencimento.Day>29)
      //  .Select(p => new ProdutoSelecionado 
      //  {
      //    name=p.Nome,//.Substring(0,2).Insert(2,"Ronaldo").Remove(2,2).Replace("do",""),
      //    id = p.Id,
      //    DiaVEncimento= p.DataVencimento
      //  })
      //  .ToList().ForEach(item =>
      //{
      //  Console.WriteLine(JsonConvert.SerializeObject(item));
      //  Console.WriteLine(" ");
      //});

      //int[] pares = { 2, 4, 6 };
      //int[] impares = { 1, 3, 5 };
      //int[] aleatorios = { 1, 2, 3, 4, 5, 6 };

      //var temnumeroPar = aleatorios.Intersect(pares); //o que tem 
      //var semrepeticao = aleatorios.Except(pares); // o que nao tem
      //var range = Enumerable.Range(10, 3);
      //var repetir = Enumerable.Repeat("Ronaldo", 3);
      #endregion estudos

      var prod = new Produto().Listar();
      //valor mais caro
      var maiscaro = prod.Max(x=>x.Valor);
      //media do valor
      var media = prod.Average(c => c.Valor);
      //valor menor valor
      var menorvalor = prod.Min(x => x.Valor);
      //somar
      var soma = prod.Sum(x => x.Valor);

      Console.ReadKey();

    }
    public class ProdutoSelecionado {
      public string name{ get; set; }
      public Guid id { get; set; }

      public DateTime DiaVEncimento { get; set; }
    }
  }
}

