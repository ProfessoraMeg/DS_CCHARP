using System;
using System.Net.Http;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Iniciando requisição HTTP...");

        // Chama o método assíncrono para fazer a requisição
        string resultado = await FazerRequisicaoHttpAsync("https://api.github.com/");
        Console.WriteLine("Resposta recebida.");
        Console.WriteLine(resultado);
    }
    static async Task<string> FazerRequisicaoHttpAsync(string url)
    {
        using HttpClient client = new HttpClient();

        // Configura o cabeçalho User-Agent para evitar erro 403
        client.DefaultRequestHeaders.Add("User-Agent", "C# App");

        // Faz a requisição HTTP GET de forma assíncrona
        HttpResponseMessage resposta = await client.GetAsync(url);
        // Lê o conteúdo da resposta como string
        string conteudo = await resposta.Content.ReadAsStringAsync();
        return conteudo;
    }
}
