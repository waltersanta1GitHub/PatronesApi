using PatronesApi.Interfaces;
using PatronesApi.Models;
namespace PatronesApi.Repositories;

public class PlayerCommandRepository : IPlayerCommandsRepository
{
    public void SavePlayer(Player player)
    {
        Console.WriteLine( $"Saving player {player.Name}");
    }
}