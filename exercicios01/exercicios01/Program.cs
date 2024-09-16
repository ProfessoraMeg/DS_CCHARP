using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando tarefa...");

        // Chama o método assíncrono
        await MetodoAssincrono();
        Console.WriteLine("Tarefa concluída.");
    }
    static async Task MetodoAssincrono()
    {
        // Simula uma operação de I/O, como uma chamada de API ou leitura de arquivo
        await Task.Delay(2000); // Aguarda por 2 segundos
        Console.WriteLine("Método assíncrono concluído.");
    }
}
