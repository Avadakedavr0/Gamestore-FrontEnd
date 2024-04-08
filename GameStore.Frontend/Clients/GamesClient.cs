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

    public GameSummary[] GetGames() => [.. games];
}