using ScreenSound_API.Filtros;
using ScreenSound_API.Modelos;
using System.Text.Json;

using (HttpClient client = new())
{
    try
    {
        string resposta =
            await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");

        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        musicas[0].ExbirDetalheMusica();

        // LinqFilter.FiltrarGenerosMusicais(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        // LinqFilter.FiltrarArtistasPorGeneroMusicais(musicas, "pop");

        var musicasPreferidasAline = new MusicasPreferidas("Playlist Aline!");
        musicasPreferidasAline.AdicionarMusicaPreferida(musicas[1]);
        musicasPreferidasAline.AdicionarMusicaPreferida(musicas[377]);
        musicasPreferidasAline.AdicionarMusicaPreferida(musicas[4]);
        musicasPreferidasAline.AdicionarMusicaPreferida(musicas[6]);
        musicasPreferidasAline.AdicionarMusicaPreferida(musicas[1467]);

        var musicasPreferidasPedro = new MusicasPreferidas("Playlist Pedro!");
        musicasPreferidasPedro.AdicionarMusicaPreferida(musicas[100]);
        musicasPreferidasPedro.AdicionarMusicaPreferida(musicas[221]);
        musicasPreferidasPedro.AdicionarMusicaPreferida(musicas[437]);
        musicasPreferidasPedro.AdicionarMusicaPreferida(musicas[67]);
        musicasPreferidasPedro.AdicionarMusicaPreferida(musicas[1867]);

        musicasPreferidasAline.ExibirMusicasPreferidas();
        musicasPreferidasPedro.ExibirMusicasPreferidas();

        musicasPreferidasAline.GerarArquivoJson();
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}