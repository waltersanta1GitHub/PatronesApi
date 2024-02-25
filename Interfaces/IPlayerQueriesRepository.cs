using PatronesApi.Models;

namespace PatronesApi.Interfaces;
public interface  IPlayerQueriesRepository
{
    Player GetById(int id);
}