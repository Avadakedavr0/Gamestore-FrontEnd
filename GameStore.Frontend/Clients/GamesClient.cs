using GameStore.Frontend.Models;

namespace GameStore.Frontend.Clients;

public class GamesClient
{
    private readonly List<GameSummary> games = 
    [
        new() {
            Id = 1,
            Name = " Fighter",
            Genre = "Fig",
            Price = 19.99M,
            ReleaseDate = new DateOnly(1992, 7, 15)
        }, 
        new() {
            Id = 2,
            Name = "Street",
            Genre = "Figh",
            Price = 10.99M,
            ReleaseDate = new DateOnly(1994, 9, 17)
        }, 
        new() {
            Id = 3,
            Name = "Pac Man",
            Genre = "Arcade",
            Price = 15.99M,
            ReleaseDate = new DateOnly(1997, 12, 18)
        } 
    ];

    private readonly Genre[] genres = new GenresClient().GetGenres();
    public GameSummary[] GetGames() => [.. games];

    public void AddGame(GameDetails game)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(game.GenreId);
        var genre = genres.Single(genre => genre.Id == int.Parse(game.GenreId));

        var GameSummary = new GameSummary
        {
            Id = games.Count + 1,
            Name = game.Name,
            Genre = genre.Name,
            Price = game.Price,
            ReleaseDate = game.ReleaseDate
        };

        games.Add(GameSummary);
    }
}