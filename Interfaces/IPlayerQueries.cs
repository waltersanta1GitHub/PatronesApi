using PatronesApi.Models;

namespace PatronesApi.Interfaces;
public interface  IPlayerQueries
{
    Player FindById(int id);
    Player FindByName(string name);
}
