using PatronesApi.Dtos;
using PatronesApi.Interfaces;
using PatronesApi.Models;

namespace PatronesApi.Commands;
public class PlayerCommands : IPlayerCommands
{
    private readonly IPlayerCommandsRepository _repository;
    public PlayerCommands(IPlayerCommandsRepository repo)
    {
        _repository = repo;
    }
    public void SavePlayer(PlayerDto player)
    {
        var newPlayer = new Player{
            Name = player.Name,
            CharacterClass = player.CharacterClass,
            HitPoints = player.HitPoints,
            ExperiencePoints = player.ExperiencePoints,
            Level = player.Level,
            Gold = player.Gold
        };   
        _repository.SavePlayer(newPlayer);    
    }
}