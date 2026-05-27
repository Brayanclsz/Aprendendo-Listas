using System;
using System.Collections.Generic;

class Program2
{
    static List<string> catalogo = new List<string>();

    static void Main()
    {
        catalogo.Add("Hambúrguer Especial");
        catalogo.Add("Batata Rústica");
        catalogo.Add("Refrigerante Artesanal");

        Console.WriteLine("--- Catalogo Inicial ---\n");
        Listar();

        catalogo.Insert(0, "Pizza Quatro Queijos"); // Adiciona no início
        catalogo.Remove("Refrigerante Artesanal");   // Remove o refrigerante

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
        foreach (string produto in catalogo)
        {
            Console.WriteLine(produto);
        }
    }

    static void Verificar(string oqVerifica)
    {
        bool verif = catalogo.Contains(oqVerifica);
        Console.WriteLine(verif);

    }

    static void ProcuraIndice(string indiceDeqm)
    {
        int indice = catalogo.IndexOf(indiceDeqm);
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