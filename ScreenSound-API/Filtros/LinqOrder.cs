using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => 
            musica.Artista).Select(musica => 
                musica.Artista).Distinct().ToList();

        Console.WriteLine("\nLista de artistas ordenados: ");
        foreach(var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
