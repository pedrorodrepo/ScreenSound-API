using System.Text.Json;

namespace ScreenSound_API.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Musica> ListaMusicasFavoritas { get; }

    public MusicasPreferidas(string nome) 
    {
        Nome = nome;
        ListaMusicasFavoritas = new List<Musica>();
    }

    public void AdicionarMusicaPreferida(Musica musica)
    {
        ListaMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasPreferidas()
    {
        Console.WriteLine($"Essas são as musicas preferidas -> {Nome}");

        foreach (var musica in ListaMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} . {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaMusicasFavoritas
        });

        string nomeArquivo = $"Musicas-preferidas-{Nome}.json";

        File.WriteAllText(nomeArquivo, json);
        Console.WriteLine("Arquivo criado com sucesso!");
        Console.WriteLine($"Encontre em {Path.GetFullPath(nomeArquivo)}");

    }
}
