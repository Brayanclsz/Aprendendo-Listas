using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Produto> catalogo = new List<Produto>();

    static void Main()
    {
        Produto produto1 = new Produto("Hambúrguer Especial", 34.90);
        Produto produto2 = new Produto("Batata Rústica", 18.00);
        Produto produto3 = new Produto("Refrigerante Artesanal", 9.50);
        catalogo.Add(produto1);
        catalogo.Add(produto2);
        catalogo.Add(produto3);

        Console.WriteLine("--- Catalogo Inicial ---\n");
        Listar();

        Produto Produto0 = new Produto("Pizza Quatro Queijos", 48.00);
        catalogo.Insert(0, Produto0);

        catalogo.Remove(produto3);

        Console.WriteLine("\n--- Catalogo Atualizado ---\n");
        Listar();

        string oqVerifica = "Batata Rústica";

        Console.WriteLine("\n--- Verificação ---");
        Console.WriteLine("\nExiste Batata Rústica no menu? ");

        Verificar(oqVerifica);


        string indiceDeqm = "Pizza Quatro Queijos";
        Console.WriteLine("\nQual o índice da Pizza QuatroQueijos no catálogo? ");
        ProcuraIndice(indiceDeqm);


        Console.WriteLine("\n---- Impressão Final ----\n");

        ListaComIndice();

        Console.WriteLine("\n");

        Contagem();


    }
    static void Listar()
    {
        foreach (Produto produto in catalogo)
        {
            Console.WriteLine(produto);
        }
    }

    static void Verificar(string oqVerifica)
    {
        bool verif = catalogo.Any(cadaProduto => cadaProduto.Nome == oqVerifica);
        Console.WriteLine(verif);
    }

    static void ProcuraIndice(string indiceDeqm)
    {
        int indice = catalogo.FindIndex(cadaProduto => cadaProduto.Nome == indiceDeqm);
        Console.WriteLine($"O índice do {indiceDeqm} é {indice}");
    }

    static void ListaComIndice()
    {
        for(int i = 0; i < catalogo.Count; i++)
        {
            Console.WriteLine($"Produto: {catalogo[i]} Indice: {i}");
        }
    }
    static void Contagem()
    {
        Console.WriteLine($"A lista possui {catalogo.Count} itens");
    }
}