using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        var numeros = Enumerable.Range(1, 10).ToList();
        Console.WriteLine("Iniciando processamento assíncrono...");

        // Chama o método assíncrono para processar a lista de números
        int soma = await ProcessarNumerosAssincronamente(numeros);
        Console.WriteLine($"Soma dos números: {soma}");
    }

    static async Task<int> ProcessarNumerosAssincronamente(List<int> numeros)
    {
        // Simula o processamento assíncrono dos números
        var tarefas = numeros.Select(async numero =>
        {
            // Simula um trabalho com delay
            await Task.Delay(100);
            return numero;
        });

        // Aguarda a conclusão de todas as tarefas e calcula a soma
        var resultados = await Task.WhenAll(tarefas);
        return resultados.Sum();
    }
}
