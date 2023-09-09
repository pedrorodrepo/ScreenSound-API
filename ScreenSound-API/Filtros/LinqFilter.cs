using ScreenSound_API.Modelos;

namespace ScreenSound_API.Filtros;

internal class LinqFilter
{
    public static void FiltrarGenerosMusicais(List<Musica> musicas)
    {
        var todosGenerosMusicais = musicas.Select(musica =>
            musica.Genero).Distinct().ToList();

        Console.WriteLine("\nLista de generos filtrados: ");
        foreach (var generos in todosGenerosMusicais)
        {
            Console.WriteLine($"- {generos}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusicais(List<Musica> musicas, string genero)
    {
        var artistasPorGenerosMusicais = musicas.Where(musica => musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"\n Lista de artista por genero musical >>>> Genero: {genero}: ");
        foreach (var artista in artistasPorGenerosMusicais)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}
