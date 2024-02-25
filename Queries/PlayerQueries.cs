using PatronesApi.Dtos;
using PatronesApi.Interfaces;
using PatronesApi.Models;

namespace PatronesApi.Queries;
public class PlayerQueries : IPlayerQueries
{
     private readonly IPlayerQueriesRepository _repository;

     public PlayerQueries(IPlayerQueriesRepository repository)
     {
        _repository = repository;
        
     }



    public Player FindById(int id)
    {
        var player = _repository.GetById(id);
        return new PlayerDto{
            Name = player.Name,
            CharacterClass = player.CharacterClass,
            HitPoints = player.HitPoints,
            ExperiencePoints = player.ExperiencePoints,
            Level= player.Level,
            Gold= player.Gold
        };
    }

    public Player FindByName(string name)
    {
        throw new NotImplementedException();
    }
}