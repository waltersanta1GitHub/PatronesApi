using PatronesApi.Models;

namespace PatronesApi.Interfaces;
public interface  IPlayerCommandsRepository
{
    void SavePlayer(Player player);
}