
using PatronesApi.Interfaces;
using PatronesApi.Models;

namespace PatronesApi.Repositories;

public class PlayerQueryRepository : IPlayerQueriesRepository
{
    public Player GetById(int id)
    {
        return new Player{
           Id=1,
           Name = "John",
           CharacterClass = "Smith", 
           HitPoints = 1,
           ExperiencePoints = 2,
           Level = 2,
           Gold = 1  
        };
    }
}